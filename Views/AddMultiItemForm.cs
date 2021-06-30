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
    public partial class AddMultiItemForm : Form
    {
        BrandDAO mBrandDAO = BrandDAO.getInstance();
        ModelDAO mModelDAO = ModelDAO.getInstance();
        ItemDAO mItemDAO = ItemDAO.getInstance();
        ProductDAO mProductDAO = ProductDAO.getInstance();
        List<Brand> listBrand = new List<Brand>();
        List<Model> listModel = new List<Model>();


        List<Item> CPUListItem = new List<Item>();
        List<Item> SSDListItem = new List<Item>();
        List<Item> HDDListItem = new List<Item>();
        List<Item> RAMListItem = new List<Item>();
        List<Item> NVIDIAListItem = new List<Item>();

        int ModelId = -1;
        List<int>[] listItemsId = new List<int>[6];


        public AddMultiItemForm()
        {
            InitializeComponent();
            initArray();
        }

        private void initArray()
        {
            for (int i = 0; i < listItemsId.Length; i++)
                listItemsId[i] = new List<int>();
        }

        private void AddMultiItemForm_Load(object sender, EventArgs e)
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
                ModelId = listModel[comboModelList.SelectedIndex].Id;
                LoadItemLists(ref CPUListItem, 1, listBoxCPU);
                LoadItemLists(ref SSDListItem, 2, listBoxSSD);
                LoadItemLists(ref HDDListItem, 3, listBoxHDD);
                LoadItemLists(ref RAMListItem, 4, listBoxRAM);
                LoadItemLists(ref NVIDIAListItem, 5, listBoxNVIDIA);
            }
        }

        private void LoadItemLists(ref List<Item> list, int ComponentId, ListBox lb)
        {
            try
            {
                list.Clear();
                list = mItemDAO.getItemsByType(ComponentId);
                getItemList(list, lb);
            }
            catch (Exception ex)
            {
                Utility.Logging.ShowError(ex);
            }
        }

        private void getItemList(List<Item> list, ListBox lb)
        {
            lb.Items.Clear();
            foreach (Item item in list)
            {
                lb.Items.Add(item.Name);
            }
        }

        private void btnAddMultiItem_Click(object sender, EventArgs e)
        {
            saveMultiProduct();
        }

        private void saveMultiProduct()
        {
            getSelectedItems();
            saveProduct();
        }

        private void saveProduct()
        {
            try
            {
                addToDatabase();
                MessageBox.Show("Done.");
            }
            catch (Exception ex)
            {
                Utility.Logging.ShowError(ex);
            }
        }

        private void addToDatabase()
        {
            if (ModelId != -1)
            {
                for (int i = 1; i < listItemsId.Length; i++)
                {
                    for (int j = 0;  j < listItemsId[i].Count; j++)
                    {
                        mProductDAO.AddProduct(ModelId, listItemsId[i][j], i);
                    }

                }
            }
        }

        private void getSelectedItems()
        {
            ListCPUndices();
            ListSSDIndices();
            ListHDDIndices();
            ListRAMIndices();
            ListNVIDIAIndices();
        }

        private void ListCPUndices()
        {
            if (listBoxCPU.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listBoxCPU.SelectedItems.Count; i++)
                {
                    listItemsId[1].Add(CPUListItem[listBoxCPU.SelectedIndices[i]].Id);
                }
            }
        }

        private void ListSSDIndices()
        {
            if (listBoxSSD.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listBoxSSD.SelectedItems.Count; i++)
                {
                    listItemsId[2].Add(SSDListItem[listBoxSSD.SelectedIndices[i]].Id);
                }
            }
        }

        private void ListHDDIndices()
        {
            if (listBoxHDD.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listBoxHDD.SelectedItems.Count; i++)
                {
                    listItemsId[3].Add(HDDListItem[listBoxHDD.SelectedIndices[i]].Id);
                }
            }
        }

        private void ListRAMIndices()
        {
            if (listBoxRAM.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listBoxRAM.SelectedItems.Count; i++)
                {
                    listItemsId[4].Add(RAMListItem[listBoxRAM.SelectedIndices[i]].Id);
                }
            }
        }

        private void ListNVIDIAIndices()
        {
            if (listBoxNVIDIA.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listBoxNVIDIA.SelectedItems.Count; i++)
                {
                    listItemsId[5].Add(NVIDIAListItem[listBoxNVIDIA.SelectedIndices[i]].Id);
                }
            }
        }

    }
}
