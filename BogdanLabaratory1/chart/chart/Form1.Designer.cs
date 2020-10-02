namespace chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.start = new System.Windows.Forms.Button();
            this.SecondFrequency = new System.Windows.Forms.NumericUpDown();
            this.PiMultiplier = new System.Windows.Forms.NumericUpDown();
            this.FirstFrequency = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FirstAmpl = new System.Windows.Forms.NumericUpDown();
            this.SecondAmpl = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstAmpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondAmpl)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 57);
            this.chart1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(968, 675);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(1004, 644);
            this.start.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(433, 88);
            this.start.TabIndex = 1;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecondFrequency
            // 
            this.SecondFrequency.Location = new System.Drawing.Point(1257, 107);
            this.SecondFrequency.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SecondFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SecondFrequency.Name = "SecondFrequency";
            this.SecondFrequency.Size = new System.Drawing.Size(180, 31);
            this.SecondFrequency.TabIndex = 2;
            this.SecondFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PiMultiplier
            // 
            this.PiMultiplier.Location = new System.Drawing.Point(1257, 157);
            this.PiMultiplier.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PiMultiplier.Name = "PiMultiplier";
            this.PiMultiplier.Size = new System.Drawing.Size(180, 31);
            this.PiMultiplier.TabIndex = 3;
            this.PiMultiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FirstFrequency
            // 
            this.FirstFrequency.Location = new System.Drawing.Point(1257, 57);
            this.FirstFrequency.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FirstFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FirstFrequency.Name = "FirstFrequency";
            this.FirstFrequency.Size = new System.Drawing.Size(180, 31);
            this.FirstFrequency.TabIndex = 4;
            this.FirstFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1252, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "alpha: x*PI/4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1113, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Частота №1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1199, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1141, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Зсув фаз";
            // 
            // FirstAmpl
            // 
            this.FirstAmpl.Location = new System.Drawing.Point(1257, 267);
            this.FirstAmpl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FirstAmpl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FirstAmpl.Name = "FirstAmpl";
            this.FirstAmpl.Size = new System.Drawing.Size(180, 31);
            this.FirstAmpl.TabIndex = 9;
            this.FirstAmpl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SecondAmpl
            // 
            this.SecondAmpl.Location = new System.Drawing.Point(1257, 317);
            this.SecondAmpl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SecondAmpl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SecondAmpl.Name = "SecondAmpl";
            this.SecondAmpl.Size = new System.Drawing.Size(180, 31);
            this.SecondAmpl.TabIndex = 10;
            this.SecondAmpl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(992, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Амплітуда коливань №1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1113, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Частота №2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(992, 319);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Амплітуда коливань №2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SecondAmpl);
            this.Controls.Add(this.FirstAmpl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstFrequency);
            this.Controls.Add(this.PiMultiplier);
            this.Controls.Add(this.SecondFrequency);
            this.Controls.Add(this.start);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstAmpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondAmpl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.NumericUpDown SecondFrequency;
        private System.Windows.Forms.NumericUpDown PiMultiplier;
        private System.Windows.Forms.NumericUpDown FirstFrequency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown FirstAmpl;
        private System.Windows.Forms.NumericUpDown SecondAmpl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}

