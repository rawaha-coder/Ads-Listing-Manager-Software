
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
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelCPU = new System.Windows.Forms.Panel();
            this.listBoxCPU = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelNvidia = new System.Windows.Forms.Panel();
            this.listBoxNVIDIA = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelRAM = new System.Windows.Forms.Panel();
            this.listBoxRAM = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSSD = new System.Windows.Forms.Panel();
            this.listBoxSSD = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHDD = new System.Windows.Forms.Panel();
            this.listBoxHDD = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelAddMultiItem.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.panelCPU.SuspendLayout();
            this.panelNvidia.SuspendLayout();
            this.panelRAM.SuspendLayout();
            this.panelSSD.SuspendLayout();
            this.panelHDD.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMultiItem
            // 
            this.btnAddMultiItem.Location = new System.Drawing.Point(686, 42);
            this.btnAddMultiItem.Name = "btnAddMultiItem";
            this.btnAddMultiItem.Size = new System.Drawing.Size(358, 23);
            this.btnAddMultiItem.TabIndex = 42;
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
            this.panelAddMultiItem.Controls.Add(this.panelMiddle);
            this.panelAddMultiItem.Controls.Add(this.panelTop);
            this.panelAddMultiItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddMultiItem.Location = new System.Drawing.Point(0, 0);
            this.panelAddMultiItem.Name = "panelAddMultiItem";
            this.panelAddMultiItem.Size = new System.Drawing.Size(1184, 721);
            this.panelAddMultiItem.TabIndex = 44;
            // 
            // panelMiddle
            // 
            this.panelMiddle.AutoScroll = true;
            this.panelMiddle.Controls.Add(this.panelCPU);
            this.panelMiddle.Controls.Add(this.panelNvidia);
            this.panelMiddle.Controls.Add(this.panelRAM);
            this.panelMiddle.Controls.Add(this.panelSSD);
            this.panelMiddle.Controls.Add(this.panelHDD);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(0, 107);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(1180, 610);
            this.panelMiddle.TabIndex = 48;
            // 
            // panelCPU
            // 
            this.panelCPU.AutoScroll = true;
            this.panelCPU.Controls.Add(this.listBoxCPU);
            this.panelCPU.Controls.Add(this.label2);
            this.panelCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCPU.Location = new System.Drawing.Point(0, 0);
            this.panelCPU.Name = "panelCPU";
            this.panelCPU.Padding = new System.Windows.Forms.Padding(5);
            this.panelCPU.Size = new System.Drawing.Size(270, 610);
            this.panelCPU.TabIndex = 50;
            // 
            // listBoxCPU
            // 
            this.listBoxCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCPU.FormattingEnabled = true;
            this.listBoxCPU.HorizontalScrollbar = true;
            this.listBoxCPU.ItemHeight = 15;
            this.listBoxCPU.Location = new System.Drawing.Point(5, 30);
            this.listBoxCPU.Name = "listBoxCPU";
            this.listBoxCPU.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxCPU.Size = new System.Drawing.Size(260, 575);
            this.listBoxCPU.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "CPU";
            // 
            // panelNvidia
            // 
            this.panelNvidia.AutoScroll = true;
            this.panelNvidia.Controls.Add(this.listBoxNVIDIA);
            this.panelNvidia.Controls.Add(this.label5);
            this.panelNvidia.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNvidia.Location = new System.Drawing.Point(270, 0);
            this.panelNvidia.Name = "panelNvidia";
            this.panelNvidia.Padding = new System.Windows.Forms.Padding(5);
            this.panelNvidia.Size = new System.Drawing.Size(260, 610);
            this.panelNvidia.TabIndex = 51;
            // 
            // listBoxNVIDIA
            // 
            this.listBoxNVIDIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNVIDIA.FormattingEnabled = true;
            this.listBoxNVIDIA.HorizontalScrollbar = true;
            this.listBoxNVIDIA.ItemHeight = 15;
            this.listBoxNVIDIA.Location = new System.Drawing.Point(5, 30);
            this.listBoxNVIDIA.Name = "listBoxNVIDIA";
            this.listBoxNVIDIA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxNVIDIA.Size = new System.Drawing.Size(250, 575);
            this.listBoxNVIDIA.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "NVIDIA";
            // 
            // panelRAM
            // 
            this.panelRAM.AutoScroll = true;
            this.panelRAM.Controls.Add(this.listBoxRAM);
            this.panelRAM.Controls.Add(this.label4);
            this.panelRAM.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRAM.Location = new System.Drawing.Point(530, 0);
            this.panelRAM.Name = "panelRAM";
            this.panelRAM.Padding = new System.Windows.Forms.Padding(5);
            this.panelRAM.Size = new System.Drawing.Size(220, 610);
            this.panelRAM.TabIndex = 52;
            // 
            // listBoxRAM
            // 
            this.listBoxRAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRAM.FormattingEnabled = true;
            this.listBoxRAM.HorizontalScrollbar = true;
            this.listBoxRAM.ItemHeight = 15;
            this.listBoxRAM.Location = new System.Drawing.Point(5, 30);
            this.listBoxRAM.Name = "listBoxRAM";
            this.listBoxRAM.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxRAM.Size = new System.Drawing.Size(210, 575);
            this.listBoxRAM.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "RAM";
            // 
            // panelSSD
            // 
            this.panelSSD.AutoScroll = true;
            this.panelSSD.Controls.Add(this.listBoxSSD);
            this.panelSSD.Controls.Add(this.label1);
            this.panelSSD.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSSD.Location = new System.Drawing.Point(750, 0);
            this.panelSSD.Name = "panelSSD";
            this.panelSSD.Padding = new System.Windows.Forms.Padding(5);
            this.panelSSD.Size = new System.Drawing.Size(250, 610);
            this.panelSSD.TabIndex = 54;
            // 
            // listBoxSSD
            // 
            this.listBoxSSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSSD.FormattingEnabled = true;
            this.listBoxSSD.HorizontalScrollbar = true;
            this.listBoxSSD.ItemHeight = 15;
            this.listBoxSSD.Location = new System.Drawing.Point(5, 30);
            this.listBoxSSD.Margin = new System.Windows.Forms.Padding(3, 35, 3, 3);
            this.listBoxSSD.Name = "listBoxSSD";
            this.listBoxSSD.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSSD.Size = new System.Drawing.Size(240, 575);
            this.listBoxSSD.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "SSD";
            // 
            // panelHDD
            // 
            this.panelHDD.AutoScroll = true;
            this.panelHDD.Controls.Add(this.listBoxHDD);
            this.panelHDD.Controls.Add(this.label3);
            this.panelHDD.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHDD.Location = new System.Drawing.Point(1000, 0);
            this.panelHDD.Name = "panelHDD";
            this.panelHDD.Padding = new System.Windows.Forms.Padding(5);
            this.panelHDD.Size = new System.Drawing.Size(180, 610);
            this.panelHDD.TabIndex = 53;
            // 
            // listBoxHDD
            // 
            this.listBoxHDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHDD.FormattingEnabled = true;
            this.listBoxHDD.HorizontalScrollbar = true;
            this.listBoxHDD.ItemHeight = 15;
            this.listBoxHDD.Location = new System.Drawing.Point(5, 30);
            this.listBoxHDD.Name = "listBoxHDD";
            this.listBoxHDD.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxHDD.Size = new System.Drawing.Size(170, 575);
            this.listBoxHDD.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "HDD";
            // 
            // panelTop
            // 
            this.panelTop.AutoScroll = true;
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1180, 107);
            this.panelTop.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddMultiItem);
            this.groupBox1.Controls.Add(this.comboModelList);
            this.groupBox1.Controls.Add(this.labelBrand);
            this.groupBox1.Controls.Add(this.labelModel);
            this.groupBox1.Controls.Add(this.comboBrandList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1180, 107);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
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
            this.panelMiddle.ResumeLayout(false);
            this.panelCPU.ResumeLayout(false);
            this.panelNvidia.ResumeLayout(false);
            this.panelRAM.ResumeLayout(false);
            this.panelSSD.ResumeLayout(false);
            this.panelHDD.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelSSD;
        private System.Windows.Forms.Panel panelHDD;
        private System.Windows.Forms.Panel panelRAM;
        private System.Windows.Forms.Panel panelNvidia;
        private System.Windows.Forms.Panel panelCPU;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Panel panelTop;
    }
}