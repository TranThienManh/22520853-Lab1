namespace _22520853_Lab01
{
    partial class Ex3
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
            textBox1 = new TextBox();
            show_kq = new TextBox();
            label2 = new Label();
            btn_Ex3_Read = new Button();
            btn_Ex03_Del = new Button();
            btn_Ex3_Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 35);
            label1.Name = "label1";
            label1.Size = new Size(233, 23);
            label1.TabIndex = 0;
            label1.Text = "Nhập số nguyên từ 0 đến 9  :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(292, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 27);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // show_kq
            // 
            show_kq.Location = new Point(155, 134);
            show_kq.Name = "show_kq";
            show_kq.ReadOnly = true;
            show_kq.Size = new Size(264, 27);
            show_kq.TabIndex = 2;
            show_kq.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 138);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 3;
            label2.Text = "Kết quả :";
            label2.Click += label2_Click;
            // 
            // btn_Ex3_Read
            // 
            btn_Ex3_Read.Location = new Point(53, 87);
            btn_Ex3_Read.Name = "btn_Ex3_Read";
            btn_Ex3_Read.Size = new Size(94, 29);
            btn_Ex3_Read.TabIndex = 4;
            btn_Ex3_Read.Text = "Read";
            btn_Ex3_Read.UseVisualStyleBackColor = true;
            btn_Ex3_Read.Click += btn_Ex3_Read_Click;
            // 
            // btn_Ex03_Del
            // 
            btn_Ex03_Del.Location = new Point(192, 87);
            btn_Ex03_Del.Name = "btn_Ex03_Del";
            btn_Ex03_Del.Size = new Size(94, 29);
            btn_Ex03_Del.TabIndex = 5;
            btn_Ex03_Del.Text = "Delete";
            btn_Ex03_Del.UseVisualStyleBackColor = true;
            btn_Ex03_Del.Click += btn_Ex03_Del_Click;
            // 
            // btn_Ex3_Exit
            // 
            btn_Ex3_Exit.Location = new Point(325, 87);
            btn_Ex3_Exit.Name = "btn_Ex3_Exit";
            btn_Ex3_Exit.Size = new Size(94, 29);
            btn_Ex3_Exit.TabIndex = 6;
            btn_Ex3_Exit.Text = "Exit";
            btn_Ex3_Exit.UseVisualStyleBackColor = true;
            btn_Ex3_Exit.Click += btn_Ex3_Exit_Click;
            // 
            // Ex3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 194);
            Controls.Add(btn_Ex3_Exit);
            Controls.Add(btn_Ex03_Del);
            Controls.Add(btn_Ex3_Read);
            Controls.Add(label2);
            Controls.Add(show_kq);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Ex3";
            Text = "Ex3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox show_kq;
        private Label label2;
        private Button btn_Ex3_Read;
        private Button btn_Ex03_Del;
        private Button btn_Ex3_Exit;
    }
}