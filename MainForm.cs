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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataMainParts.DataSource = Inventory.AllParts;  
        }

        
        private void btnMainPartsSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnMainProductsSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnMainPartsAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPart addMain = new AddPart();
            addMain.Show();
        }

        private void btnMainPartsModify_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyPart modifyMain = new ModifyPart();
            modifyMain.Show();
        }

        private void btnMainPartsDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnMainProductsAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct addProductMain = new AddProduct();
            addProductMain.Show();
        }

        private void btnMainProductsModify_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyProduct modProductMain = new ModifyProduct();
            modProductMain.Show();
        }

        private void btnMainProductsDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnMainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMainPartsSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMainProductsSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataMainParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataMainProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
