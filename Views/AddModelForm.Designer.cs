
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
            this.lblListModel = new System.Windows.Forms.Label();
            this.txtModelDescription = new System.Windows.Forms.TextBox();
            this.lblModelDescription = new System.Windows.Forms.Label();
            this.boxListModel = new System.Windows.Forms.ListBox();
            this.btnDeleteModel = new System.Windows.Forms.Button();
            this.btnUpdateModel = new System.Windows.Forms.Button();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.lblAddModel = new System.Windows.Forms.Label();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelPrice = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmbxListBrand = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblListModel
            // 
            this.lblListModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListModel.Location = new System.Drawing.Point(386, 66);
            this.lblListModel.Name = "lblListModel";
            this.lblListModel.Size = new System.Drawing.Size(174, 23);
            this.lblListModel.TabIndex = 25;
            this.lblListModel.Text = "Models";
            // 
            // txtModelDescription
            // 
            this.txtModelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModelDescription.Location = new System.Drawing.Point(12, 274);
            this.txtModelDescription.Multiline = true;
            this.txtModelDescription.Name = "txtModelDescription";
            this.txtModelDescription.Size = new System.Drawing.Size(318, 280);
            this.txtModelDescription.TabIndex = 24;
            // 
            // lblModelDescription
            // 
            this.lblModelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModelDescription.Location = new System.Drawing.Point(12, 248);
            this.lblModelDescription.Name = "lblModelDescription";
            this.lblModelDescription.Size = new System.Drawing.Size(255, 23);
            this.lblModelDescription.TabIndex = 23;
            this.lblModelDescription.Text = "Description";
            // 
            // boxListModel
            // 
            this.boxListModel.FormattingEnabled = true;
            this.boxListModel.ItemHeight = 15;
            this.boxListModel.Location = new System.Drawing.Point(386, 92);
            this.boxListModel.Name = "boxListModel";
            this.boxListModel.Size = new System.Drawing.Size(174, 469);
            this.boxListModel.TabIndex = 22;
            this.boxListModel.DoubleClick += new System.EventHandler(this.boxListModel_DoubleClick);
            // 
            // btnDeleteModel
            // 
            this.btnDeleteModel.Location = new System.Drawing.Point(174, 560);
            this.btnDeleteModel.Name = "btnDeleteModel";
            this.btnDeleteModel.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteModel.TabIndex = 20;
            this.btnDeleteModel.Text = "Delete";
            this.btnDeleteModel.UseVisualStyleBackColor = true;
            this.btnDeleteModel.Click += new System.EventHandler(this.btnDeleteModel_Click);
            // 
            // btnUpdateModel
            // 
            this.btnUpdateModel.Location = new System.Drawing.Point(93, 560);
            this.btnUpdateModel.Name = "btnUpdateModel";
            this.btnUpdateModel.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateModel.TabIndex = 19;
            this.btnUpdateModel.Text = "Update";
            this.btnUpdateModel.UseVisualStyleBackColor = true;
            this.btnUpdateModel.Click += new System.EventHandler(this.btnUpdateModel_Click);
            // 
            // btnAddModel
            // 
            this.btnAddModel.Location = new System.Drawing.Point(12, 560);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(75, 23);
            this.btnAddModel.TabIndex = 18;
            this.btnAddModel.Text = "Add";
            this.btnAddModel.UseVisualStyleBackColor = true;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // lblAddModel
            // 
            this.lblAddModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddModel.Location = new System.Drawing.Point(12, 120);
            this.lblAddModel.Name = "lblAddModel";
            this.lblAddModel.Size = new System.Drawing.Size(318, 23);
            this.lblAddModel.TabIndex = 17;
            this.lblAddModel.Text = "Model";
            // 
            // txtModelName
            // 
            this.txtModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModelName.Location = new System.Drawing.Point(12, 144);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(318, 24);
            this.txtModelName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Price";
            // 
            // txtModelPrice
            // 
            this.txtModelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModelPrice.Location = new System.Drawing.Point(12, 205);
            this.txtModelPrice.Name = "txtModelPrice";
            this.txtModelPrice.Size = new System.Drawing.Size(318, 24);
            this.txtModelPrice.TabIndex = 26;
            this.txtModelPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumberEntred);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.Location = new System.Drawing.Point(12, 63);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(52, 20);
            this.lblBrand.TabIndex = 28;
            this.lblBrand.Text = "Brand";
            // 
            // cmbxListBrand
            // 
            this.cmbxListBrand.FormattingEnabled = true;
            this.cmbxListBrand.Location = new System.Drawing.Point(13, 85);
            this.cmbxListBrand.Name = "cmbxListBrand";
            this.cmbxListBrand.Size = new System.Drawing.Size(317, 23);
            this.cmbxListBrand.TabIndex = 29;
            this.cmbxListBrand.SelectedIndexChanged += new System.EventHandler(this.cmbxListBrand_SelectedIndexChanged);
            // 
            // AddModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(764, 661);
            this.Controls.Add(this.cmbxListBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModelPrice);
            this.Controls.Add(this.lblListModel);
            this.Controls.Add(this.txtModelDescription);
            this.Controls.Add(this.lblModelDescription);
            this.Controls.Add(this.boxListModel);
            this.Controls.Add(this.btnDeleteModel);
            this.Controls.Add(this.btnUpdateModel);
            this.Controls.Add(this.btnAddModel);
            this.Controls.Add(this.lblAddModel);
            this.Controls.Add(this.txtModelName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AddModelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddModelForm";
            this.Load += new System.EventHandler(this.AddModelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblListModel;
        private System.Windows.Forms.TextBox txtModelDescription;
        private System.Windows.Forms.Label lblModelDescription;
        private System.Windows.Forms.ListBox boxListModel;
        private System.Windows.Forms.Button btnDeleteModel;
        private System.Windows.Forms.Button btnUpdateModel;
        private System.Windows.Forms.Button btnAddModel;
        private System.Windows.Forms.Label lblAddModel;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelPrice;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbxListBrand;
    }
}