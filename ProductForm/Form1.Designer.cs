namespace ProductForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.chtPriceDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGetProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtPriceDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(470, 360);
            this.dgvProducts.TabIndex = 0;
            // 
            // chtPriceDistribution
            // 
            chartArea2.Name = "ChartArea1";
            this.chtPriceDistribution.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtPriceDistribution.Legends.Add(legend2);
            this.chtPriceDistribution.Location = new System.Drawing.Point(488, 12);
            this.chtPriceDistribution.Name = "chtPriceDistribution";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtPriceDistribution.Series.Add(series2);
            this.chtPriceDistribution.Size = new System.Drawing.Size(415, 360);
            this.chtPriceDistribution.TabIndex = 1;
            this.chtPriceDistribution.Text = "chart1";
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(189, 379);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(119, 65);
            this.btnGetProducts.TabIndex = 2;
            this.btnGetProducts.Text = "Вывод списка продуктов";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.btnGetProducts);
            this.Controls.Add(this.chtPriceDistribution);
            this.Controls.Add(this.dgvProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtPriceDistribution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtPriceDistribution;
        private System.Windows.Forms.Button btnGetProducts;
    }
}

