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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            sqlconnection con = new sqlconnection();
            con.connectionstring = "date sourse = DESKTOP-E4UJ6RE\\SQLEXPRESS; datebase = gym ;integrated security =true";
            sqlcommand cmd = new sqlcommand();
            cmd.commandText = " Select * from NewMember " ;
            sqldataAdapter DA = new sqldataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("this will delete your date. confirm?","delete date",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                sqlconnection con = new sqlconnection();
                con.connectionstring = "date sourse = DESKTOP-E4UJ6RE\\SQLEXPRESS; datebase = gym ;integrated security =true";
                sqlcommand cmd = new sqlcommand();
                cmd.commandText = " delete from NewMember where MID = " + textBox1.Text + " ";
                sqldataAdapter DA = new sqldataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

            }
            else
            {
                this.Activate();
                sqlconnection con = new sqlconnection();
                con.connectionstring = "date sourse = DESKTOP-E4UJ6RE\\SQLEXPRESS; datebase = gym ;integrated security =true";
                sqlcommand cmd = new sqlcommand();
                cmd.commandText = " delete from NewMember where MID = " + textBox1.Text + " ";
                sqldataAdapter DA = new sqldataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];


            }



        }
    }
}
