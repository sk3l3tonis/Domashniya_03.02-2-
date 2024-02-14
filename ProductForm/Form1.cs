using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Npgsql;

namespace ProductForm
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=localhost; Port=5432; Database=productform; Username=postgres; Password=1212321";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetProducts_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT name, price, article FROM prodform";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "prodform");
                    dgvProducts.DataSource = ds.Tables["prodform"];
                }
            }

            DrawPriceDistribution();
        }

        private void DrawPriceDistribution()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT price FROM prodform";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    Dictionary<string, int> priceCategories = new Dictionary<string, int>();
                    priceCategories["Категория 1 (от 40 до 300 рублей)"] = dt.AsEnumerable().Count(row => row.Field<decimal>("price") >= 40 && row.Field<decimal>("price") <= 300);
                    priceCategories["Категория 2 (от 350 до 750 рублей)"] = dt.AsEnumerable().Count(row => row.Field<decimal>("price") >= 350 && row.Field<decimal>("price") <= 750);
                    priceCategories["Категория 3 (от 1000 до 1700 рублей)"] = dt.AsEnumerable().Count(row => row.Field<decimal>("price") >= 1000 && row.Field<decimal>("price") <= 1700);

                    chtPriceDistribution.Series.Clear();
                    chtPriceDistribution.Titles.Clear();
                    chtPriceDistribution.Titles.Add("Распределение товаров по ценовым категориям");

                    Series series = new Series();
                    series.Name = "Ценовые категории";
                    series.ChartType = SeriesChartType.Column;

                    foreach (KeyValuePair<string, int> category in priceCategories)
                    {
                        series.Points.AddXY(category.Key, category.Value);
                    }

                    chtPriceDistribution.Series.Add(series);
                    chtPriceDistribution.ChartAreas[0].AxisX.Interval = 1;
                }
            }
        }

    }
}
        
    