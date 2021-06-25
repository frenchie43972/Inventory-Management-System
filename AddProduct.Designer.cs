
namespace KFrench_C968
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataAddProductAllParts = new System.Windows.Forms.DataGridView();
            this.dataAddProductAssociate = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnAddProductSave = new System.Windows.Forms.Button();
            this.btnAddProductCancel = new System.Windows.Forms.Button();
            this.btnAddProductDelete = new System.Windows.Forms.Button();
            this.lblAddProductTitle = new System.Windows.Forms.Label();
            this.lblAddProductID = new System.Windows.Forms.Label();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.lblAddProductInv = new System.Windows.Forms.Label();
            this.lblAddProductMax = new System.Windows.Forms.Label();
            this.txtAddProductID = new System.Windows.Forms.TextBox();
            this.txtAddProductName = new System.Windows.Forms.TextBox();
            this.txtAddProductInv = new System.Windows.Forms.TextBox();
            this.lblAddProductPrice = new System.Windows.Forms.Label();
            this.txtAddProductPrice = new System.Windows.Forms.TextBox();
            this.txtAddProductMax = new System.Windows.Forms.TextBox();
            this.lblAddProductMin = new System.Windows.Forms.Label();
            this.txtAddProductMin = new System.Windows.Forms.TextBox();
            this.btnAddProductSearch = new System.Windows.Forms.Button();
            this.txtAddProductSearch = new System.Windows.Forms.TextBox();
            this.lblAllCandidateParts = new System.Windows.Forms.Label();
            this.lblAssociatedParts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataAddProductAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAddProductAssociate)).BeginInit();
            this.SuspendLayout();
            // 
            // dataAddProductAllParts
            // 
            this.dataAddProductAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAddProductAllParts.Location = new System.Drawing.Point(527, 79);
            this.dataAddProductAllParts.Name = "dataAddProductAllParts";
            this.dataAddProductAllParts.RowTemplate.Height = 25;
            this.dataAddProductAllParts.Size = new System.Drawing.Size(456, 159);
            this.dataAddProductAllParts.TabIndex = 17;
            this.dataAddProductAllParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAddProductAllParts_CellClick);
            this.dataAddProductAllParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAddProductAllParts_CellContentClick);
            // 
            // dataAddProductAssociate
            // 
            this.dataAddProductAssociate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAddProductAssociate.Location = new System.Drawing.Point(527, 334);
            this.dataAddProductAssociate.Name = "dataAddProductAssociate";
            this.dataAddProductAssociate.RowTemplate.Height = 25;
            this.dataAddProductAssociate.Size = new System.Drawing.Size(456, 159);
            this.dataAddProductAssociate.TabIndex = 18;
            this.dataAddProductAssociate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAddProductAssociate_CellContentClick);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.Location = new System.Drawing.Point(908, 258);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 30);
            this.btnAddProduct.TabIndex = 19;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnAddProductSave
            // 
            this.btnAddProductSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddProductSave.Location = new System.Drawing.Point(816, 556);
            this.btnAddProductSave.Name = "btnAddProductSave";
            this.btnAddProductSave.Size = new System.Drawing.Size(75, 30);
            this.btnAddProductSave.TabIndex = 20;
            this.btnAddProductSave.Text = "Save";
            this.btnAddProductSave.UseVisualStyleBackColor = true;
            this.btnAddProductSave.Click += new System.EventHandler(this.btnAddProductSave_Click);
            // 
            // btnAddProductCancel
            // 
            this.btnAddProductCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddProductCancel.Location = new System.Drawing.Point(908, 556);
            this.btnAddProductCancel.Name = "btnAddProductCancel";
            this.btnAddProductCancel.Size = new System.Drawing.Size(75, 30);
            this.btnAddProductCancel.TabIndex = 21;
            this.btnAddProductCancel.Text = "Cancel";
            this.btnAddProductCancel.UseVisualStyleBackColor = true;
            this.btnAddProductCancel.Click += new System.EventHandler(this.btnAddProductCancel_Click);
            // 
            // btnAddProductDelete
            // 
            this.btnAddProductDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddProductDelete.Location = new System.Drawing.Point(908, 511);
            this.btnAddProductDelete.Name = "btnAddProductDelete";
            this.btnAddProductDelete.Size = new System.Drawing.Size(75, 30);
            this.btnAddProductDelete.TabIndex = 22;
            this.btnAddProductDelete.Text = "Delete";
            this.btnAddProductDelete.UseVisualStyleBackColor = true;
            this.btnAddProductDelete.Click += new System.EventHandler(this.btnAddProductDelete_Click);
            // 
            // lblAddProductTitle
            // 
            this.lblAddProductTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddProductTitle.Location = new System.Drawing.Point(12, 30);
            this.lblAddProductTitle.Name = "lblAddProductTitle";
            this.lblAddProductTitle.Size = new System.Drawing.Size(168, 35);
            this.lblAddProductTitle.TabIndex = 23;
            this.lblAddProductTitle.Text = "Add Product";
            // 
            // lblAddProductID
            // 
            this.lblAddProductID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddProductID.Location = new System.Drawing.Point(40, 133);
            this.lblAddProductID.Name = "lblAddProductID";
            this.lblAddProductID.Size = new System.Drawing.Size(100, 23);
            this.lblAddProductID.TabIndex = 24;
            this.lblAddProductID.Text = "Product ID";
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddProductName.Location = new System.Drawing.Point(71, 190);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(69, 23);
            this.lblAddProductName.TabIndex = 25;
            this.lblAddProductName.Text = "Name";
            // 
            // lblAddProductInv
            // 
            this.lblAddProductInv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddProductInv.Location = new System.Drawing.Point(40, 248);
            this.lblAddProductInv.Name = "lblAddProductInv";
            this.lblAddProductInv.Size = new System.Drawing.Size(100, 23);
            this.lblAddProductInv.TabIndex = 26;
            this.lblAddProductInv.Text = "Inventory";
            // 
            // lblAddProductMax
            // 
            this.lblAddProductMax.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddProductMax.Location = new System.Drawing.Point(81, 372);
            this.lblAddProductMax.Name = "lblAddProductMax";
            this.lblAddProductMax.Size = new System.Drawing.Size(59, 23);
            this.lblAddProductMax.TabIndex = 27;
            this.lblAddProductMax.Text = "Max";
            // 
            // txtAddProductID
            // 
            this.txtAddProductID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddProductID.Location = new System.Drawing.Point(164, 126);
            this.txtAddProductID.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtAddProductID.Name = "txtAddProductID";
            this.txtAddProductID.Size = new System.Drawing.Size(174, 29);
            this.txtAddProductID.TabIndex = 28;
            this.txtAddProductID.TextChanged += new System.EventHandler(this.txtAddProductID_TextChanged);
            // 
            // txtAddProductName
            // 
            this.txtAddProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddProductName.Location = new System.Drawing.Point(164, 183);
            this.txtAddProductName.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtAddProductName.Name = "txtAddProductName";
            this.txtAddProductName.Size = new System.Drawing.Size(174, 29);
            this.txtAddProductName.TabIndex = 29;
            this.txtAddProductName.TextChanged += new System.EventHandler(this.txtAddProductName_TextChanged);
            // 
            // txtAddProductInv
            // 
            this.txtAddProductInv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddProductInv.Location = new System.Drawing.Point(164, 241);
            this.txtAddProductInv.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtAddProductInv.Name = "txtAddProductInv";
            this.txtAddProductInv.Size = new System.Drawing.Size(174, 29);
            this.txtAddProductInv.TabIndex = 30;
            this.txtAddProductInv.TextChanged += new System.EventHandler(this.txtAddProductInv_TextChanged);
            // 
            // lblAddProductPrice
            // 
            this.lblAddProductPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddProductPrice.Location = new System.Drawing.Point(40, 311);
            this.lblAddProductPrice.Name = "lblAddProductPrice";
            this.lblAddProductPrice.Size = new System.Drawing.Size(100, 23);
            this.lblAddProductPrice.TabIndex = 31;
            this.lblAddProductPrice.Text = "Price / Cost";
            this.lblAddProductPrice.Click += new System.EventHandler(this.lblAddPartPrice_Click);
            // 
            // txtAddProductPrice
            // 
            this.txtAddProductPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddProductPrice.Location = new System.Drawing.Point(164, 304);
            this.txtAddProductPrice.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtAddProductPrice.Name = "txtAddProductPrice";
            this.txtAddProductPrice.Size = new System.Drawing.Size(174, 29);
            this.txtAddProductPrice.TabIndex = 32;
            this.txtAddProductPrice.TextChanged += new System.EventHandler(this.txtAddProductPrice_TextChanged);
            // 
            // txtAddProductMax
            // 
            this.txtAddProductMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddProductMax.Location = new System.Drawing.Point(164, 365);
            this.txtAddProductMax.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtAddProductMax.Name = "txtAddProductMax";
            this.txtAddProductMax.Size = new System.Drawing.Size(77, 29);
            this.txtAddProductMax.TabIndex = 33;
            this.txtAddProductMax.TextChanged += new System.EventHandler(this.txtAddProductMax_TextChanged);
            // 
            // lblAddProductMin
            // 
            this.lblAddProductMin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddProductMin.Location = new System.Drawing.Point(291, 372);
            this.lblAddProductMin.Name = "lblAddProductMin";
            this.lblAddProductMin.Size = new System.Drawing.Size(60, 31);
            this.lblAddProductMin.TabIndex = 34;
            this.lblAddProductMin.Text = "Min";
            // 
            // txtAddProductMin
            // 
            this.txtAddProductMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddProductMin.Location = new System.Drawing.Point(357, 365);
            this.txtAddProductMin.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtAddProductMin.Name = "txtAddProductMin";
            this.txtAddProductMin.Size = new System.Drawing.Size(77, 29);
            this.txtAddProductMin.TabIndex = 35;
            this.txtAddProductMin.TextChanged += new System.EventHandler(this.txtAddProductMin_TextChanged);
            // 
            // btnAddProductSearch
            // 
            this.btnAddProductSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddProductSearch.Location = new System.Drawing.Point(727, 30);
            this.btnAddProductSearch.Name = "btnAddProductSearch";
            this.btnAddProductSearch.Size = new System.Drawing.Size(75, 30);
            this.btnAddProductSearch.TabIndex = 36;
            this.btnAddProductSearch.Text = "Search";
            this.btnAddProductSearch.UseVisualStyleBackColor = true;
            this.btnAddProductSearch.Click += new System.EventHandler(this.btnAddProductSearch_Click);
            // 
            // txtAddProductSearch
            // 
            this.txtAddProductSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddProductSearch.Location = new System.Drawing.Point(808, 31);
            this.txtAddProductSearch.MinimumSize = new System.Drawing.Size(125, 30);
            this.txtAddProductSearch.Name = "txtAddProductSearch";
            this.txtAddProductSearch.Size = new System.Drawing.Size(175, 29);
            this.txtAddProductSearch.TabIndex = 37;
            this.txtAddProductSearch.TextChanged += new System.EventHandler(this.txtAddProductSearch_TextChanged);
            // 
            // lblAllCandidateParts
            // 
            this.lblAllCandidateParts.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAllCandidateParts.Location = new System.Drawing.Point(527, 49);
            this.lblAllCandidateParts.Name = "lblAllCandidateParts";
            this.lblAllCandidateParts.Size = new System.Drawing.Size(159, 23);
            this.lblAllCandidateParts.TabIndex = 38;
            this.lblAllCandidateParts.Text = "All Candidate Parts";
            // 
            // lblAssociatedParts
            // 
            this.lblAssociatedParts.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAssociatedParts.Location = new System.Drawing.Point(527, 304);
            this.lblAssociatedParts.Name = "lblAssociatedParts";
            this.lblAssociatedParts.Size = new System.Drawing.Size(250, 23);
            this.lblAssociatedParts.TabIndex = 39;
            this.lblAssociatedParts.Text = "All Parts Associated with Product";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 618);
            this.Controls.Add(this.lblAssociatedParts);
            this.Controls.Add(this.lblAllCandidateParts);
            this.Controls.Add(this.txtAddProductSearch);
            this.Controls.Add(this.btnAddProductSearch);
            this.Controls.Add(this.txtAddProductMin);
            this.Controls.Add(this.lblAddProductMin);
            this.Controls.Add(this.txtAddProductMax);
            this.Controls.Add(this.txtAddProductPrice);
            this.Controls.Add(this.lblAddProductPrice);
            this.Controls.Add(this.txtAddProductInv);
            this.Controls.Add(this.txtAddProductName);
            this.Controls.Add(this.txtAddProductID);
            this.Controls.Add(this.lblAddProductMax);
            this.Controls.Add(this.lblAddProductInv);
            this.Controls.Add(this.lblAddProductName);
            this.Controls.Add(this.lblAddProductID);
            this.Controls.Add(this.lblAddProductTitle);
            this.Controls.Add(this.btnAddProductDelete);
            this.Controls.Add(this.btnAddProductCancel);
            this.Controls.Add(this.btnAddProductSave);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dataAddProductAssociate);
            this.Controls.Add(this.dataAddProductAllParts);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataAddProductAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAddProductAssociate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataAddProductAllParts;
        private System.Windows.Forms.DataGridView dataAddProductAssociate;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnAddProductSave;
        private System.Windows.Forms.Button btnAddProductCancel;
        private System.Windows.Forms.Button btnAddProductDelete;
        private System.Windows.Forms.Label lblAddProductTitle;
        private System.Windows.Forms.Label lblAddProductID;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.Label lblAddProductInv;
        private System.Windows.Forms.Label lblAddProductMax;
        private System.Windows.Forms.TextBox txtAddProductID;
        private System.Windows.Forms.TextBox txtAddProductName;
        private System.Windows.Forms.TextBox txtAddProductInv;
        private System.Windows.Forms.Label lblAddProductPrice;
        private System.Windows.Forms.TextBox txtAddProductPrice;
        private System.Windows.Forms.TextBox txtAddProductMax;
        private System.Windows.Forms.Label lblAddProductMin;
        private System.Windows.Forms.TextBox txtAddProductMin;
        private System.Windows.Forms.Button btnAddProductSearch;
        private System.Windows.Forms.TextBox txtAddProductSearch;
        private System.Windows.Forms.Label lblAllCandidateParts;
        private System.Windows.Forms.Label lblAssociatedParts;
    }
}