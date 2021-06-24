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
        ItemDAO itemDAO = ItemDAO.getInstance();
        ProductDAO productDAO = ProductDAO.getInstance();
        List<Brand> listBrand = new List<Brand>();
        List<Model>[] listModel = new List<Model>[4];
        List<Component> listComponent = new List<Component>();
        List<Item> listItem = new List<Item>();
        List<int> listModelsId = new List<int>();
        int selectedItemId = -1;
        int selectedComponentId = -1;

        public AddMultiProductForm()
        {
            InitializeComponent();
        }

        private void AddMultiProductForm_Load(object sender, EventArgs e)
        {
            initListModel();
            LoadBrandList();
            LoadComponentList();
        }

        private void initListModel()
        {
            for (int i = 0; i < listModel.Length; i++)
                listModel[i] = new List<Model>();
        }

        private void LoadBrandList()
        {
            try
            {
                listBrand = brandDAO.GetData();
                displayBrandList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayBrandList()
        {
            foreach (Brand item in listBrand)
            {
                brandComboList0.Items.Add(item.Name);
                brandComboList1.Items.Add(item.Name);
                brandComboList2.Items.Add(item.Name);
                brandComboList3.Items.Add(item.Name);
            }
        }

        private void LoadComponentList()
        {
            try
            {
                listComponent.Clear();
                listComponent = mComponentDAO.SelectData();
                displayComponentList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayComponentList()
        {
            comboComponentList.Items.Clear();
            foreach (Component item in listComponent)
            {
                comboComponentList.Items.Add(item.Name);
            }
        }

        private void comboComponentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboComponentList.SelectedIndex != -1)
                getItemList();
        }

        private void getItemList()
        {
                selectedComponentId = listComponent[comboComponentList.SelectedIndex].Id;
                LoadItemtList();
        }

        private void LoadItemtList()
        {
            try
            {
                listItem.Clear();
                listItem = itemDAO.getItemsByType(selectedComponentId);
                displayItemsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayItemsList()
        {
            listBoxItems.Items.Clear();
            foreach (Item item in listItem)
            {
                listBoxItems.Items.Add(item.Name);
            }
        }


        private void comboBrandList0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brandComboList0.SelectedIndex != -1)
            {
                int id = listBrand[brandComboList0.SelectedIndex].Id;
                displayModelList0(LoadModelList(0, id));
            }
                
        }
        private void brandComboList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brandComboList1.SelectedIndex != -1)
            {
                int id = listBrand[brandComboList1.SelectedIndex].Id;
                displayModelList1(LoadModelList(1, id));
            }
        }

        private void brandComboList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brandComboList2.SelectedIndex != -1)
            {
                int id = listBrand[brandComboList2.SelectedIndex].Id;
                displayModelList2(LoadModelList(2, id));
            }
        }

        private void brandComboList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brandComboList3.SelectedIndex != -1)
            {
                int id = listBrand[brandComboList3.SelectedIndex].Id;
                displayModelList3(LoadModelList(3, id));
            }
        }

        private List<Model> LoadModelList(int i, int id)
        {
            try
            {
                listModel[i].Clear();
                listModel[i] = modelDAO.getModelsByBrandId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listModel[i];
        }

        private void displayModelList0(List<Model> list)
        {
            modelList0.Items.Clear();
            foreach (Model model in list)
            {
                modelList0.Items.Add(model.Name);
            }
        }

        private void displayModelList1(List<Model> list)
        {
            modelList1.Items.Clear();
            foreach (Model model in list)
            {
                modelList1.Items.Add(model.Name);
            }
        }

        private void displayModelList2(List<Model> list)
        {
            modelList2.Items.Clear();
            foreach (Model model in list)
            {
                modelList2.Items.Add(model.Name);
            }
        }

        private void displayModelList3(List<Model> list)
        {
            modelList3.Items.Clear();
            foreach (Model model in list)
            {
                modelList3.Items.Add(model.Name);
            }
        }

        private void btnAddMultiProduct_Click(object sender, EventArgs e)
        {
            saveMultiProduct();
        }

        private void saveMultiProduct()
        {
            getSelectedModelsIndices();
            getSelectedItem();
            saveToDatabase();
        }

        private void saveToDatabase()
        {
            try
            {
                if (selectedComponentId != -1 && selectedItemId != -1)
                {
                    for (int i = 0; i < listModelsId.Count; i++)
                    {
                        productDAO.AddProduct(listModelsId[i], selectedItemId, selectedComponentId);
                    }
                }
            }
            catch(Exception ex)
            {
                Utility.Logging.LogError(ex);
            }

        }

        private void getSelectedItem()
        {
            if(listBoxItems.SelectedIndex != -1)
                selectedItemId = listItem[listBoxItems.SelectedIndex].Id;

        }

        private void getSelectedModelsIndices()
        {
            listModelsId.Clear();
            modelList0Indices();
            modelList1Indices();
            modelList2Indices();
            modelList3Indices();
        }

        private void modelList0Indices()
        {
            if (modelList0.SelectedItems.Count > 0)
            {
                for (int i = 0; i < modelList0.SelectedItems.Count; i++)
                {
                    listModelsId.Add(listModel[0][modelList0.SelectedIndices[i]].Id);
                }
            }
        }

        private void modelList1Indices()
        {
            if (modelList1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < modelList1.SelectedItems.Count; i++)
                {
                    listModelsId.Add(listModel[1][modelList1.SelectedIndices[i]].Id);
                }
            }
        }

        private void modelList2Indices()
        {
            if (modelList2.SelectedItems.Count > 0)
            {
                for (int i = 0; i < modelList2.SelectedItems.Count; i++)
                {
                    listModelsId.Add(listModel[2][modelList2.SelectedIndices[i]].Id);
                }
            }
        }

        private void modelList3Indices()
        {
            if (modelList3.SelectedItems.Count > 0)
            {
                for (int i = 0; i < modelList3.SelectedItems.Count; i++)
                {
                    listModelsId.Add(listModel[3][modelList3.SelectedIndices[i]].Id);
                }
            }
        }


    }
}
