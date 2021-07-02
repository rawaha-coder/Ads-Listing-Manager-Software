
namespace Ads_Listing_Manager_Software.Views
{
    partial class AddMultiItemForm
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
            this.btnAddMultiItem = new System.Windows.Forms.Button();
            this.comboBrandList = new System.Windows.Forms.ComboBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.comboModelList = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.panelAddMultiItem = new System.Windows.Forms.Panel();
            this.listBoxNVIDIA = new System.Windows.Forms.ListBox();
            this.listBoxRAM = new System.Windows.Forms.ListBox();
            this.listBoxHDD = new System.Windows.Forms.ListBox();
            this.listBoxSSD = new System.Windows.Forms.ListBox();
            this.listBoxCPU = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelAddMultiItem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMultiItem
            // 
            this.btnAddMultiItem.Location = new System.Drawing.Point(686, 31);
            this.btnAddMultiItem.Name = "btnAddMultiItem";
            this.btnAddMultiItem.Size = new System.Drawing.Size(358, 34);
            this.btnAddMultiItem.TabIndex = 39;
            this.btnAddMultiItem.Text = "Add ";
            this.btnAddMultiItem.UseVisualStyleBackColor = true;
            this.btnAddMultiItem.Click += new System.EventHandler(this.btnAddMultiItem_Click);
            // 
            // comboBrandList
            // 
            this.comboBrandList.FormattingEnabled = true;
            this.comboBrandList.Location = new System.Drawing.Point(10, 42);
            this.comboBrandList.Name = "comboBrandList";
            this.comboBrandList.Size = new System.Drawing.Size(327, 23);
            this.comboBrandList.TabIndex = 40;
            this.comboBrandList.SelectedIndexChanged += new System.EventHandler(this.comboBrandList_SelectedIndexChanged);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBrand.Location = new System.Drawing.Point(10, 19);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(52, 20);
            this.labelBrand.TabIndex = 43;
            this.labelBrand.Text = "Brand";
            // 
            // comboModelList
            // 
            this.comboModelList.FormattingEnabled = true;
            this.comboModelList.Location = new System.Drawing.Point(343, 42);
            this.comboModelList.Name = "comboModelList";
            this.comboModelList.Size = new System.Drawing.Size(328, 23);
            this.comboModelList.TabIndex = 41;
            this.comboModelList.SelectedIndexChanged += new System.EventHandler(this.comboModelList_SelectedIndexChanged);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelModel.Location = new System.Drawing.Point(344, 19);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(52, 20);
            this.labelModel.TabIndex = 42;
            this.labelModel.Text = "Model";
            // 
            // panelAddMultiItem
            // 
            this.panelAddMultiItem.AutoScroll = true;
            this.panelAddMultiItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAddMultiItem.Controls.Add(this.groupBox2);
            this.panelAddMultiItem.Controls.Add(this.groupBox1);
            this.panelAddMultiItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddMultiItem.Location = new System.Drawing.Point(0, 0);
            this.panelAddMultiItem.Name = "panelAddMultiItem";
            this.panelAddMultiItem.Size = new System.Drawing.Size(1184, 721);
            this.panelAddMultiItem.TabIndex = 44;
            // 
            // listBoxNVIDIA
            // 
            this.listBoxNVIDIA.FormattingEnabled = true;
            this.listBoxNVIDIA.ItemHeight = 15;
            this.listBoxNVIDIA.Location = new System.Drawing.Point(848, 47);
            this.listBoxNVIDIA.Name = "listBoxNVIDIA";
            this.listBoxNVIDIA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxNVIDIA.Size = new System.Drawing.Size(196, 469);
            this.listBoxNVIDIA.TabIndex = 6;
            // 
            // listBoxRAM
            // 
            this.listBoxRAM.FormattingEnabled = true;
            this.listBoxRAM.ItemHeight = 15;
            this.listBoxRAM.Location = new System.Drawing.Point(686, 47);
            this.listBoxRAM.Name = "listBoxRAM";
            this.listBoxRAM.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxRAM.Size = new System.Drawing.Size(156, 469);
            this.listBoxRAM.TabIndex = 6;
            // 
            // listBoxHDD
            // 
            this.listBoxHDD.FormattingEnabled = true;
            this.listBoxHDD.ItemHeight = 15;
            this.listBoxHDD.Location = new System.Drawing.Point(526, 47);
            this.listBoxHDD.Name = "listBoxHDD";
            this.listBoxHDD.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxHDD.Size = new System.Drawing.Size(154, 469);
            this.listBoxHDD.TabIndex = 6;
            // 
            // listBoxSSD
            // 
            this.listBoxSSD.FormattingEnabled = true;
            this.listBoxSSD.ItemHeight = 15;
            this.listBoxSSD.Location = new System.Drawing.Point(345, 47);
            this.listBoxSSD.Name = "listBoxSSD";
            this.listBoxSSD.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSSD.Size = new System.Drawing.Size(174, 469);
            this.listBoxSSD.TabIndex = 6;
            // 
            // listBoxCPU
            // 
            this.listBoxCPU.FormattingEnabled = true;
            this.listBoxCPU.ItemHeight = 15;
            this.listBoxCPU.Location = new System.Drawing.Point(10, 45);
            this.listBoxCPU.Name = "listBoxCPU";
            this.listBoxCPU.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxCPU.Size = new System.Drawing.Size(327, 469);
            this.listBoxCPU.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "CPU";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(344, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "SSD";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(526, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "HDD";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(686, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "RAM";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(848, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "NVIDIA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelBrand);
            this.groupBox1.Controls.Add(this.comboModelList);
            this.groupBox1.Controls.Add(this.labelModel);
            this.groupBox1.Controls.Add(this.comboBrandList);
            this.groupBox1.Controls.Add(this.btnAddMultiItem);
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 83);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listBoxNVIDIA);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listBoxRAM);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.listBoxHDD);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listBoxSSD);
            this.groupBox2.Controls.Add(this.listBoxCPU);
            this.groupBox2.Location = new System.Drawing.Point(10, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1054, 534);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // AddMultiItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1184, 721);
            this.Controls.Add(this.panelAddMultiItem);
            this.Name = "AddMultiItemForm";
            this.Text = "AddMultiItemForm";
            this.Load += new System.EventHandler(this.AddMultiItemForm_Load);
            this.panelAddMultiItem.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMultiItem;
        private System.Windows.Forms.ComboBox comboBrandList;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.ComboBox comboModelList;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Panel panelAddMultiItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxCPU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRAM;
        private System.Windows.Forms.ListBox listBoxHDD;
        private System.Windows.Forms.ListBox listBoxSSD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxNVIDIA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}