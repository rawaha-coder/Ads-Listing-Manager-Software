
namespace Ads_Listing_Manager_Software.Views
{
    partial class ItemForm
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.comboItemList = new System.Windows.Forms.ComboBox();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.labelComponent = new System.Windows.Forms.Label();
            this.comboComponentList = new System.Windows.Forms.ComboBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 721);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescription);
            this.groupBox3.Location = new System.Drawing.Point(23, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 318);
            this.groupBox3.TabIndex = 56;
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
            this.groupBox2.Controls.Add(this.buttonClear);
            this.groupBox2.Controls.Add(this.txtProfitPrice);
            this.groupBox2.Controls.Add(this.txtResultCalcul);
            this.groupBox2.Controls.Add(this.btnCalculTotalPrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtFeePrice);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(23, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 71);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calcul price";
            // 
            // txtResultCalcul
            // 
            this.txtResultCalcul.Location = new System.Drawing.Point(357, 29);
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
            this.btnCalculTotalPrice.Location = new System.Drawing.Point(260, 23);
            this.btnCalculTotalPrice.Name = "btnCalculTotalPrice";
            this.btnCalculTotalPrice.Size = new System.Drawing.Size(90, 32);
            this.btnCalculTotalPrice.TabIndex = 10;
            this.btnCalculTotalPrice.Text = "Calcul";
            this.btnCalculTotalPrice.UseVisualStyleBackColor = false;
            this.btnCalculTotalPrice.Click += new System.EventHandler(this.btnCalculTotalPrice_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(126, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Profit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fee:";
            // 
            // txtProfitPrice
            // 
            this.txtProfitPrice.Location = new System.Drawing.Point(174, 29);
            this.txtProfitPrice.Name = "txtProfitPrice";
            this.txtProfitPrice.Size = new System.Drawing.Size(50, 23);
            this.txtProfitPrice.TabIndex = 9;
            this.txtProfitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumberEntred);
            // 
            // txtFeePrice
            // 
            this.txtFeePrice.Location = new System.Drawing.Point(55, 29);
            this.txtFeePrice.Name = "txtFeePrice";
            this.txtFeePrice.Size = new System.Drawing.Size(50, 23);
            this.txtFeePrice.TabIndex = 8;
            this.txtFeePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumberEntred);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboItemList);
            this.groupBox1.Controls.Add(this.txtItemPrice);
            this.groupBox1.Controls.Add(this.labelComponent);
            this.groupBox1.Controls.Add(this.comboComponentList);
            this.groupBox1.Controls.Add(this.labelItem);
            this.groupBox1.Location = new System.Drawing.Point(23, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 141);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item";
            // 
            // comboItemList
            // 
            this.comboItemList.FormattingEnabled = true;
            this.comboItemList.Location = new System.Drawing.Point(118, 83);
            this.comboItemList.Name = "comboItemList";
            this.comboItemList.Size = new System.Drawing.Size(318, 23);
            this.comboItemList.TabIndex = 55;
            this.comboItemList.SelectedIndexChanged += new System.EventHandler(this.comboItemList_SelectedIndexChanged);
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(447, 83);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.ReadOnly = true;
            this.txtItemPrice.Size = new System.Drawing.Size(100, 23);
            this.txtItemPrice.TabIndex = 54;
            // 
            // labelComponent
            // 
            this.labelComponent.AutoSize = true;
            this.labelComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComponent.Location = new System.Drawing.Point(7, 34);
            this.labelComponent.Name = "labelComponent";
            this.labelComponent.Size = new System.Drawing.Size(92, 20);
            this.labelComponent.TabIndex = 53;
            this.labelComponent.Text = "Component";
            // 
            // comboComponentList
            // 
            this.comboComponentList.FormattingEnabled = true;
            this.comboComponentList.Location = new System.Drawing.Point(118, 35);
            this.comboComponentList.Name = "comboComponentList";
            this.comboComponentList.Size = new System.Drawing.Size(429, 23);
            this.comboComponentList.TabIndex = 50;
            this.comboComponentList.SelectedIndexChanged += new System.EventHandler(this.comboComponentList_SelectedIndexChanged);
            // 
            // labelItem
            // 
            this.labelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelItem.Location = new System.Drawing.Point(7, 85);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(92, 23);
            this.labelItem.TabIndex = 52;
            this.labelItem.Text = "Item";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(477, 22);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 35);
            this.buttonClear.TabIndex = 56;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1184, 721);
            this.Controls.Add(this.panel1);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelComponent;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.ComboBox comboComponentList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResultCalcul;
        private System.Windows.Forms.Button btnCalculTotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProfitPrice;
        private System.Windows.Forms.TextBox txtFeePrice;
        private System.Windows.Forms.ComboBox comboItemList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button buttonClear;
    }
}