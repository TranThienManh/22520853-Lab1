namespace _22520853_Lab01
{
    partial class EX3_1
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
            btn_Ex3_1_Exit = new Button();
            btn_Ex03_1_Del = new Button();
            btn_Ex3_1_Read = new Button();
            label2 = new Label();
            show_kq = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Ex3_1_Exit
            // 
            btn_Ex3_1_Exit.Location = new Point(353, 115);
            btn_Ex3_1_Exit.Name = "btn_Ex3_1_Exit";
            btn_Ex3_1_Exit.Size = new Size(94, 29);
            btn_Ex3_1_Exit.TabIndex = 13;
            btn_Ex3_1_Exit.Text = "Exit";
            btn_Ex3_1_Exit.UseVisualStyleBackColor = true;
            btn_Ex3_1_Exit.Click += btn_Ex3_Exit_Click;
            // 
            // btn_Ex03_1_Del
            // 
            btn_Ex03_1_Del.Location = new Point(220, 115);
            btn_Ex03_1_Del.Name = "btn_Ex03_1_Del";
            btn_Ex03_1_Del.Size = new Size(94, 29);
            btn_Ex03_1_Del.TabIndex = 12;
            btn_Ex03_1_Del.Text = "Delete";
            btn_Ex03_1_Del.UseVisualStyleBackColor = true;
            btn_Ex03_1_Del.Click += btn_Ex03_Del_Click;
            // 
            // btn_Ex3_1_Read
            // 
            btn_Ex3_1_Read.Location = new Point(81, 115);
            btn_Ex3_1_Read.Name = "btn_Ex3_1_Read";
            btn_Ex3_1_Read.Size = new Size(94, 29);
            btn_Ex3_1_Read.TabIndex = 11;
            btn_Ex3_1_Read.Text = "Read";
            btn_Ex3_1_Read.UseVisualStyleBackColor = true;
            btn_Ex3_1_Read.Click += btn_Ex3_Read_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 166);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 10;
            label2.Text = "Kết quả :";
            // 
            // show_kq
            // 
            show_kq.Location = new Point(159, 165);
            show_kq.Multiline = true;
            show_kq.Name = "show_kq";
            show_kq.ReadOnly = true;
            show_kq.Size = new Size(288, 78);
            show_kq.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 27);
            textBox1.TabIndex = 8;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 63);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.TabIndex = 7;
            label1.Text = "Nhập số nguyên :";
            // 
            // EX3_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 274);
            Controls.Add(btn_Ex3_1_Exit);
            Controls.Add(btn_Ex03_1_Del);
            Controls.Add(btn_Ex3_1_Read);
            Controls.Add(label2);
            Controls.Add(show_kq);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "EX3_1";
            Text = "EX3_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Ex3_1_Exit;
        private Button btn_Ex03_1_Del;
        private Button btn_Ex3_1_Read;
        private Label label2;
        private TextBox show_kq;
        private TextBox textBox1;
        private Label label1;
    }
}