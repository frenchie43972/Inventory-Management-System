
namespace KFrench_C968
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMainPartsSearch = new System.Windows.Forms.TextBox();
            this.txtMainProductsSearch = new System.Windows.Forms.TextBox();
            this.btnMainProductsSearch = new System.Windows.Forms.Button();
            this.btnMainPartsAdd = new System.Windows.Forms.Button();
            this.btnMainPartsModify = new System.Windows.Forms.Button();
            this.btnMainPartsDelete = new System.Windows.Forms.Button();
            this.btnMainProductsDelete = new System.Windows.Forms.Button();
            this.btnMainProductsModify = new System.Windows.Forms.Button();
            this.btnMainProductsAdd = new System.Windows.Forms.Button();
            this.btnMainExit = new System.Windows.Forms.Button();
            this.lblMainParts = new System.Windows.Forms.Label();
            this.lblMainProducts = new System.Windows.Forms.Label();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.dataMainParts = new System.Windows.Forms.DataGridView();
            this.dataMainProducts = new System.Windows.Forms.DataGridView();
            this.btnMainPartsSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataMainParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMainProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMainPartsSearch
            // 
            this.txtMainPartsSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMainPartsSearch.Location = new System.Drawing.Point(330, 121);
            this.txtMainPartsSearch.MinimumSize = new System.Drawing.Size(125, 30);
            this.txtMainPartsSearch.Name = "txtMainPartsSearch";
            this.txtMainPartsSearch.Size = new System.Drawing.Size(175, 29);
            this.txtMainPartsSearch.TabIndex = 2;
            this.txtMainPartsSearch.TextChanged += new System.EventHandler(this.txtMainPartsSearch_TextChanged);
            // 
            // txtMainProductsSearch
            // 
            this.txtMainProductsSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMainProductsSearch.Location = new System.Drawing.Point(834, 121);
            this.txtMainProductsSearch.MinimumSize = new System.Drawing.Size(125, 30);
            this.txtMainProductsSearch.Name = "txtMainProductsSearch";
            this.txtMainProductsSearch.Size = new System.Drawing.Size(175, 29);
            this.txtMainProductsSearch.TabIndex = 3;
            this.txtMainProductsSearch.TextChanged += new System.EventHandler(this.txtMainProductsSearch_TextChanged);
            // 
            // btnMainProductsSearch
            // 
            this.btnMainProductsSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainProductsSearch.Location = new System.Drawing.Point(753, 121);
            this.btnMainProductsSearch.Name = "btnMainProductsSearch";
            this.btnMainProductsSearch.Size = new System.Drawing.Size(75, 30);
            this.btnMainProductsSearch.TabIndex = 5;
            this.btnMainProductsSearch.Text = "Search";
            this.btnMainProductsSearch.UseVisualStyleBackColor = true;
            this.btnMainProductsSearch.Click += new System.EventHandler(this.btnMainProductsSearch_Click);
            // 
            // btnMainPartsAdd
            // 
            this.btnMainPartsAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainPartsAdd.Location = new System.Drawing.Point(268, 371);
            this.btnMainPartsAdd.Name = "btnMainPartsAdd";
            this.btnMainPartsAdd.Size = new System.Drawing.Size(75, 30);
            this.btnMainPartsAdd.TabIndex = 6;
            this.btnMainPartsAdd.Text = "Add";
            this.btnMainPartsAdd.UseVisualStyleBackColor = true;
            this.btnMainPartsAdd.Click += new System.EventHandler(this.btnMainPartsAdd_Click);
            // 
            // btnMainPartsModify
            // 
            this.btnMainPartsModify.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainPartsModify.Location = new System.Drawing.Point(349, 371);
            this.btnMainPartsModify.Name = "btnMainPartsModify";
            this.btnMainPartsModify.Size = new System.Drawing.Size(75, 30);
            this.btnMainPartsModify.TabIndex = 7;
            this.btnMainPartsModify.Text = "Modify";
            this.btnMainPartsModify.UseVisualStyleBackColor = true;
            this.btnMainPartsModify.Click += new System.EventHandler(this.btnMainPartsModify_Click);
            // 
            // btnMainPartsDelete
            // 
            this.btnMainPartsDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainPartsDelete.Location = new System.Drawing.Point(430, 371);
            this.btnMainPartsDelete.Name = "btnMainPartsDelete";
            this.btnMainPartsDelete.Size = new System.Drawing.Size(75, 30);
            this.btnMainPartsDelete.TabIndex = 8;
            this.btnMainPartsDelete.Text = "Delete";
            this.btnMainPartsDelete.UseVisualStyleBackColor = true;
            this.btnMainPartsDelete.Click += new System.EventHandler(this.btnMainPartsDelete_Click);
            // 
            // btnMainProductsDelete
            // 
            this.btnMainProductsDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainProductsDelete.Location = new System.Drawing.Point(934, 371);
            this.btnMainProductsDelete.Name = "btnMainProductsDelete";
            this.btnMainProductsDelete.Size = new System.Drawing.Size(75, 30);
            this.btnMainProductsDelete.TabIndex = 9;
            this.btnMainProductsDelete.Text = "Delete";
            this.btnMainProductsDelete.UseVisualStyleBackColor = true;
            this.btnMainProductsDelete.Click += new System.EventHandler(this.btnMainProductsDelete_Click);
            // 
            // btnMainProductsModify
            // 
            this.btnMainProductsModify.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainProductsModify.Location = new System.Drawing.Point(853, 371);
            this.btnMainProductsModify.Name = "btnMainProductsModify";
            this.btnMainProductsModify.Size = new System.Drawing.Size(75, 30);
            this.btnMainProductsModify.TabIndex = 10;
            this.btnMainProductsModify.Text = "Modify";
            this.btnMainProductsModify.UseVisualStyleBackColor = true;
            this.btnMainProductsModify.Click += new System.EventHandler(this.btnMainProductsModify_Click);
            // 
            // btnMainProductsAdd
            // 
            this.btnMainProductsAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainProductsAdd.Location = new System.Drawing.Point(772, 371);
            this.btnMainProductsAdd.Name = "btnMainProductsAdd";
            this.btnMainProductsAdd.Size = new System.Drawing.Size(75, 30);
            this.btnMainProductsAdd.TabIndex = 11;
            this.btnMainProductsAdd.Text = "Add";
            this.btnMainProductsAdd.UseVisualStyleBackColor = true;
            this.btnMainProductsAdd.Click += new System.EventHandler(this.btnMainProductsAdd_Click);
            // 
            // btnMainExit
            // 
            this.btnMainExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainExit.Location = new System.Drawing.Point(934, 447);
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.Size = new System.Drawing.Size(75, 30);
            this.btnMainExit.TabIndex = 12;
            this.btnMainExit.Text = "Exit";
            this.btnMainExit.UseVisualStyleBackColor = true;
            this.btnMainExit.Click += new System.EventHandler(this.btnMainExit_Click);
            // 
            // lblMainParts
            // 
            this.lblMainParts.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMainParts.Location = new System.Drawing.Point(49, 128);
            this.lblMainParts.Name = "lblMainParts";
            this.lblMainParts.Size = new System.Drawing.Size(100, 23);
            this.lblMainParts.TabIndex = 13;
            this.lblMainParts.Text = "Parts";
            // 
            // lblMainProducts
            // 
            this.lblMainProducts.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMainProducts.Location = new System.Drawing.Point(553, 128);
            this.lblMainProducts.Name = "lblMainProducts";
            this.lblMainProducts.Size = new System.Drawing.Size(117, 24);
            this.lblMainProducts.TabIndex = 14;
            this.lblMainProducts.Text = "Products";
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMainTitle.Location = new System.Drawing.Point(49, 19);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(456, 34);
            this.lblMainTitle.TabIndex = 15;
            this.lblMainTitle.Text = "Inventory Management System";
            // 
            // dataMainParts
            // 
            this.dataMainParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMainParts.Location = new System.Drawing.Point(49, 166);
            this.dataMainParts.Name = "dataMainParts";
            this.dataMainParts.RowTemplate.Height = 25;
            this.dataMainParts.Size = new System.Drawing.Size(456, 199);
            this.dataMainParts.TabIndex = 16;
            this.dataMainParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMainParts_CellContentClick);
            // 
            // dataMainProducts
            // 
            this.dataMainProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMainProducts.Location = new System.Drawing.Point(553, 166);
            this.dataMainProducts.Name = "dataMainProducts";
            this.dataMainProducts.RowTemplate.Height = 25;
            this.dataMainProducts.Size = new System.Drawing.Size(456, 199);
            this.dataMainProducts.TabIndex = 17;
            this.dataMainProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMainProducts_CellContentClick);
            // 
            // btnMainPartsSearch
            // 
            this.btnMainPartsSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainPartsSearch.Location = new System.Drawing.Point(239, 121);
            this.btnMainPartsSearch.Name = "btnMainPartsSearch";
            this.btnMainPartsSearch.Size = new System.Drawing.Size(75, 30);
            this.btnMainPartsSearch.TabIndex = 18;
            this.btnMainPartsSearch.Text = "Search";
            this.btnMainPartsSearch.UseVisualStyleBackColor = true;
            this.btnMainPartsSearch.Click += new System.EventHandler(this.btnMainPartsSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 520);
            this.Controls.Add(this.btnMainPartsSearch);
            this.Controls.Add(this.dataMainProducts);
            this.Controls.Add(this.dataMainParts);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.lblMainProducts);
            this.Controls.Add(this.lblMainParts);
            this.Controls.Add(this.btnMainExit);
            this.Controls.Add(this.btnMainProductsAdd);
            this.Controls.Add(this.btnMainProductsModify);
            this.Controls.Add(this.btnMainProductsDelete);
            this.Controls.Add(this.btnMainPartsDelete);
            this.Controls.Add(this.btnMainPartsModify);
            this.Controls.Add(this.btnMainPartsAdd);
            this.Controls.Add(this.btnMainProductsSearch);
            this.Controls.Add(this.txtMainProductsSearch);
            this.Controls.Add(this.txtMainPartsSearch);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataMainParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMainProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMainPartsSearch;
        private System.Windows.Forms.TextBox txtMainProductsSearch;
        private System.Windows.Forms.Button btnMainProductsSearch;
        private System.Windows.Forms.Button btnMainPartsAdd;
        private System.Windows.Forms.Button btnMainPartsModify;
        private System.Windows.Forms.Button btnMainPartsDelete;
        private System.Windows.Forms.Button btnMainProductsDelete;
        private System.Windows.Forms.Button btnMainProductsModify;
        private System.Windows.Forms.Button btnMainProductsAdd;
        private System.Windows.Forms.Button btnMainExit;
        private System.Windows.Forms.Label lblMainParts;
        private System.Windows.Forms.Label lblMainProducts;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.DataGridView dataMainParts;
        private System.Windows.Forms.DataGridView dataMainProducts;
        private System.Windows.Forms.Button btnMainPartsSearch;
    }
}

