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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string EquipName = txtEquipName.Text;
            string Description = txtEquipName.Text;
            string MUsed = txtMusclesUsed.Text;
            string DDate = txtDeliveryDate.Text;
            Int64 cost = Int64.Parse(txtCost.Text);


          
            MessageBox.Show("data saved" );

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEquipName.Clear();
            txtMusclesUsed.Clear();
            txtCost.Clear();
            txtDescription.Clear();
            txtDeliveryDate.Value = DateTime.Now;
        }
    }
}
