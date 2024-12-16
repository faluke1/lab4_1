namespace hehe
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFullname = new TextBox();
            txtTitle = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnSplitName = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 46);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "ชื่อ-นามสกุล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 113);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "คำนำหน้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 165);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 2;
            label3.Text = "ชื่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 215);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "นามสกุล";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(126, 43);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(471, 27);
            txtFullname.TabIndex = 4;
            txtFullname.Text = "นายสัณหณัฐ จำปานิล";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(126, 113);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(274, 27);
            txtTitle.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(126, 165);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(274, 27);
            txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(126, 215);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(274, 27);
            txtLastName.TabIndex = 7;
            // 
            // btnSplitName
            // 
            btnSplitName.Location = new Point(628, 43);
            btnSplitName.Name = "btnSplitName";
            btnSplitName.Size = new Size(160, 34);
            btnSplitName.TabIndex = 8;
            btnSplitName.Text = "แยกชื่อสกุล";
            btnSplitName.UseVisualStyleBackColor = true;
            btnSplitName.Click += btnSplitName_Click;
            // 
            // button1
            // 
            button1.Location = new Point(608, 142);
            button1.Name = "button1";
            button1.Size = new Size(166, 72);
            button1.TabIndex = 9;
            button1.Text = "ล้างค่า";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(564, 272);
            button2.Name = "button2";
            button2.Size = new Size(224, 103);
            button2.TabIndex = 10;
            button2.Text = "กลับไปหน้าแรก";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(29, 272);
            button3.Name = "button3";
            button3.Size = new Size(160, 34);
            button3.TabIndex = 11;
            button3.Text = "เด็กหญิง";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(195, 272);
            button4.Name = "button4";
            button4.Size = new Size(160, 34);
            button4.TabIndex = 12;
            button4.Text = "นาย";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(361, 272);
            button5.Name = "button5";
            button5.Size = new Size(160, 34);
            button5.TabIndex = 13;
            button5.Text = "ดช.";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(29, 322);
            button6.Name = "button6";
            button6.Size = new Size(160, 34);
            button6.TabIndex = 14;
            button6.Text = "น.ส.";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(195, 322);
            button7.Name = "button7";
            button7.Size = new Size(160, 34);
            button7.TabIndex = 15;
            button7.Text = "ร.ต.ต.";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(361, 322);
            button8.Name = "button8";
            button8.Size = new Size(160, 34);
            button8.TabIndex = 16;
            button8.Text = "มรว.";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(195, 362);
            button9.Name = "button9";
            button9.Size = new Size(160, 34);
            button9.TabIndex = 17;
            button9.Text = "ด.ต.";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 589);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSplitName);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtTitle);
            Controls.Add(txtFullname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "แยกชื่อ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFullname;
        private TextBox txtTitle;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnSplitName;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
