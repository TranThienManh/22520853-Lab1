namespace _22520853_Lab01
{
    partial class Ex2
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
            btn_Ex02_cal = new Button();
            btn_Ex02_Reset = new Button();
            btn_Ex02_Exit = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            MaxBox = new TextBox();
            MinBox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 53);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 91);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 1;
            label2.Text = "Số thứ hai :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 131);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 2;
            label3.Text = "Số thứ ba :";
            // 
            // btn_Ex02_cal
            // 
            btn_Ex02_cal.Location = new Point(370, 47);
            btn_Ex02_cal.Name = "btn_Ex02_cal";
            btn_Ex02_cal.Size = new Size(109, 32);
            btn_Ex02_cal.TabIndex = 3;
            btn_Ex02_cal.Text = "Tìm";
            btn_Ex02_cal.UseVisualStyleBackColor = true;
            btn_Ex02_cal.Click += btn_Ex02_cal_Click;
            // 
            // btn_Ex02_Reset
            // 
            btn_Ex02_Reset.Location = new Point(370, 85);
            btn_Ex02_Reset.Name = "btn_Ex02_Reset";
            btn_Ex02_Reset.Size = new Size(109, 32);
            btn_Ex02_Reset.TabIndex = 4;
            btn_Ex02_Reset.Text = "Reset";
            btn_Ex02_Reset.UseVisualStyleBackColor = true;
            btn_Ex02_Reset.Click += btn_Ex02_Reset_Click;
            // 
            // btn_Ex02_Exit
            // 
            btn_Ex02_Exit.Location = new Point(370, 125);
            btn_Ex02_Exit.Name = "btn_Ex02_Exit";
            btn_Ex02_Exit.Size = new Size(109, 32);
            btn_Ex02_Exit.TabIndex = 5;
            btn_Ex02_Exit.Text = "Exit";
            btn_Ex02_Exit.UseVisualStyleBackColor = true;
            btn_Ex02_Exit.Click += btn_Ex02_Exit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(199, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 27);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(497, 69);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 9;
            label4.Text = "Max :";
            // 
            // MaxBox
            // 
            MaxBox.Location = new Point(559, 66);
            MaxBox.Name = "MaxBox";
            MaxBox.ReadOnly = true;
            MaxBox.Size = new Size(140, 27);
            MaxBox.TabIndex = 10;
            // 
            // MinBox
            // 
            MinBox.Location = new Point(559, 115);
            MinBox.Name = "MinBox";
            MinBox.ReadOnly = true;
            MinBox.Size = new Size(140, 27);
            MinBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(501, 118);
            label5.Name = "label5";
            label5.Size = new Size(48, 23);
            label5.TabIndex = 12;
            label5.Text = "Min :";
            // 
            // Ex2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 216);
            Controls.Add(label5);
            Controls.Add(MinBox);
            Controls.Add(MaxBox);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_Ex02_Exit);
            Controls.Add(btn_Ex02_Reset);
            Controls.Add(btn_Ex02_cal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ex2";
            Text = "Bài 02 – Số lớn nhất, nhỏ nhất";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_Ex02_cal;
        private Button btn_Ex02_Reset;
        private Button btn_Ex02_Exit;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private TextBox MaxBox;
        private TextBox MinBox;
        private Label label5;
    }
}