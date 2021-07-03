
namespace Ads_Listing_Manager_Software.Views
{
    partial class AddBrandForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBrandForm));
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddBrand = new System.Windows.Forms.Button();
            this.buttonUpdateBrand = new System.Windows.Forms.Button();
            this.buttonDeleteBrand = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.viewListBrand = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelLeftSide.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBrand.Location = new System.Drawing.Point(3, 33);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(418, 24);
            this.txtBrand.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Brand";
            // 
            // buttonAddBrand
            // 
            this.buttonAddBrand.Location = new System.Drawing.Point(3, 600);
            this.buttonAddBrand.Name = "buttonAddBrand";
            this.buttonAddBrand.Size = new System.Drawing.Size(100, 35);
            this.buttonAddBrand.TabIndex = 3;
            this.buttonAddBrand.Text = "Add";
            this.buttonAddBrand.UseVisualStyleBackColor = true;
            this.buttonAddBrand.Click += new System.EventHandler(this.ButtonAddBrand_Click);
            // 
            // buttonUpdateBrand
            // 
            this.buttonUpdateBrand.Enabled = false;
            this.buttonUpdateBrand.Location = new System.Drawing.Point(109, 600);
            this.buttonUpdateBrand.Name = "buttonUpdateBrand";
            this.buttonUpdateBrand.Size = new System.Drawing.Size(100, 35);
            this.buttonUpdateBrand.TabIndex = 4;
            this.buttonUpdateBrand.Text = "Update";
            this.buttonUpdateBrand.UseVisualStyleBackColor = true;
            this.buttonUpdateBrand.Click += new System.EventHandler(this.ButtonUpdateBrand_Click);
            // 
            // buttonDeleteBrand
            // 
            this.buttonDeleteBrand.Enabled = false;
            this.buttonDeleteBrand.Location = new System.Drawing.Point(215, 600);
            this.buttonDeleteBrand.Name = "buttonDeleteBrand";
            this.buttonDeleteBrand.Size = new System.Drawing.Size(100, 35);
            this.buttonDeleteBrand.TabIndex = 5;
            this.buttonDeleteBrand.Text = "Delete";
            this.buttonDeleteBrand.UseVisualStyleBackColor = true;
            this.buttonDeleteBrand.Click += new System.EventHandler(this.ButtonDeleteBrand_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(3, 102);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(418, 492);
            this.txtDescription.TabIndex = 2;
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Location = new System.Drawing.Point(321, 600);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(100, 35);
            this.buttonClearFields.TabIndex = 5;
            this.buttonClearFields.Text = "Clear";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.ButtonClearFields_Click);
            // 
            // viewListBrand
            // 
            this.viewListBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewListBrand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewListBrand.FullRowSelect = true;
            this.viewListBrand.GridLines = true;
            this.viewListBrand.HideSelection = false;
            this.viewListBrand.Location = new System.Drawing.Point(4, 31);
            this.viewListBrand.MultiSelect = false;
            this.viewListBrand.Name = "viewListBrand";
            this.viewListBrand.Size = new System.Drawing.Size(670, 600);
            this.viewListBrand.TabIndex = 57;
            this.viewListBrand.UseCompatibleStateImageBehavior = false;
            this.viewListBrand.View = System.Windows.Forms.View.Details;
            this.viewListBrand.DoubleClick += new System.EventHandler(this.viewListBrand_DoubleClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Brand List";
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.AutoScroll = true;
            this.panelLeftSide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLeftSide.Controls.Add(this.label1);
            this.panelLeftSide.Controls.Add(this.buttonClearFields);
            this.panelLeftSide.Controls.Add(this.txtDescription);
            this.panelLeftSide.Controls.Add(this.buttonDeleteBrand);
            this.panelLeftSide.Controls.Add(this.txtBrand);
            this.panelLeftSide.Controls.Add(this.buttonUpdateBrand);
            this.panelLeftSide.Controls.Add(this.label2);
            this.panelLeftSide.Controls.Add(this.buttonAddBrand);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(440, 721);
            this.panelLeftSide.TabIndex = 58;
            // 
            // panelMiddle
            // 
            this.panelMiddle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMiddle.Controls.Add(this.label3);
            this.panelMiddle.Controls.Add(this.viewListBrand);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(440, 0);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(744, 721);
            this.panelMiddle.TabIndex = 59;
            // 
            // AddBrandForm
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
            this.Name = "AddBrandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBrandForm";
            this.Load += new System.EventHandler(this.AddBrandForm_Load);
            this.panelLeftSide.ResumeLayout(false);
            this.panelLeftSide.PerformLayout();
            this.panelMiddle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddBrand;
        private System.Windows.Forms.Button buttonUpdateBrand;
        private System.Windows.Forms.Button buttonDeleteBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.ListView viewListBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Panel panelMiddle;
    }
}