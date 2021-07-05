using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
using Ads_Listing_Manager_Software.Utility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ads_Listing_Manager_Software.Views
{
    public partial class DesktopForm : Form
    {
        private readonly ProductDAO mProductDAO;
        private readonly BrandDAO mBrandDAO;
        private readonly ModelDAO mModelDAO;
        private List<Brand> listBrand;
        private List<Model> listModel;
        private List<Product> CPUList;
        private List<Product> SSDList;
        private List<Product> HDDList;
        private List<Product> RAMList;
        private List<Product> NVIDIAList;

        double mModelPrice, mCPUPrice, mSSDPrice, mHDDPrice, mRAMPrice, mNVIDIAPrice;

        string mModelName, mCPUName, mSSDName, mHDDName, mRAMName, mNVIDIAName;

        public DesktopForm()
        {
            InitializeComponent();
            mProductDAO = ProductDAO.getInstance();
            mBrandDAO = BrandDAO.getInstance();
            mModelDAO = ModelDAO.getInstance();
            InitProductLists();
            SetTextViewToZero();
            setVariableNameToEmpty();
            SetVariablePriceToZero();
        }

        private void InitProductLists()
        {
            listBrand = new List<Brand>();
            listModel = new List<Model>();
            CPUList = new List<Product>();
            SSDList = new List<Product>();
            HDDList = new List<Product>();
            RAMList = new List<Product>();
            NVIDIAList = new List<Product>();
        }

        private void SetTextViewToZero()
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
            txtDescription.Text = "";
        }

        private void setVariableNameToEmpty()
        {
            mModelName = "";
            mCPUName = "";
            mSSDName = "";
            mHDDName = "";
            mRAMName = "";
            mNVIDIAName = "";
        }

        private void SetVariablePriceToZero()
        {
            mModelPrice = 0.0;
            mCPUPrice = 0.0;
            mSSDPrice = 0.0;
            mHDDPrice = 0.0;
            mRAMPrice = 0.0;
            mNVIDIAPrice = 0.0;
        }

        private void DesktopForm_Load(object sender, EventArgs e)
        {
            LoadBrandList();
        }

        private void LoadBrandList()
        {
            try
            {
                listBrand.Clear();
                listBrand = mBrandDAO.GetData();
                getBrandList();
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void getBrandList()
        {
            comboBrandList.Items.Clear();
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
                Logging.ShowError(ex);
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
                LoadProductList(ref CPUList, model.Id, Constant.CPU_INDEX, comboCPUList);
                LoadProductList(ref SSDList, model.Id, Constant.SDD_INDEX, comboSSDList);
                LoadProductList(ref HDDList, model.Id, Constant.HDD_INDEX, comboHDDList);
                LoadProductList(ref RAMList, model.Id, Constant.RAM_INDEX, comboRAMList);
                LoadProductList(ref NVIDIAList, model.Id, Constant.NVIDIA_INDEX, comboNVIDIAList);
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
                Logging.ShowError(ex);
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

        private void ButtonCalculTotalPrice_Click(object sender, EventArgs e)
        {
            txtResultCalcul.Text = CalculTotalPay().ToString("0.00");
            GetArticle();
        }

        private double CalculTotalPay()
        {
            return CalculTotalPrice() + (CalculTotalPrice() * FeePercentage()) + (CalculTotalPrice() * ProfitPercentage());
        }

        private double CalculTotalPrice()
        {
            return mModelPrice + mCPUPrice + mSSDPrice + mHDDPrice + mRAMPrice + mNVIDIAPrice;
        }

        private double FeePercentage()
        {
            double fee = (txtFeePrice.Text != "") ? Convert.ToDouble(txtFeePrice.Text) : 0;
            return fee / 100;
        }

        private double ProfitPercentage()
        {
            double profit = (txtProfitPrice.Text != "") ? Convert.ToDouble(txtProfitPrice.Text) : 0;
            return profit / 100;
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            SetTextViewToZero();
            setVariableNameToEmpty();
            SetVariablePriceToZero();
            ClearComboBox();
        }

        private void ClearComboBox()
        {
            comboBrandList.SelectedIndex = -1;
            comboBrandList.Text = "";
            comboModelList.SelectedIndex = -1;
            comboModelList.Text = "";
            comboCPUList.SelectedIndex = -1;
            comboCPUList.Text = "";
            comboSSDList.SelectedIndex = -1;
            comboSSDList.Text = "";
            comboHDDList.SelectedIndex = -1;
            comboHDDList.Text = "";
            comboRAMList.SelectedIndex = -1;
            comboRAMList.Text = "";
            comboNVIDIAList.SelectedIndex = -1;
            comboNVIDIAList.Text = "";
        }
    }
}
