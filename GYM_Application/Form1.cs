using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GYM_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void equpmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void equpmentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void deletMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("this will close your application. confir?","CLOSE",MessageBoxButtons.YesNo,MessageBoxIcon.Error)==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("welcome Back", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Log Out ! Confir?" ,"LOG OUT",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
                login lg = new login();
                lg.Show();
            }
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMember newMember= new NewMember();
            newMember.Show();
        }
    }
}