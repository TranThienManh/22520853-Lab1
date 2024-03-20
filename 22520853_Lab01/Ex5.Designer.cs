namespace _22520853_Lab01
{
    partial class Ex5
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
            input_a = new TextBox();
            input_b = new TextBox();
            cbo_state = new ComboBox();
            btn_Cal = new Button();
            btn_Reset = new Button();
            btn_Exit = new Button();
            panel1 = new Panel();
            output_sum = new TextBox();
            label9 = new Label();
            output_gt = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            output_b = new TextBox();
            label5 = new Label();
            output_a = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 37);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập A : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 37);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập B :";
            // 
            // input_a
            // 
            input_a.Location = new Point(256, 37);
            input_a.Name = "input_a";
            input_a.Size = new Size(101, 27);
            input_a.TabIndex = 2;
            input_a.TextAlign = HorizontalAlignment.Center;
            // 
            // input_b
            // 
            input_b.Location = new Point(477, 34);
            input_b.Name = "input_b";
            input_b.Size = new Size(114, 27);
            input_b.TabIndex = 3;
            input_b.TextAlign = HorizontalAlignment.Center;
            // 
            // cbo_state
            // 
            cbo_state.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_state.FormattingEnabled = true;
            cbo_state.Items.AddRange(new object[] { "Bảng cửu chương ", "Tính toán giá trị" });
            cbo_state.Location = new Point(330, 85);
            cbo_state.Name = "cbo_state";
            cbo_state.Size = new Size(151, 28);
            cbo_state.TabIndex = 4;
            cbo_state.SelectedIndexChanged += cbo_state_SelectedIndexChanged;
            // 
            // btn_Cal
            // 
            btn_Cal.Location = new Point(133, 127);
            btn_Cal.Name = "btn_Cal";
            btn_Cal.Size = new Size(166, 35);
            btn_Cal.TabIndex = 6;
            btn_Cal.Text = "Tính các giá trị ";
            btn_Cal.UseVisualStyleBackColor = true;
            btn_Cal.Click += btn_Cal_Click;
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(492, 130);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(90, 35);
            btn_Reset.TabIndex = 7;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(600, 130);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(90, 35);
            btn_Exit.TabIndex = 8;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(output_sum);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(output_gt);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(output_b);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(output_a);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(23, 171);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 297);
            panel1.TabIndex = 9;
            // 
            // output_sum
            // 
            output_sum.Location = new Point(454, 190);
            output_sum.Name = "output_sum";
            output_sum.ReadOnly = true;
            output_sum.Size = new Size(125, 27);
            output_sum.TabIndex = 13;
            output_sum.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(425, 152);
            label9.Name = "label9";
            label9.Size = new Size(246, 20);
            label9.TabIndex = 12;
            label9.Text = "2.  S = A1 + A2 + A3 + A4 + … + AB";
            // 
            // output_gt
            // 
            output_gt.Location = new Point(454, 113);
            output_gt.Name = "output_gt";
            output_gt.ReadOnly = true;
            output_gt.Size = new Size(125, 27);
            output_gt.TabIndex = 11;
            output_gt.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(425, 81);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 10;
            label8.Text = "1.  ( A -B )!";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(425, 31);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 9;
            label7.Text = "Tính toán giá trị";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 20);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 8;
            label6.Text = "Bảng cửu chương";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 55);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 7;
            label4.Text = "Output B";
            // 
            // output_b
            // 
            output_b.Location = new Point(173, 78);
            output_b.Multiline = true;
            output_b.Name = "output_b";
            output_b.ReadOnly = true;
            output_b.Size = new Size(117, 207);
            output_b.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 55);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 5;
            label5.Text = "Output A";
            // 
            // output_a
            // 
            output_a.Location = new Point(27, 78);
            output_a.Multiline = true;
            output_a.Name = "output_a";
            output_a.ReadOnly = true;
            output_a.Size = new Size(119, 207);
            output_a.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 0;
            label3.Text = "Kết quả ";
            // 
            // Ex5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(panel1);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Reset);
            Controls.Add(btn_Cal);
            Controls.Add(cbo_state);
            Controls.Add(input_b);
            Controls.Add(input_a);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ex5";
            Text = "Ex5";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox input_a;
        private TextBox input_b;
        private ComboBox cbo_state;
        private Button btn_Cal;
        private Button btn_Reset;
        private Button btn_Exit;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private TextBox output_b;
        private Label label5;
        private TextBox output_a;
        private Label label6;
        private Label label8;
        private Label label7;
        private TextBox output_gt;
        private TextBox output_sum;
        private Label label9;
    }
}