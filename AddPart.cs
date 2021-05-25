using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFrench_C968
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void lblAddPartPrice_Click(object sender, EventArgs e)
        {

        }

        private void radioInHouseAdd_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioOutsourcedAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOutsourcedAdd.Checked)
            {
                lblAddPartMachineID.Text = "Company Name";
            }
            else
            {
                lblAddPartMachineID.Text = "Machine ID";
            }
        }

        private void txtAddPartID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddPartName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddPartInv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddPartPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddPartMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddPartMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddPartMachineID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPartSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPartCancel_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MainForm addCancel = new MainForm();
            //addCancel.Show();
            this.Close();
        }

        private void lblAddPartMachineID_Click(object sender, EventArgs e)
        {
            
        }
    }
}
