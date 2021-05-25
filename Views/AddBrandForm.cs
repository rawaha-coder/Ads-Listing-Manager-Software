using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Model;
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
            Load_Data();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                brand.Name = txtBrand.Text;
                brand.Description = txtDescription.Text;
                brandDAO.addData(brand);
                MessageBox.Show("Brand Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                ClearField();
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brand Not Saved: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void Load_Data()
        {
            listItem.Clear();
            try
            {
                listItem = brandDAO.getData();
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

        private void boxListBrand_DoubleClick(object sender, EventArgs e)
        {
            txtBrand.Text = listItem[boxListBrand.SelectedIndex].Name;
            txtDescription.Text = listItem[boxListBrand.SelectedIndex].Description; ;
            mBrand.Id = listItem[boxListBrand.SelectedIndex].Id;
        }
    }
}
