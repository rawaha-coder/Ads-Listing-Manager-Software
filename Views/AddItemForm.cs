using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
using Ads_Listing_Manager_Software.Utility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Component = Ads_Listing_Manager_Software.Models.Component;

namespace Ads_Listing_Manager_Software.Views
{
    public partial class AddItemForm : Form
    {
        private readonly ComponentDAO mComponentDAO;
        private readonly ItemDAO itemDAO;
        private Component mComponent;
        private Item mItem;
        private List<Component> listComponent;
        private List<Item> listItem ;
        public AddItemForm()
        {
            InitializeComponent();
            mComponentDAO = ComponentDAO.getInstance();
            itemDAO = ItemDAO.getInstance();
            mComponent = new Component();
            mItem = new Item();
            listComponent = new List<Component>();
            listItem = new List<Item>();
        }

        private void FormAddItem_Load(object sender, EventArgs e)
        {
            LoadComponentList();
        }

        private void LoadComponentList()
        {
            try
            {
                listComponent.Clear();
                listComponent = mComponentDAO.SelectData();
                getComponentList();
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
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

        private void comboComponentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboComponentList.SelectedIndex != -1)
            {
                mComponent = listComponent[comboComponentList.SelectedIndex];
                mItem.Type = mComponent.Id;
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
                Logging.ShowError(ex);
            }
        }

        private void getItemsList()
        {
            viewListItems.Clear();
            viewListItems.Items.Clear();
            SetViewListItemColumns();
            foreach (Item item in listItem)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Name;
                lvi.SubItems.Add(item.Code);
                lvi.SubItems.Add(item.Price.ToString());
                lvi.SubItems.Add(item.Quantity.ToString());
                lvi.SubItems.Add(item.Description);
                viewListItems.Items.Add(lvi);
            }
        }

        private void SetViewListItemColumns()
        {
            viewListItems.Columns.Add("Name", 400, HorizontalAlignment.Left);
            viewListItems.Columns.Add("Code", 140, HorizontalAlignment.Left);
            viewListItems.Columns.Add("Price", 80, HorizontalAlignment.Left);
            viewListItems.Columns.Add("Quantity", 80, HorizontalAlignment.Left);
            viewListItems.Columns.Add("Description", 300, HorizontalAlignment.Left);
        }

        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            if (InputIsNotValidate())
            {
                MessageBox.Show("Check input value!");
                return;
            }
            SaveItemData();
            ClearInputFieldValue();
        }

        private bool InputIsNotValidate()
        {
            return txtItemName.Text == "" || txtItemCode.Text == "" || txtItemPrice.Text == "" || comboComponentList.SelectedIndex == -1 || txtItemQuantity.Text == "";
        }

        private void SaveItemData()
        {
            try
            {
                GetInputFieldValue();
                itemDAO.AddData(mItem);
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void GetInputFieldValue()
        {
            mItem.Name = txtItemName.Text;
            mItem.Code = txtItemCode.Text;
            mItem.Price = Convert.ToDouble(txtItemPrice.Text);
            mItem.Quantity = Convert.ToInt32(txtItemQuantity.Text);
            mItem.Description = txtItemDescription.Text;
            mItem.Type = listComponent[comboComponentList.SelectedIndex].Id;
        }

        private void ClearInputFieldValue()
        {
            txtItemName.Text = "";
            txtItemCode.Text = "";
            txtItemPrice.Text = "";
            txtItemQuantity.Text = "";
            txtItemDescription.Text = "";
            comboComponentList.SelectedIndex = -1;
            comboComponentList.Text = "";
            
            if (viewListItems.Items.Count > 0)
                viewListItems.Items.Clear();
        }

        private void viewListItems_DoubleClick(object sender, EventArgs e)
        {
            selectItemForUpdateOrDelete();
            EnableUpdateAndDeleteButton();
        }
        private void selectItemForUpdateOrDelete()
        {

            if (viewListItems.SelectedItems.Count > 0)
            {
                try
                {
                    mItem = listItem[viewListItems.Items.IndexOf(viewListItems.SelectedItems[0])];
                    SetInputFieldValue();
                }
                catch (Exception ex)
                {
                    Logging.ShowError(ex);
                }
            }
        }

        private void SetInputFieldValue()
        {
            txtItemName.Text = mItem.Name;
            txtItemCode.Text = mItem.Code;
            txtItemPrice.Text = mItem.Price.ToString();
            txtItemQuantity.Text = mItem.Quantity.ToString();
            txtItemDescription.Text = mItem.Description; ;
        }

        private void ButtonUpdateItem_Click(object sender, EventArgs e)
        {
            if (InputIsNotValidate() || mItem.Id <= 0)
            {
                MessageBox.Show("Check input value!");
                return;
            }
            UpdateItemData();
            ClearInputFieldValue();
            DisableUpdateAndDeleteButton();
        }
        private void UpdateItemData()
        {
            try
            {
                GetInputFieldValue();
                itemDAO.UpdateData(mItem);
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void ButtonDeleteItem_Click(object sender, EventArgs e)
        {
            if (InputIsNotValidate() || mItem.Id <= 0)
            {
                MessageBox.Show("Check input value!");
                return;
            }
            DeleteProductData();
            ClearInputFieldValue();
            DisableUpdateAndDeleteButton();
        }
        private void DeleteProductData()
        {
            try
            {
                itemDAO.DeleteData(mItem);
            }
            catch (Exception ex)
            {
                Logging.ShowError(ex);
            }
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
            ClearInputFieldValue();
            DisableUpdateAndDeleteButton();
        }

        private void DisableUpdateAndDeleteButton()
        {
            buttonAddItem.Enabled = true;
            buttonUpdateItem.Enabled = false;
            buttonDeleteItem.Enabled = false;
        }

        private void EnableUpdateAndDeleteButton()
        {
            buttonAddItem.Enabled = false;
            buttonUpdateItem.Enabled = true;
            buttonDeleteItem.Enabled = true;
        }
    }
}
