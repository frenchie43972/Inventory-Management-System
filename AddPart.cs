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
            btnAddPartSave.Enabled = false;

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

        public void txtAddPartID_TextChanged(object sender, EventArgs e)
        {

        }
        /*The below code for textboxes have exception handling to verify correct information is entered into the fields*/
        private void txtAddPartName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddPartName.Text))
            {
                txtAddPartName.BackColor = Color.Salmon;
                btnAddPartSave.Enabled = false;
            }
            else
            {
                txtAddPartName.BackColor = Color.White;
                btnAddPartSave.Enabled = true;
            }
        }

        private void txtAddPartInv_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddPartInv.Text) || !Int32.TryParse(txtAddPartInv.Text, out _))
            {
                txtAddPartInv.BackColor = Color.Salmon;
                btnAddPartSave.Enabled = false;
            }
            
            else
            {
                txtAddPartInv.BackColor = Color.White;
                btnAddPartSave.Enabled = true;
            }
        }

        private void txtAddPartPrice_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddPartPrice.Text) || !Decimal.TryParse(txtAddPartPrice.Text, out _))
            {
                txtAddPartPrice.BackColor = Color.Salmon;
                btnAddPartSave.Enabled = false;
            }
            else
            {
                txtAddPartPrice.BackColor = Color.White;
                btnAddPartSave.Enabled = true;
            }
        }

        private void txtAddPartMax_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddPartMax.Text) || !Int32.TryParse(txtAddPartMax.Text, out _))
            {
                txtAddPartMax.BackColor = Color.Salmon;
                btnAddPartSave.Enabled = false;
            }
            else
            {
                txtAddPartMax.BackColor = Color.White;
                btnAddPartSave.Enabled = true;
            }
        }

        private void txtAddPartMin_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddPartMin.Text) || !Int32.TryParse(txtAddPartMin.Text, out _))
            {
                txtAddPartMin.BackColor = Color.Salmon;
                btnAddPartSave.Enabled = false;
            }
            else
            {
                txtAddPartMin.BackColor = Color.White;
                btnAddPartSave.Enabled = true;
            }
        }

        private void txtAddPartMachineID_TextChanged(object sender, EventArgs e)
        {   
            /*Ensures that when In House is checked it will only accept integers and when Outsourced is checked
             it can accepts either string or integers and will not allow a save unless the correct information is entered*/
            if (radioInHouseAdd.Checked)
            {
                if (String.IsNullOrWhiteSpace(txtAddPartMachineID.Text) || !Int32.TryParse(txtAddPartMachineID.Text, out _))
                {
                    txtAddPartMachineID.BackColor = Color.Salmon;
                    btnAddPartSave.Enabled = false;
                }
                else
                {
                    txtAddPartMachineID.BackColor = Color.White;
                    btnAddPartSave.Enabled = true;
                }
            }
            if (radioOutsourcedAdd.Checked)
            {
                if (String.IsNullOrWhiteSpace(txtAddPartMachineID.Text))
                {
                    txtAddPartMachineID.BackColor = Color.Salmon;
                    btnAddPartSave.Enabled = false;
                }
                else
                {
                    txtAddPartMachineID.BackColor = Color.White;
                    btnAddPartSave.Enabled = true;
                }
            }
        }

        private void BtnAddPartSave_Click(object sender, EventArgs e)
        {
            //Modifies the selected row from the main page
            if (radioInHouseAdd.Checked)
            {
                InHouse inHouse = new(txtAddPartName.Text, decimal.Parse(txtAddPartPrice.Text), int.Parse(txtAddPartInv.Text),
                    int.Parse(txtAddPartMin.Text), int.Parse(txtAddPartMax.Text), int.Parse(txtAddPartMachineID.Text));
                //Ensures you cannot enter or save quantities if Max is less than Min or Inventory is leass than Min or greater than Max
                if (int.Parse(txtAddPartMax.Text) < int.Parse(txtAddPartMin.Text))
                {
                    MessageBox.Show("Max quantity may not exceed Min quantity!", "ATTENTION!");
                    txtAddPartMax.BackColor = Color.Salmon;
                    btnAddPartSave.Enabled = false;
                    return;
                }
                if ((Int32.Parse(txtAddPartInv.Text) < Int32.Parse(txtAddPartMin.Text)) || 
                    (Int32.Parse(txtAddPartInv.Text) > Int32.Parse(txtAddPartMax.Text)))
                {
                    MessageBox.Show("Your Inventory may not be below the Min or above the Max quantities!", "ATTENTION!");
                    txtAddPartInv.BackColor = Color.Salmon;
                    btnAddPartSave.Enabled = false;
                    return;
                }
                
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
