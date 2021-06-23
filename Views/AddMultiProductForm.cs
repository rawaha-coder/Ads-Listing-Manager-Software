using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ads_Listing_Manager_Software.Views
{
    public partial class AddMultiProductForm : Form
    {
        BrandDAO brandDAO = BrandDAO.getInstance();
        ModelDAO modelDAO = ModelDAO.getInstance();
        ComponentDAO mComponentDAO = ComponentDAO.getInstance();
        ProductDAO productDAO = ProductDAO.getInstance();
        Model mModel = new Model();
        List<Brand> listBrand = new List<Brand>();
        List<Model> listModel = new List<Model>();
        List<Component> listComponent = new List<Component>();
        List<Product> listProduct = new List<Product>();

        public AddMultiProductForm()
        {
            InitializeComponent();
        }

        private void AddMultiProductForm_Load(object sender, EventArgs e)
        {
            LoadBrandList();
            LoadComponentList();
        }

        private void LoadBrandList()
        {
            try
            {
                listBrand = brandDAO.GetData();
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
                comboBrandList1.Items.Add(item.Name);
                comboBrandList2.Items.Add(item.Name);
                comboBrandList3.Items.Add(item.Name);
                comboBrandList4.Items.Add(item.Name);
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

        private void comboComponentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboComponentList.SelectedIndex != -1)
            {
                LoadProductList(listComponent[comboComponentList.SelectedIndex].Id);
            }
        }

        private void LoadProductList(int id)
        {
            listBoxProduct.Items.Clear(); listProduct.Clear();
            try
            {
                listProduct = productDAO.getProductsByType(id);
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
                listBoxProduct.Items.Add(item.Item.Name);
            }
        }

        private void comboBrandList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
