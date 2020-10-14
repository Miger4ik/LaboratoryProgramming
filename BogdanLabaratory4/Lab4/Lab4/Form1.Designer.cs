namespace Lab4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonIntegrate = new System.Windows.Forms.Button();
            this.numericA = new System.Windows.Forms.NumericUpDown();
            this.numericB = new System.Windows.Forms.NumericUpDown();
            this.numericH = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonRectangles = new System.Windows.Forms.RadioButton();
            this.radioButtonTrapezoid = new System.Windows.Forms.RadioButton();
            this.radioButtonSimpson = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "H";
            // 
            // buttonIntegrate
            // 
            this.buttonIntegrate.Location = new System.Drawing.Point(322, 287);
            this.buttonIntegrate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIntegrate.Name = "buttonIntegrate";
            this.buttonIntegrate.Size = new System.Drawing.Size(118, 28);
            this.buttonIntegrate.TabIndex = 6;
            this.buttonIntegrate.Text = "Integrate";
            this.buttonIntegrate.UseVisualStyleBackColor = true;
            this.buttonIntegrate.Click += new System.EventHandler(this.buttonIntegrate_Click);
            // 
            // numericA
            // 
            this.numericA.Location = new System.Drawing.Point(342, 40);
            this.numericA.Margin = new System.Windows.Forms.Padding(2);
            this.numericA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericA.Name = "numericA";
            this.numericA.Size = new System.Drawing.Size(98, 20);
            this.numericA.TabIndex = 7;
            // 
            // numericB
            // 
            this.numericB.Location = new System.Drawing.Point(342, 70);
            this.numericB.Margin = new System.Windows.Forms.Padding(2);
            this.numericB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericB.Name = "numericB";
            this.numericB.Size = new System.Drawing.Size(98, 20);
            this.numericB.TabIndex = 8;
            // 
            // numericH
            // 
            this.numericH.Location = new System.Drawing.Point(342, 107);
            this.numericH.Margin = new System.Windows.Forms.Padding(2);
            this.numericH.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericH.Name = "numericH";
            this.numericH.Size = new System.Drawing.Size(98, 20);
            this.numericH.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(51, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "0.0";
            // 
            // radioButtonRectangles
            // 
            this.radioButtonRectangles.AutoSize = true;
            this.radioButtonRectangles.Checked = true;
            this.radioButtonRectangles.Location = new System.Drawing.Point(322, 178);
            this.radioButtonRectangles.Name = "radioButtonRectangles";
            this.radioButtonRectangles.Size = new System.Drawing.Size(79, 17);
            this.radioButtonRectangles.TabIndex = 11;
            this.radioButtonRectangles.TabStop = true;
            this.radioButtonRectangles.Text = "Rectangles";
            this.radioButtonRectangles.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrapezoid
            // 
            this.radioButtonTrapezoid.AutoSize = true;
            this.radioButtonTrapezoid.Location = new System.Drawing.Point(322, 203);
            this.radioButtonTrapezoid.Name = "radioButtonTrapezoid";
            this.radioButtonTrapezoid.Size = new System.Drawing.Size(72, 17);
            this.radioButtonTrapezoid.TabIndex = 12;
            this.radioButtonTrapezoid.TabStop = true;
            this.radioButtonTrapezoid.Text = "Trapezoid";
            this.radioButtonTrapezoid.UseVisualStyleBackColor = true;
            // 
            // radioButtonSimpson
            // 
            this.radioButtonSimpson.AutoSize = true;
            this.radioButtonSimpson.Location = new System.Drawing.Point(321, 226);
            this.radioButtonSimpson.Name = "radioButtonSimpson";
            this.radioButtonSimpson.Size = new System.Drawing.Size(65, 17);
            this.radioButtonSimpson.TabIndex = 13;
            this.radioButtonSimpson.Text = "Simpson";
            this.radioButtonSimpson.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 355);
            this.Controls.Add(this.radioButtonSimpson);
            this.Controls.Add(this.radioButtonTrapezoid);
            this.Controls.Add(this.radioButtonRectangles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericH);
            this.Controls.Add(this.numericB);
            this.Controls.Add(this.numericA);
            this.Controls.Add(this.buttonIntegrate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonIntegrate;
        private System.Windows.Forms.NumericUpDown numericA;
        private System.Windows.Forms.NumericUpDown numericB;
        private System.Windows.Forms.NumericUpDown numericH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonRectangles;
        private System.Windows.Forms.RadioButton radioButtonTrapezoid;
        private System.Windows.Forms.RadioButton radioButtonSimpson;
    }
}

