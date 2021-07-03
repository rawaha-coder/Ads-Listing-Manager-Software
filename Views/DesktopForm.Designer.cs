
namespace Ads_Listing_Manager_Software.Views
{
    partial class DesktopForm
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
            this.comboBrandList = new System.Windows.Forms.ComboBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.comboModelList = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.comboCPUList = new System.Windows.Forms.ComboBox();
            this.labelComponent = new System.Windows.Forms.Label();
            this.comboSSDList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboHDDList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboRAMList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboNVIDIAList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNvidiaPrice = new System.Windows.Forms.TextBox();
            this.txtRAMPrice = new System.Windows.Forms.TextBox();
            this.txtHDDPrice = new System.Windows.Forms.TextBox();
            this.txtSSDPrice = new System.Windows.Forms.TextBox();
            this.txtCPUPrice = new System.Windows.Forms.TextBox();
            this.txtModelPrice = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResultCalcul = new System.Windows.Forms.TextBox();
            this.btnCalculTotalPrice = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProfitPrice = new System.Windows.Forms.TextBox();
            this.txtFeePrice = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBrandList
            // 
            this.comboBrandList.FormattingEnabled = true;
            this.comboBrandList.Location = new System.Drawing.Point(99, 34);
            this.comboBrandList.Name = "comboBrandList";
            this.comboBrandList.Size = new System.Drawing.Size(457, 23);
            this.comboBrandList.TabIndex = 1;
            this.comboBrandList.SelectedIndexChanged += new System.EventHandler(this.comboBrandList_SelectedIndexChanged);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBrand.Location = new System.Drawing.Point(24, 33);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(52, 20);
            this.labelBrand.TabIndex = 38;
            this.labelBrand.Text = "Brand";
            // 
            // comboModelList
            // 
            this.comboModelList.FormattingEnabled = true;
            this.comboModelList.Location = new System.Drawing.Point(99, 76);
            this.comboModelList.Name = "comboModelList";
            this.comboModelList.Size = new System.Drawing.Size(318, 23);
            this.comboModelList.TabIndex = 2;
            this.comboModelList.SelectedIndexChanged += new System.EventHandler(this.comboModelList_SelectedIndexChanged);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelModel.Location = new System.Drawing.Point(22, 76);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(52, 20);
            this.labelModel.TabIndex = 37;
            this.labelModel.Text = "Model";
            // 
            // comboCPUList
            // 
            this.comboCPUList.FormattingEnabled = true;
            this.comboCPUList.Location = new System.Drawing.Point(99, 116);
            this.comboCPUList.Name = "comboCPUList";
            this.comboCPUList.Size = new System.Drawing.Size(318, 23);
            this.comboCPUList.TabIndex = 3;
            this.comboCPUList.SelectedIndexChanged += new System.EventHandler(this.comboCPUList_SelectedIndexChanged);
            // 
            // labelComponent
            // 
            this.labelComponent.AutoSize = true;
            this.labelComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComponent.Location = new System.Drawing.Point(22, 119);
            this.labelComponent.Name = "labelComponent";
            this.labelComponent.Size = new System.Drawing.Size(42, 20);
            this.labelComponent.TabIndex = 36;
            this.labelComponent.Text = "CPU";
            // 
            // comboSSDList
            // 
            this.comboSSDList.FormattingEnabled = true;
            this.comboSSDList.Location = new System.Drawing.Point(99, 157);
            this.comboSSDList.Name = "comboSSDList";
            this.comboSSDList.Size = new System.Drawing.Size(318, 23);
            this.comboSSDList.TabIndex = 4;
            this.comboSSDList.SelectedIndexChanged += new System.EventHandler(this.comboSSDList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "SSD";
            // 
            // comboHDDList
            // 
            this.comboHDDList.FormattingEnabled = true;
            this.comboHDDList.Location = new System.Drawing.Point(99, 198);
            this.comboHDDList.Name = "comboHDDList";
            this.comboHDDList.Size = new System.Drawing.Size(318, 23);
            this.comboHDDList.TabIndex = 5;
            this.comboHDDList.SelectedIndexChanged += new System.EventHandler(this.comboHDDList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "HDD";
            // 
            // comboRAMList
            // 
            this.comboRAMList.FormattingEnabled = true;
            this.comboRAMList.Location = new System.Drawing.Point(99, 241);
            this.comboRAMList.Name = "comboRAMList";
            this.comboRAMList.Size = new System.Drawing.Size(318, 23);
            this.comboRAMList.TabIndex = 6;
            this.comboRAMList.SelectedIndexChanged += new System.EventHandler(this.comboRAMList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "RAM";
            // 
            // comboNVIDIAList
            // 
            this.comboNVIDIAList.FormattingEnabled = true;
            this.comboNVIDIAList.Location = new System.Drawing.Point(99, 283);
            this.comboNVIDIAList.Name = "comboNVIDIAList";
            this.comboNVIDIAList.Size = new System.Drawing.Size(318, 23);
            this.comboNVIDIAList.TabIndex = 7;
            this.comboNVIDIAList.SelectedIndexChanged += new System.EventHandler(this.comboNVIDIAList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "NVIDIA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNvidiaPrice);
            this.groupBox1.Controls.Add(this.txtRAMPrice);
            this.groupBox1.Controls.Add(this.txtHDDPrice);
            this.groupBox1.Controls.Add(this.txtSSDPrice);
            this.groupBox1.Controls.Add(this.txtCPUPrice);
            this.groupBox1.Controls.Add(this.txtModelPrice);
            this.groupBox1.Controls.Add(this.labelBrand);
            this.groupBox1.Controls.Add(this.comboNVIDIAList);
            this.groupBox1.Controls.Add(this.labelComponent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboCPUList);
            this.groupBox1.Controls.Add(this.comboRAMList);
            this.groupBox1.Controls.Add(this.labelModel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboModelList);
            this.groupBox1.Controls.Add(this.comboHDDList);
            this.groupBox1.Controls.Add(this.comboBrandList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboSSDList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 326);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WorkStation Component";
            // 
            // txtNvidiaPrice
            // 
            this.txtNvidiaPrice.Location = new System.Drawing.Point(456, 283);
            this.txtNvidiaPrice.Name = "txtNvidiaPrice";
            this.txtNvidiaPrice.ReadOnly = true;
            this.txtNvidiaPrice.Size = new System.Drawing.Size(100, 23);
            this.txtNvidiaPrice.TabIndex = 53;
            // 
            // txtRAMPrice
            // 
            this.txtRAMPrice.Location = new System.Drawing.Point(456, 241);
            this.txtRAMPrice.Name = "txtRAMPrice";
            this.txtRAMPrice.ReadOnly = true;
            this.txtRAMPrice.Size = new System.Drawing.Size(100, 23);
            this.txtRAMPrice.TabIndex = 52;
            // 
            // txtHDDPrice
            // 
            this.txtHDDPrice.Location = new System.Drawing.Point(456, 198);
            this.txtHDDPrice.Name = "txtHDDPrice";
            this.txtHDDPrice.ReadOnly = true;
            this.txtHDDPrice.Size = new System.Drawing.Size(100, 23);
            this.txtHDDPrice.TabIndex = 51;
            // 
            // txtSSDPrice
            // 
            this.txtSSDPrice.Location = new System.Drawing.Point(456, 157);
            this.txtSSDPrice.Name = "txtSSDPrice";
            this.txtSSDPrice.ReadOnly = true;
            this.txtSSDPrice.Size = new System.Drawing.Size(100, 23);
            this.txtSSDPrice.TabIndex = 50;
            // 
            // txtCPUPrice
            // 
            this.txtCPUPrice.Location = new System.Drawing.Point(456, 116);
            this.txtCPUPrice.Name = "txtCPUPrice";
            this.txtCPUPrice.ReadOnly = true;
            this.txtCPUPrice.Size = new System.Drawing.Size(100, 23);
            this.txtCPUPrice.TabIndex = 49;
            // 
            // txtModelPrice
            // 
            this.txtModelPrice.Location = new System.Drawing.Point(456, 77);
            this.txtModelPrice.Name = "txtModelPrice";
            this.txtModelPrice.ReadOnly = true;
            this.txtModelPrice.Size = new System.Drawing.Size(100, 23);
            this.txtModelPrice.TabIndex = 48;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonClear);
            this.groupBox2.Controls.Add(this.txtResultCalcul);
            this.groupBox2.Controls.Add(this.btnCalculTotalPrice);
            this.groupBox2.Controls.Add(this.txtProfitPrice);
            this.groupBox2.Controls.Add(this.txtFeePrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 68);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calcul price";
            // 
            // txtResultCalcul
            // 
            this.txtResultCalcul.Location = new System.Drawing.Point(363, 31);
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
            this.btnCalculTotalPrice.Location = new System.Drawing.Point(267, 23);
            this.btnCalculTotalPrice.Name = "btnCalculTotalPrice";
            this.btnCalculTotalPrice.Size = new System.Drawing.Size(90, 32);
            this.btnCalculTotalPrice.TabIndex = 10;
            this.btnCalculTotalPrice.Text = "Calcul:";
            this.btnCalculTotalPrice.UseVisualStyleBackColor = false;
            this.btnCalculTotalPrice.Click += new System.EventHandler(this.btnCalculTotalPrice_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(132, 29);
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
            this.txtProfitPrice.Location = new System.Drawing.Point(179, 31);
            this.txtProfitPrice.Name = "txtProfitPrice";
            this.txtProfitPrice.Size = new System.Drawing.Size(50, 23);
            this.txtProfitPrice.TabIndex = 9;
            this.txtProfitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfitPrice_KeyPress);
            // 
            // txtFeePrice
            // 
            this.txtFeePrice.Location = new System.Drawing.Point(54, 31);
            this.txtFeePrice.Name = "txtFeePrice";
            this.txtFeePrice.Size = new System.Drawing.Size(50, 23);
            this.txtFeePrice.TabIndex = 8;
            this.txtFeePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFeePrice_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescription);
            this.groupBox3.Location = new System.Drawing.Point(13, 420);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 229);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(7, 14);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(565, 209);
            this.txtDescription.TabIndex = 11;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(485, 22);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 35);
            this.buttonClear.TabIndex = 55;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // DesktopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DesktopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DesktopForm";
            this.Load += new System.EventHandler(this.DesktopForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBrandList;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.ComboBox comboModelList;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ComboBox comboCPUList;
        private System.Windows.Forms.Label labelComponent;
        private System.Windows.Forms.ComboBox comboSSDList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboHDDList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboRAMList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboNVIDIAList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNvidiaPrice;
        private System.Windows.Forms.TextBox txtRAMPrice;
        private System.Windows.Forms.TextBox txtHDDPrice;
        private System.Windows.Forms.TextBox txtSSDPrice;
        private System.Windows.Forms.TextBox txtCPUPrice;
        private System.Windows.Forms.TextBox txtModelPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResultCalcul;
        private System.Windows.Forms.Button btnCalculTotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProfitPrice;
        private System.Windows.Forms.TextBox txtFeePrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button buttonClear;
    }
}