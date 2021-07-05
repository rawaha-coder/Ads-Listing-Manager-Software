using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
using Ads_Listing_Manager_Software.Utility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ads_Listing_Manager_Software.Views
{
    public partial class ItemForm : Form
    {
        private readonly ComponentDAO mComponentDAO;
        private readonly ItemDAO itemDAO;
        private Component mComponent;
        private Item mItem;
        private List<Component> listComponent;
        private List<Item> listItem;
        double mItemPrice;
        string mItemName;
        string mItemDescription;

        public ItemForm()
        {
            InitializeComponent();
            mComponentDAO = ComponentDAO.getInstance();
            itemDAO = ItemDAO.getInstance();
            mComponent = new Component();
            mItem = new Item();
            listComponent = new List<Component>();
            listItem = new List<Item>();
            mItemPrice = 0.0;
            mItemName = "";
            mItemDescription = "";
        }

        private void ItemForm_Load(object sender, EventArgs e)
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
            try
            {
                comboItemList.Items.Clear();
                comboItemList.Text = "";
                foreach (Item item in listItem)
                {
                    comboItemList.Items.Add(item.Name);
                }
            }
            catch(Exception ex)
            {
                Logging.ShowError(ex);
            }
        }

        private void comboItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboItemList.SelectedIndex != -1)
            {
                getItemPrice();
            }
        }

        private void getItemPrice()
        {
            mItem = listItem[comboItemList.SelectedIndex];
            txtItemPrice.Text = mItem.Price.ToString();
            mItemPrice = mItem.Price;
            mItemName = mItem.Name;
            mItemDescription = mItem.Description;
        }

        private void buttonCalculTotalPrice_Click(object sender, EventArgs e)
        {
            txtResultCalcul.Text = CalculTotalPay().ToString("0.00");
            GetArticle();
        }

        private double CalculTotalPay()
        {
            return mItemPrice + (mItemPrice * FeePercentage()) + (mItemPrice * ProfitPercentage());
        }

        private double FeePercentage()
        {
            double fee = (txtFeePrice.Text != "") ? Convert.ToDouble(txtFeePrice.Text) : 0;
            return fee / 100;
        }

        private double ProfitPercentage()
        {
            double profit = (txtProfitPrice.Text != "") ? Convert.ToDouble(txtProfitPrice.Text) : 0;
            return profit / 100;
        }

        private void GetArticle()
        {
            txtDescription.Clear();
            txtDescription.Text += "Item: " + mItemName + Environment.NewLine;
            txtDescription.Text += "Description: " + mItemDescription + Environment.NewLine;
        }

        private void ValidateNumberEntred(object sender, KeyPressEventArgs e)
        {
            Utility.Utility.ValidateNumberEntred(sender, e);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            comboComponentList.SelectedIndex = -1;
            comboComponentList.Text = "";
            comboItemList.SelectedIndex = -1;
            comboItemList.Text = "";
            txtItemPrice.Text = "0.0";
            txtFeePrice.Text = "";
            txtProfitPrice.Text = "";
            txtResultCalcul.Text = "0.0";
            txtDescription.Text = "";
            mItemPrice = 0;
            mItemName = "";
            mItemDescription = "";
        }
    }
}
