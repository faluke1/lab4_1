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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int[] numbers = textBox1.Lines.Select(line => int.TryParse(line, out var result) ? result : 0).ToArray();
            SortAscending(numbers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] numbers = textBox1.Lines.Select(line => int.TryParse(line, out var result) ? result : 0).ToArray();
            faluke(numbers);
        }

        void faluke(int[] arr)
        {
            Array.Sort(arr);  // เรียงลำดับจากน้อยไปมาก
            Array.Reverse(arr);  // กลับลำดับเพื่อให้เป็นการเรียงจากมากไปน้อย
                                 //return arr;

            string result = "";


            foreach (int a in arr)  // ใช้ int แทน string
            {

                result += a.ToString() + Environment.NewLine;  // เก็บผลลัพธ์ใน result
            }
            label1.Text = "เรียงลำดับจากมากไปน้อย\n" + result;
        }

        void SortAscending(int[] arr)
        {
            Array.Sort(arr);  // เรียงลำดับจากน้อยไปมาก
            //return arr;

            string result = "";


            foreach (int a in arr)  // ใช้ int แทน string
            {

                result += a.ToString() + Environment.NewLine;  // เก็บผลลัพธ์ใน result
            }
            label1.Text = "เรียงลำดับจากน้อยไปมาก\n" + result;
        }
    }
}
