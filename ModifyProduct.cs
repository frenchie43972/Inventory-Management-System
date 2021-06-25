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
    public partial class ModifyProduct : Form
    {
        public ModifyProduct()
        {
            InitializeComponent();
            Product test = new Product("Tom", 9.99M, 23, 1, 35);
            Inventory.CurrentProduct = test;
            txtModifyProductID.Enabled = false;
            btnModifyProductSave.Enabled = false;
            txtModifyProductID.Text = Inventory.Products[Inventory.CurrentIndex].ProductID.ToString();
            txtModifyProductName.Text = Inventory.Products[Inventory.CurrentIndex].Name;
            txtModifyProductInv.Text = Inventory.Products[Inventory.CurrentIndex].Instock.ToString();
            txtModifyProductPrice.Text = Inventory.Products[Inventory.CurrentIndex].Price.ToString();
            txtModifyProductMax.Text = Inventory.Products[Inventory.CurrentIndex].Max.ToString();
            txtModifyProductMin.Text = Inventory.Products[Inventory.CurrentIndex].Min.ToString();
            GridViewRefresh();
            FormatPartViewDGV(dataModifyProductAllParts);
            FormatPartViewDGV(dataModifyProductAssociate);
            
        }

        private static void FormatPartViewDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
        }
        public void GridViewRefresh()
        {
            dataModifyProductAllParts.DataSource = Inventory.AllParts;
            dataModifyProductAssociate.DataSource =  dataModifyProductAllParts;
            dataModifyProductAllParts.ClearSelection();
        }

        private void txtModifyProductSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModifyProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModifyProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModifyProductInv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModifyProductPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModifyProductMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModifyProductMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModifyProductSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            Inventory.CurrentProduct.AddAssociatedPart(Inventory.CurrentPart);
            dataModifyProductAssociate.DataSource = Inventory.CurrentProduct.AssociatedParts;
        }

        private void btnModifyProductDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyProductSave_Click(object sender, EventArgs e)
        {
            Product updateProduct = new(txtModifyProductName.Text, decimal.Parse(txtModifyProductPrice.Text), int.Parse(txtModifyProductInv.Text),
                    int.Parse(txtModifyProductMin.Text), int.Parse(txtModifyProductMax.Text));
            if (int.Parse(txtModifyProductMax.Text) < int.Parse(txtModifyProductMin.Text))
            {
                MessageBox.Show("Max quantity may not exceed Min quantity!", "ATTENTION!");
                txtModifyProductMax.BackColor = Color.Salmon;
                btnModifyProductSave.Enabled = false;
                return;
            }
            if ((Int32.Parse(txtModifyProductInv.Text) < Int32.Parse(txtModifyProductMin.Text)) ||
                (Int32.Parse(txtModifyProductInv.Text) > Int32.Parse(txtModifyProductMax.Text)))
            {
                MessageBox.Show("Your Inventory may not be below the Min or above the Max quantities!", "ATTENTION!");
                txtModifyProductInv.BackColor = Color.Salmon;
                btnModifyProductSave.Enabled = false;
                return;
            }
            if (dataModifyProductAssociate.RowCount == 0)
            {
                MessageBox.Show("You have no associated parts with this product.", "ATTENTION!");
                btnModifyProductSave.Enabled = false;
                return;
            }
            else
            {
                btnModifyProductSave.Enabled = true;
                this.Hide();
                MainForm productSave = new();
                Inventory.Add_Product(updateProduct);
                productSave.Show();
            }
        }

        private void btnModifyProductCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm modProdCancel = new MainForm();
            modProdCancel.Show();
        }

        private void dataModifyProductAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentIndex = dataModifyProductAllParts.CurrentCell.RowIndex;
            Inventory.CurrentPart = Inventory.AllParts[Inventory.CurrentIndex];
        }

        private void dataModifyProductAssociate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentIndex = dataModifyProductAssociate.CurrentCell.RowIndex;
            Inventory.CurrentProduct = Inventory.Products[Inventory.CurrentIndex];
        }

        private void dataModifyProductAssociate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
