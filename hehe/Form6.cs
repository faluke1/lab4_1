﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hehe
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int[] data_2 = textBox1.Lines.Select(line => int.TryParse(line, out var result) ? result : 0).ToArray();
            tet(data_2);
        }

        void tet2(int[] data_2)
        {
            string result = "";
            int sum_2 = 0;
            double cof = 0;

            for (int i = 0; i < data_2.Length; i++)  // ใช้ int[] แทน string[]
            {
                int a = data_2[i];   // ใช้ค่า int ที่มีอยู่แล้วใน Array
                sum_2 += a;
                cof++;
                result += a.ToString() + Environment.NewLine;
            }
            label1.Text = "method แบบ For\n" + result + "ค่าเฉลี่ย: " + sum_2 / cof;
        }

        void tet(int[] data_2)
        {
            string result = "";
            int sum_2 = 0;
            double cof = 0;

            foreach (int a in data_2)  // ใช้ int แทน string
            {
                sum_2 += a;            // เพิ่มผลรวม
                cof++;                 // นับจำนวน
                result += a.ToString() + Environment.NewLine;  // เก็บผลลัพธ์ใน result
            }
            label1.Text = "method แบบ Foreach\n" + result + "ค่าเฉลี่ย: " + sum_2 / cof;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] data_2 = textBox1.Lines.Select(line => int.TryParse(line, out var result) ? result : 0).ToArray();
            tet2(data_2);
        }
    }
}
