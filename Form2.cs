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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            usersName.Text = "Welcome to your school's Math game" + Form1.passingUsername;
        }

        private void lvl1button_Click(object sender, EventArgs e)
        {
            Form3 frmRem = new Form3();
            frmRem.Show();
            this.Hide();
        }
    }
}
