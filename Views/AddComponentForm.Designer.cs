
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
            this.lblListComponent = new System.Windows.Forms.Label();
            this.txtComponentDescription = new System.Windows.Forms.TextBox();
            this.lblTypeDescription = new System.Windows.Forms.Label();
            this.boxListComponent = new System.Windows.Forms.ListBox();
            this.btnDeleteComponent = new System.Windows.Forms.Button();
            this.btnUpdateComponent = new System.Windows.Forms.Button();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.lblAddComponent = new System.Windows.Forms.Label();
            this.txtComponentName = new System.Windows.Forms.TextBox();
            this.labelComponentID = new System.Windows.Forms.Label();
            this.txtComponentID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblListComponent
            // 
            this.lblListComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListComponent.Location = new System.Drawing.Point(386, 66);
            this.lblListComponent.Name = "lblListComponent";
            this.lblListComponent.Size = new System.Drawing.Size(174, 23);
            this.lblListComponent.TabIndex = 25;
            this.lblListComponent.Text = "List Component";
            // 
            // txtComponentDescription
            // 
            this.txtComponentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComponentDescription.Location = new System.Drawing.Point(12, 216);
            this.txtComponentDescription.Multiline = true;
            this.txtComponentDescription.Name = "txtComponentDescription";
            this.txtComponentDescription.Size = new System.Drawing.Size(318, 338);
            this.txtComponentDescription.TabIndex = 24;
            // 
            // lblTypeDescription
            // 
            this.lblTypeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTypeDescription.Location = new System.Drawing.Point(12, 190);
            this.lblTypeDescription.Name = "lblTypeDescription";
            this.lblTypeDescription.Size = new System.Drawing.Size(255, 23);
            this.lblTypeDescription.TabIndex = 23;
            this.lblTypeDescription.Text = "Description";
            // 
            // boxListComponent
            // 
            this.boxListComponent.FormattingEnabled = true;
            this.boxListComponent.ItemHeight = 15;
            this.boxListComponent.Location = new System.Drawing.Point(386, 92);
            this.boxListComponent.Name = "boxListComponent";
            this.boxListComponent.Size = new System.Drawing.Size(174, 469);
            this.boxListComponent.TabIndex = 22;
            this.boxListComponent.DoubleClick += new System.EventHandler(this.boxListComponent_DoubleClick);
            // 
            // btnDeleteComponent
            // 
            this.btnDeleteComponent.Location = new System.Drawing.Point(174, 560);
            this.btnDeleteComponent.Name = "btnDeleteComponent";
            this.btnDeleteComponent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteComponent.TabIndex = 20;
            this.btnDeleteComponent.Text = "Delete";
            this.btnDeleteComponent.UseVisualStyleBackColor = true;
            this.btnDeleteComponent.Click += new System.EventHandler(this.btnDeleteComponent_Click);
            // 
            // btnUpdateComponent
            // 
            this.btnUpdateComponent.Location = new System.Drawing.Point(93, 560);
            this.btnUpdateComponent.Name = "btnUpdateComponent";
            this.btnUpdateComponent.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateComponent.TabIndex = 19;
            this.btnUpdateComponent.Text = "Update";
            this.btnUpdateComponent.UseVisualStyleBackColor = true;
            this.btnUpdateComponent.Click += new System.EventHandler(this.btnUpdateComponent_Click);
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.Location = new System.Drawing.Point(12, 560);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(75, 23);
            this.btnAddComponent.TabIndex = 18;
            this.btnAddComponent.Text = "Add";
            this.btnAddComponent.UseVisualStyleBackColor = true;
            this.btnAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // lblAddComponent
            // 
            this.lblAddComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddComponent.Location = new System.Drawing.Point(12, 126);
            this.lblAddComponent.Name = "lblAddComponent";
            this.lblAddComponent.Size = new System.Drawing.Size(318, 23);
            this.lblAddComponent.TabIndex = 17;
            this.lblAddComponent.Text = "Component";
            // 
            // txtComponentName
            // 
            this.txtComponentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComponentName.Location = new System.Drawing.Point(12, 150);
            this.txtComponentName.Name = "txtComponentName";
            this.txtComponentName.Size = new System.Drawing.Size(318, 24);
            this.txtComponentName.TabIndex = 16;
            // 
            // labelComponentID
            // 
            this.labelComponentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComponentID.Location = new System.Drawing.Point(12, 66);
            this.labelComponentID.Name = "labelComponentID";
            this.labelComponentID.Size = new System.Drawing.Size(318, 23);
            this.labelComponentID.TabIndex = 27;
            this.labelComponentID.Text = "ID";
            // 
            // txtComponentID
            // 
            this.txtComponentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComponentID.Location = new System.Drawing.Point(12, 90);
            this.txtComponentID.Name = "txtComponentID";
            this.txtComponentID.Size = new System.Drawing.Size(318, 24);
            this.txtComponentID.TabIndex = 26;
            this.txtComponentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComponentID_KeyPress);
            // 
            // AddComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(764, 661);
            this.Controls.Add(this.labelComponentID);
            this.Controls.Add(this.txtComponentID);
            this.Controls.Add(this.lblListComponent);
            this.Controls.Add(this.txtComponentDescription);
            this.Controls.Add(this.lblTypeDescription);
            this.Controls.Add(this.boxListComponent);
            this.Controls.Add(this.btnDeleteComponent);
            this.Controls.Add(this.btnUpdateComponent);
            this.Controls.Add(this.btnAddComponent);
            this.Controls.Add(this.lblAddComponent);
            this.Controls.Add(this.txtComponentName);
            this.Name = "AddComponentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTypeForm";
            this.Load += new System.EventHandler(this.AddComponentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblListComponent;
        private System.Windows.Forms.TextBox txtComponentDescription;
        private System.Windows.Forms.Label lblTypeDescription;
        private System.Windows.Forms.ListBox boxListComponent;
        private System.Windows.Forms.Button btnDeleteComponent;
        private System.Windows.Forms.Button btnUpdateComponent;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.Label lblAddComponent;
        private System.Windows.Forms.TextBox txtComponentName;
        private System.Windows.Forms.Label labelComponentID;
        private System.Windows.Forms.TextBox txtComponentID;
    }
}