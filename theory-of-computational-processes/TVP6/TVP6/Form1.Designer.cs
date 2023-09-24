namespace TVP6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumCDecimalBox = new System.Windows.Forms.TextBox();
            this.NumBDecimalTextBox = new System.Windows.Forms.TextBox();
            this.numADecimalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumCBinaryBox = new System.Windows.Forms.TextBox();
            this.NumBBinaryBox = new System.Windows.Forms.TextBox();
            this.NumABinanaryBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HistoryBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumCDecimalBox);
            this.groupBox1.Controls.Add(this.NumBDecimalTextBox);
            this.groupBox1.Controls.Add(this.numADecimalTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "числа в десятичной системе";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NumCDecimalBox
            // 
            this.NumCDecimalBox.Location = new System.Drawing.Point(89, 122);
            this.NumCDecimalBox.Name = "NumCDecimalBox";
            this.NumCDecimalBox.Size = new System.Drawing.Size(189, 20);
            this.NumCDecimalBox.TabIndex = 5;
            // 
            // NumBDecimalTextBox
            // 
            this.NumBDecimalTextBox.Location = new System.Drawing.Point(89, 81);
            this.NumBDecimalTextBox.Name = "NumBDecimalTextBox";
            this.NumBDecimalTextBox.Size = new System.Drawing.Size(189, 20);
            this.NumBDecimalTextBox.TabIndex = 4;
            // 
            // numADecimalTextBox
            // 
            this.numADecimalTextBox.Location = new System.Drawing.Point(89, 39);
            this.numADecimalTextBox.Name = "numADecimalTextBox";
            this.numADecimalTextBox.Size = new System.Drawing.Size(189, 20);
            this.numADecimalTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Число C =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Число B =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число А =";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumCBinaryBox);
            this.groupBox2.Controls.Add(this.NumBBinaryBox);
            this.groupBox2.Controls.Add(this.NumABinanaryBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(2, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 177);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "числа в двоичной системе";
            // 
            // NumCBinaryBox
            // 
            this.NumCBinaryBox.Location = new System.Drawing.Point(89, 122);
            this.NumCBinaryBox.Name = "NumCBinaryBox";
            this.NumCBinaryBox.Size = new System.Drawing.Size(188, 20);
            this.NumCBinaryBox.TabIndex = 5;
            // 
            // NumBBinaryBox
            // 
            this.NumBBinaryBox.Location = new System.Drawing.Point(89, 81);
            this.NumBBinaryBox.Name = "NumBBinaryBox";
            this.NumBBinaryBox.Size = new System.Drawing.Size(188, 20);
            this.NumBBinaryBox.TabIndex = 4;
            // 
            // NumABinanaryBox
            // 
            this.NumABinanaryBox.Location = new System.Drawing.Point(89, 39);
            this.NumABinanaryBox.Name = "NumABinanaryBox";
            this.NumABinanaryBox.Size = new System.Drawing.Size(188, 20);
            this.NumABinanaryBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Число C =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Число B =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Число А =";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(12, 410);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(304, 29);
            this.start_button.TabIndex = 7;
            this.start_button.Text = "Перемножить";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.startButtonClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HistoryBox);
            this.groupBox3.Location = new System.Drawing.Point(333, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 560);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "История";
            // 
            // HistoryBox
            // 
            this.HistoryBox.Location = new System.Drawing.Point(6, 19);
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(420, 525);
            this.HistoryBox.TabIndex = 0;
            this.HistoryBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 624);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Теория вычислительных процессов №6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NumCDecimalBox;
        private System.Windows.Forms.TextBox NumBDecimalTextBox;
        private System.Windows.Forms.TextBox numADecimalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NumCBinaryBox;
        private System.Windows.Forms.TextBox NumBBinaryBox;
        private System.Windows.Forms.TextBox NumABinanaryBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox HistoryBox;
    }
}

