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
        private readonly BrandDAO mBrandDAO;
        private readonly ComponentDAO mComponentDAO;
        private readonly ModelDAO mModelDAO;
        private readonly ProductDAO mProductDAO;
        private readonly ItemDAO itemDAO;
        private Model mModel;
        private Component mComponent;
        private Product mProduct;
        private Item mItem;
        private List<Brand> listBrand;
        private List<Component> listComponent;
        private List<Model> listModel;
        private List<Product> listProduct;
        private List<Item> listItem;
        public AddProductForm()
        {
            InitializeComponent();
            mBrandDAO = BrandDAO.getInstance();
            mComponentDAO = ComponentDAO.getInstance();
            mModelDAO = ModelDAO.getInstance();
            mProductDAO = ProductDAO.getInstance();
            itemDAO = ItemDAO.getInstance();
            mModel = new Model();
            mComponent = new Component();
            mProduct = new Product();
            mItem = new Item();
            listBrand = new List<Brand>();
            listComponent = new List<Component>();
            listModel = new List<Model>();
            listProduct = new List<Product>();
            listItem = new List<Item>();
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
                SetBrandListInComboBox();
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void SetBrandListInComboBox()
        {
            comboBrandList.Items.Clear();
            foreach (Brand item in listBrand)
            {
                comboBrandList.Items.Add(item.Name);
            }
        }

        private void LoadComponentList()
        {
            try
            {
                listComponent.Clear();
                listComponent = mComponentDAO.SelectData();
                SetComponentListInComboBox();
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void SetComponentListInComboBox()
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
                LoadModelList();
        }

        private void LoadModelList()
        {
            try
            {
                listModel.Clear();
                listModel = mModelDAO.getModelsByBrandId(listBrand[comboBrandList.SelectedIndex].Id);
                SetModelListInComboBox();
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void SetModelListInComboBox()
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
                SetProductListInViewList();
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void SetProductListInViewList()
        {
            viewListItems.Clear();
            viewListItems.Items.Clear();
            SetViewListColumns();
            foreach (Product product in listProduct)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.Item.Name;
                lvi.SubItems.Add(product.Item.Price.ToString());
                lvi.SubItems.Add(product.Item.Quantity.ToString());
                viewListItems.Items.Add(lvi);
            }
        }

        private void SetViewListColumns()
        {
            viewListItems.Columns.Add("Product", 400, HorizontalAlignment.Left);
            viewListItems.Columns.Add("Price", 100, HorizontalAlignment.Left);
            viewListItems.Columns.Add("Quantity", 80, HorizontalAlignment.Left);
        }

        private void comboListComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListItem();
            UpdateViewList();
        }

        private void LoadListItem()
        {
            if (comboComponentList.SelectedIndex != -1)
            {
                mComponent = listComponent[comboComponentList.SelectedIndex];
                GetItemtList();
            }
        }

        private void GetItemtList()
        {
            try
            {
                listItem.Clear();
                listItem = itemDAO.getItemsByType(mComponent.Id);
                SetListItemInComboBox();
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void SetListItemInComboBox()
        {
            comboItemList.Items.Clear();
            ClearItemFields();
            foreach (Item item in listItem)
            {
                comboItemList.Items.Add(item.Name);
            }
        }

        private void UpdateViewList()
        {
            if (comboComponentList.SelectedIndex != -1 && comboModelList.SelectedIndex != -1)
            {
                mComponent = listComponent[comboComponentList.SelectedIndex];
                mModel = listModel[comboModelList.SelectedIndex];
                LoadProductListByModelAndType();
            }
        }

        private void LoadProductListByModelAndType()
        {
            try
            {
                listProduct.Clear();
                listProduct = mProductDAO.getProductsByModelAndType(mModel.Id, mComponent.Id);
                SetProductListInViewList();
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
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
                Logging.ShowError(ex);
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
            if (viewListItems.SelectedItems.Count > 0)
            {
                selectProductForUpdateOrDelete();
                EnableDeleteButton();
            }
        }

        private void selectProductForUpdateOrDelete()
        {
            try
            {
                mProduct = listProduct[viewListItems.Items.IndexOf(viewListItems.SelectedItems[0])];
                comboItemList.Text = mProduct.Item.Name;
                txtProductPrice.Text = mProduct.Item.Price.ToString();
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            if (InputIsNotValidate())
            {
                MessageBox.Show("Check input values");
                return;
            }
            SaveProductData();
        }

        private bool InputIsNotValidate()
        {
            return comboItemList.SelectedIndex == -1 || comboModelList.SelectedIndex == -1 || comboComponentList.SelectedIndex == -1 || txtProductPrice.Text == "" || txtProductQuantity.Text == "";
        }

        private void SaveProductData()
        {
            try
            {
                GetInputFieldValue();
                mProductDAO.AddData(mProduct);
                ClearField();
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void GetInputFieldValue()
        {
            mProduct.Item.Id = listItem[comboItemList.SelectedIndex].Id;
            mProduct.Item.Name = comboItemList.Text;
            mProduct.Item.Price = Convert.ToDouble(txtProductPrice.Text);
            mProduct.Item.Quantity = Convert.ToInt32(txtProductQuantity.Text);
            mProduct.Model.Id = listModel[comboModelList.SelectedIndex].Id;
            mProduct.Type.Id = listComponent[comboComponentList.SelectedIndex].Id;
        }

        private void ButtonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (InputIsNotValidate())
            {
                MessageBox.Show("Check input values");
                return;
            }
            DeleteProductData();
            ClearField();
            DisableDeleteButton();
        }

        private void DeleteProductData()
        {
            try
            {
                mProductDAO.DeleteData(mProduct.Id);
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void ClearField()
        {
            ClearItemFields();
            comboBrandList.SelectedIndex = -1;
            comboBrandList.Text = "";
            comboComponentList.SelectedIndex = -1;
            comboComponentList.Text = "";
            comboModelList.SelectedIndex = -1;
            comboModelList.Text = "";
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

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            ClearField();
            DisableDeleteButton();
        }

        private void DisableDeleteButton()
        {
            buttonDeleteProduct.Enabled = false;
            buttonAddProduct.Enabled = true;
            comboBrandList.Enabled = true;
            comboModelList.Enabled = true;
            comboComponentList.Enabled = true;
            comboItemList.Enabled = true;
        }

        private void EnableDeleteButton()
        {
            buttonDeleteProduct.Enabled = true;
            buttonAddProduct.Enabled = false;
            comboBrandList.Enabled = false;
            comboModelList.Enabled = false;
            comboComponentList.Enabled = false;
            comboItemList.Enabled = false;
        }
    }
}
