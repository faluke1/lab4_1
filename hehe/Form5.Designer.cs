namespace hehe
{
    partial class Form5
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
            comboBox1 = new ComboBox();
            txt_out = new Label();
            button1 = new Button();
            txt_in_int = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_in_str = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 197);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(131, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txt_out
            // 
            txt_out.BackColor = SystemColors.ControlDark;
            txt_out.Location = new Point(93, 251);
            txt_out.Name = "txt_out";
            txt_out.Size = new Size(198, 232);
            txt_out.TabIndex = 2;
            txt_out.Text = "..";
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(323, 229);
            button1.Name = "button1";
            button1.Size = new Size(147, 64);
            button1.TabIndex = 3;
            button1.Text = "เริ่ม";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_in_int
            // 
            txt_in_int.Location = new Point(133, 149);
            txt_in_int.Name = "txt_in_int";
            txt_in_int.Size = new Size(131, 27);
            txt_in_int.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 156);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 5;
            label2.Text = "แถว";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 205);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 6;
            label3.Text = "แบบ";
            // 
            // txt_in_str
            // 
            txt_in_str.Location = new Point(133, 105);
            txt_in_str.Name = "txt_in_str";
            txt_in_str.Size = new Size(131, 27);
            txt_in_str.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 108);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 8;
            label4.Text = "ตัวอักษร";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(838, 536);
            Controls.Add(label4);
            Controls.Add(txt_in_str);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_in_int);
            Controls.Add(button1);
            Controls.Add(txt_out);
            Controls.Add(comboBox1);
            Name = "Form5";
            Text = "เรียงตัว";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label txt_out;
        private Button button1;
        private TextBox txt_in_int;
        private Label label2;
        private Label label3;
        private TextBox txt_in_str;
        private Label label4;
    }
}