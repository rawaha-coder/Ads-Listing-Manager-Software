using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Component = Ads_Listing_Manager_Software.Models.Component;

namespace Ads_Listing_Manager_Software.Views
{
    public partial class FormAddItem : Form
    {
        ComponentDAO mComponentDAO = ComponentDAO.getInstance();
        ItemDAO itemDAO = ItemDAO.getInstance();
        Component mComponent = new Component();
        Item mItem = new Item();
        List<Component> listComponent = new List<Component>();
        List<Item> listItem = new List<Item>();
        public FormAddItem()
        {
            InitializeComponent();
        }

        private void FormAddItem_Load(object sender, EventArgs e)
        {
            LoadComponentList();
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
            listItem.Clear();
            try
            {
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
            viewListItems.Clear();
            viewListItems.Items.Clear();
            viewListItems.Columns.Add("CPU", 400, HorizontalAlignment.Left);
            viewListItems.Columns.Add("Code", 140, HorizontalAlignment.Left);
            viewListItems.Columns.Add("Price", 80, HorizontalAlignment.Left);
            viewListItems.Columns.Add("Quantity", 80, HorizontalAlignment.Left);
            foreach (Item item in listItem)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Name;
                lvi.SubItems.Add(item.Code);
                lvi.SubItems.Add(item.Price.ToString());
                lvi.SubItems.Add(item.Quantity.ToString());
                viewListItems.Items.Add(lvi);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (InputIsNotValidate())
            {
                MessageBox.Show(Utility.Utility.CHECK_INPUT_VALUE);
                return;
            }
            SaveItemData();
        }

        private bool InputIsNotValidate()
        {
            return txtItemName.Text == "" || txtItemPrice.Text == "" || comboComponentList.SelectedIndex == -1 || txtItemQuantity.Text == "";
        }

        private void SaveItemData()
        {
            try
            {
                GetFieldsInput();
                itemDAO.AddData(mItem);
                ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Utility.Utility.DATA_NOT_SAVED + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void GetFieldsInput()
        {
            mItem.Name = txtItemName.Text;
            mItem.Code = txtItemCode.Text;
            mItem.Price = Convert.ToDouble(txtItemPrice.Text);
            mItem.Quantity = Convert.ToInt32(txtItemQuantity.Text);
            mItem.Description = txtItemDescription.Text;
            mItem.Type = listComponent[comboComponentList.SelectedIndex].Id;
        }

        private void ClearField()
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

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (InputIsNotValidate())
            {
                MessageBox.Show("Model name required");
                return;
            }
            UpdateItemData();
        }
        private void UpdateItemData()
        {
            try
            {
                GetFieldsInput();
                itemDAO.UpdateData(mItem);
                ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewListItems_DoubleClick(object sender, EventArgs e)
        {
            selectItemForUpdateOrDelete();
        }
        private void selectItemForUpdateOrDelete()
        {

            if (viewListItems.SelectedItems.Count > 0)
            {
                try
                {
                    mItem = listItem[viewListItems.Items.IndexOf(viewListItems.SelectedItems[0])];
                    txtItemName.Text = mItem.Name;
                    txtItemCode.Text = mItem.Code;
                    txtItemPrice.Text = mItem.Price.ToString();
                    txtItemQuantity.Text = mItem.Quantity.ToString();
                    txtItemDescription.Text = mItem.Description; ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
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
                itemDAO.DeleteData(mItem);
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

        private void ValidateIntegerNumberEntred(object sender, KeyPressEventArgs e)
        {
            Utility.Utility.ValidateIntegerNumberEntred(sender, e);
        }
    }
}
