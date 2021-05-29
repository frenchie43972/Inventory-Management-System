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
            txtAddPartID.Enabled = false; 
            
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
            if (String.IsNullOrWhiteSpace(txtAddPartName.Text))
            {
                txtAddPartName.BackColor = Color.Salmon;
            }
            else
            {
                txtAddPartName.BackColor = Color.White;
            }
        }

        private void txtAddPartInv_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddPartInv.Text) || !Int32.TryParse(txtAddPartInv.Text, out _))
            {
                txtAddPartInv.BackColor = Color.Salmon;
            }
            else
            {
                txtAddPartInv.BackColor = Color.White;
            }
        }

        private void txtAddPartPrice_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddPartPrice.Text) || !Decimal.TryParse(txtAddPartPrice.Text, out _))
            {
                txtAddPartPrice.BackColor = Color.Salmon;
            }
            else
            {
                txtAddPartPrice.BackColor = Color.White;
            }
        }

        private void txtAddPartMax_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddPartMax.Text) || !Int32.TryParse(txtAddPartMax.Text, out _))
            {
                txtAddPartMax.BackColor = Color.Salmon;
            }
            else
            {
                txtAddPartMax.BackColor = Color.White;
            }
        }

        private void txtAddPartMin_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddPartMin.Text) || !Int32.TryParse(txtAddPartMin.Text, out _))
            {
                txtAddPartMin.BackColor = Color.Salmon;
            }
            else
            {
                txtAddPartMin.BackColor = Color.White;
            }
        }

        private void txtAddPartMachineID_TextChanged(object sender, EventArgs e)
        {
            if (radioInHouseAdd.Checked)
            {
                if (String.IsNullOrWhiteSpace(txtAddPartMachineID.Text) || !Int32.TryParse(txtAddPartMachineID.Text, out _))
                {
                    txtAddPartMachineID.BackColor = Color.Salmon;
                }
                else
                {
                    txtAddPartMachineID.BackColor = Color.White;
                }
                //btnAddPartSave.Enabled = saveVerify();
            }
            if (radioOutsourcedAdd.Checked)
            {
                if (String.IsNullOrWhiteSpace(txtAddPartMachineID.Text))
                {
                    txtAddPartMachineID.BackColor = Color.Salmon;
                }
                else
                {
                    txtAddPartMachineID.BackColor = Color.White;
                }
                //btnAddPartSave.Enabled = saveVerify();
            }

        }

        //private bool saveVerify()
        //{
        //    return true; 
        //} 
        private void BtnAddPartSave_Click(object sender, EventArgs e)
        {
            //Adds either In House or Outsourced Part. Displays on the Main Form
            if (radioInHouseAdd.Checked)
            {
                InHouse inHouse = new(txtAddPartName.Text, decimal.Parse(txtAddPartPrice.Text), int.Parse(txtAddPartInv.Text),
                    int.Parse(txtAddPartMin.Text), int.Parse(txtAddPartMax.Text), int.Parse(txtAddPartMachineID.Text));

                this.Hide();
                MainForm addSave = new();
                Inventory.AddPart(inHouse); 
                addSave.Show();
            }
            else
            {
                Outsource outsource = new(txtAddPartName.Text, decimal.Parse(txtAddPartPrice.Text), int.Parse(txtAddPartInv.Text),
                    int.Parse(txtAddPartMin.Text), int.Parse(txtAddPartMax.Text), txtAddPartMachineID.Text);

                this.Hide();
                MainForm addSave = new();
                Inventory.AddPart(outsource);
                addSave.Show();
            }

        }

        private void btnAddPartCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm addCancel = new MainForm();
            addCancel.Show();
        }

        private void lblAddPartMachineID_Click(object sender, EventArgs e)
        {
            
        }
    }
}
