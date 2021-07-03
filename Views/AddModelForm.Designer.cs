
namespace Ads_Listing_Manager_Software.Views
{
    partial class AddModelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddModelForm));
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblModelDescription = new System.Windows.Forms.Label();
            this.buttonDeleteModel = new System.Windows.Forms.Button();
            this.buttonUpdateModel = new System.Windows.Forms.Button();
            this.buttonAddModel = new System.Windows.Forms.Button();
            this.lblAddModel = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.comboListBrand = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboGrade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.viewListModel = new System.Windows.Forms.ListView();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelLeftSide.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(16, 360);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(420, 235);
            this.txtDescription.TabIndex = 24;
            // 
            // lblModelDescription
            // 
            this.lblModelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModelDescription.Location = new System.Drawing.Point(17, 334);
            this.lblModelDescription.Name = "lblModelDescription";
            this.lblModelDescription.Size = new System.Drawing.Size(100, 23);
            this.lblModelDescription.TabIndex = 23;
            this.lblModelDescription.Text = "Description";
            // 
            // buttonDeleteModel
            // 
            this.buttonDeleteModel.Enabled = false;
            this.buttonDeleteModel.Location = new System.Drawing.Point(229, 601);
            this.buttonDeleteModel.Name = "buttonDeleteModel";
            this.buttonDeleteModel.Size = new System.Drawing.Size(100, 35);
            this.buttonDeleteModel.TabIndex = 20;
            this.buttonDeleteModel.Text = "Delete";
            this.buttonDeleteModel.UseVisualStyleBackColor = true;
            this.buttonDeleteModel.Click += new System.EventHandler(this.ButtonDeleteModel_Click);
            // 
            // buttonUpdateModel
            // 
            this.buttonUpdateModel.Enabled = false;
            this.buttonUpdateModel.Location = new System.Drawing.Point(123, 601);
            this.buttonUpdateModel.Name = "buttonUpdateModel";
            this.buttonUpdateModel.Size = new System.Drawing.Size(100, 35);
            this.buttonUpdateModel.TabIndex = 19;
            this.buttonUpdateModel.Text = "Update";
            this.buttonUpdateModel.UseVisualStyleBackColor = true;
            this.buttonUpdateModel.Click += new System.EventHandler(this.ButtonUpdateModel_Click);
            // 
            // buttonAddModel
            // 
            this.buttonAddModel.Location = new System.Drawing.Point(17, 601);
            this.buttonAddModel.Name = "buttonAddModel";
            this.buttonAddModel.Size = new System.Drawing.Size(100, 35);
            this.buttonAddModel.TabIndex = 18;
            this.buttonAddModel.Text = "Add";
            this.buttonAddModel.UseVisualStyleBackColor = true;
            this.buttonAddModel.Click += new System.EventHandler(this.ButtonAddModel_Click);
            // 
            // lblAddModel
            // 
            this.lblAddModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddModel.Location = new System.Drawing.Point(16, 74);
            this.lblAddModel.Name = "lblAddModel";
            this.lblAddModel.Size = new System.Drawing.Size(54, 23);
            this.lblAddModel.TabIndex = 17;
            this.lblAddModel.Text = "Model";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(16, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(419, 24);
            this.txtName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(16, 159);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(419, 24);
            this.txtPrice.TabIndex = 26;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumberEntred);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.Location = new System.Drawing.Point(16, 17);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(52, 20);
            this.lblBrand.TabIndex = 28;
            this.lblBrand.Text = "Brand";
            // 
            // comboListBrand
            // 
            this.comboListBrand.FormattingEnabled = true;
            this.comboListBrand.Location = new System.Drawing.Point(17, 39);
            this.comboListBrand.Name = "comboListBrand";
            this.comboListBrand.Size = new System.Drawing.Size(418, 23);
            this.comboListBrand.TabIndex = 29;
            this.comboListBrand.SelectedIndexChanged += new System.EventHandler(this.comboListBrand_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.Location = new System.Drawing.Point(17, 225);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(418, 24);
            this.txtQuantity.TabIndex = 26;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateIntegerNumberEntred);
            // 
            // labelQuantity
            // 
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuantity.Location = new System.Drawing.Point(17, 201);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(71, 23);
            this.labelQuantity.TabIndex = 27;
            this.labelQuantity.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Grade";
            // 
            // comboGrade
            // 
            this.comboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrade.FormattingEnabled = true;
            this.comboGrade.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboGrade.Location = new System.Drawing.Point(17, 292);
            this.comboGrade.Name = "comboGrade";
            this.comboGrade.Size = new System.Drawing.Size(418, 23);
            this.comboGrade.TabIndex = 29;
            this.comboGrade.SelectedIndexChanged += new System.EventHandler(this.comboListBrand_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 55;
            this.label3.Text = "List Model";
            // 
            // viewListModel
            // 
            this.viewListModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewListModel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewListModel.FullRowSelect = true;
            this.viewListModel.GridLines = true;
            this.viewListModel.HideSelection = false;
            this.viewListModel.Location = new System.Drawing.Point(22, 41);
            this.viewListModel.MultiSelect = false;
            this.viewListModel.Name = "viewListModel";
            this.viewListModel.Size = new System.Drawing.Size(633, 592);
            this.viewListModel.TabIndex = 56;
            this.viewListModel.UseCompatibleStateImageBehavior = false;
            this.viewListModel.View = System.Windows.Forms.View.Details;
            this.viewListModel.DoubleClick += new System.EventHandler(this.viewListModel_DoubleClick);
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Location = new System.Drawing.Point(335, 601);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(100, 35);
            this.buttonClearFields.TabIndex = 20;
            this.buttonClearFields.Text = "Clear";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.ButtonClearFields_Click);
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.AutoScroll = true;
            this.panelLeftSide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLeftSide.Controls.Add(this.lblBrand);
            this.panelLeftSide.Controls.Add(this.txtName);
            this.panelLeftSide.Controls.Add(this.lblAddModel);
            this.panelLeftSide.Controls.Add(this.comboGrade);
            this.panelLeftSide.Controls.Add(this.buttonAddModel);
            this.panelLeftSide.Controls.Add(this.comboListBrand);
            this.panelLeftSide.Controls.Add(this.buttonUpdateModel);
            this.panelLeftSide.Controls.Add(this.label2);
            this.panelLeftSide.Controls.Add(this.buttonDeleteModel);
            this.panelLeftSide.Controls.Add(this.buttonClearFields);
            this.panelLeftSide.Controls.Add(this.labelQuantity);
            this.panelLeftSide.Controls.Add(this.lblModelDescription);
            this.panelLeftSide.Controls.Add(this.txtQuantity);
            this.panelLeftSide.Controls.Add(this.txtDescription);
            this.panelLeftSide.Controls.Add(this.label1);
            this.panelLeftSide.Controls.Add(this.txtPrice);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(457, 721);
            this.panelLeftSide.TabIndex = 57;
            // 
            // panelMiddle
            // 
            this.panelMiddle.AutoScroll = true;
            this.panelMiddle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMiddle.Controls.Add(this.viewListModel);
            this.panelMiddle.Controls.Add(this.label3);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(457, 0);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(727, 721);
            this.panelMiddle.TabIndex = 58;
            // 
            // AddModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1184, 721);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelLeftSide);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddModelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddModelForm";
            this.Load += new System.EventHandler(this.AddModelForm_Load);
            this.panelLeftSide.ResumeLayout(false);
            this.panelLeftSide.PerformLayout();
            this.panelMiddle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblModelDescription;
        private System.Windows.Forms.Button buttonDeleteModel;
        private System.Windows.Forms.Button buttonUpdateModel;
        private System.Windows.Forms.Button buttonAddModel;
        private System.Windows.Forms.Label lblAddModel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox comboListBrand;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView viewListModel;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Panel panelMiddle;
    }
}