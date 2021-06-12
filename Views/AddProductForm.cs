using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
using Ads_Listing_Manager_Software.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Component = Ads_Listing_Manager_Software.Models.Component;

namespace Ads_Listing_Manager_Software.Views
{
    public partial class AddProductForm : Form
    {
        BrandDAO mBrandDAO = BrandDAO.getInstance();
        ComponentDAO mComponentDAO = ComponentDAO.getInstance();
        ModelDAO mModelDAO = ModelDAO.getInstance();
        ProductDAO mProductDAO = ProductDAO.getInstance();
        Model mModel = new Model();
        Component mComponent = new Component();
        Product mProduct = new Product();
        
        List<Brand> listBrand = new List<Brand>();
        List<Component> listComponent = new List<Component>();
        List<Model> listModel = new List<Model>();
        List<Product> listProduct = new List<Product>();

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            LoadBrandList();
            LoadComponentList();
        }

        private void LoadBrandList()
        {
            comboBrandList.Items.Clear(); listBrand.Clear();
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

        private void LoadComponentList()
        {
            listComponent.Clear(); comboComponentList.Items.Clear();
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
            foreach (Component item in listComponent)
            {
                comboComponentList.Items.Add(item.Name);
            }
        }

        private void comboBrandList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBrandList.SelectedIndex != -1)
                LoadModelList();
        }

        private void LoadModelList()
        {
            comboModelList.Items.Clear(); listModel.Clear();
            try
            {
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
            foreach (Model item in listModel)
            {
                comboModelList.Items.Add(item.Name);
            }
        }

        private void comboListModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboModelList.SelectedIndex != -1)
            {
                mModel = listModel[comboModelList.SelectedIndex];
                mProduct.Model.Id = mModel.Id;
            }
        }

        private void comboListComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBrandList.SelectedIndex != -1 && comboModelList.SelectedIndex != -1 && comboComponentList.SelectedIndex != -1)
            {
                mComponent = listComponent[comboComponentList.SelectedIndex];
                mProduct.Type.Id = mComponent.Id;
                LoadProductList();
            }
        }

        private void LoadProductList()
        {
            boxListProduct.Items.Clear(); listProduct.Clear();
            try
            {
                listProduct = mProductDAO.getProductsByModelComponentId(mModel.Id, mComponent.Id);
                getProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getProductList()
        {
            foreach (Product item in listProduct)
            {
                boxListProduct.Items.Add(item.Name);
            }
        }

        private void boxListProduct_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                mProduct = listProduct[boxListProduct.SelectedIndex];
                txtProductName.Text = mProduct.Name;
                txtProductPrice.Text = mProduct.Price.ToString();
                txtProductDescription.Text = mProduct.Description; ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (InputIsNotValidate())
            {
                MessageBox.Show(Utility.Utility.CHECK_INPUT_VALUE);
                return;
            }
            SaveProductData();
        }

        private void SaveProductData()
        {
            try
            {
                GetFieldsInput();
                mProductDAO.AddData(mProduct);
                ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Utility.Utility.DATA_NOT_SAVED + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void GetFieldsInput()
        {
            mProduct.Name = txtProductName.Text;
            mProduct.Price = Convert.ToDouble(txtProductPrice.Text);
            mProduct.Description = txtProductDescription.Text;
            mProduct.Model.Id = listModel[comboModelList.SelectedIndex].Id;
            mProduct.Type.Id = listComponent[comboComponentList.SelectedIndex].Id;
        }

        private bool InputIsNotValidate()
        {
            return txtProductName.Text == "" || txtProductPrice.Text == "" || comboModelList.SelectedIndex == -1 || comboComponentList.SelectedIndex == -1;
        }

        private void ClearField()
        {
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtProductDescription.Text = "";
            comboModelList.SelectedIndex = -1;
            comboBrandList.Text = "";
            comboComponentList.SelectedIndex = -1;
            comboComponentList.Text = "";
            comboModelList.SelectedIndex = -1;
            comboModelList.Text = "";
            if(boxListProduct.Items.Count > 0)
                boxListProduct.Items.Clear();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (InputIsNotValidate())
            {
                MessageBox.Show("Model name required");
                return;
            }
            UpdateProductData();
        }

        private void UpdateProductData()
        {
            try
            {
                GetFieldsInput();
                mProductDAO.UpdateData(mProduct);
                ClearField();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (InputIsNotValidate())
            {
                MessageBox.Show("Model name required");
                return;
            }
            DeleteProductData();
        }

        private void DeleteProductData()
        {
            try
            {
                mProductDAO.DeleteData(mProduct);
                ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brand Not Deleted: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void ValidateNumberEntred(object sender, KeyPressEventArgs e)
        {
            Utility.Utility.ValidateNumberEntred(sender, e);
        }
    }
}
