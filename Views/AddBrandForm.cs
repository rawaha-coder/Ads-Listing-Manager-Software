using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ads_Listing_Manager_Software.Views
{
    public partial class AddBrandForm : Form
    {
        BrandDAO brandDAO;
        List<Brand> listItem;
        Brand mBrand;
        public AddBrandForm()
        {
            InitializeComponent();
            brandDAO = BrandDAO.getInstance();
            listItem = new List<Brand>();
            mBrand = new Brand();
        }

        private void AddBrandForm_Load(object sender, EventArgs e)
        {
            LoadBrandData();
        }

        private void LoadBrandData()
        {
            try
            {
                listItem.Clear();
                listItem = brandDAO.GetData();
                DisplayBrandDataInViewList();
            }
            catch (Exception ex)
            {
                Utility.Logging.ShowError(ex);
            }
        }

        private void DisplayBrandDataInViewList()
        {
            viewListBrand.Clear();
            viewListBrand.Items.Clear();
            SetHeaderStyle();
            foreach (Brand item in listItem)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Name;
                lvi.SubItems.Add(item.Description);
                viewListBrand.Items.Add(lvi);
            }
        }

        private void SetHeaderStyle()
        {
            ColumnHeader brandName, brandDescription;
            brandName = new ColumnHeader();
            brandDescription = new ColumnHeader();
            brandName.Text = "Name";
            brandName.TextAlign = HorizontalAlignment.Left;
            brandName.Width = 160;
            brandDescription.TextAlign = HorizontalAlignment.Left;
            brandDescription.Text = "Description";
            brandDescription.Width = 400;
            viewListBrand.Columns.Add(brandName);
            viewListBrand.Columns.Add(brandDescription);
        }

        private void ButtonAddBrand_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text == "")
            {
                MessageBox.Show("Brand name required");
                return;
            }
            AddBrandDataToDatabase();
        }

        private void AddBrandDataToDatabase()
        {
            try
            {
                GetFieldsValues();
                brandDAO.AddData(mBrand);
                MessageBox.Show("Brand Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                ClearField();
                LoadBrandData();
            }
            catch (Exception ex)
            {
                Utility.Logging.ShowError(ex);
            }
        }

        private void GetFieldsValues()
        {
            mBrand.Name = txtBrand.Text.Trim().ToUpper();
            mBrand.Description = txtDescription.Text;
        }

        private void ClearField()
        {
            txtBrand.Text = "";
            txtDescription.Text = "";
            DisableUpdateAndDeleteButton();
        }

        private void ButtonUpdateBrand_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text == "")
            {
                MessageBox.Show("Brand name required");
                return;
            }
            UpdateBrandDataInDatabase();
        }

        private void UpdateBrandDataInDatabase()
        {
            try
            {
                GetFieldsValues();
                brandDAO.UpdateData(mBrand);
                MessageBox.Show("Brand Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                ClearField();
                LoadBrandData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brand Not Updated: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void ButtonDeleteBrand_Click(object sender, EventArgs e)
        {
            if (CheckAbilityForDelete())
            {
                return;
            }
            DeleteBrandDataFromDatabase();
        }

        private bool CheckAbilityForDelete()
        {
            bool haveModel = true;
            if (mBrand.Id > 0 && txtBrand.Text != "")
            {
                try
                {
                    ModelDAO modelDAO = ModelDAO.getInstance();
                    haveModel = modelDAO.ModelsCount(mBrand.Id) > 0;
                    if(haveModel)
                        MessageBox.Show("Brand has models, Please delete models first");
                }
                catch(Exception ex)
                {
                    Utility.Logging.ShowError(ex);
                }
            }
            else
            {
                MessageBox.Show("Select brand to delete");
            }
            return haveModel;
        }

        private void DeleteBrandDataFromDatabase()
        {
            try
            {
                brandDAO.DeleteData(mBrand);
                MessageBox.Show("Brand Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                ClearField();
                LoadBrandData();
            }
            catch (Exception ex)
            {
                Utility.Logging.ShowError(ex);
            }
        }

        private void viewListBrand_DoubleClick(object sender, EventArgs e)
        {
            if (viewListBrand.SelectedItems.Count > 0)
                SelectBrandForUpdateOrDelete();
        }

        private void SelectBrandForUpdateOrDelete()
        {
            EnableUpdateAndDeleteButton();
            mBrand = listItem[viewListBrand.Items.IndexOf(viewListBrand.SelectedItems[0])];
            txtBrand.Text = mBrand.Name;
            txtDescription.Text = mBrand.Description; ;
        }

        private void EnableUpdateAndDeleteButton()
        {
            buttonAddBrand.Enabled = false;
            buttonUpdateBrand.Enabled = true;
            buttonDeleteBrand.Enabled = true;
        }

        private void DisableUpdateAndDeleteButton()
        {
            buttonAddBrand.Enabled = true;
            buttonUpdateBrand.Enabled = false;
            buttonDeleteBrand.Enabled = false;
        }

        private void ButtonClearFields_Click(object sender, EventArgs e)
        {
            ClearField();
        }
    }
}
