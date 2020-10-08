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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterpolationForm));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PointsToShowGroupBox = new System.Windows.Forms.GroupBox();
            this.HermiteInterpolation = new System.Windows.Forms.CheckBox();
            this.LinearInterpolation = new System.Windows.Forms.CheckBox();
            this.DefaultPoints = new System.Windows.Forms.CheckBox();
            this.ShowPointsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.PointsToShowGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Gray;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(207, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
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
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(809, 641);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Interpolation Chart";
            // 
            // PointsToShowGroupBox
            // 
            this.PointsToShowGroupBox.Controls.Add(this.HermiteInterpolation);
            this.PointsToShowGroupBox.Controls.Add(this.LinearInterpolation);
            this.PointsToShowGroupBox.Controls.Add(this.DefaultPoints);
            this.PointsToShowGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PointsToShowGroupBox.Location = new System.Drawing.Point(0, 146);
            this.PointsToShowGroupBox.Name = "PointsToShowGroupBox";
            this.PointsToShowGroupBox.Size = new System.Drawing.Size(210, 100);
            this.PointsToShowGroupBox.TabIndex = 1;
            this.PointsToShowGroupBox.TabStop = false;
            this.PointsToShowGroupBox.Text = "Points to show";
            // 
            // HermiteInterpolation
            // 
            this.HermiteInterpolation.AutoSize = true;
            this.HermiteInterpolation.Location = new System.Drawing.Point(6, 65);
            this.HermiteInterpolation.Name = "HermiteInterpolation";
            this.HermiteInterpolation.Size = new System.Drawing.Size(206, 25);
            this.HermiteInterpolation.TabIndex = 2;
            this.HermiteInterpolation.Text = "Єрмітова Інтерполяція";
            this.HermiteInterpolation.UseVisualStyleBackColor = true;
            // 
            // LinearInterpolation
            // 
            this.LinearInterpolation.AutoSize = true;
            this.LinearInterpolation.Location = new System.Drawing.Point(6, 42);
            this.LinearInterpolation.Name = "LinearInterpolation";
            this.LinearInterpolation.Size = new System.Drawing.Size(189, 25);
            this.LinearInterpolation.TabIndex = 2;
            this.LinearInterpolation.Text = "Лінійна Інтерполяція";
            this.LinearInterpolation.UseVisualStyleBackColor = true;
            // 
            // DefaultPoints
            // 
            this.DefaultPoints.AutoSize = true;
            this.DefaultPoints.Location = new System.Drawing.Point(6, 19);
            this.DefaultPoints.Name = "DefaultPoints";
            this.DefaultPoints.Size = new System.Drawing.Size(196, 25);
            this.DefaultPoints.TabIndex = 2;
            this.DefaultPoints.Text = "Малюємо Синусоїду";
            this.DefaultPoints.UseVisualStyleBackColor = true;
            // 
            // ShowPointsButton
            // 
            this.ShowPointsButton.FlatAppearance.BorderSize = 0;
            this.ShowPointsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPointsButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPointsButton.ForeColor = System.Drawing.Color.Black;
            this.ShowPointsButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowPointsButton.Image")));
            this.ShowPointsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowPointsButton.Location = new System.Drawing.Point(0, 255);
            this.ShowPointsButton.Name = "ShowPointsButton";
            this.ShowPointsButton.Size = new System.Drawing.Size(200, 101);
            this.ShowPointsButton.TabIndex = 2;
            this.ShowPointsButton.Text = "Show";
            this.ShowPointsButton.UseVisualStyleBackColor = true;
            this.ShowPointsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PointsToShowGroupBox);
            this.panel1.Controls.Add(this.ShowPointsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 641);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(44, -11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 117);
            this.label1.TabIndex = 5;
            this.label1.Text = "L";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 100);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(51, -11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 117);
            this.label2.TabIndex = 0;
            this.label2.Text = "L";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(200, 251);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 94);
            this.panelLeft.TabIndex = 6;
            // 
            // InterpolationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(836, 641);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InterpolationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.PointsToShowGroupBox.ResumeLayout(false);
            this.PointsToShowGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox PointsToShowGroupBox;
        private System.Windows.Forms.CheckBox HermiteInterpolation;
        private System.Windows.Forms.CheckBox LinearInterpolation;
        private System.Windows.Forms.CheckBox DefaultPoints;
        private System.Windows.Forms.Button ShowPointsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelLeft;
    }
}

