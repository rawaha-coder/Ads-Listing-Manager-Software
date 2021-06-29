
namespace Ads_Listing_Manager_Software.Views
{
    partial class AddItemForm
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
            this.viewListItems = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemQuantity = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.comboComponentList = new System.Windows.Forms.ComboBox();
            this.labelComponent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.labelProduct = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.panelAddItem = new System.Windows.Forms.Panel();
            this.panelDisplayItem = new System.Windows.Forms.Panel();
            this.panelAddItem.SuspendLayout();
            this.panelDisplayItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewListItems
            // 
            this.viewListItems.GridLines = true;
            this.viewListItems.HideSelection = false;
            this.viewListItems.Location = new System.Drawing.Point(9, 48);
            this.viewListItems.MultiSelect = false;
            this.viewListItems.Name = "viewListItems";
            this.viewListItems.Size = new System.Drawing.Size(640, 584);
            this.viewListItems.TabIndex = 54;
            this.viewListItems.UseCompatibleStateImageBehavior = false;
            this.viewListItems.View = System.Windows.Forms.View.Details;
            this.viewListItems.DoubleClick += new System.EventHandler(this.viewListItems_DoubleClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 23);
            this.label2.TabIndex = 50;
            this.label2.Text = "Quantity";
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtItemQuantity.Location = new System.Drawing.Point(10, 294);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(319, 24);
            this.txtItemQuantity.TabIndex = 38;
            this.txtItemQuantity.Text = "1";
            this.txtItemQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateIntegerNumberEntred);
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(10, 211);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(318, 23);
            this.labelPrice.TabIndex = 51;
            this.labelPrice.Text = "Price";
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtItemPrice.Location = new System.Drawing.Point(10, 235);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(319, 24);
            this.txtItemPrice.TabIndex = 39;
            this.txtItemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumberEntred);
            // 
            // comboComponentList
            // 
            this.comboComponentList.FormattingEnabled = true;
            this.comboComponentList.Location = new System.Drawing.Point(11, 48);
            this.comboComponentList.Name = "comboComponentList";
            this.comboComponentList.Size = new System.Drawing.Size(318, 23);
            this.comboComponentList.TabIndex = 36;
            this.comboComponentList.SelectedIndexChanged += new System.EventHandler(this.comboComponentList_SelectedIndexChanged);
            // 
            // labelComponent
            // 
            this.labelComponent.AutoSize = true;
            this.labelComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComponent.Location = new System.Drawing.Point(11, 25);
            this.labelComponent.Name = "labelComponent";
            this.labelComponent.Size = new System.Drawing.Size(92, 20);
            this.labelComponent.TabIndex = 49;
            this.labelComponent.Text = "Component";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "List Item";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtItemDescription.Location = new System.Drawing.Point(12, 369);
            this.txtItemDescription.Multiline = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(318, 234);
            this.txtItemDescription.TabIndex = 40;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(11, 343);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(318, 23);
            this.labelDescription.TabIndex = 46;
            this.labelDescription.Text = "Description";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(224, 609);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(100, 35);
            this.btnDeleteItem.TabIndex = 43;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(118, 609);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(100, 35);
            this.btnUpdateItem.TabIndex = 42;
            this.btnUpdateItem.Text = "Update";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 609);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(100, 35);
            this.btnAddItem.TabIndex = 41;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // labelProduct
            // 
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProduct.Location = new System.Drawing.Point(11, 83);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(318, 23);
            this.labelProduct.TabIndex = 45;
            this.labelProduct.Text = "Product";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtItemName.Location = new System.Drawing.Point(11, 109);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(319, 24);
            this.txtItemName.TabIndex = 37;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtItemCode.Location = new System.Drawing.Point(10, 171);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(319, 24);
            this.txtItemCode.TabIndex = 39;
            // 
            // labelCode
            // 
            this.labelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCode.Location = new System.Drawing.Point(10, 147);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(318, 23);
            this.labelCode.TabIndex = 51;
            this.labelCode.Text = "Code";
            // 
            // panelAddItem
            // 
            this.panelAddItem.AutoScroll = true;
            this.panelAddItem.Controls.Add(this.labelComponent);
            this.panelAddItem.Controls.Add(this.txtItemName);
            this.panelAddItem.Controls.Add(this.label2);
            this.panelAddItem.Controls.Add(this.labelProduct);
            this.panelAddItem.Controls.Add(this.txtItemQuantity);
            this.panelAddItem.Controls.Add(this.btnAddItem);
            this.panelAddItem.Controls.Add(this.labelCode);
            this.panelAddItem.Controls.Add(this.btnUpdateItem);
            this.panelAddItem.Controls.Add(this.txtItemCode);
            this.panelAddItem.Controls.Add(this.btnDeleteItem);
            this.panelAddItem.Controls.Add(this.labelPrice);
            this.panelAddItem.Controls.Add(this.labelDescription);
            this.panelAddItem.Controls.Add(this.txtItemPrice);
            this.panelAddItem.Controls.Add(this.txtItemDescription);
            this.panelAddItem.Controls.Add(this.comboComponentList);
            this.panelAddItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAddItem.Location = new System.Drawing.Point(0, 0);
            this.panelAddItem.Name = "panelAddItem";
            this.panelAddItem.Size = new System.Drawing.Size(348, 721);
            this.panelAddItem.TabIndex = 55;
            // 
            // panelDisplayItem
            // 
            this.panelDisplayItem.AutoScroll = true;
            this.panelDisplayItem.Controls.Add(this.label1);
            this.panelDisplayItem.Controls.Add(this.viewListItems);
            this.panelDisplayItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplayItem.Location = new System.Drawing.Point(348, 0);
            this.panelDisplayItem.Name = "panelDisplayItem";
            this.panelDisplayItem.Size = new System.Drawing.Size(836, 721);
            this.panelDisplayItem.TabIndex = 56;
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1184, 721);
            this.Controls.Add(this.panelDisplayItem);
            this.Controls.Add(this.panelAddItem);
            this.Name = "AddItemForm";
            this.Text = "FormAddItem";
            this.Load += new System.EventHandler(this.FormAddItem_Load);
            this.panelAddItem.ResumeLayout(false);
            this.panelAddItem.PerformLayout();
            this.panelDisplayItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView viewListItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.ComboBox comboComponentList;
        private System.Windows.Forms.Label labelComponent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Panel panelAddItem;
        private System.Windows.Forms.Panel panelDisplayItem;
    }
}