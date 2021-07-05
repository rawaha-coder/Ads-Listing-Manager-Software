using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
using Ads_Listing_Manager_Software.Utility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ads_Listing_Manager_Software.Views
{
    public partial class ProductForm : Form
    {
        private readonly BrandDAO mBrandDAO;
        private readonly ComponentDAO mComponentDAO;
        private readonly ModelDAO mModelDAO;
        private readonly ProductDAO mProductDAO;
        private Model mModel ;
        private Component mComponent;
        private Product mProduct;
        private List<Brand> listBrand;
        private List<Component> listComponent ;
        private List<Model> listModel;
        private List<Product> listProduct;

        double mModelPrice, mProductPrice;
        string mModelName, mProductName, mProductDescrition;

        public ProductForm()
        {
            InitializeComponent();
            mBrandDAO = BrandDAO.getInstance();
            mComponentDAO = ComponentDAO.getInstance();
            mModelDAO = ModelDAO.getInstance();
            mProductDAO = ProductDAO.getInstance();
            mModel = new Model();
            mComponent = new Component();
            mProduct = new Product();
            listBrand = new List<Brand>();
            listComponent = new List<Component>();
            listModel = new List<Model>();
            listProduct = new List<Product>();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            SetTextViewToZero();
            SetVariablePriceToZero();
            SetVariableNameToEmpty();
            LoadBrandList();
            LoadComponentList();
        }

        private void SetVariableNameToEmpty()
        {
            mModelName = "";
            mProductName = "";
            mProductDescrition = "";
        }

        private void SetVariablePriceToZero()
        {
            mModelPrice = 0.0;
            mProductPrice = 0.0;
        }

        private void SetTextViewToZero()
        {
            txtModelPrice.Text = "0.0";
            txtProductPrice.Text = "0.0";
            txtResultCalcul.Text = "0.0";
            txtFeePrice.Text = "0";
            txtProfitPrice.Text = "0";
            txtDescription.Text = "";
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

        private void LoadComponentList()
        {
            listComponent.Clear();
            try
            {
                listComponent = mComponentDAO.SelectData();
                getComponentList();
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void getComponentList()
        {
            comboComponentList.Items.Clear();
            foreach (Component item in listComponent)
            {
                comboComponentList.Items.Add(item.Name);
            }
        }

        private void comboBrandList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBrandList.SelectedIndex != -1)
            {
                comboModelList.SelectedIndex = -1;
                comboModelList.Text = "";
                txtModelPrice.Text = "0.0";
                LoadModelList();
            }
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
                GetSelectedModel();
                LoadProductList();
            }
        }

        private void GetSelectedModel()
        {
            try
            {
                mModel = listModel[comboModelList.SelectedIndex];
                txtModelPrice.Text = mModel.Price.ToString();
                mModelPrice = mModel.Price;
                mModelName = mModel.Name;
            }
            catch(Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void LoadProductList()
        {
            try
            {
                listProduct.Clear();
                listProduct = mProductDAO.getProductsByModel(mModel.Id);
                displayProductList();
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void displayProductList()
        {
            comboProductList.Items.Clear();
            foreach (Product product in listProduct)
            {
                comboProductList.Items.Add(product.Item.Name);
            }
        }

        private void comboComponentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboComponentList.SelectedIndex != -1)
            {
                GetNewComponent();
                updateProductList();
            }
        }

        private void GetNewComponent()
        {
            try
            {
                mComponent = listComponent[comboComponentList.SelectedIndex];
                comboProductList.SelectedIndex = -1;
                comboProductList.Text = "";
                txtProductPrice.Text = "0.0";
            }
            catch(Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void updateProductList()
        {
            try
            {
                listProduct.Clear();
                listProduct = mProductDAO.getProductsByModelAndType(mModel.Id, mComponent.Id);
                displayProductList();
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void comboProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProductList.SelectedIndex != -1)
            {
                try
                {
                    mProduct = listProduct[comboProductList.SelectedIndex];
                    txtProductPrice.Text = mProduct.Item.Price.ToString();
                    mProductPrice = mProduct.Item.Price;
                    mProductName = mProduct.Item.Name;
                    mProductDescrition = mProduct.Item.Description;
                }
                catch(Exception ex)
                {
                    Logging.ShowError(ex);
                }
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
            return mModelPrice + mProductPrice;
        }

        private double FeePercentage()
        {
            double fee = (txtFeePrice.Text != "") ? Convert.ToDouble(txtFeePrice.Text) : 0;
            return fee / 100; ;
        }

        private double ProfitPercentage()
        {
            double profit = (txtProfitPrice.Text != "") ? Convert.ToDouble(txtProfitPrice.Text) : 0;
            return profit / 100;
        }

        private void GetArticle()
        {
            txtDescription.Clear();
            txtDescription.Text += "Model: " + mModelName + Environment.NewLine;
            txtDescription.Text += "Product: " + mProductName + Environment.NewLine;
            txtDescription.Text += "Description: " + mProductDescrition + Environment.NewLine;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearComboBox();
            SetTextViewToZero();
            SetVariablePriceToZero();
            SetVariableNameToEmpty();
        }

        private void ClearComboBox()
        {
            comboBrandList.SelectedIndex = -1;
            comboBrandList.Text = "";
            comboModelList.SelectedIndex = -1;
            comboModelList.Text = "";
            comboProductList.SelectedIndex = -1;
            comboProductList.Text = "";
            comboComponentList.SelectedIndex = -1;
            comboComponentList.Text = "";
        }
    }
}
