
namespace KFrench_C968
{
    partial class ModifyPart
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
            this.lblModifyPartTitle = new System.Windows.Forms.Label();
            this.radioInHouseModify = new System.Windows.Forms.RadioButton();
            this.radioOutsourcedModify = new System.Windows.Forms.RadioButton();
            this.lblModifyPartID = new System.Windows.Forms.Label();
            this.lblModifyPartName = new System.Windows.Forms.Label();
            this.lblModifyPartInv = new System.Windows.Forms.Label();
            this.lblModifyPartPrice = new System.Windows.Forms.Label();
            this.lblModifyPartMax = new System.Windows.Forms.Label();
            this.lblModifyPartMin = new System.Windows.Forms.Label();
            this.lblModifyPartMachineID = new System.Windows.Forms.Label();
            this.txtModifyPartID = new System.Windows.Forms.TextBox();
            this.txtModifyPartName = new System.Windows.Forms.TextBox();
            this.txtModifyPartInv = new System.Windows.Forms.TextBox();
            this.txtModifyPartPrice = new System.Windows.Forms.TextBox();
            this.txtModifyPartMax = new System.Windows.Forms.TextBox();
            this.txtModifyPartMin = new System.Windows.Forms.TextBox();
            this.txtModifyMachineID = new System.Windows.Forms.TextBox();
            this.btnModifyPartSave = new System.Windows.Forms.Button();
            this.btnModifyPartCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModifyPartTitle
            // 
            this.lblModifyPartTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModifyPartTitle.Location = new System.Drawing.Point(12, 16);
            this.lblModifyPartTitle.Name = "lblModifyPartTitle";
            this.lblModifyPartTitle.Size = new System.Drawing.Size(142, 42);
            this.lblModifyPartTitle.TabIndex = 3;
            this.lblModifyPartTitle.Text = "Modify Part";
            // 
            // radioInHouseModify
            // 
            this.radioInHouseModify.AutoSize = true;
            this.radioInHouseModify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioInHouseModify.Location = new System.Drawing.Point(165, 16);
            this.radioInHouseModify.Name = "radioInHouseModify";
            this.radioInHouseModify.Size = new System.Drawing.Size(82, 21);
            this.radioInHouseModify.TabIndex = 4;
            this.radioInHouseModify.TabStop = true;
            this.radioInHouseModify.Text = "In-House";
            this.radioInHouseModify.UseVisualStyleBackColor = true;
            this.radioInHouseModify.CheckedChanged += new System.EventHandler(this.radioInHouseModify_CheckedChanged);
            // 
            // radioOutsourcedModify
            // 
            this.radioOutsourcedModify.AutoSize = true;
            this.radioOutsourcedModify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioOutsourcedModify.Location = new System.Drawing.Point(292, 16);
            this.radioOutsourcedModify.Name = "radioOutsourcedModify";
            this.radioOutsourcedModify.Size = new System.Drawing.Size(97, 21);
            this.radioOutsourcedModify.TabIndex = 5;
            this.radioOutsourcedModify.TabStop = true;
            this.radioOutsourcedModify.Text = "Outsourced";
            this.radioOutsourcedModify.UseVisualStyleBackColor = true;
            this.radioOutsourcedModify.CheckedChanged += new System.EventHandler(this.radioOutsourcedModify_CheckedChanged);
            // 
            // lblModifyPartID
            // 
            this.lblModifyPartID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModifyPartID.Location = new System.Drawing.Point(58, 90);
            this.lblModifyPartID.Name = "lblModifyPartID";
            this.lblModifyPartID.Size = new System.Drawing.Size(82, 23);
            this.lblModifyPartID.TabIndex = 11;
            this.lblModifyPartID.Text = "Part ID";
            // 
            // lblModifyPartName
            // 
            this.lblModifyPartName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModifyPartName.Location = new System.Drawing.Point(71, 147);
            this.lblModifyPartName.Name = "lblModifyPartName";
            this.lblModifyPartName.Size = new System.Drawing.Size(69, 23);
            this.lblModifyPartName.TabIndex = 12;
            this.lblModifyPartName.Text = "Name";
            // 
            // lblModifyPartInv
            // 
            this.lblModifyPartInv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModifyPartInv.Location = new System.Drawing.Point(40, 203);
            this.lblModifyPartInv.Name = "lblModifyPartInv";
            this.lblModifyPartInv.Size = new System.Drawing.Size(100, 23);
            this.lblModifyPartInv.TabIndex = 13;
            this.lblModifyPartInv.Text = "Inventory";
            // 
            // lblModifyPartPrice
            // 
            this.lblModifyPartPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModifyPartPrice.Location = new System.Drawing.Point(23, 258);
            this.lblModifyPartPrice.Name = "lblModifyPartPrice";
            this.lblModifyPartPrice.Size = new System.Drawing.Size(100, 23);
            this.lblModifyPartPrice.TabIndex = 14;
            this.lblModifyPartPrice.Text = "Price / Cost";
            // 
            // lblModifyPartMax
            // 
            this.lblModifyPartMax.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModifyPartMax.Location = new System.Drawing.Point(81, 313);
            this.lblModifyPartMax.Name = "lblModifyPartMax";
            this.lblModifyPartMax.Size = new System.Drawing.Size(59, 23);
            this.lblModifyPartMax.TabIndex = 16;
            this.lblModifyPartMax.Text = "Max";
            // 
            // lblModifyPartMin
            // 
            this.lblModifyPartMin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModifyPartMin.Location = new System.Drawing.Point(276, 313);
            this.lblModifyPartMin.Name = "lblModifyPartMin";
            this.lblModifyPartMin.Size = new System.Drawing.Size(60, 31);
            this.lblModifyPartMin.TabIndex = 17;
            this.lblModifyPartMin.Text = "Min";
            // 
            // lblModifyPartMachineID
            // 
            this.lblModifyPartMachineID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModifyPartMachineID.Location = new System.Drawing.Point(23, 370);
            this.lblModifyPartMachineID.Name = "lblModifyPartMachineID";
            this.lblModifyPartMachineID.Size = new System.Drawing.Size(136, 23);
            this.lblModifyPartMachineID.TabIndex = 18;
            this.lblModifyPartMachineID.Text = "Machine ID";
            // 
            // txtModifyPartID
            // 
            this.txtModifyPartID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModifyPartID.Location = new System.Drawing.Point(165, 83);
            this.txtModifyPartID.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtModifyPartID.Name = "txtModifyPartID";
            this.txtModifyPartID.Size = new System.Drawing.Size(174, 29);
            this.txtModifyPartID.TabIndex = 19;
            this.txtModifyPartID.TextChanged += new System.EventHandler(this.txtModifyPartID_TextChanged);
            // 
            // txtModifyPartName
            // 
            this.txtModifyPartName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModifyPartName.Location = new System.Drawing.Point(165, 140);
            this.txtModifyPartName.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtModifyPartName.Name = "txtModifyPartName";
            this.txtModifyPartName.Size = new System.Drawing.Size(174, 29);
            this.txtModifyPartName.TabIndex = 20;
            this.txtModifyPartName.TextChanged += new System.EventHandler(this.txtModifyPartName_TextChanged);
            // 
            // txtModifyPartInv
            // 
            this.txtModifyPartInv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModifyPartInv.Location = new System.Drawing.Point(165, 196);
            this.txtModifyPartInv.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtModifyPartInv.Name = "txtModifyPartInv";
            this.txtModifyPartInv.Size = new System.Drawing.Size(174, 29);
            this.txtModifyPartInv.TabIndex = 21;
            this.txtModifyPartInv.TextChanged += new System.EventHandler(this.txtModifyPartInv_TextChanged);
            // 
            // txtModifyPartPrice
            // 
            this.txtModifyPartPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModifyPartPrice.Location = new System.Drawing.Point(165, 251);
            this.txtModifyPartPrice.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtModifyPartPrice.Name = "txtModifyPartPrice";
            this.txtModifyPartPrice.Size = new System.Drawing.Size(174, 29);
            this.txtModifyPartPrice.TabIndex = 22;
            this.txtModifyPartPrice.TextChanged += new System.EventHandler(this.txtModifyPartPrice_TextChanged);
            // 
            // txtModifyPartMax
            // 
            this.txtModifyPartMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModifyPartMax.Location = new System.Drawing.Point(165, 306);
            this.txtModifyPartMax.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtModifyPartMax.Name = "txtModifyPartMax";
            this.txtModifyPartMax.Size = new System.Drawing.Size(77, 29);
            this.txtModifyPartMax.TabIndex = 23;
            this.txtModifyPartMax.TextChanged += new System.EventHandler(this.txtModifyPartMax_TextChanged);
            // 
            // txtModifyPartMin
            // 
            this.txtModifyPartMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModifyPartMin.Location = new System.Drawing.Point(342, 306);
            this.txtModifyPartMin.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtModifyPartMin.Name = "txtModifyPartMin";
            this.txtModifyPartMin.Size = new System.Drawing.Size(77, 29);
            this.txtModifyPartMin.TabIndex = 24;
            this.txtModifyPartMin.TextChanged += new System.EventHandler(this.txtModifyPartMin_TextChanged);
            // 
            // txtModifyMachineID
            // 
            this.txtModifyMachineID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModifyMachineID.Location = new System.Drawing.Point(165, 363);
            this.txtModifyMachineID.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtModifyMachineID.Name = "txtModifyMachineID";
            this.txtModifyMachineID.Size = new System.Drawing.Size(174, 29);
            this.txtModifyMachineID.TabIndex = 25;
            this.txtModifyMachineID.TextChanged += new System.EventHandler(this.txtModifyMachineID_TextChanged);
            // 
            // btnModifyPartSave
            // 
            this.btnModifyPartSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifyPartSave.Location = new System.Drawing.Point(261, 409);
            this.btnModifyPartSave.Name = "btnModifyPartSave";
            this.btnModifyPartSave.Size = new System.Drawing.Size(75, 30);
            this.btnModifyPartSave.TabIndex = 26;
            this.btnModifyPartSave.Text = "Save";
            this.btnModifyPartSave.UseVisualStyleBackColor = true;
            this.btnModifyPartSave.Click += new System.EventHandler(this.btnModifyPartSave_Click);
            // 
            // btnModifyPartCancel
            // 
            this.btnModifyPartCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifyPartCancel.Location = new System.Drawing.Point(344, 409);
            this.btnModifyPartCancel.Name = "btnModifyPartCancel";
            this.btnModifyPartCancel.Size = new System.Drawing.Size(75, 30);
            this.btnModifyPartCancel.TabIndex = 27;
            this.btnModifyPartCancel.Text = "Cancel";
            this.btnModifyPartCancel.UseVisualStyleBackColor = true;
            this.btnModifyPartCancel.Click += new System.EventHandler(this.btnModifyPartCancel_Click);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(469, 481);
            this.Controls.Add(this.btnModifyPartCancel);
            this.Controls.Add(this.btnModifyPartSave);
            this.Controls.Add(this.txtModifyMachineID);
            this.Controls.Add(this.txtModifyPartMin);
            this.Controls.Add(this.txtModifyPartMax);
            this.Controls.Add(this.txtModifyPartPrice);
            this.Controls.Add(this.txtModifyPartInv);
            this.Controls.Add(this.txtModifyPartName);
            this.Controls.Add(this.txtModifyPartID);
            this.Controls.Add(this.lblModifyPartMachineID);
            this.Controls.Add(this.lblModifyPartMin);
            this.Controls.Add(this.lblModifyPartMax);
            this.Controls.Add(this.lblModifyPartPrice);
            this.Controls.Add(this.lblModifyPartInv);
            this.Controls.Add(this.lblModifyPartName);
            this.Controls.Add(this.lblModifyPartID);
            this.Controls.Add(this.radioOutsourcedModify);
            this.Controls.Add(this.radioInHouseModify);
            this.Controls.Add(this.lblModifyPartTitle);
            this.Name = "ModifyPart";
            this.Text = "Modify Part";
            this.Load += new System.EventHandler(this.ModifyPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModifyPartTitle;
        private System.Windows.Forms.RadioButton radioInHouseModify;
        private System.Windows.Forms.RadioButton radioOutsourcedModify;
        private System.Windows.Forms.Label lblModifyPartID;
        private System.Windows.Forms.Label lblModifyPartName;
        private System.Windows.Forms.Label lblModifyPartInv;
        private System.Windows.Forms.Label lblModifyPartPrice;
        private System.Windows.Forms.Label lblModifyPartMax;
        private System.Windows.Forms.Label lblModifyPartMin;
        private System.Windows.Forms.Label lblModifyPartMachineID;
        private System.Windows.Forms.TextBox txtModifyPartID;
        private System.Windows.Forms.TextBox txtModifyPartName;
        private System.Windows.Forms.TextBox txtModifyPartInv;
        private System.Windows.Forms.TextBox txtModifyPartPrice;
        private System.Windows.Forms.TextBox txtModifyPartMax;
        private System.Windows.Forms.TextBox txtModifyPartMin;
        private System.Windows.Forms.TextBox txtModifyMachineID;
        private System.Windows.Forms.Button btnModifyPartSave;
        private System.Windows.Forms.Button btnModifyPartCancel;
    }
}