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
        BrandDAO brandDAO = BrandDAO.getInstance();
        List<Brand> listItem = new List<Brand>();
        Brand mBrand = new Brand();
        public AddBrandForm()
        {
            InitializeComponent();
            LoadBrandData();
        }

        private void LoadBrandData()
        {
            listItem.Clear();
            boxListBrand.Items.Clear();
            try
            {
                listItem = brandDAO.GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            foreach (Brand item in listItem)
            {
                boxListBrand.Items.Add(item.Name);
            }
        }

        private void ClearField()
        {
            txtBrand.Text = "";
            txtDescription.Text = "";
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            if(txtBrand.Text == "")
            {
                MessageBox.Show("Brand name required");
                return;
            }
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

        private void boxListBrand_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtBrand.Text = listItem[boxListBrand.SelectedIndex].Name;
                txtDescription.Text = listItem[boxListBrand.SelectedIndex].Description; ;
                mBrand.Id = listItem[boxListBrand.SelectedIndex].Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateBrand_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text == "")
            {
                MessageBox.Show("Brand name required");
                return;
            }
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
            if (mBrand.Id <= 0)
            {
                MessageBox.Show("Brand name required");
                return;
            }
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
    }
}
