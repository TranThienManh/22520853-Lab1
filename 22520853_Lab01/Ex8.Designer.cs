namespace _22520853_Lab01
{
    partial class Ex8
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
            input = new TextBox();
            btn_Add = new Button();
            FoodList = new ListBox();
            btn_Find = new Button();
            btn_Reset = new Button();
            btn_Exit = new Button();
            label2 = new Label();
            output = new TextBox();
            btn_Remove = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 65);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập món ăn :";
            // 
            // input
            // 
            input.Location = new Point(256, 66);
            input.Name = "input";
            input.Size = new Size(168, 27);
            input.TabIndex = 1;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(256, 122);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(168, 53);
            btn_Add.TabIndex = 2;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // FoodList
            // 
            FoodList.FormattingEnabled = true;
            FoodList.Location = new Point(447, 65);
            FoodList.Name = "FoodList";
            FoodList.Size = new Size(197, 204);
            FoodList.TabIndex = 3;
            FoodList.SelectedIndexChanged += FoodList_SelectedIndexChanged;
            // 
            // btn_Find
            // 
            btn_Find.Location = new Point(116, 339);
            btn_Find.Name = "btn_Find";
            btn_Find.Size = new Size(130, 50);
            btn_Find.TabIndex = 4;
            btn_Find.Text = "Tìm món ăn";
            btn_Find.UseVisualStyleBackColor = true;
            btn_Find.Click += btn_Find_Click;
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(339, 339);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(130, 50);
            btn_Reset.TabIndex = 5;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(514, 339);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(130, 50);
            btn_Exit.TabIndex = 6;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 294);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 7;
            label2.Text = "Hôm nay ăn :";
            // 
            // output
            // 
            output.Location = new Point(256, 287);
            output.Name = "output";
            output.Size = new Size(388, 27);
            output.TabIndex = 8;
            // 
            // btn_Remove
            // 
            btn_Remove.Location = new Point(256, 192);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(168, 53);
            btn_Remove.TabIndex = 9;
            btn_Remove.Text = "Xóa";
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // Ex8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Remove);
            Controls.Add(output);
            Controls.Add(label2);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Reset);
            Controls.Add(btn_Find);
            Controls.Add(FoodList);
            Controls.Add(btn_Add);
            Controls.Add(input);
            Controls.Add(label1);
            Name = "Ex8";
            Text = "Ex8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input;
        private Button btn_Add;
        private ListBox FoodList;
        private Button btn_Find;
        private Button btn_Reset;
        private Button btn_Exit;
        private Label label2;
        private TextBox output;
        private Button btn_Remove;
    }
}