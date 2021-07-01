﻿
namespace Ads_Listing_Manager_Software.Views
{
    partial class ProductForm
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
            this.panelProductForm = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResultCalcul = new System.Windows.Forms.TextBox();
            this.btnCalculTotalPrice = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProfitPrice = new System.Windows.Forms.TextBox();
            this.txtFeePrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtModelPrice = new System.Windows.Forms.TextBox();
            this.comboProductList = new System.Windows.Forms.ComboBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.comboBrandList = new System.Windows.Forms.ComboBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelComponent = new System.Windows.Forms.Label();
            this.comboModelList = new System.Windows.Forms.ComboBox();
            this.comboComponentList = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelProductForm.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProductForm
            // 
            this.panelProductForm.AutoScroll = true;
            this.panelProductForm.Controls.Add(this.groupBox3);
            this.panelProductForm.Controls.Add(this.groupBox2);
            this.panelProductForm.Controls.Add(this.groupBox1);
            this.panelProductForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductForm.Location = new System.Drawing.Point(0, 0);
            this.panelProductForm.Name = "panelProductForm";
            this.panelProductForm.Size = new System.Drawing.Size(1184, 721);
            this.panelProductForm.TabIndex = 0;
            this.panelProductForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProductForm_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescription);
            this.groupBox3.Location = new System.Drawing.Point(12, 342);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 318);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(7, 14);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(565, 298);
            this.txtDescription.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResultCalcul);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnCalculTotalPrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtProfitPrice);
            this.groupBox2.Controls.Add(this.txtFeePrice);
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 68);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calcul price";
            // 
            // txtResultCalcul
            // 
            this.txtResultCalcul.Location = new System.Drawing.Point(356, 27);
            this.txtResultCalcul.Name = "txtResultCalcul";
            this.txtResultCalcul.ReadOnly = true;
            this.txtResultCalcul.Size = new System.Drawing.Size(100, 23);
            this.txtResultCalcul.TabIndex = 54;
            // 
            // btnCalculTotalPrice
            // 
            this.btnCalculTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalculTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculTotalPrice.Location = new System.Drawing.Point(247, 20);
            this.btnCalculTotalPrice.Name = "btnCalculTotalPrice";
            this.btnCalculTotalPrice.Size = new System.Drawing.Size(100, 35);
            this.btnCalculTotalPrice.TabIndex = 10;
            this.btnCalculTotalPrice.Text = "Calcul";
            this.btnCalculTotalPrice.UseVisualStyleBackColor = false;
            this.btnCalculTotalPrice.Click += new System.EventHandler(this.btnCalculTotalPrice_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(115, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Profit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fee:";
            // 
            // txtProfitPrice
            // 
            this.txtProfitPrice.Location = new System.Drawing.Point(172, 29);
            this.txtProfitPrice.Name = "txtProfitPrice";
            this.txtProfitPrice.Size = new System.Drawing.Size(60, 23);
            this.txtProfitPrice.TabIndex = 9;
            // 
            // txtFeePrice
            // 
            this.txtFeePrice.Location = new System.Drawing.Point(49, 29);
            this.txtFeePrice.Name = "txtFeePrice";
            this.txtFeePrice.Size = new System.Drawing.Size(60, 23);
            this.txtFeePrice.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProductPrice);
            this.groupBox1.Controls.Add(this.txtModelPrice);
            this.groupBox1.Controls.Add(this.comboProductList);
            this.groupBox1.Controls.Add(this.labelBrand);
            this.groupBox1.Controls.Add(this.comboBrandList);
            this.groupBox1.Controls.Add(this.labelProduct);
            this.groupBox1.Controls.Add(this.labelComponent);
            this.groupBox1.Controls.Add(this.comboModelList);
            this.groupBox1.Controls.Add(this.comboComponentList);
            this.groupBox1.Controls.Add(this.labelModel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 222);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(455, 170);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.ReadOnly = true;
            this.txtProductPrice.Size = new System.Drawing.Size(100, 23);
            this.txtProductPrice.TabIndex = 56;
            // 
            // txtModelPrice
            // 
            this.txtModelPrice.Location = new System.Drawing.Point(455, 81);
            this.txtModelPrice.Name = "txtModelPrice";
            this.txtModelPrice.ReadOnly = true;
            this.txtModelPrice.Size = new System.Drawing.Size(100, 23);
            this.txtModelPrice.TabIndex = 54;
            // 
            // comboProductList
            // 
            this.comboProductList.FormattingEnabled = true;
            this.comboProductList.Location = new System.Drawing.Point(113, 170);
            this.comboProductList.Name = "comboProductList";
            this.comboProductList.Size = new System.Drawing.Size(318, 23);
            this.comboProductList.TabIndex = 36;
            this.comboProductList.SelectedIndexChanged += new System.EventHandler(this.comboProductList_SelectedIndexChanged);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBrand.Location = new System.Drawing.Point(15, 31);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(52, 20);
            this.labelBrand.TabIndex = 40;
            this.labelBrand.Text = "Brand";
            // 
            // comboBrandList
            // 
            this.comboBrandList.FormattingEnabled = true;
            this.comboBrandList.Location = new System.Drawing.Point(113, 31);
            this.comboBrandList.Name = "comboBrandList";
            this.comboBrandList.Size = new System.Drawing.Size(442, 23);
            this.comboBrandList.TabIndex = 33;
            this.comboBrandList.SelectedIndexChanged += new System.EventHandler(this.comboBrandList_SelectedIndexChanged);
            // 
            // labelProduct
            // 
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProduct.Location = new System.Drawing.Point(15, 169);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(70, 23);
            this.labelProduct.TabIndex = 37;
            this.labelProduct.Text = "Product";
            // 
            // labelComponent
            // 
            this.labelComponent.AutoSize = true;
            this.labelComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComponent.Location = new System.Drawing.Point(15, 124);
            this.labelComponent.Name = "labelComponent";
            this.labelComponent.Size = new System.Drawing.Size(92, 20);
            this.labelComponent.TabIndex = 38;
            this.labelComponent.Text = "Component";
            // 
            // comboModelList
            // 
            this.comboModelList.FormattingEnabled = true;
            this.comboModelList.Location = new System.Drawing.Point(113, 80);
            this.comboModelList.Name = "comboModelList";
            this.comboModelList.Size = new System.Drawing.Size(324, 23);
            this.comboModelList.TabIndex = 34;
            this.comboModelList.SelectedIndexChanged += new System.EventHandler(this.comboModelList_SelectedIndexChanged);
            // 
            // comboComponentList
            // 
            this.comboComponentList.FormattingEnabled = true;
            this.comboComponentList.Location = new System.Drawing.Point(113, 125);
            this.comboComponentList.Name = "comboComponentList";
            this.comboComponentList.Size = new System.Drawing.Size(442, 23);
            this.comboComponentList.TabIndex = 35;
            this.comboComponentList.SelectedIndexChanged += new System.EventHandler(this.comboComponentList_SelectedIndexChanged);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelModel.Location = new System.Drawing.Point(15, 80);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(52, 20);
            this.labelModel.TabIndex = 39;
            this.labelModel.Text = "Model";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(485, 22);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 30);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1184, 721);
            this.Controls.Add(this.panelProductForm);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.panelProductForm.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProductForm;
        private System.Windows.Forms.ComboBox comboProductList;
        private System.Windows.Forms.ComboBox comboBrandList;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.ComboBox comboModelList;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ComboBox comboComponentList;
        private System.Windows.Forms.Label labelComponent;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtModelPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResultCalcul;
        private System.Windows.Forms.Button btnCalculTotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProfitPrice;
        private System.Windows.Forms.TextBox txtFeePrice;
        private System.Windows.Forms.Button btnClear;
    }
}