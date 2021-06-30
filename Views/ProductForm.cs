using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ads_Listing_Manager_Software.Views
{
    public partial class ProductForm : Form
    {
        BrandDAO mBrandDAO;
        ComponentDAO mComponentDAO;
        ModelDAO mModelDAO;
        ProductDAO mProductDAO;
        ItemDAO mItemDAO;
        Model mModel ;
        Component mComponent;
        Product mProduct;
        List<Brand> listBrand;
        List<Component> listComponent ;
        List<Model> listModel;
        List<Product> listProduct;
        List<Item> listItem;

        double mModelPrice;
        double mProductPrice;
        string mModelName;
        string mProductName;
        string mProductDescrition;

        public ProductForm()
        {
            InitializeComponent();
            mBrandDAO = BrandDAO.getInstance();
            mComponentDAO = ComponentDAO.getInstance();
            mModelDAO = ModelDAO.getInstance();
            mProductDAO = ProductDAO.getInstance();
            mItemDAO = ItemDAO.getInstance();
            mModel = new Model();
            mComponent = new Component();
            mProduct = new Product();
            listBrand = new List<Brand>();
            listComponent = new List<Component>();
            listModel = new List<Model>();
            listProduct = new List<Product>();
            listItem = new List<Item>();
        }

        private void panelProductForm_Paint(object sender, PaintEventArgs e)
        {
            initToZeroString();
            LoadBrandList();
            LoadComponentList();
        }

        private void initToZeroString()
        {
            txtModelPrice.Text = "0.0";
            txtProductPrice.Text = "0.0";
            txtResultCalcul.Text = "0.0";
            txtFeePrice.Text = "";
            txtProfitPrice.Text = "";
            mModelPrice = 0.0;
            mProductPrice = 0.0;
            mModelName = "";
            mProductName = "";
            mProductDescrition = "";
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
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
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
                mModel = listModel[comboModelList.SelectedIndex];
                txtModelPrice.Text = mModel.Price.ToString();
                mModelPrice = mModel.Price;
                mModelName = mModel.Name;
                LoadProductList();
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
                MessageBox.Show(ex.Message);
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
                GetNewProductList();
            }
        }

        private void GetNewProductList()
        {
            mComponent = listComponent[comboComponentList.SelectedIndex];
            comboProductList.SelectedIndex = -1;
            comboProductList.Text = "";
            txtProductPrice.Text = "0.0";
            updateProductList();
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
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearItemFields()
        {
            comboBrandList.SelectedIndex = -1;
            comboBrandList.Text = "";
            comboModelList.SelectedIndex = -1;
            comboModelList.Text = "";
            comboProductList.SelectedIndex = -1;
            comboProductList.Text = "";
            comboComponentList.SelectedIndex = -1;
            comboComponentList.Text = "";
            txtDescription.Text = "";
            txtFeePrice.Text = "";
            txtProfitPrice.Text = "";
            txtModelPrice.Text = "";
            txtProductPrice.Text = "";
            txtResultCalcul.Text = "";
            initToZeroString();
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
                    Utility.Logging.ShowError(ex);
                }

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
            double CalculTotalPrice = mModelPrice + mProductPrice;
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
            txtDescription.Text += "Model: " + mModelName + Environment.NewLine;
            txtDescription.Text += "Product: " + mProductName + Environment.NewLine;
            txtDescription.Text += "Description: " + mProductDescrition + Environment.NewLine;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearItemFields();
        }
    }
}
