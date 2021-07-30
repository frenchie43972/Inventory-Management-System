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
        private BindingList<Part> bottomList = new BindingList<Part>();
        private int topIndex = 0;
        private int bottomIndex = -1;

        public AddProduct()
        {
            InitializeComponent();
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
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            if (txtAddProductSearch.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(txtAddProductSearch.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if (found)
                {
                    dataAddProductAllParts.DataSource = TempList;
                }
            }
            if (!found)
            {
                if (String.IsNullOrWhiteSpace(txtAddProductSearch.Text))
                {
                    MessageBox.Show("Search filed cannot be empty.", "Attention!");
                    dataAddProductAllParts.DataSource = Inventory.AllParts;
                }
                else
                {
                    MessageBox.Show("Part not found.", "Attention!");
                    dataAddProductAllParts.DataSource = Inventory.AllParts;
                }
            }
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
            bottomList.Add(Inventory.AllParts[topIndex]); 
        }

        private void btnAddProductDelete_Click(object sender, EventArgs e)
        {
            if(bottomList.Count == 0)
            {
                return;
            }

            DialogResult associatedPartDelete = MessageBox.Show("Are you sure you want to delete this part?", "Confirm", MessageBoxButtons.YesNo);

            if (associatedPartDelete == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataAddProductAssociate.SelectedRows)
                {
                    bottomList.RemoveAt(row.Index);
                }
            }
        }

        private void btnAddProductSave_Click(object sender, EventArgs e)
        {
            
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

            this.Hide();
            MainForm productSave = new();
            Product newProduct = new(txtAddProductName.Text, decimal.Parse(txtAddProductPrice.Text), int.Parse(txtAddProductInv.Text),
                    int.Parse(txtAddProductMin.Text), int.Parse(txtAddProductMax.Text));
            foreach (Part p in bottomList)
            {
                newProduct.AddAssociatedPart(p);
            }
            Inventory.Add_Product(newProduct);
            productSave.Show();

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
            dataAddProductAssociate.DataSource = bottomList;
            dataAddProductAllParts.ClearSelection();
        }

        private void dataAddProductAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            topIndex = dataAddProductAllParts.CurrentCell.RowIndex;
        }

        private void dataAddProductAssociate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bottomIndex = dataAddProductAssociate.CurrentCell.RowIndex;
        }
    }
}
