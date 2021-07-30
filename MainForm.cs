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
            GridViewRefresh();
            FormatPartDGV(dataMainParts);
            FormatPartDGV(dataMainProducts);
        }

        private static void FormatPartDGV(DataGridView d) 
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
        }

        private void BtnMainPartsSearch_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            if (txtMainPartsSearch.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(txtMainPartsSearch.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if (found)
                {
                    dataMainParts.DataSource = TempList;
                }
            }
            if (!found)
            {
                if (String.IsNullOrWhiteSpace(txtMainPartsSearch.Text))
                {
                    MessageBox.Show("Search filed cannot be empty.", "Attention!");
                    dataMainParts.DataSource = Inventory.AllParts;
                }
                else
                {
                    MessageBox.Show("Part not found.", "Attention!");
                    dataMainParts.DataSource = Inventory.AllParts;
                }
            }
        }

        private void BtnMainProductsSearch_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempList = new BindingList<Product>();
            bool found = false;
            if (txtMainProductsSearch.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(txtMainProductsSearch.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.Products[i]);
                        found = true;
                    }
                }
                if (found)
                {
                    dataMainProducts.DataSource = TempList;
                }
            }
            if (!found)
            {
                if (String.IsNullOrWhiteSpace(txtMainProductsSearch.Text))
                {
                    MessageBox.Show("Search filed cannot be empty.", "Attention!");
                    dataMainProducts.DataSource = Inventory.Products;
                }
                else
                {
                    MessageBox.Show("Part not found.", "Attention!");
                    dataMainProducts.DataSource = Inventory.Products;
                }
            }
        }

        private void BtnMainPartsAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPart addMain = new AddPart();
            addMain.Show();
        }

        private void BtnMainPartsModify_Click(object sender, EventArgs e)
        {
            if (dataMainParts.CurrentRow.DataBoundItem.GetType() == typeof(InHouse))
            {
                InHouse inHouse = (InHouse)dataMainParts.CurrentRow.DataBoundItem;
                this.Hide();
                ModifyPart modifyMain = new ModifyPart();
                modifyMain.Show();
            }
            else if (dataMainParts.CurrentRow.DataBoundItem.GetType() == typeof(Outsource))
            {
                Outsource outsource = (Outsource)dataMainParts.CurrentRow.DataBoundItem;
                this.Hide();
                ModifyPart modifyMain = new ModifyPart();
                modifyMain.Show();
            }
            else
            {
                MessageBox.Show("Please select a part to modify.", "ATTENTION!");
                return;
            }
        }

        public void BtnMainPartsDelete_Click(object sender, EventArgs e)
        {
            //Deletes one entry at a time.
            DialogResult partDelete = MessageBox.Show("Are you sure you want to delete this part?", "Confirm", MessageBoxButtons.YesNo);

            if (partDelete == DialogResult.Yes)
            {
                Inventory.DeletePart(Inventory.CurrentPart);
                dataMainParts.DataSource = Inventory.AllParts;
            }
            else
            {
                dataMainParts.DataSource = Inventory.AllParts;
            }
            
        }

        private void BtnMainProductsAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct addProductMain = new AddProduct();
            addProductMain.Show();
        }

        private void BtnMainProductsModify_Click(object sender, EventArgs e)
        {
            if (dataMainProducts.CurrentRow.DataBoundItem.GetType() == typeof(Product))
            {
                Product modifyProduct = (Product)dataMainProducts.CurrentRow.DataBoundItem;
                this.Hide();
                ModifyProduct modifyMain = new();
                modifyMain.Show();
            }            
            else
            {
                MessageBox.Show("Please select a part to modify.", "ATTENTION!");
                return;
            }
        }

        private void BtnMainProductsDelete_Click(object sender, EventArgs e)
        {
            //Deletes one entry at a time.
            DialogResult productDelete = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo);

            if (productDelete == DialogResult.Yes)
            {
                if (Inventory.Products.Count > 0)
                {
                    foreach (DataGridViewRow row in dataMainProducts.SelectedRows)
                    {
                        int productID = int.Parse(dataMainProducts.Rows[dataMainProducts.CurrentCell.RowIndex].Cells[0].Value.ToString());
                        Product invalidProduct = Inventory.LookupProduct(productID);
                        if (invalidProduct.AssociatedParts.Count > 0)
                        {
                            DialogResult message = MessageBox.Show("A product must not have any associated parts in order to be deleted", "Attention!");
                        }
                        else
                        {
                            Inventory.RemoveProduct(productID);
                        }
                    }
                }
            }
            else
            {
                dataMainProducts.DataSource = Inventory.CurrentProduct; 
            }
        }

        private void BtnMainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMainPartsSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMainProductsSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataMainProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentIndex = dataMainProducts.CurrentCell.RowIndex;
            Inventory.CurrentProduct = Inventory.Products[Inventory.CurrentIndex];
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GridViewRefresh();
            PartDisplay();
            ProductDisplay();
        }

        public void GridViewRefresh ()
        {
            dataMainParts.DataSource = Inventory.AllParts;
            dataMainParts.DataSource = Inventory.Products;
            dataMainParts.ClearSelection();
        }

        private void PartDisplay()
        {
            dataMainParts.DataSource = Inventory.AllParts;
        }

        private void ProductDisplay()
        {
            dataMainProducts.DataSource = Inventory.Products;
        }

        private void dataMainParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentIndex = dataMainParts.CurrentCell.RowIndex;
            Inventory.CurrentPart = Inventory.AllParts[Inventory.CurrentIndex];
        }
    }
}
