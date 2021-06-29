using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
using Ads_Listing_Manager_Software.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
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
        ItemDAO itemDAO = ItemDAO.getInstance();
        Model mModel = new Model();
        Component mComponent = new Component();
        Product mProduct = new Product();
        Item mItem = new Item();
        List<Brand> listBrand = new List<Brand>();
        List<Component> listComponent = new List<Component>();
        List<Model> listModel = new List<Model>();
        List<Product> listProduct = new List<Product>();
        List<Item> listItem = new List<Item>();
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

        private void comboListModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboModelList.SelectedIndex != -1)
            {
                mModel = listModel[comboModelList.SelectedIndex];
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
            viewListItems.Clear();
            viewListItems.Items.Clear();
            viewListItems.Columns.Add("Product", 500, HorizontalAlignment.Left);
            viewListItems.Columns.Add("Price", 100, HorizontalAlignment.Left);
            viewListItems.Columns.Add("Quantity", 80, HorizontalAlignment.Left);
            foreach (Product product in listProduct)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.Item.Name;
                lvi.SubItems.Add(product.Item.Price.ToString());
                lvi.SubItems.Add(product.Item.Quantity.ToString());
                viewListItems.Items.Add(lvi);
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

        private void comboListComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateItemList();
            updateListView();
        }

        private void updateListView()
        {
            if (comboComponentList.SelectedIndex != -1 && comboModelList.SelectedIndex != -1)
            {
                mComponent = listComponent[comboComponentList.SelectedIndex];
                mModel = listModel[comboModelList.SelectedIndex];
                LoadProductListByModelAndType();
            }
        }

        private void updateItemList()
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
                getItemsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getItemsList()
        {
            comboItemList.Items.Clear();
            ClearItemFields();
            foreach (Item item in listItem)
            {
                comboItemList.Items.Add(item.Name);
            }
        }

        private void LoadProductListByModelAndType()
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

        private void comboItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboComponentList.SelectedIndex != -1 && comboItemList.SelectedIndex != -1)
                {
                    mItem = listItem[comboItemList.SelectedIndex];
                    setProductFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void setProductFields()
        {
            txtProductCode.Text = mItem.Code;
            txtProductPrice.Text = mItem.Price.ToString();
            txtProductQuantity.Text = mItem.Quantity.ToString();
        }

        private void viewListProduct_DoubleClick(object sender, EventArgs e)
        {
            btnUpdateProduct.Enabled = true;
            btnDeleteProduct.Enabled = true;
            selectProductForUpdateOrDelete();
        }

        private void selectProductForUpdateOrDelete()
        {
                try
                {
                    if (viewListItems.SelectedItems.Count > 0)
                    {
                        mProduct = listProduct[viewListItems.Items.IndexOf(viewListItems.SelectedItems[0])];
                        comboItemList.Text = mProduct.Item.Name;
                        txtProductPrice.Text = mProduct.Item.Price.ToString();
                    }

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
                mProductDAO.DeleteData(mProduct.Id);
                ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brand Not Deleted: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void GetFieldsInput()
        {
            mProduct.Item.Id = listItem[comboItemList.SelectedIndex].Id;
            mProduct.Item.Name = comboItemList.Text;
            mProduct.Item.Price = Convert.ToDouble(txtProductPrice.Text);
            mProduct.Item.Quantity = Convert.ToInt32(txtProductQuantity.Text);
            mProduct.Model.Id = listModel[comboModelList.SelectedIndex].Id;
            mProduct.Type.Id = listComponent[comboComponentList.SelectedIndex].Id;
        }

        private bool InputIsNotValidate()
        {
            return comboItemList.SelectedIndex == -1 || comboModelList.SelectedIndex == -1 || comboComponentList.SelectedIndex == -1 || txtProductPrice.Text == "" || txtProductQuantity.Text == "";
        }

        private void ClearField()
        {
            ClearItemFields();
            comboModelList.SelectedIndex = -1;
            comboBrandList.Text = "";
            comboComponentList.SelectedIndex = -1;
            comboComponentList.Text = "";
            comboModelList.SelectedIndex = -1;
            comboModelList.Text = "";
            btnUpdateProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            if (viewListItems.Items.Count > 0)
                viewListItems.Items.Clear();
        }

        private void ClearItemFields()
        {
            comboItemList.SelectedIndex = -1;
            comboItemList.Text = "";
            txtProductCode.Text = "";
            txtProductPrice.Text = "";
            txtProductQuantity.Text = "";
        }

        private void ValidateNumberEntred(object sender, KeyPressEventArgs e)
        {
            Utility.Utility.ValidateNumberEntred(sender, e);
        }

        private void ValidateIntegerNumberEntred(object sender, KeyPressEventArgs e)
        {
            Utility.Utility.ValidateIntegerNumberEntred(sender, e);
        }
    }
}
