namespace TVP_Laba1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBoxDecimalResult = new TextBox();
            textBoxDecimalB = new TextBox();
            textBoxDecimalA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBoxBinaryResult = new TextBox();
            textBoxBinaryB = new TextBox();
            textBoxBinaryA = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            button1 = new Button();
            groupBox4 = new GroupBox();
            historyTextBox = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxDecimalResult);
            groupBox1.Controls.Add(textBoxDecimalB);
            groupBox1.Controls.Add(textBoxDecimalA);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(48, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 146);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Числа в десятичной системе";
            // 
            // textBoxDecimalResult
            // 
            textBoxDecimalResult.Location = new Point(89, 89);
            textBoxDecimalResult.Name = "textBoxDecimalResult";
            textBoxDecimalResult.Size = new Size(162, 23);
            textBoxDecimalResult.TabIndex = 5;
            // 
            // textBoxDecimalB
            // 
            textBoxDecimalB.Location = new Point(89, 62);
            textBoxDecimalB.Name = "textBoxDecimalB";
            textBoxDecimalB.Size = new Size(128, 23);
            textBoxDecimalB.TabIndex = 4;
            // 
            // textBoxDecimalA
            // 
            textBoxDecimalA.Location = new Point(91, 28);
            textBoxDecimalA.Name = "textBoxDecimalA";
            textBoxDecimalA.Size = new Size(126, 23);
            textBoxDecimalA.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 89);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Результат";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 65);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Число B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Число A";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxBinaryResult);
            groupBox2.Controls.Add(textBoxBinaryB);
            groupBox2.Controls.Add(textBoxBinaryA);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(48, 233);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(516, 170);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Числа в двоичной системе";
            // 
            // textBoxBinaryResult
            // 
            textBoxBinaryResult.Location = new Point(86, 95);
            textBoxBinaryResult.Name = "textBoxBinaryResult";
            textBoxBinaryResult.Size = new Size(424, 23);
            textBoxBinaryResult.TabIndex = 6;
            // 
            // textBoxBinaryB
            // 
            textBoxBinaryB.Location = new Point(86, 62);
            textBoxBinaryB.Name = "textBoxBinaryB";
            textBoxBinaryB.Size = new Size(424, 23);
            textBoxBinaryB.TabIndex = 5;
            // 
            // textBoxBinaryA
            // 
            textBoxBinaryA.Location = new Point(86, 31);
            textBoxBinaryA.Name = "textBoxBinaryA";
            textBoxBinaryA.Size = new Size(424, 23);
            textBoxBinaryA.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 98);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 3;
            label6.Text = "Результат";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 65);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 2;
            label5.Text = "Число B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 31);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 1;
            label4.Text = "Число A";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(48, 171);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(172, 56);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Умножение";
            // 
            // button1
            // 
            button1.Location = new Point(0, 22);
            button1.Name = "button1";
            button1.Size = new Size(169, 23);
            button1.TabIndex = 2;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(historyTextBox);
            groupBox4.Location = new Point(570, 19);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(503, 548);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "История";
            // 
            // historyTextBox
            // 
            historyTextBox.Location = new Point(24, 24);
            historyTextBox.Name = "historyTextBox";
            historyTextBox.Size = new Size(468, 514);
            historyTextBox.TabIndex = 0;
            historyTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 611);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Теория вычислительных процессов №3";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox3;
        private Button button1;
        private GroupBox groupBox4;
        private TextBox textBoxDecimalResult;
        private TextBox textBoxDecimalB;
        private TextBox textBoxDecimalA;
        private TextBox textBoxBinaryResult;
        private TextBox textBoxBinaryB;
        private TextBox textBoxBinaryA;
        private RichTextBox historyTextBox;
    }
}