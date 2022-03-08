namespace KTCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = textboxusernam.Text;
            string pass = textboxmatkhau.Text;
            if (user =="admin" && pass == "admin")
            {
                Form2 f2 = new Form2();
                f2.Show();
                Form1 form1 = new Form1();
                form1.Close();  
            }
        }
    }
}