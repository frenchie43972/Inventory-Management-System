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
        }

        private void radioInHouseModify_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioOutsourcedModify_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtModifyPartID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModifyPartName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModifyPartInv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModifyPartPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModifyPartMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModifyPartMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModifyMachineID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModifyPartSave_Click(object sender, EventArgs e)
        {

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
