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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string[] bb = { "รูปแบบที่1", "รูปแบบที่2", "รูปแบบที่3" };
            comboBox1.Items.AddRange(bb);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a1 = 0;

            if (int.TryParse(txt_in_int.Text, out a1) == false)
            {
                MessageBox.Show("กรอกข้อมูลเป็นตัวเลข", "Error");
                txt_in_int.Focus();
                txt_in_int.SelectAll();
                return;
            }
            else if (txt_in_str.Text.Trim() == "")
            {
                MessageBox.Show("กรอกอักษระ", "Error");
                txt_in_str.Focus();
                txt_in_str.SelectAll();
                return;
            }
            txt_out.Text = falukecostom(Convert.ToInt32(txt_in_int.Text), txt_in_str.Text, comboBox1.Text);
        }

        string falukecostom(int size, string charc, string selectedItem)
        {

            string result = "";
            //selectedItem = comboBox1.Text;


            if (selectedItem == "รูปแบบที่1")
            {
                int width = size * 2; // ความกว้าง
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < width; j++)
                    {

                        if (i == 0 || i == size - 1 || j == 0 || j == width - 1)
                        {
                            result += charc;
                        }
                        else
                        {
                            result += "   ";
                        }
                    }
                    result += "\n";
                }
            }
            else if (selectedItem == "รูปแบบที่2")
            {
                for (int i = 0; i < size + 2; i++)
                {
                    for (int j = 0; j < size + 2; j++)
                    {
                        if (i == 0 || i == size + 1 || j == 0 || j == size + 1)
                            result += charc;
                        else
                            result += i;
                    }
                    result += "\n";
                }
            }
            else if (selectedItem == "รูปแบบที่3")
            {
                for (int i = 1; i <= size; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        result += charc;
                    }
                    result += "\n";
                }
            }
            else
            {
                MessageBox.Show("กรอกเลือกรูปแบบที่กำหนดไว้", "Error");


            }


            return result;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}