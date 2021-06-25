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
    public partial class AddProduct : Form
    {

        public AddProduct()
        {
            InitializeComponent();
            Product test = new Product("Tom", 9.99M, 23, 1, 35);
            Inventory.CurrentProduct = test;
            GridViewRefresh();
            FormatPartViewDGV(dataAddProductAllParts);
            FormatPartViewDGV(dataAddProductAssociate);
            txtAddProductID.Enabled = false;
            btnAddProductSave.Enabled = false;
        }

        private static void FormatPartViewDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
        }

        private void lblAddPartPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProductSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtAddProductSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddProductName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddProductName.Text))
            {
                txtAddProductName.BackColor = Color.Salmon;
                btnAddProductSave.Enabled = false;
            }
            else
            {
                txtAddProductName.BackColor = Color.White;
                btnAddProductSave.Enabled = true;
            }
        }

        private void txtAddProductInv_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddProductInv.Text) || !Int32.TryParse(txtAddProductInv.Text, out _))
            {
                txtAddProductInv.BackColor = Color.Salmon;
                btnAddProductSave.Enabled = false;
            }
            else
            {
                txtAddProductInv.BackColor = Color.White;
                btnAddProductSave.Enabled = true;
            }
        }

        private void txtAddProductPrice_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddProductPrice.Text) || !Decimal.TryParse(txtAddProductPrice.Text, out _))
            {
                txtAddProductPrice.BackColor = Color.Salmon;
                btnAddProductSave.Enabled = false;
            }
            else
            {
                txtAddProductPrice.BackColor = Color.White;
                btnAddProductSave.Enabled = true;
            }
        }

        private void txtAddProductMax_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddProductMax.Text) || !Int32.TryParse(txtAddProductMax.Text, out _))
            {
                txtAddProductMax.BackColor = Color.Salmon;
                btnAddProductSave.Enabled = false;
            }
            else
            {
                txtAddProductMax.BackColor = Color.White;
                btnAddProductSave.Enabled = true;
            }
        }

        private void txtAddProductMin_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddProductMin.Text) || !Int32.TryParse(txtAddProductMin.Text, out _))
            {
                txtAddProductMin.BackColor = Color.Salmon;
                btnAddProductSave.Enabled = false;
            }
            else
            {
                txtAddProductMin.BackColor = Color.White;
                btnAddProductSave.Enabled = true;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Inventory.CurrentProduct.AddAssociatedPart(Inventory.CurrentPart);
            dataAddProductAssociate.DataSource = Inventory.CurrentProduct.AssociatedParts;
        }

        private void btnAddProductDelete_Click(object sender, EventArgs e)
        {
            DialogResult associatedPartDelete = MessageBox.Show("Are you sure you want to delete this part?", "Confirm", MessageBoxButtons.YesNo);

            if (associatedPartDelete == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataAddProductAssociate.SelectedRows)
                {
                    dataAddProductAssociate.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                dataAddProductAssociate.DataSource = Inventory.CurrentProduct.AssociatedParts;
            }
            
        }

        private void btnAddProductSave_Click(object sender, EventArgs e)
        {
            Product newProduct = new(txtAddProductName.Text, decimal.Parse(txtAddProductPrice.Text), int.Parse(txtAddProductInv.Text),
                    int.Parse(txtAddProductMin.Text), int.Parse(txtAddProductMax.Text));
            if (int.Parse(txtAddProductMax.Text) < int.Parse(txtAddProductMin.Text))
            {
                MessageBox.Show("Max quantity may not exceed Min quantity!", "ATTENTION!");
                txtAddProductMax.BackColor = Color.Salmon;
                btnAddProductSave.Enabled = false;
                return;
            }
            if ((Int32.Parse(txtAddProductInv.Text) < Int32.Parse(txtAddProductMin.Text)) ||
                (Int32.Parse(txtAddProductInv.Text) > Int32.Parse(txtAddProductMax.Text)))
            {
                MessageBox.Show("Your Inventory may not be below the Min or above the Max quantities!", "ATTENTION!");
                txtAddProductInv.BackColor = Color.Salmon;
                btnAddProductSave.Enabled = false;
                return;
            }
            if (dataAddProductAssociate.RowCount == 0)
            {
                MessageBox.Show("You have no associated parts with this product.", "ATTENTION!");
                btnAddProductSave.Enabled = false;
                return;
            }
            else
            {
                btnAddProductSave.Enabled = true;
                this.Hide();
                MainForm productSave = new();
                Inventory.Add_Product(newProduct);
                productSave.Show();
            }
        }

        private void btnAddProductCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm addProdCancel = new MainForm();
            addProdCancel.Show();
        }

        private void dataAddProductAllParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataAddProductAssociate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void GridViewRefresh()
        {
            dataAddProductAllParts.DataSource = Inventory.AllParts;
            dataAddProductAssociate.DataSource = dataAddProductAllParts;
            dataAddProductAllParts.ClearSelection();
        }

        private void dataAddProductAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentIndex = dataAddProductAllParts.CurrentCell.RowIndex;
            Inventory.CurrentPart = Inventory.AllParts[Inventory.CurrentIndex];
        }

        private void dataAddProductAssociate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentIndex = dataAddProductAssociate.CurrentCell.RowIndex;
            Inventory.CurrentProduct = Inventory.Products[Inventory.CurrentIndex];
        }
    }
}
