namespace _22520853_Lab01
{
    partial class Ex1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_ex1_calc = new Button();
            btn_Reset = new Button();
            btn_Exit = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 83);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "SỐ THỨ NHẤT :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 131);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "SỐ THỨ HAI :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 236);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "KẾT QUẢ :";
            // 
            // btn_ex1_calc
            // 
            btn_ex1_calc.Location = new Point(283, 179);
            btn_ex1_calc.Name = "btn_ex1_calc";
            btn_ex1_calc.Size = new Size(241, 29);
            btn_ex1_calc.TabIndex = 3;
            btn_ex1_calc.Text = "TÍNH";
            btn_ex1_calc.UseVisualStyleBackColor = true;
            btn_ex1_calc.Click += btn_ex1_calc_Click_1;
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(283, 285);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(94, 29);
            btn_Reset.TabIndex = 4;
            btn_Reset.Text = "RESET";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(430, 285);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 29);
            btn_Exit.TabIndex = 5;
            btn_Exit.Text = "EXIT";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(399, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(399, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(399, 229);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // Ex1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Reset);
            Controls.Add(btn_ex1_calc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ex1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_ex1_calc;
        private Button btn_Reset;
        private Button btn_Exit;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}