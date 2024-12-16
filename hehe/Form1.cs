namespace hehe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSplitName_Click(object sender, EventArgs e)
        {
            string fullName = "", firstname = "", lastname = "", title = "";
            int x = 0;

            fullName = txtFullname.Text.Trim(); //ลบ spzce หน้าสุดและหลังสุดออก

            //ตรวจสอบว่ามีคำนำหน้าที่ต้องการหรือไม่ (นางสาว, นาง,นาย)
            if (fullName.StartsWith("นางสาว"))
            {
                x = 6;    //ตำแหน่งที่ต้องการแยก
                title = fullName.Substring(0, x);
            }
            else if (fullName.StartsWith("นาง") || fullName.StartsWith("นาย"))
            {
                x = 3;      //ตำแหน่งที่ต้องการแยก
                title = fullName.Substring(0, x);
            }
            else if (fullName.StartsWith("เด็กชาย"))
            {
                x = 7; //คำแหน่งที่ต้องแยก
                title = fullName.Substring(0, x);
            }
            else if (fullName.StartsWith("เด็กหญิง"))
            {
                x = 8; //ตำแหน่งที่ต้องแยก
                title = fullName.Substring(0, x);
            }
            else
            {
                x = fullName.LastIndexOf('.') + 1;
                title = fullName.Substring(0, x);
            }
            fullName = fullName.Substring(x).Trim();
            //หาตำแหน่งช่องว่างระหว่างชื่อและสกุล
            x = fullName.IndexOf(' ');

            //ตัดตั้งแต่ตัวที่0จนถึงตำแหน่งช่องว่าง
            firstname = fullName.Substring(0, x).Trim();
            //ตัดตั้งแต่ตำแหน่งช่องว่างไปจนหมดข้อความจะได้นามสกุล
            lastname = fullName.Substring(x).Trim();

            //แสดงผลใน Textbox
            txtTitle.Text = title;
            txtFirstName.Text = firstname;
            txtLastName.Text = lastname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clearForm();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtFullname.Text = ("เด็กหญิงคิมมี่ ไม่ชอบอาบน้ำ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtFullname.Text = ("นายคิมมี่ ไม่ชอบอาบน้ำ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtFullname.Text = ("ดช.คิมมี่ ไม่ชอบอาบน้ำ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtFullname.Text = ("นส.คิมมี่ ไม่ชอบอาบน้ำ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtFullname.Text = ("ร.ต.ต.คิมมี่ ไม่ชอบอาบน้ำ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtFullname.Text = ("มรว.คิมมี่ ไม่ชอบอาบน้ำ");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtFullname.Text = ("ด.ต.คิมมี่ ไม่ชอบอาบน้ำ");
        }
    }
}
