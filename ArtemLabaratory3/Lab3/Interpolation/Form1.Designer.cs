namespace Interpolation
{
    partial class InterpolationForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.InterpolationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PointsToShowGroupBox = new System.Windows.Forms.GroupBox();
            this.HermiteInterpolationCheckBox = new System.Windows.Forms.CheckBox();
            this.LinearInterpolationCheckBox = new System.Windows.Forms.CheckBox();
            this.DefaultPointsCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowPointsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InterpolationChart)).BeginInit();
            this.PointsToShowGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InterpolationChart
            // 
            chartArea1.Name = "ChartArea1";
            this.InterpolationChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.InterpolationChart.Legends.Add(legend1);
            this.InterpolationChart.Location = new System.Drawing.Point(229, 11);
            this.InterpolationChart.Margin = new System.Windows.Forms.Padding(2);
            this.InterpolationChart.Name = "InterpolationChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Default Points";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Linear Interpolation";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "Hermite Interpolation";
            this.InterpolationChart.Series.Add(series1);
            this.InterpolationChart.Series.Add(series2);
            this.InterpolationChart.Series.Add(series3);
            this.InterpolationChart.Size = new System.Drawing.Size(600, 624);
            this.InterpolationChart.TabIndex = 0;
            this.InterpolationChart.Text = "Interpolation Chart";
            // 
            // PointsToShowGroupBox
            // 
            this.PointsToShowGroupBox.Controls.Add(this.HermiteInterpolationCheckBox);
            this.PointsToShowGroupBox.Controls.Add(this.LinearInterpolationCheckBox);
            this.PointsToShowGroupBox.Controls.Add(this.DefaultPointsCheckBox);
            this.PointsToShowGroupBox.Location = new System.Drawing.Point(12, 11);
            this.PointsToShowGroupBox.Name = "PointsToShowGroupBox";
            this.PointsToShowGroupBox.Size = new System.Drawing.Size(200, 100);
            this.PointsToShowGroupBox.TabIndex = 1;
            this.PointsToShowGroupBox.TabStop = false;
            this.PointsToShowGroupBox.Text = "Points to show";
            // 
            // HermiteInterpolationCheckBox
            // 
            this.HermiteInterpolationCheckBox.AutoSize = true;
            this.HermiteInterpolationCheckBox.Location = new System.Drawing.Point(6, 65);
            this.HermiteInterpolationCheckBox.Name = "HermiteInterpolationCheckBox";
            this.HermiteInterpolationCheckBox.Size = new System.Drawing.Size(136, 27);
            this.HermiteInterpolationCheckBox.TabIndex = 2;
            this.HermiteInterpolationCheckBox.Text = "Hermite Interpolation";
            this.HermiteInterpolationCheckBox.UseVisualStyleBackColor = true;
            // 
            // LinearInterpolationCheckBox
            // 
            this.LinearInterpolationCheckBox.AutoSize = true;
            this.LinearInterpolationCheckBox.Location = new System.Drawing.Point(6, 42);
            this.LinearInterpolationCheckBox.Name = "LinearInterpolationCheckBox";
            this.LinearInterpolationCheckBox.Size = new System.Drawing.Size(129, 27);
            this.LinearInterpolationCheckBox.TabIndex = 2;
            this.LinearInterpolationCheckBox.Text = "Linear Interpolation";
            this.LinearInterpolationCheckBox.UseVisualStyleBackColor = true;
            // 
            // DefaultPointsCheckBox
            // 
            this.DefaultPointsCheckBox.AutoSize = true;
            this.DefaultPointsCheckBox.Location = new System.Drawing.Point(6, 19);
            this.DefaultPointsCheckBox.Name = "DefaultPointsCheckBox";
            this.DefaultPointsCheckBox.Size = new System.Drawing.Size(102, 27);
            this.DefaultPointsCheckBox.TabIndex = 2;
            this.DefaultPointsCheckBox.Text = "DefaultPoints";
            this.DefaultPointsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowPointsButton
            // 
            this.ShowPointsButton.Location = new System.Drawing.Point(137, 117);
            this.ShowPointsButton.Name = "ShowPointsButton";
            this.ShowPointsButton.Size = new System.Drawing.Size(75, 23);
            this.ShowPointsButton.TabIndex = 2;
            this.ShowPointsButton.Text = "Show";
            this.ShowPointsButton.UseVisualStyleBackColor = true;
            this.ShowPointsButton.Click += new System.EventHandler(this.ShowPointsButton_Click);
            // 
            // InterpolationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 641);
            this.Controls.Add(this.ShowPointsButton);
            this.Controls.Add(this.PointsToShowGroupBox);
            this.Controls.Add(this.InterpolationChart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InterpolationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.InterpolationChart)).EndInit();
            this.PointsToShowGroupBox.ResumeLayout(false);
            this.PointsToShowGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart InterpolationChart;
        private System.Windows.Forms.GroupBox PointsToShowGroupBox;
        private System.Windows.Forms.CheckBox HermiteInterpolationCheckBox;
        private System.Windows.Forms.CheckBox LinearInterpolationCheckBox;
        private System.Windows.Forms.CheckBox DefaultPointsCheckBox;
        private System.Windows.Forms.Button ShowPointsButton;
    }
}

