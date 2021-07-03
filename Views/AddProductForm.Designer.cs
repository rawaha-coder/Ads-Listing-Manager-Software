
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
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
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
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelLeftSide.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Enabled = false;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(116, 500);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(100, 35);
            this.buttonDeleteProduct.TabIndex = 10;
            this.buttonDeleteProduct.Text = "Delete";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.ButtonDeleteProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(10, 500);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(100, 35);
            this.buttonAddProduct.TabIndex = 8;
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // labelProduct
            // 
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProduct.Location = new System.Drawing.Point(10, 204);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(52, 23);
            this.labelProduct.TabIndex = 17;
            this.labelProduct.Text = "Item";
            // 
            // labelComponent
            // 
            this.labelComponent.AutoSize = true;
            this.labelComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComponent.Location = new System.Drawing.Point(10, 141);
            this.labelComponent.Name = "labelComponent";
            this.labelComponent.Size = new System.Drawing.Size(73, 20);
            this.labelComponent.TabIndex = 26;
            this.labelComponent.Text = "Category";
            // 
            // comboComponentList
            // 
            this.comboComponentList.FormattingEnabled = true;
            this.comboComponentList.Location = new System.Drawing.Point(10, 164);
            this.comboComponentList.Name = "comboComponentList";
            this.comboComponentList.Size = new System.Drawing.Size(312, 23);
            this.comboComponentList.TabIndex = 3;
            this.comboComponentList.SelectedIndexChanged += new System.EventHandler(this.comboListComponent_SelectedIndexChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(10, 344);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(54, 23);
            this.labelPrice.TabIndex = 29;
            this.labelPrice.Text = "Price";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductPrice.Location = new System.Drawing.Point(10, 370);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.ReadOnly = true;
            this.txtProductPrice.Size = new System.Drawing.Size(312, 24);
            this.txtProductPrice.TabIndex = 6;
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumberEntred);
            // 
            // comboModelList
            // 
            this.comboModelList.FormattingEnabled = true;
            this.comboModelList.Location = new System.Drawing.Point(10, 96);
            this.comboModelList.Name = "comboModelList";
            this.comboModelList.Size = new System.Drawing.Size(312, 23);
            this.comboModelList.TabIndex = 2;
            this.comboModelList.SelectedIndexChanged += new System.EventHandler(this.comboListModel_SelectedIndexChanged);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelModel.Location = new System.Drawing.Point(10, 73);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(52, 20);
            this.labelModel.TabIndex = 30;
            this.labelModel.Text = "Model";
            // 
            // comboBrandList
            // 
            this.comboBrandList.FormattingEnabled = true;
            this.comboBrandList.Location = new System.Drawing.Point(10, 30);
            this.comboBrandList.Name = "comboBrandList";
            this.comboBrandList.Size = new System.Drawing.Size(312, 23);
            this.comboBrandList.TabIndex = 1;
            this.comboBrandList.SelectedIndexChanged += new System.EventHandler(this.comboBrandList_SelectedIndexChanged);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBrand.Location = new System.Drawing.Point(10, 7);
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
            this.viewListItems.FullRowSelect = true;
            this.viewListItems.GridLines = true;
            this.viewListItems.HideSelection = false;
            this.viewListItems.Location = new System.Drawing.Point(18, 30);
            this.viewListItems.MultiSelect = false;
            this.viewListItems.Name = "viewListItems";
            this.viewListItems.Size = new System.Drawing.Size(715, 600);
            this.viewListItems.TabIndex = 11;
            this.viewListItems.UseCompatibleStateImageBehavior = false;
            this.viewListItems.View = System.Windows.Forms.View.Details;
            this.viewListItems.DoubleClick += new System.EventHandler(this.viewListProduct_DoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "List Product";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductQuantity.Location = new System.Drawing.Point(10, 440);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.ReadOnly = true;
            this.txtProductQuantity.Size = new System.Drawing.Size(312, 24);
            this.txtProductQuantity.TabIndex = 7;
            this.txtProductQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateIntegerNumberEntred);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Quantity";
            // 
            // comboItemList
            // 
            this.comboItemList.FormattingEnabled = true;
            this.comboItemList.Location = new System.Drawing.Point(10, 230);
            this.comboItemList.Name = "comboItemList";
            this.comboItemList.Size = new System.Drawing.Size(312, 23);
            this.comboItemList.TabIndex = 4;
            this.comboItemList.SelectedIndexChanged += new System.EventHandler(this.comboItemList_SelectedIndexChanged);
            // 
            // labelCode
            // 
            this.labelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCode.Location = new System.Drawing.Point(10, 273);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(52, 23);
            this.labelCode.TabIndex = 53;
            this.labelCode.Text = "Code";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductCode.Location = new System.Drawing.Point(10, 299);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(312, 24);
            this.txtProductCode.TabIndex = 5;
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.AutoScroll = true;
            this.panelLeftSide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLeftSide.Controls.Add(this.labelBrand);
            this.panelLeftSide.Controls.Add(this.labelCode);
            this.panelLeftSide.Controls.Add(this.labelProduct);
            this.panelLeftSide.Controls.Add(this.txtProductCode);
            this.panelLeftSide.Controls.Add(this.buttonAddProduct);
            this.panelLeftSide.Controls.Add(this.comboItemList);
            this.panelLeftSide.Controls.Add(this.buttonClearFields);
            this.panelLeftSide.Controls.Add(this.buttonDeleteProduct);
            this.panelLeftSide.Controls.Add(this.comboBrandList);
            this.panelLeftSide.Controls.Add(this.labelComponent);
            this.panelLeftSide.Controls.Add(this.comboComponentList);
            this.panelLeftSide.Controls.Add(this.comboModelList);
            this.panelLeftSide.Controls.Add(this.txtProductPrice);
            this.panelLeftSide.Controls.Add(this.labelModel);
            this.panelLeftSide.Controls.Add(this.labelPrice);
            this.panelLeftSide.Controls.Add(this.label2);
            this.panelLeftSide.Controls.Add(this.txtProductQuantity);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(343, 721);
            this.panelLeftSide.TabIndex = 54;
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Location = new System.Drawing.Point(222, 500);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(100, 35);
            this.buttonClearFields.TabIndex = 10;
            this.buttonClearFields.Text = "Clear";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // panelMiddle
            // 
            this.panelMiddle.AutoScroll = true;
            this.panelMiddle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMiddle.Controls.Add(this.label1);
            this.panelMiddle.Controls.Add(this.viewListItems);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(343, 0);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(841, 721);
            this.panelMiddle.TabIndex = 55;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1184, 721);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelLeftSide);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.panelLeftSide.ResumeLayout(false);
            this.panelLeftSide.PerformLayout();
            this.panelMiddle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonAddProduct;
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
        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.Panel panelMiddle;
    }
}