
namespace Ads_Listing_Manager_Software.Views
{
    partial class AddComponentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddComponentForm));
            this.lblListComponent = new System.Windows.Forms.Label();
            this.txtComponentDescription = new System.Windows.Forms.TextBox();
            this.lblTypeDescription = new System.Windows.Forms.Label();
            this.buttonDeleteComponent = new System.Windows.Forms.Button();
            this.buttonUpdateComponent = new System.Windows.Forms.Button();
            this.buttonAddComponent = new System.Windows.Forms.Button();
            this.lblAddComponent = new System.Windows.Forms.Label();
            this.txtComponentName = new System.Windows.Forms.TextBox();
            this.labelComponentID = new System.Windows.Forms.Label();
            this.txtComponentID = new System.Windows.Forms.TextBox();
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.viewListComponent = new System.Windows.Forms.ListView();
            this.panelLeftSide.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListComponent
            // 
            this.lblListComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListComponent.Location = new System.Drawing.Point(4, 5);
            this.lblListComponent.Name = "lblListComponent";
            this.lblListComponent.Size = new System.Drawing.Size(174, 23);
            this.lblListComponent.TabIndex = 25;
            this.lblListComponent.Text = "List Category";
            // 
            // txtComponentDescription
            // 
            this.txtComponentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComponentDescription.Location = new System.Drawing.Point(3, 160);
            this.txtComponentDescription.Multiline = true;
            this.txtComponentDescription.Name = "txtComponentDescription";
            this.txtComponentDescription.Size = new System.Drawing.Size(418, 434);
            this.txtComponentDescription.TabIndex = 24;
            // 
            // lblTypeDescription
            // 
            this.lblTypeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTypeDescription.Location = new System.Drawing.Point(3, 134);
            this.lblTypeDescription.Name = "lblTypeDescription";
            this.lblTypeDescription.Size = new System.Drawing.Size(255, 23);
            this.lblTypeDescription.TabIndex = 23;
            this.lblTypeDescription.Text = "Description";
            // 
            // buttonDeleteComponent
            // 
            this.buttonDeleteComponent.Enabled = false;
            this.buttonDeleteComponent.Location = new System.Drawing.Point(215, 600);
            this.buttonDeleteComponent.Name = "buttonDeleteComponent";
            this.buttonDeleteComponent.Size = new System.Drawing.Size(100, 35);
            this.buttonDeleteComponent.TabIndex = 20;
            this.buttonDeleteComponent.Text = "Delete";
            this.buttonDeleteComponent.UseVisualStyleBackColor = true;
            this.buttonDeleteComponent.Click += new System.EventHandler(this.btnDeleteComponent_Click);
            // 
            // buttonUpdateComponent
            // 
            this.buttonUpdateComponent.Enabled = false;
            this.buttonUpdateComponent.Location = new System.Drawing.Point(109, 600);
            this.buttonUpdateComponent.Name = "buttonUpdateComponent";
            this.buttonUpdateComponent.Size = new System.Drawing.Size(100, 35);
            this.buttonUpdateComponent.TabIndex = 19;
            this.buttonUpdateComponent.Text = "Update";
            this.buttonUpdateComponent.UseVisualStyleBackColor = true;
            this.buttonUpdateComponent.Click += new System.EventHandler(this.ButtonUpdateComponent_Click);
            // 
            // buttonAddComponent
            // 
            this.buttonAddComponent.Location = new System.Drawing.Point(3, 600);
            this.buttonAddComponent.Name = "buttonAddComponent";
            this.buttonAddComponent.Size = new System.Drawing.Size(100, 35);
            this.buttonAddComponent.TabIndex = 18;
            this.buttonAddComponent.Text = "Add";
            this.buttonAddComponent.UseVisualStyleBackColor = true;
            this.buttonAddComponent.Click += new System.EventHandler(this.ButtonAddComponent_Click);
            // 
            // lblAddComponent
            // 
            this.lblAddComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddComponent.Location = new System.Drawing.Point(3, 67);
            this.lblAddComponent.Name = "lblAddComponent";
            this.lblAddComponent.Size = new System.Drawing.Size(100, 23);
            this.lblAddComponent.TabIndex = 17;
            this.lblAddComponent.Text = "Category";
            this.lblAddComponent.Click += new System.EventHandler(this.lblAddComponent_Click);
            // 
            // txtComponentName
            // 
            this.txtComponentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComponentName.Location = new System.Drawing.Point(3, 93);
            this.txtComponentName.Name = "txtComponentName";
            this.txtComponentName.Size = new System.Drawing.Size(418, 24);
            this.txtComponentName.TabIndex = 16;
            // 
            // labelComponentID
            // 
            this.labelComponentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComponentID.Location = new System.Drawing.Point(3, 5);
            this.labelComponentID.Name = "labelComponentID";
            this.labelComponentID.Size = new System.Drawing.Size(31, 23);
            this.labelComponentID.TabIndex = 27;
            this.labelComponentID.Text = "ID";
            // 
            // txtComponentID
            // 
            this.txtComponentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComponentID.Location = new System.Drawing.Point(3, 31);
            this.txtComponentID.Name = "txtComponentID";
            this.txtComponentID.Size = new System.Drawing.Size(418, 24);
            this.txtComponentID.TabIndex = 26;
            this.txtComponentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComponentID_KeyPress);
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.AutoScroll = true;
            this.panelLeftSide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLeftSide.Controls.Add(this.txtComponentDescription);
            this.panelLeftSide.Controls.Add(this.labelComponentID);
            this.panelLeftSide.Controls.Add(this.txtComponentName);
            this.panelLeftSide.Controls.Add(this.txtComponentID);
            this.panelLeftSide.Controls.Add(this.lblAddComponent);
            this.panelLeftSide.Controls.Add(this.buttonAddComponent);
            this.panelLeftSide.Controls.Add(this.buttonUpdateComponent);
            this.panelLeftSide.Controls.Add(this.lblTypeDescription);
            this.panelLeftSide.Controls.Add(this.buttonClearFields);
            this.panelLeftSide.Controls.Add(this.buttonDeleteComponent);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(440, 721);
            this.panelLeftSide.TabIndex = 28;
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Location = new System.Drawing.Point(321, 600);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(100, 35);
            this.buttonClearFields.TabIndex = 20;
            this.buttonClearFields.Text = "Clear";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // panelMiddle
            // 
            this.panelMiddle.AutoScroll = true;
            this.panelMiddle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMiddle.Controls.Add(this.viewListComponent);
            this.panelMiddle.Controls.Add(this.lblListComponent);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(440, 0);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(744, 721);
            this.panelMiddle.TabIndex = 29;
            // 
            // viewListComponent
            // 
            this.viewListComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewListComponent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewListComponent.FullRowSelect = true;
            this.viewListComponent.GridLines = true;
            this.viewListComponent.HideSelection = false;
            this.viewListComponent.Location = new System.Drawing.Point(4, 31);
            this.viewListComponent.MultiSelect = false;
            this.viewListComponent.Name = "viewListComponent";
            this.viewListComponent.Size = new System.Drawing.Size(670, 600);
            this.viewListComponent.TabIndex = 58;
            this.viewListComponent.UseCompatibleStateImageBehavior = false;
            this.viewListComponent.View = System.Windows.Forms.View.Details;
            this.viewListComponent.DoubleClick += new System.EventHandler(this.viewListComponent_DoubleClick);
            // 
            // AddComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1184, 721);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelLeftSide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddComponentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddComponentForm";
            this.Load += new System.EventHandler(this.AddComponentForm_Load);
            this.panelLeftSide.ResumeLayout(false);
            this.panelLeftSide.PerformLayout();
            this.panelMiddle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblListComponent;
        private System.Windows.Forms.TextBox txtComponentDescription;
        private System.Windows.Forms.Label lblTypeDescription;
        private System.Windows.Forms.Button buttonDeleteComponent;
        private System.Windows.Forms.Button buttonUpdateComponent;
        private System.Windows.Forms.Button buttonAddComponent;
        private System.Windows.Forms.Label lblAddComponent;
        private System.Windows.Forms.TextBox txtComponentName;
        private System.Windows.Forms.Label labelComponentID;
        private System.Windows.Forms.TextBox txtComponentID;
        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.ListView viewListComponent;
    }
}