namespace Bookstore
{
    partial class UserStatistics
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.notesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.databaseDataSet = new Bookstore.DatabaseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.notesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // notesChart
            // 
            chartArea1.Name = "ChartArea1";
            this.notesChart.ChartAreas.Add(chartArea1);
            this.notesChart.DataSource = this.databaseDataSet;
            this.notesChart.Location = new System.Drawing.Point(21, 69);
            this.notesChart.Name = "notesChart";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Name = "Notes";
            this.notesChart.Series.Add(series1);
            this.notesChart.Size = new System.Drawing.Size(758, 369);
            this.notesChart.TabIndex = 0;
            this.notesChart.Text = "notesChart";
            this.notesChart.Click += new System.EventHandler(this.NotesChart_Click);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(297, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "Your rates : ";
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // UserStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notesChart);
            this.Name = "UserStatistics";
            this.Text = "UserStatistics";
            this.Load += new System.EventHandler(this.UserStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart notesChart;
        private System.Windows.Forms.Label label1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
    }
}