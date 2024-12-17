namespace hehe
{
    partial class Form2
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
            txtBaseSalary = new TextBox();
            txtOvertimeHours = new TextBox();
            txtOvertimeRate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblResult = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtBaseSalary
            // 
            txtBaseSalary.Location = new Point(55, 109);
            txtBaseSalary.Name = "txtBaseSalary";
            txtBaseSalary.Size = new Size(110, 27);
            txtBaseSalary.TabIndex = 19;
            // 
            // txtOvertimeHours
            // 
            txtOvertimeHours.Location = new Point(55, 219);
            txtOvertimeHours.Name = "txtOvertimeHours";
            txtOvertimeHours.Size = new Size(110, 27);
            txtOvertimeHours.TabIndex = 20;
            // 
            // txtOvertimeRate
            // 
            txtOvertimeRate.Location = new Point(55, 307);
            txtOvertimeRate.Name = "txtOvertimeRate";
            txtOvertimeRate.Size = new Size(110, 27);
            txtOvertimeRate.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 86);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 22;
            label1.Text = "เงินเดือนพื้นฐาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 196);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 23;
            label2.Text = "จำนวนชั่วโมงโอที";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 284);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 24;
            label3.Text = "อัตราค่าชั่วโมงโอที";
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(255, 192, 128);
            lblResult.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(324, 40);
            lblResult.Name = "lblResult";
            lblResult.RightToLeft = RightToLeft.No;
            lblResult.Size = new Size(223, 131);
            lblResult.TabIndex = 25;
            lblResult.Text = "0.00";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(324, 192);
            button1.Name = "button1";
            button1.Size = new Size(223, 80);
            button1.TabIndex = 26;
            button1.Text = "คำนวณ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(324, 307);
            button2.Name = "button2";
            button2.Size = new Size(112, 58);
            button2.TabIndex = 27;
            button2.Text = "ล้างค่า";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(902, 588);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOvertimeRate);
            Controls.Add(txtOvertimeHours);
            Controls.Add(txtBaseSalary);
            Name = "Form2";
            Text = "คำนวณเงินเดือน";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBaseSalary;
        private TextBox txtOvertimeHours;
        private TextBox txtOvertimeRate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResult;
        private Button button1;
        private Button button2;
    }
}