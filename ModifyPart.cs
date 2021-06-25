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
    public partial class ModifyPart : Form
    {
        public ModifyPart()
        {
            InitializeComponent();
            txtModifyPartID.Enabled = false;
            txtModifyPartID.Text = Inventory.AllParts[Inventory.CurrentIndex].PartID.ToString();
            txtModifyPartName.Text = Inventory.AllParts[Inventory.CurrentIndex].Name;
            txtModifyPartInv.Text = Inventory.AllParts[Inventory.CurrentIndex].InStock.ToString();
            txtModifyPartPrice.Text = Inventory.AllParts[Inventory.CurrentIndex].Price.ToString();
            txtModifyPartMax.Text = Inventory.AllParts[Inventory.CurrentIndex].Max.ToString();
            txtModifyPartMin.Text = Inventory.AllParts[Inventory.CurrentIndex].Min.ToString();
            //Supposed to be used for MachineID
            txtModifyMachineID.Text = Inventory.AllParts[Inventory.CurrentIndex].Min.ToString();
        }

        private void radioInHouseModify_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioOutsourcedModify_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOutsourcedModify.Checked)
            {
                lblModifyPartMachineID.Text = "Company Name";
            }
            else
            {
                lblModifyPartMachineID.Text = "Machine ID";
            }
        }

        private void txtModifyPartID_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtModifyPartName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtModifyPartName.Text))
            {
                txtModifyPartName.BackColor = Color.Salmon;
                btnModifyPartSave.Enabled = false;
            }
            else
            {
                txtModifyPartName.BackColor = Color.White;
                btnModifyPartSave.Enabled = true;
            }
        }

        private void txtModifyPartInv_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtModifyPartInv.Text) || !Int32.TryParse(txtModifyPartInv.Text, out _))
            {
                txtModifyPartInv.BackColor = Color.Salmon;
                btnModifyPartSave.Enabled = false;
            }
            else
            {
                txtModifyPartInv.BackColor = Color.White;
                btnModifyPartSave.Enabled = true;
            }
        }

        private void txtModifyPartPrice_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtModifyPartPrice.Text) || !Decimal.TryParse(txtModifyPartPrice.Text, out _))
            {
                txtModifyPartPrice.BackColor = Color.Salmon;
                btnModifyPartSave.Enabled = false;
            }
            else
            {
                txtModifyPartPrice.BackColor = Color.White;
                btnModifyPartSave.Enabled = true;
            }
        }

        private void txtModifyPartMax_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtModifyPartMax.Text) || !Int32.TryParse(txtModifyPartMax.Text, out _))
            {
                txtModifyPartMax.BackColor = Color.Salmon;
                btnModifyPartSave.Enabled = false;
            }
            else
            {
                txtModifyPartMax.BackColor = Color.White;
                btnModifyPartSave.Enabled = true;
            }
        }

        private void txtModifyPartMin_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtModifyPartMin.Text) || !Int32.TryParse(txtModifyPartMin.Text, out _))
            {
                txtModifyPartMin.BackColor = Color.Salmon;
                btnModifyPartSave.Enabled = false;
            }
            else
            {
                txtModifyPartMin.BackColor = Color.White;
                btnModifyPartSave.Enabled = true;
            }
        }

        private void txtModifyMachineID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModifyPartSave_Click(object sender, EventArgs e)
        {
            //Will modify either In House or Outsourced Part. Displays on the Main Form
            if (radioInHouseModify.Checked)
            {
                InHouse inHouse = new(txtModifyPartName.Text, decimal.Parse(txtModifyPartPrice.Text), int.Parse(txtModifyPartInv.Text),
                    int.Parse(txtModifyPartMin.Text), int.Parse(txtModifyPartMax.Text), int.Parse(txtModifyMachineID.Text));
                //Ensures you cannot enter or save quantities if Max is less than Min or Inventory is leass than Min or greater than Max
                if (int.Parse(txtModifyPartMax.Text) < int.Parse(txtModifyPartMin.Text))
                {
                    MessageBox.Show("Max quantity may not exceed Min quantity!", "ATTENTION!");
                    txtModifyPartMax.BackColor = Color.Salmon;
                    btnModifyPartSave.Enabled = false;
                    return;
                }
                if ((Int32.Parse(txtModifyPartInv.Text) < Int32.Parse(txtModifyPartMin.Text)) ||
                    (Int32.Parse(txtModifyPartInv.Text) > Int32.Parse(txtModifyPartMax.Text)))
                {
                    MessageBox.Show("Your Inventory may not be below the Min or above the Max qyantities!", "ATTENTION!");
                    txtModifyPartInv.BackColor = Color.Salmon;
                    btnModifyPartSave.Enabled = false;
                    return;
                }

                this.Hide();
                MainForm addSave = new();
                Inventory.UpdatePart(Int32.Parse(txtModifyPartID.Text), inHouse);
                addSave.Show();
            }
            else
            {
                Outsource outsource = new(txtModifyPartName.Text, decimal.Parse(txtModifyPartPrice.Text), int.Parse(txtModifyPartInv.Text),
                    int.Parse(txtModifyPartMin.Text), int.Parse(txtModifyPartMax.Text), txtModifyMachineID.Text);

                this.Hide();
                MainForm addSave = new();
                Inventory.UpdatePart(Int32.Parse(txtModifyPartID.Text), outsource);
                addSave.Show();
            }
        }

        private void btnModifyPartCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm modifyCancel = new MainForm();
            modifyCancel.Show();
        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {

        }
    }
}
