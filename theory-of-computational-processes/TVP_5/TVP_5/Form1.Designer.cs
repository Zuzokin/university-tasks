namespace TVP_5
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
            this.NumBDecimalBox = new System.Windows.Forms.TextBox();
            this.NumADecimalBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumCBinaryBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumBbinaryBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumABinaryBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Sub = new System.Windows.Forms.RadioButton();
            this.Add = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.HistoryBox = new System.Windows.Forms.RichTextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumCDecimalBox);
            this.groupBox1.Controls.Add(this.NumBDecimalBox);
            this.groupBox1.Controls.Add(this.NumADecimalBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Числа в десятичной системе";
            // 
            // NumCDecimalBox
            // 
            this.NumCDecimalBox.Location = new System.Drawing.Point(95, 108);
            this.NumCDecimalBox.Name = "NumCDecimalBox";
            this.NumCDecimalBox.Size = new System.Drawing.Size(194, 20);
            this.NumCDecimalBox.TabIndex = 5;
            // 
            // NumBDecimalBox
            // 
            this.NumBDecimalBox.Location = new System.Drawing.Point(95, 70);
            this.NumBDecimalBox.Name = "NumBDecimalBox";
            this.NumBDecimalBox.Size = new System.Drawing.Size(194, 20);
            this.NumBDecimalBox.TabIndex = 4;
            // 
            // NumADecimalBox
            // 
            this.NumADecimalBox.Location = new System.Drawing.Point(95, 32);
            this.NumADecimalBox.Name = "NumADecimalBox";
            this.NumADecimalBox.Size = new System.Drawing.Size(194, 20);
            this.NumADecimalBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Число C = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Число B = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число А = ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumCBinaryBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.NumBbinaryBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.NumABinaryBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Числа в двоичной системе";
            // 
            // NumCBinaryBox
            // 
            this.NumCBinaryBox.Location = new System.Drawing.Point(92, 108);
            this.NumCBinaryBox.Name = "NumCBinaryBox";
            this.NumCBinaryBox.Size = new System.Drawing.Size(203, 20);
            this.NumCBinaryBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Число А = ";
            // 
            // NumBbinaryBox
            // 
            this.NumBbinaryBox.Location = new System.Drawing.Point(92, 70);
            this.NumBbinaryBox.Name = "NumBbinaryBox";
            this.NumBbinaryBox.Size = new System.Drawing.Size(203, 20);
            this.NumBbinaryBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Число B = ";
            // 
            // NumABinaryBox
            // 
            this.NumABinaryBox.Location = new System.Drawing.Point(92, 32);
            this.NumABinaryBox.Name = "NumABinaryBox";
            this.NumABinaryBox.Size = new System.Drawing.Size(203, 20);
            this.NumABinaryBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Число C = ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.start_button);
            this.groupBox3.Controls.Add(this.Sub);
            this.groupBox3.Controls.Add(this.Add);
            this.groupBox3.Location = new System.Drawing.Point(13, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбор операци";
            // 
            // Sub
            // 
            this.Sub.AutoSize = true;
            this.Sub.Location = new System.Drawing.Point(31, 67);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(80, 17);
            this.Sub.TabIndex = 4;
            this.Sub.Text = "Вычитание";
            this.Sub.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Checked = true;
            this.Add.Location = new System.Drawing.Point(31, 31);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(76, 17);
            this.Add.TabIndex = 3;
            this.Add.TabStop = true;
            this.Add.Text = "Сложение";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.HistoryBox);
            this.groupBox4.Location = new System.Drawing.Point(321, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 509);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "История";
            // 
            // HistoryBox
            // 
            this.HistoryBox.Location = new System.Drawing.Point(6, 19);
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(325, 477);
            this.HistoryBox.TabIndex = 0;
            this.HistoryBox.Text = "";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(131, 31);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Выполнить";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.startButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 539);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Теория вычислительных процессов №5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NumCDecimalBox;
        private System.Windows.Forms.TextBox NumBDecimalBox;
        private System.Windows.Forms.TextBox NumADecimalBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NumCBinaryBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NumBbinaryBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumABinaryBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Sub;
        private System.Windows.Forms.RadioButton Add;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox HistoryBox;
        private System.Windows.Forms.Button start_button;
    }
}

