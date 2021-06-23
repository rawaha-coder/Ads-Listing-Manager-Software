
namespace Ads_Listing_Manager_Software.Views
{
    partial class AddMultiProductForm
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
            this.lblAddModel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBrandList1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxListModel = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxProduct = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboComponentList = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBrandList2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBrandList3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBrandList4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteBrand = new System.Windows.Forms.Button();
            this.btnUpdateBrand = new System.Windows.Forms.Button();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddModel
            // 
            this.lblAddModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddModel.Location = new System.Drawing.Point(6, 28);
            this.lblAddModel.Name = "lblAddModel";
            this.lblAddModel.Size = new System.Drawing.Size(318, 23);
            this.lblAddModel.TabIndex = 31;
            this.lblAddModel.Text = "Brand";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBrandList1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boxListModel);
            this.groupBox1.Controls.Add(this.lblAddModel);
            this.groupBox1.Location = new System.Drawing.Point(318, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 555);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Models";
            // 
            // comboBrandList1
            // 
            this.comboBrandList1.FormattingEnabled = true;
            this.comboBrandList1.Location = new System.Drawing.Point(6, 50);
            this.comboBrandList1.Name = "comboBrandList1";
            this.comboBrandList1.Size = new System.Drawing.Size(173, 23);
            this.comboBrandList1.TabIndex = 36;
            this.comboBrandList1.SelectedIndexChanged += new System.EventHandler(this.comboBrandList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Model";
            // 
            // boxListModel
            // 
            this.boxListModel.FormattingEnabled = true;
            this.boxListModel.ItemHeight = 15;
            this.boxListModel.Location = new System.Drawing.Point(7, 106);
            this.boxListModel.Name = "boxListModel";
            this.boxListModel.Size = new System.Drawing.Size(172, 439);
            this.boxListModel.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.listBoxProduct);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboComponentList);
            this.groupBox2.Location = new System.Drawing.Point(14, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 555);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Models";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Products";
            // 
            // listBoxProduct
            // 
            this.listBoxProduct.FormattingEnabled = true;
            this.listBoxProduct.ItemHeight = 15;
            this.listBoxProduct.Location = new System.Drawing.Point(6, 106);
            this.listBoxProduct.Name = "listBoxProduct";
            this.listBoxProduct.Size = new System.Drawing.Size(286, 439);
            this.listBoxProduct.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Component";
            // 
            // comboComponentList
            // 
            this.comboComponentList.FormattingEnabled = true;
            this.comboComponentList.Location = new System.Drawing.Point(7, 50);
            this.comboComponentList.Name = "comboComponentList";
            this.comboComponentList.Size = new System.Drawing.Size(285, 23);
            this.comboComponentList.TabIndex = 33;
            this.comboComponentList.SelectedIndexChanged += new System.EventHandler(this.comboComponentList_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBrandList2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(512, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 555);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Models";
            // 
            // comboBrandList2
            // 
            this.comboBrandList2.FormattingEnabled = true;
            this.comboBrandList2.Location = new System.Drawing.Point(6, 50);
            this.comboBrandList2.Name = "comboBrandList2";
            this.comboBrandList2.Size = new System.Drawing.Size(173, 23);
            this.comboBrandList2.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Model";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(7, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 439);
            this.listBox1.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Brand";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBrandList3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.listBox2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(706, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 555);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Models";
            // 
            // comboBrandList3
            // 
            this.comboBrandList3.FormattingEnabled = true;
            this.comboBrandList3.Location = new System.Drawing.Point(6, 50);
            this.comboBrandList3.Name = "comboBrandList3";
            this.comboBrandList3.Size = new System.Drawing.Size(173, 23);
            this.comboBrandList3.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "Model";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(7, 106);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(172, 439);
            this.listBox2.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(318, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Brand";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBrandList4);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.listBox3);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(900, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(188, 555);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Models";
            // 
            // comboBrandList4
            // 
            this.comboBrandList4.FormattingEnabled = true;
            this.comboBrandList4.Location = new System.Drawing.Point(6, 50);
            this.comboBrandList4.Name = "comboBrandList4";
            this.comboBrandList4.Size = new System.Drawing.Size(173, 23);
            this.comboBrandList4.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(8, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(318, 23);
            this.label8.TabIndex = 35;
            this.label8.Text = "Model";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(7, 106);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(172, 439);
            this.listBox3.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(318, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "Brand";
            // 
            // btnDeleteBrand
            // 
            this.btnDeleteBrand.Location = new System.Drawing.Point(204, 587);
            this.btnDeleteBrand.Name = "btnDeleteBrand";
            this.btnDeleteBrand.Size = new System.Drawing.Size(90, 34);
            this.btnDeleteBrand.TabIndex = 41;
            this.btnDeleteBrand.Text = "Delete";
            this.btnDeleteBrand.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBrand
            // 
            this.btnUpdateBrand.Location = new System.Drawing.Point(108, 587);
            this.btnUpdateBrand.Name = "btnUpdateBrand";
            this.btnUpdateBrand.Size = new System.Drawing.Size(90, 34);
            this.btnUpdateBrand.TabIndex = 40;
            this.btnUpdateBrand.Text = "Update";
            this.btnUpdateBrand.UseVisualStyleBackColor = true;
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Location = new System.Drawing.Point(12, 587);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(90, 34);
            this.btnAddBrand.TabIndex = 39;
            this.btnAddBrand.Text = "Add";
            this.btnAddBrand.UseVisualStyleBackColor = true;
            // 
            // AddMultiProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.btnDeleteBrand);
            this.Controls.Add(this.btnUpdateBrand);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddMultiProductForm";
            this.Text = "AddMultiProductForm";
            this.Load += new System.EventHandler(this.AddMultiProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAddModel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox boxListModel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboComponentList;
        private System.Windows.Forms.ComboBox comboBrandList1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBrandList2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBrandList3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBrandList4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteBrand;
        private System.Windows.Forms.Button btnUpdateBrand;
        private System.Windows.Forms.Button btnAddBrand;
    }
}