
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
            this.txtTypeDescription = new System.Windows.Forms.TextBox();
            this.lblTypeDescription = new System.Windows.Forms.Label();
            this.boxListType = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAddComponent = new System.Windows.Forms.Label();
            this.txtAddType = new System.Windows.Forms.TextBox();
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
            // txtTypeDescription
            // 
            this.txtTypeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTypeDescription.Location = new System.Drawing.Point(12, 167);
            this.txtTypeDescription.Multiline = true;
            this.txtTypeDescription.Name = "txtTypeDescription";
            this.txtTypeDescription.Size = new System.Drawing.Size(318, 387);
            this.txtTypeDescription.TabIndex = 24;
            // 
            // lblTypeDescription
            // 
            this.lblTypeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTypeDescription.Location = new System.Drawing.Point(12, 141);
            this.lblTypeDescription.Name = "lblTypeDescription";
            this.lblTypeDescription.Size = new System.Drawing.Size(255, 23);
            this.lblTypeDescription.TabIndex = 23;
            this.lblTypeDescription.Text = "Description";
            // 
            // boxListType
            // 
            this.boxListType.FormattingEnabled = true;
            this.boxListType.ItemHeight = 15;
            this.boxListType.Location = new System.Drawing.Point(386, 92);
            this.boxListType.Name = "boxListType";
            this.boxListType.Size = new System.Drawing.Size(174, 469);
            this.boxListType.TabIndex = 22;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 560);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblAddComponent
            // 
            this.lblAddComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddComponent.Location = new System.Drawing.Point(12, 66);
            this.lblAddComponent.Name = "lblAddComponent";
            this.lblAddComponent.Size = new System.Drawing.Size(255, 23);
            this.lblAddComponent.TabIndex = 17;
            this.lblAddComponent.Text = "Component";
            // 
            // txtAddType
            // 
            this.txtAddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddType.Location = new System.Drawing.Point(12, 90);
            this.txtAddType.Name = "txtAddType";
            this.txtAddType.Size = new System.Drawing.Size(318, 24);
            this.txtAddType.TabIndex = 16;
            // 
            // AddComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(764, 661);
            this.Controls.Add(this.lblListComponent);
            this.Controls.Add(this.txtTypeDescription);
            this.Controls.Add(this.lblTypeDescription);
            this.Controls.Add(this.boxListType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAddComponent);
            this.Controls.Add(this.txtAddType);
            this.Name = "AddComponentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTypeForm";
            this.Load += new System.EventHandler(this.AddComponentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblListComponent;
        private System.Windows.Forms.TextBox txtTypeDescription;
        private System.Windows.Forms.Label lblTypeDescription;
        private System.Windows.Forms.ListBox boxListType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAddComponent;
        private System.Windows.Forms.TextBox txtAddType;
    }
}