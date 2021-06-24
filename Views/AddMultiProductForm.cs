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
        Model mModel = new Model();
        Component mComponent = new Component();
        List<Brand> listBrand = new List<Brand>();
        List<Model>[] listModel = new List<Model>[4];
        List<Component> listComponent = new List<Component>();
        List<Item> listItem = new List<Item>();

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
            listComponent.Clear(); comboComponentList.Items.Clear();
            try
            {
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
            foreach (Component item in listComponent)
            {
                comboComponentList.Items.Add(item.Name);
            }
        }

        private void comboComponentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            getItemList();
        }

        private void getItemList()
        {
            if (comboComponentList.SelectedIndex != -1)
            {
                mComponent = listComponent[comboComponentList.SelectedIndex];
                LoadItemtList();
            }
        }

        private void LoadItemtList()
        {
            try
            {
                listItem.Clear();
                listItem = itemDAO.getItemsByType(mComponent.Id);
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


    }
}
