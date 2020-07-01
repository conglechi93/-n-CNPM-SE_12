namespace CNPM_SE_12.View
{
    partial class Chart_Payment
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_Bill = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Bill
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Bill.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Bill.Legends.Add(legend1);
            this.chart_Bill.Location = new System.Drawing.Point(12, 3);
            this.chart_Bill.Name = "chart_Bill";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "VND Đồng";
            this.chart_Bill.Series.Add(series1);
            this.chart_Bill.Size = new System.Drawing.Size(575, 300);
            this.chart_Bill.TabIndex = 0;
            this.chart_Bill.Text = "chart_Bill";
            // 
            // Chart_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 303);
            this.Controls.Add(this.chart_Bill);
            this.Name = "Chart_Payment";
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Bill;
    }
}
