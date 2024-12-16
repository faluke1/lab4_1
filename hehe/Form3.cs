using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hehe
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            try
            {
                // รับค่าระยะทางและเวลา
                double distance = double.Parse(txtdistance.Text); // ระยะทาง (เมตร)
                double time = double.Parse(txttime.Text);         // เวลา (วินาที)
                double minutes = time * 60; 

                // ตรวจสอบไม่ให้เวลาเป็น 0 หรือติดลบ
                if (time <= 0)
                {
                    MessageBox.Show("เวลาไม่สามารถเป็นศูนย์หรือติดลบได้", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // สูตรคำนวณความเร็ว: v = s / t
               // double speed = distance / time;
                double speed = kk(distance, time);

                // แสดงผลลัพธ์ใน Label
                lblResult.Text = speed.ToString("0.00") + " m/s"; // หน่วย: เมตรต่อวินาที
            }
            catch (FormatException)
            {
                MessageBox.Show("กรุณากรอกตัวเลขที่ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        double kk(double speed, double s)
        {
            return speed / s;
        }
          
    }
}
