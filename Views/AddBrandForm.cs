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
                GetBrandData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void GetBrandData()
        {
            try
            {
                listItem.Clear();
                listItem = brandDAO.GetData();
                DisplayBrandInViewList();
            }
            catch(Exception ex)
            {
                Utility.Logging.ShowError(ex);
            }

        }

        private void DisplayBrandInViewList()
        {
            viewListBrand.Clear();
            viewListBrand.Items.Clear();
            LoadHeaderStyle();
            foreach (Brand item in listItem)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Name;
                lvi.SubItems.Add(item.Description);
                viewListBrand.Items.Add(lvi);
            }
        }

        private void LoadHeaderStyle()
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

        private void btnAddBrand_Click(object sender, EventArgs e)
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
                Brand brand = new Brand();
                brand.Name = txtBrand.Text.Trim().ToUpper();
                brand.Description = txtDescription.Text;
                brandDAO.AddData(brand);
                MessageBox.Show("Brand Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                ClearField();
                LoadBrandData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brand Not Saved: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void ClearField()
        {
            txtBrand.Text = "";
            txtDescription.Text = "";
            DisableUpdateAndDeleteButton();
        }

        private void btnUpdateBrand_Click(object sender, EventArgs e)
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
                mBrand.Name = txtBrand.Text.Trim().ToUpper();
                mBrand.Description = txtDescription.Text;
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

        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            if (CheckAbilityForDelete())
            {
                return;
            }
            DeleteBranddataFromDatabase();
        }

        private bool CheckAbilityForDelete()
        {
            return BrandHaveChildModel();
        }

        private bool BrandHaveChildModel()
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

        private void DeleteBranddataFromDatabase()
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
                MessageBox.Show("Brand Not Deleted: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void viewListBrand_DoubleClick(object sender, EventArgs e)
        {
            if (viewListBrand.SelectedItems.Count > 0)
                SelectBrandForUpdateOrDelete1();
        }

        private void SelectBrandForUpdateOrDelete1()
        {
            EnableUpdateAndDeleteButton();
            mBrand = listItem[viewListBrand.Items.IndexOf(viewListBrand.SelectedItems[0])];
            txtBrand.Text = mBrand.Name;
            txtDescription.Text = mBrand.Description; ;
        }

        private void EnableUpdateAndDeleteButton()
        {
            btnUpdateBrand.Enabled = true;
            btnDeleteBrand.Enabled = true;
        }

        private void DisableUpdateAndDeleteButton()
        {
            btnUpdateBrand.Enabled = false;
            btnDeleteBrand.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
    }
}
