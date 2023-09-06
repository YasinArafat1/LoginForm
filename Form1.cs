using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_making_simple_login_page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.UserName = textBox1_Username.Text;
            l.Password = Convert.ToInt32(textBox2_Password.Text);
            l.submit();
            label4.Text = "Data Inserted Successfully";
        }
    }
}
