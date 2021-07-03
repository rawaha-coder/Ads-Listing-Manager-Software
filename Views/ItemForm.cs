using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ads_Listing_Manager_Software.Views
{
    public partial class ItemForm : Form
    {
        ComponentDAO mComponentDAO = ComponentDAO.getInstance();
        ItemDAO itemDAO = ItemDAO.getInstance();
        Component mComponent = new Component();
        Item mItem = new Item();
        List<Component> listComponent = new List<Component>();
        List<Item> listItem = new List<Item>();

        double mItemPrice = 0.0;
        string mItemName = "";
        string mItemDescription = "";

        public ItemForm()
        {
            InitializeComponent();
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
                Utility.Logging.ShowError(ex);
            }
        }

        private void comboItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboItemList.SelectedIndex != -1)
            {
                mItem = listItem[comboItemList.SelectedIndex];
                txtItemPrice.Text = mItem.Price.ToString();
                mItemPrice = mItem.Price;
                mItemName = mItem.Name;
                mItemDescription = mItem.Description;
            }
        }

        private void btnCalculTotalPrice_Click(object sender, EventArgs e)
        {
            var price = CalculTotalPay();
            txtResultCalcul.Text = price.ToString();
            GetArticle();
        }

        private double CalculTotalPay()
        {
            double total = 0.0;
            total = mItemPrice + (mItemPrice * FeePercentage()) + (mItemPrice * ProfitPercentage());
            return total;
        }

        private double FeePercentage()
        {
            double fee = (txtFeePrice.Text != "") ? Convert.ToDouble(txtFeePrice.Text) : 0;
            double feePercenage = fee / 100;
            return feePercenage;
        }

        private double ProfitPercentage()
        {
            double profit = (txtProfitPrice.Text != "") ? Convert.ToDouble(txtProfitPrice.Text) : 0;
            double feePercenage = profit / 100;
            return feePercenage;
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

        }
    }
}
