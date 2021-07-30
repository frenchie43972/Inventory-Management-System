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
        private BindingList<Part> bottomList = new BindingList<Part>();
        private int topIndex = 0;
        private int bottomIndex = -1;
        public ModifyProduct()
        {
            InitializeComponent();
            GridViewRefresh();
            FormatPartViewDGV(dataModifyProductAllParts);
            FormatPartViewDGV(dataModifyProductAssociate);
            txtModifyProductID.Enabled = false;
            txtModifyProductID.Text = Inventory.Products[Inventory.CurrentIndex].ProductID.ToString();
            txtModifyProductName.Text = Inventory.Products[Inventory.CurrentIndex].Name;
            txtModifyProductInv.Text = Inventory.Products[Inventory.CurrentIndex].Instock.ToString();
            txtModifyProductPrice.Text = Inventory.Products[Inventory.CurrentIndex].Price.ToString();
            txtModifyProductMax.Text = Inventory.Products[Inventory.CurrentIndex].Max.ToString();
            txtModifyProductMin.Text = Inventory.Products[Inventory.CurrentIndex].Min.ToString();
            foreach (Part p in Inventory.Products[Inventory.CurrentIndex].AssociatedParts)
            {
                bottomList.Add(p);
            }
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
            dataModifyProductAssociate.DataSource = bottomList;
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
            if (String.IsNullOrWhiteSpace(txtModifyProductName.Text))
            {
                txtModifyProductName.BackColor = Color.Salmon;
                btnModifyProductSave.Enabled = false;
            }
            else
            {
                txtModifyProductName.BackColor = Color.White;
                btnModifyProductSave.Enabled = true;
            }
        }

        private void txtModifyProductInv_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtModifyProductInv.Text) || !Int32.TryParse(txtModifyProductInv.Text, out _))
            {
                txtModifyProductInv.BackColor = Color.Salmon;
                btnModifyProductSave.Enabled = false;
            }
            else
            {
                txtModifyProductInv.BackColor = Color.White;
                btnModifyProductSave.Enabled = true;
            }
        }

        private void txtModifyProductPrice_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtModifyProductPrice.Text) || !Decimal.TryParse(txtModifyProductPrice.Text, out _))
            {
                txtModifyProductPrice.BackColor = Color.Salmon;
                btnModifyProductSave.Enabled = false;
            }
            else
            {
                txtModifyProductPrice.BackColor = Color.White;
                btnModifyProductSave.Enabled = true;
            }
        }

        private void txtModifyProductMax_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtModifyProductMax.Text) || !Int32.TryParse(txtModifyProductMax.Text, out _))
            {
                txtModifyProductMax.BackColor = Color.Salmon;
                btnModifyProductSave.Enabled = false;
            }
            else
            {
                txtModifyProductMax.BackColor = Color.White;
                btnModifyProductSave.Enabled = true;
            }
        }

        private void txtModifyProductMin_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtModifyProductMin.Text) || !Int32.TryParse(txtModifyProductMin.Text, out _))
            {
                txtModifyProductMin.BackColor = Color.Salmon;
                btnModifyProductSave.Enabled = false;
            }
            else
            {
                txtModifyProductMin.BackColor = Color.White;
                btnModifyProductSave.Enabled = true;
            }
        }

        private void btnModifyProductSearch_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            if (txtModifyProductSearch.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(txtModifyProductSearch.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if (found)
                {
                    dataModifyProductAllParts.DataSource = TempList;
                }
            }
            if (!found)
            {
                if (String.IsNullOrWhiteSpace(txtModifyProductSearch.Text))
                {
                    MessageBox.Show("Search filed cannot be empty.", "Attention!");
                    dataModifyProductAllParts.DataSource = Inventory.AllParts;
                }
                else
                {
                    MessageBox.Show("Part not found.", "Attention!");
                    dataModifyProductAllParts.DataSource = Inventory.AllParts;
                }
            }
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            bottomList.Add(Inventory.AllParts[topIndex]);
        }

        private void btnModifyProductDelete_Click(object sender, EventArgs e)
        {
            if (bottomList.Count == 0)
            {
                return;
            }

            DialogResult associatedPartDelete = MessageBox.Show("Are you sure you want to delete this part?", "Confirm", MessageBoxButtons.YesNo);

            if (associatedPartDelete == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataModifyProductAssociate.SelectedRows)
                {
                    bottomList.RemoveAt(row.Index);
                }
            }
        }

        private void btnModifyProductSave_Click(object sender, EventArgs e)
        {
            
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
            
            this.Hide();
            MainForm productSave = new();
            Product updateProduct = new(Int32.Parse(txtModifyProductID.Text), txtModifyProductName.Text, decimal.Parse(txtModifyProductPrice.Text), int.Parse(txtModifyProductInv.Text),
                int.Parse(txtModifyProductMin.Text), int.Parse(txtModifyProductMax.Text));
            foreach (Part p in bottomList)
            {
                updateProduct.AddAssociatedPart(p);
            }
            Inventory.UpdateProduct(0, updateProduct);
            productSave.Show();
        }

        private void btnModifyProductCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm modProdCancel = new MainForm();
            modProdCancel.Show();
        }

        private void dataModifyProductAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            topIndex = dataModifyProductAllParts.CurrentCell.RowIndex;
        }

        private void dataModifyProductAssociate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bottomIndex = dataModifyProductAssociate.CurrentCell.RowIndex;
        }

        private void dataModifyProductAssociate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Inventory.CurrentIndex = dataModifyProductAssociate.CurrentCell.RowIndex;
            //Inventory.CurrentProduct = Inventory.Products[Inventory.CurrentIndex];
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
