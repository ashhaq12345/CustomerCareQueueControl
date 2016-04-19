using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void signin_Click(object sender, EventArgs e)
        {
            string username = userbox.Text;
            string password = passbox.Text;
            if (username.Equals("ash") && password.Equals("123"))
            {
                Form3 f = new Form3();
                this.Dispose();
                f.Show();
                

            }
            else {
                MessageBox.Show("Wrong Log In Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
