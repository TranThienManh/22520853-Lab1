namespace _22520853_Lab01
{
    partial class Ex6
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
            input = new TextBox();
            output = new TextBox();
            btn_Ex5_find = new Button();
            btn_Ex5_Reset = new Button();
            btn_Ex5_Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(47, 42);
            label1.Name = "label1";
            label1.Size = new Size(236, 23);
            label1.TabIndex = 0;
            label1.Text = "Nhập ngày, tháng, năm sinh :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(47, 92);
            label2.Name = "label2";
            label2.Size = new Size(148, 23);
            label2.TabIndex = 1;
            label2.Text = "Cung hoàng đạo :";
            // 
            // input
            // 
            input.Location = new Point(299, 42);
            input.Name = "input";
            input.Size = new Size(203, 27);
            input.TabIndex = 2;
            // 
            // output
            // 
            output.Location = new Point(299, 88);
            output.Name = "output";
            output.Size = new Size(203, 27);
            output.TabIndex = 3;
            // 
            // btn_Ex5_find
            // 
            btn_Ex5_find.Location = new Point(64, 157);
            btn_Ex5_find.Name = "btn_Ex5_find";
            btn_Ex5_find.Size = new Size(105, 45);
            btn_Ex5_find.TabIndex = 4;
            btn_Ex5_find.Text = "Find";
            btn_Ex5_find.UseVisualStyleBackColor = true;
            btn_Ex5_find.Click += btn_Ex5_find_Click;
            // 
            // btn_Ex5_Reset
            // 
            btn_Ex5_Reset.Location = new Point(254, 157);
            btn_Ex5_Reset.Name = "btn_Ex5_Reset";
            btn_Ex5_Reset.Size = new Size(105, 45);
            btn_Ex5_Reset.TabIndex = 5;
            btn_Ex5_Reset.Text = "Reset";
            btn_Ex5_Reset.UseVisualStyleBackColor = true;
            btn_Ex5_Reset.Click += btn_Ex5_Reset_Click;
            // 
            // btn_Ex5_Exit
            // 
            btn_Ex5_Exit.Location = new Point(397, 157);
            btn_Ex5_Exit.Name = "btn_Ex5_Exit";
            btn_Ex5_Exit.Size = new Size(105, 45);
            btn_Ex5_Exit.TabIndex = 6;
            btn_Ex5_Exit.Text = "Exit";
            btn_Ex5_Exit.UseVisualStyleBackColor = true;
            btn_Ex5_Exit.Click += btn_Ex5_Exit_Click;
            // 
            // Ex6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 266);
            Controls.Add(btn_Ex5_Exit);
            Controls.Add(btn_Ex5_Reset);
            Controls.Add(btn_Ex5_find);
            Controls.Add(output);
            Controls.Add(input);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ex6";
            Text = "Ex6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox input;
        private TextBox output;
        private Button btn_Ex5_find;
        private Button btn_Ex5_Reset;
        private Button btn_Ex5_Exit;
    }
}