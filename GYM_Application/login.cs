using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Application
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void bynLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUserName.Text;
            string password = txtBoxpassword.Text;
            if (txtBoxUserName.Text == "habiba"  && txtBoxpassword.Text== "777efef")
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect User ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
