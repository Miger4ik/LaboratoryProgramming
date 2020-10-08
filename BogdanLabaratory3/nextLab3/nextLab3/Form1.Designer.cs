namespace nextLab3
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
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dotsUpDown = new System.Windows.Forms.NumericUpDown();
            this.showSinCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.showLineCheckBox = new System.Windows.Forms.CheckBox();
            this.showErmiteCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(518, 445);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(530, 406);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(236, 32);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "кількість інтерпольованих точок";
            // 
            // dotsUpDown
            // 
            this.dotsUpDown.Location = new System.Drawing.Point(703, 55);
            this.dotsUpDown.Name = "dotsUpDown";
            this.dotsUpDown.Size = new System.Drawing.Size(63, 20);
            this.dotsUpDown.TabIndex = 5;
            // 
            // showSinCheckBox
            // 
            this.showSinCheckBox.AutoSize = true;
            this.showSinCheckBox.Checked = true;
            this.showSinCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showSinCheckBox.Location = new System.Drawing.Point(527, 141);
            this.showSinCheckBox.Name = "showSinCheckBox";
            this.showSinCheckBox.Size = new System.Drawing.Size(127, 17);
            this.showSinCheckBox.TabIndex = 6;
            this.showSinCheckBox.Text = "Показати синусоїду";
            this.showSinCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // showLineCheckBox
            // 
            this.showLineCheckBox.AutoSize = true;
            this.showLineCheckBox.Location = new System.Drawing.Point(527, 177);
            this.showLineCheckBox.Name = "showLineCheckBox";
            this.showLineCheckBox.Size = new System.Drawing.Size(179, 17);
            this.showLineCheckBox.TabIndex = 8;
            this.showLineCheckBox.Text = "Показати лінійну інтерполяцію";
            this.showLineCheckBox.UseVisualStyleBackColor = true;
            // 
            // showErmiteCheckBox
            // 
            this.showErmiteCheckBox.AutoSize = true;
            this.showErmiteCheckBox.Location = new System.Drawing.Point(527, 211);
            this.showErmiteCheckBox.Name = "showErmiteCheckBox";
            this.showErmiteCheckBox.Size = new System.Drawing.Size(190, 17);
            this.showErmiteCheckBox.TabIndex = 9;
            this.showErmiteCheckBox.Text = "Показати ермітову інтерполяцію";
            this.showErmiteCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showErmiteCheckBox);
            this.Controls.Add(this.showLineCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showSinCheckBox);
            this.Controls.Add(this.dotsUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown dotsUpDown;
        private System.Windows.Forms.CheckBox showSinCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox showLineCheckBox;
        private System.Windows.Forms.CheckBox showErmiteCheckBox;
        private System.Windows.Forms.Label label4;
    }
}

