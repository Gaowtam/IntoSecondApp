using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntoSecondApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            String email = txtFirstName.Text+" "+txtLastName.Text;
            MessageBox.Show(email);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
