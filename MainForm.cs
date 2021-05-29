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
        }

        private static void FormatPartDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
        }

        private void BtnMainPartsSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnMainProductsSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnMainPartsAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPart addMain = new AddPart();
            addMain.Show();
        }

        private void BtnMainPartsModify_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyPart modifyMain = new ModifyPart();
            modifyMain.Show();
        }

        private void BtnMainPartsDelete_Click(object sender, EventArgs e)
        {
            //Deletes a single row, but not multiple??
            DialogResult partDelete = MessageBox.Show("Are you sure you want to delete this part?", "Confirm", MessageBoxButtons.YesNo);

            if (partDelete == DialogResult.Yes)
            {
                var deleteRow = dataMainParts.CurrentCell.RowIndex;
                dataMainParts.Rows.RemoveAt(deleteRow); 
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
            this.Hide();
            ModifyProduct modProductMain = new ModifyProduct();
            modProductMain.Show();
        }

        private void BtnMainProductsDelete_Click(object sender, EventArgs e)
        {

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

        private void dataMainParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Does not display Machine ID or Company Name
            Inventory.CurrentIndex = dataMainParts.CurrentCell.RowIndex;
        }

        private void dataMainProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GridViewRefresh();
            PartDisplay();
        }

        public void GridViewRefresh ()
        {
            dataMainParts.DataSource = Inventory.AllParts;
            dataMainParts.ClearSelection();
        }

        private void PartDisplay()
        {
            dataMainParts.DataSource = Inventory.AllParts;
        }
    }
}
