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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ประกาศตัวแปร
            double baseSalary, overtimeHours, overtimeRate, totalSalary;

            // ตรวจสอบและแปลงค่าจาก TextBox
            if (!double.TryParse(txtBaseSalary.Text, out baseSalary) ||
                !double.TryParse(txtOvertimeHours.Text, out overtimeHours) ||
                !double.TryParse(txtOvertimeRate.Text, out overtimeRate))
            {
                MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลขที่ถูกต้อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            // คำนวณเงินเดือนรวม
            //totalSalary = baseSalary + (overtimeHours * overtimeRate);
            totalSalary = faluke(baseSalary, overtimeHours, overtimeRate);

           // แสดงผลลัพธ์
           lblResult.Text = $"เงินเดือนรวม: {totalSalary:C}";
        }
        double faluke(double oop, double str, double fa)
        {
            return oop + (str * fa);
        }
    }
}  
