namespace hehe
{
    partial class Form3
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
            groupBox1 = new GroupBox();
            txttime = new TextBox();
            txtdistance = new TextBox();
            btnCalculate = new Button();
            lblDistance = new Label();
            lblTime = new Label();
            label1 = new Label();
            lblResult = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Cyan;
            groupBox1.Controls.Add(txttime);
            groupBox1.Controls.Add(txtdistance);
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(lblDistance);
            groupBox1.Controls.Add(lblTime);
            groupBox1.Location = new Point(12, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 180);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวณความเร็ว";
            // 
            // txttime
            // 
            txttime.Location = new Point(104, 108);
            txttime.Name = "txttime";
            txttime.Size = new Size(97, 27);
            txttime.TabIndex = 19;
            // 
            // txtdistance
            // 
            txtdistance.Location = new Point(106, 57);
            txtdistance.Name = "txtdistance";
            txtdistance.Size = new Size(95, 27);
            txtdistance.TabIndex = 18;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(250, 75);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(155, 34);
            btnCalculate.TabIndex = 17;
            btnCalculate.Text = "คำนวณความเร็ว";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnTriangleArea_Click;
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(37, 57);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(55, 20);
            lblDistance.TabIndex = 4;
            lblDistance.Text = "ระยะทาง";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(37, 115);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(35, 20);
            lblTime.TabIndex = 7;
            lblTime.Text = "เวลา";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(578, 159);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 19;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(255, 192, 128);
            lblResult.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(544, 144);
            lblResult.Name = "lblResult";
            lblResult.RightToLeft = RightToLeft.No;
            lblResult.Size = new Size(223, 162);
            lblResult.TabIndex = 20;
            lblResult.Text = "0.00";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 599);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "หาความเร็ว";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCalculate;
        private Label lblDistance;
        private Label lblTime;
        private Label label1;
        private Label lblResult;
        private TextBox txttime;
        private TextBox txtdistance;
    }
}