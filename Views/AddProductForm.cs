using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
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
            try
            {
                listBrand.Clear();
                comboBrandList.Items.Clear();
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
                comboModelList.Items.Clear();
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

        private void LoadComponentList()
        {
            try
            {
                listComponent.Clear();
                comboComponentList.Items.Clear();
                listComponent = mComponentDAO.GetData();
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

        private void comboListModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            mModel = listModel[comboModelList.SelectedIndex];
        }

        private void comboListComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBrandList.SelectedIndex != -1 && comboBrandList.SelectedIndex != -1 && comboModelList.SelectedIndex != -1)
                LoadProductList();
            mComponent = listComponent[comboComponentList.SelectedIndex];
        }

        private void LoadProductList()
        {
            listProduct.Clear();
            boxListProduct.Items.Clear();
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

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (notValidate())
            {
                MessageBox.Show("Please check input!");
                return;
            }
            try
            {
                mProduct.Name = txtProductName.Text;
                mProduct.Price = Convert.ToDouble(txtProductPrice.Text);
                mProduct.Description = txtProductDescription.Text;
                mProduct.Model.Id = listModel[comboModelList.SelectedIndex].Id;
                mProduct.Type.Id = listComponent[comboComponentList.SelectedIndex].Id;
                mProductDAO.AddData(mProduct);
                MessageBox.Show("Product Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                //ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Model Not Saved: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void ClearField()
        {
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtProductDescription.Text = "";
            comboModelList.SelectedIndex = -1;
            comboComponentList.SelectedIndex = -1;
            boxListProduct.Items.Clear();
        }

        private bool notValidate()
        {
            return txtProductName.Text == "" || txtProductPrice.Text == "" || comboModelList.SelectedIndex == -1 || comboComponentList.SelectedIndex == -1 ;
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {

        }

        private void ValidateNumberEntred(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }




    }
}
