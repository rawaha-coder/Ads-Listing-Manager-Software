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

        public DesktopForm()
        {
            InitializeComponent();
        }

        private void DesktopForm_Load(object sender, EventArgs e)
        {
            LoadBrandList();
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
                int modelId = listModel[comboModelList.SelectedIndex].Id;
                LoadProductList(CPUList, modelId, 1, comboCPUList);
                LoadProductList(SSDList, modelId, 2, comboSSDList);
                LoadProductList(HDDList, modelId, 3, comboHDDList);
                LoadProductList(RAMList, modelId, 4, comboRAM);
                LoadProductList(NVIDIAList, modelId, 5, comboNVIDIAList);
            }
        }

        private void LoadProductList(List<Product> list, int modelId, int ComponentId, ComboBox combo)
        {
            try
            {
                list.Clear();
                list = mProductDAO.getProductsByModelComponentId(modelId, ComponentId);
                getProductList(list, combo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getProductList(List<Product> list, ComboBox combo)
        {
            combo.Items.Clear();
            foreach (Product item in list)
            {
                combo.Items.Add(item.Name);
            }
        }

    }
}
