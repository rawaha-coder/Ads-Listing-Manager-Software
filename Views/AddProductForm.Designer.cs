﻿
namespace Ads_Listing_Manager_Software.Views
{
    partial class AddProductForm
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
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelComponent = new System.Windows.Forms.Label();
            this.comboComponentList = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.comboModelList = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.comboBrandList = new System.Windows.Forms.ComboBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.viewListItems = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboItemList = new System.Windows.Forms.ComboBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductDescription.Location = new System.Drawing.Point(13, 473);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(318, 74);
            this.txtProductDescription.TabIndex = 6;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(12, 440);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(318, 23);
            this.labelDescription.TabIndex = 23;
            this.labelDescription.Text = "Description";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(174, 560);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 9;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(93, 560);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProduct.TabIndex = 8;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(12, 560);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // labelProduct
            // 
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProduct.Location = new System.Drawing.Point(12, 205);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(318, 23);
            this.labelProduct.TabIndex = 17;
            this.labelProduct.Text = "Item";
            // 
            // labelComponent
            // 
            this.labelComponent.AutoSize = true;
            this.labelComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComponent.Location = new System.Drawing.Point(12, 147);
            this.labelComponent.Name = "labelComponent";
            this.labelComponent.Size = new System.Drawing.Size(92, 20);
            this.labelComponent.TabIndex = 26;
            this.labelComponent.Text = "Component";
            // 
            // comboComponentList
            // 
            this.comboComponentList.FormattingEnabled = true;
            this.comboComponentList.Location = new System.Drawing.Point(12, 171);
            this.comboComponentList.Name = "comboComponentList";
            this.comboComponentList.Size = new System.Drawing.Size(318, 23);
            this.comboComponentList.TabIndex = 3;
            this.comboComponentList.SelectedIndexChanged += new System.EventHandler(this.comboListComponent_SelectedIndexChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(12, 322);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(318, 23);
            this.labelPrice.TabIndex = 29;
            this.labelPrice.Text = "Price";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductPrice.Location = new System.Drawing.Point(12, 347);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(319, 24);
            this.txtProductPrice.TabIndex = 5;
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumberEntred);
            // 
            // comboModelList
            // 
            this.comboModelList.FormattingEnabled = true;
            this.comboModelList.Location = new System.Drawing.Point(12, 116);
            this.comboModelList.Name = "comboModelList";
            this.comboModelList.Size = new System.Drawing.Size(318, 23);
            this.comboModelList.TabIndex = 2;
            this.comboModelList.SelectedIndexChanged += new System.EventHandler(this.comboListModel_SelectedIndexChanged);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelModel.Location = new System.Drawing.Point(12, 92);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(52, 20);
            this.labelModel.TabIndex = 30;
            this.labelModel.Text = "Model";
            // 
            // comboBrandList
            // 
            this.comboBrandList.FormattingEnabled = true;
            this.comboBrandList.Location = new System.Drawing.Point(13, 63);
            this.comboBrandList.Name = "comboBrandList";
            this.comboBrandList.Size = new System.Drawing.Size(318, 23);
            this.comboBrandList.TabIndex = 1;
            this.comboBrandList.SelectedIndexChanged += new System.EventHandler(this.comboBrandList_SelectedIndexChanged);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBrand.Location = new System.Drawing.Point(13, 39);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(52, 20);
            this.labelBrand.TabIndex = 32;
            this.labelBrand.Text = "Brand";
            // 
            // viewListItems
            // 
            this.viewListItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewListItems.GridLines = true;
            this.viewListItems.HideSelection = false;
            this.viewListItems.Location = new System.Drawing.Point(403, 62);
            this.viewListItems.MultiSelect = false;
            this.viewListItems.Name = "viewListItems";
            this.viewListItems.Size = new System.Drawing.Size(669, 529);
            this.viewListItems.TabIndex = 33;
            this.viewListItems.UseCompatibleStateImageBehavior = false;
            this.viewListItems.View = System.Windows.Forms.View.Details;
            this.viewListItems.DoubleClick += new System.EventHandler(this.viewListProduct_DoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(403, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "List Product";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductQuantity.Location = new System.Drawing.Point(13, 408);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(319, 24);
            this.txtProductQuantity.TabIndex = 5;
            this.txtProductQuantity.Text = "1";
            this.txtProductQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateIntegerNumberEntred);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Quantity";
            // 
            // comboItemList
            // 
            this.comboItemList.FormattingEnabled = true;
            this.comboItemList.Location = new System.Drawing.Point(12, 229);
            this.comboItemList.Name = "comboItemList";
            this.comboItemList.Size = new System.Drawing.Size(318, 23);
            this.comboItemList.TabIndex = 34;
            this.comboItemList.SelectedIndexChanged += new System.EventHandler(this.comboItemList_SelectedIndexChanged);
            // 
            // labelCode
            // 
            this.labelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCode.Location = new System.Drawing.Point(14, 266);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(318, 23);
            this.labelCode.TabIndex = 53;
            this.labelCode.Text = "Code";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductCode.Location = new System.Drawing.Point(14, 290);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(319, 24);
            this.txtProductCode.TabIndex = 52;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.comboItemList);
            this.Controls.Add(this.viewListItems);
            this.Controls.Add(this.comboBrandList);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.comboModelList);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.comboComponentList);
            this.Controls.Add(this.labelComponent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.labelProduct);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelComponent;
        private System.Windows.Forms.ComboBox comboComponentList;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.ComboBox comboModelList;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ComboBox comboBrandList;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.ListView viewListItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboItemList;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox txtProductCode;
    }
}