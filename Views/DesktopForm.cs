using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ads_Listing_Manager_Software.Views
{
    public partial class DesktopForm : Form
    {
        ProductDAO mProductDAO = ProductDAO.getInstance();
        BrandDAO mBrandDAO = BrandDAO.getInstance();
        ModelDAO mModelDAO = ModelDAO.getInstance();
        List<Brand> listBrand = new List<Brand>();
        List<Model> listModel = new List<Model>();
        List<Product> CPUList = new List<Product>();
        List<Product> SSDList = new List<Product>();
        List<Product> HDDList = new List<Product>();
        List<Product> RAMList = new List<Product>();
        List<Product> NVIDIAList = new List<Product>();

        double mModelPrice = 0.0;
        double mCPUPrice = 0.0;
        double mSSDPrice = 0.0;
        double mHDDPrice = 0.0;
        double mRAMPrice = 0.0;
        double mNVIDIAPrice = 0.0;

        string mModelName = "";
        string mCPUName = "";
        string mSSDName = "";
        string mHDDName = "";
        string mRAMName = "";
        string mNVIDIAName = "";

        public DesktopForm()
        {
            InitializeComponent();
        }

        private void DesktopForm_Load(object sender, EventArgs e)
        {
            initToZeroString();
            LoadBrandList();
        }

        private void initToZeroString()
        {
            txtModelPrice.Text = "0.0";
            txtCPUPrice.Text = "0.0";
            txtSSDPrice.Text = "0.0";
            txtHDDPrice.Text = "0.0";
            txtRAMPrice.Text = "0.0";
            txtNvidiaPrice.Text = "0.0";
            txtResultCalcul.Text = "0.0";
            txtFeePrice.Text = "";
            txtProfitPrice.Text = "";

            mModelName = "";
            mCPUName = "";
            mSSDName = "";
            mHDDName = "";
            mRAMName = "";
            mNVIDIAName = "";

        }

        private void LoadBrandList()
        {
            try
            {
                listBrand = mBrandDAO.GetData();
                getBrandList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getBrandList()
        {
            foreach (Brand item in listBrand)
            {
                comboBrandList.Items.Add(item.Name);
            }
        }
        private void comboBrandList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBrandList.SelectedIndex != -1)
                LoadModelList();
        }

        private void LoadModelList()
        {
            try
            {
                listModel.Clear();
                listModel = mModelDAO.getModelsByBrandId(listBrand[comboBrandList.SelectedIndex].Id);
                getModelList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getModelList()
        {
            comboModelList.Items.Clear();
            foreach (Model item in listModel)
            {
                comboModelList.Items.Add(item.Name);
            }
        }

        private void comboModelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboModelList.SelectedIndex != -1)
            {
                Model model = listModel[comboModelList.SelectedIndex];
                txtModelPrice.Text = model.Price.ToString();
                mModelPrice = model.Price;
                mModelName = model.Name;
                LoadProductList(ref CPUList, model.Id, 1, comboCPUList);
                LoadProductList(ref SSDList, model.Id, 2, comboSSDList);
                LoadProductList(ref HDDList, model.Id, 3, comboHDDList);
                LoadProductList(ref RAMList, model.Id, 4, comboRAMList);
                LoadProductList(ref NVIDIAList, model.Id, 5, comboNVIDIAList);
            }
        }

        private void LoadProductList(ref List<Product> list, int modelId, int ComponentId, ComboBox combo)
        {
            try
            {
                list.Clear();
                list = mProductDAO.getProductsByModelAndType(modelId, ComponentId);
                getProductList(list, combo);
            }
            catch (Exception ex)
            {
                Utility.Logging.ShowError(ex);
            }
        }

        private void getProductList(List<Product> list, ComboBox combo)
        {
            combo.Items.Clear();
            foreach (Product item in list)
            {
                combo.Items.Add(item.Item.Name);
            }
        }

        private void comboCPUList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCPUList.SelectedIndex != -1 && CPUList.Count > 0)
            {
                Product product = CPUList[comboCPUList.SelectedIndex];
                txtCPUPrice.Text = product.Item.Price.ToString();
                mCPUName = product.Item.Name;
                mCPUPrice = product.Item.Price;
            }
        }

        private void comboSSDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSSDList.SelectedIndex != -1 && SSDList.Count > 0)
            {
                Product product = SSDList[comboSSDList.SelectedIndex];
                txtSSDPrice.Text = product.Item.Price.ToString();
                mSSDName = product.Item.Name;
                mSSDPrice = product.Item.Price;
            }
        }

        private void comboHDDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboHDDList.SelectedIndex != -1 && HDDList.Count > 0)
            {
                Product product = HDDList[comboHDDList.SelectedIndex];
                txtHDDPrice.Text = product.Item.Price.ToString();
                mHDDName = product.Item.Name;
                mHDDPrice = product.Item.Price;
            }
        }

        private void comboRAMList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRAMList.SelectedIndex != -1 && RAMList.Count > 0)
            {
                Product product = RAMList[comboRAMList.SelectedIndex];
                txtRAMPrice.Text = product.Item.Price.ToString();
                mRAMName = product.Item.Name;
                mRAMPrice = product.Item.Price;
            }
        }

        private void comboNVIDIAList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNVIDIAList.SelectedIndex != -1 && NVIDIAList.Count > 0)
            {
                Product product = NVIDIAList[comboNVIDIAList.SelectedIndex];
                txtNvidiaPrice.Text = product.Item.Price.ToString();
                mNVIDIAName = product.Item.Name;
                mNVIDIAPrice = product.Item.Price;
            }
        }

        private void btnCalculTotalPrice_Click(object sender, EventArgs e)
        {
            var price = CalculTotalPay();
            txtResultCalcul.Text = price.ToString();
            GetArticle();
        }

        private double CalculTotalPay()
        {
            double total = 0.0;
            total = CalculTotalPrice() + (CalculTotalPrice() * FeePercentage()) + (CalculTotalPrice() * ProfitPercentage());
            return total;
        }

        private double CalculTotalPrice()
        {
            double CalculTotalPrice = mModelPrice + mCPUPrice + mSSDPrice + mHDDPrice + mRAMPrice + mNVIDIAPrice;
            return CalculTotalPrice;
        }

        private double FeePercentage()
        {
            double fee = (txtFeePrice.Text != "") ? Convert.ToDouble(txtFeePrice.Text) : 0;
            double feePercenage = fee / 100;
            return feePercenage;
        }

        private double ProfitPercentage()
        {
            double profit = (txtProfitPrice.Text != "") ? Convert.ToDouble(txtProfitPrice.Text) : 0;
            double feePercenage = profit / 100;
            return feePercenage;
        }

        private void GetArticle()
        {
            txtDescription.Clear();
            txtDescription.Text += "PC Model: " + mModelName + Environment.NewLine;
            txtDescription.Text += "CPU: " + mCPUName + Environment.NewLine;
            txtDescription.Text += "Memory: " + mRAMName + Environment.NewLine;
            txtDescription.Text += "Storage: " + mSSDName + " + " + mHDDName + Environment.NewLine;
            txtDescription.Text += "Video Card: " + mNVIDIAName + Environment.NewLine;
        }

        private void txtFeePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.Utility.ValidateNumberEntred(sender, e);
        }

        private void txtProfitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.Utility.ValidateNumberEntred(sender, e);
        }
    }
}
