using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mATHASSIGNMENT
{
    public partial class Form1 : Form
    {
        public static string passingUsername;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            passingUsername = usernameTxtbox.Text;
            Form2 frmRem = new Form2();
            frmRem.Show();
            this.Hide();
        }
    }
}
