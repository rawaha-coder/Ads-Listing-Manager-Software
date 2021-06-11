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
    public partial class AddModelForm : Form
    {
        BrandDAO brandDAO = BrandDAO.getInstance();
        ModelDAO modelDAO = ModelDAO.getInstance();
        Model mModel = new Model();
        List<Brand> listBrand = new List<Brand>();
        List<Model> listModel = new List<Model>();

        public AddModelForm()
        {
            InitializeComponent();
        }

        private void AddModelForm_Load(object sender, EventArgs e)
        {
            LoadBrandData();
        }

        private void LoadBrandData()
        {
            listBrand.Clear(); cmbxListBrand.Items.Clear();
            try
            {
                listBrand = brandDAO.GetData();
                getBrandList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getBrandList()
        {
            foreach (Brand item in listBrand)
            {
                cmbxListBrand.Items.Add(item.Name);
            }
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                MessageBox.Show("Model name required");
                return;
            }
            try
            {
                Model pc = new Model();
                pc.Name = txtModelName.Text.Trim().ToUpper();
                pc.Price = Convert.ToDouble(txtModelPrice.Text);
                pc.Description = txtModelDescription.Text;
                pc.Brand.Id = listBrand[cmbxListBrand.SelectedIndex].Id;
                modelDAO.addData(pc);
                MessageBox.Show("Model Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Model Not Saved: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private bool CheckInput()
        {
            return txtModelName.Text == "" || txtModelPrice.Text == "" || cmbxListBrand.SelectedIndex == -1;
        }

        private void btnUpdateModel_Click(object sender, EventArgs e)
        {
            if (txtModelName.Text == "" || txtModelPrice.Text == "" || cmbxListBrand.SelectedIndex == -1)
            {
                MessageBox.Show("Model name required");
                return;
            }
            try
            {
                mModel.Name = txtModelName.Text.Trim().ToUpper();
                mModel.Price = Convert.ToDouble(txtModelPrice.Text);
                mModel.Description = txtModelDescription.Text;
                mModel.Brand.Id = listBrand[cmbxListBrand.SelectedIndex].Id;
                modelDAO.UpdateData(mModel);
                MessageBox.Show("Model Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Model Not Updated: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnDeleteModel_Click(object sender, EventArgs e)
        {
            if (txtModelName.Text == "" || txtModelPrice.Text == "" || cmbxListBrand.SelectedIndex == -1)
            {
                MessageBox.Show("Model name required");
                return;
            }
            try
            {
                modelDAO.DeleteData(mModel);
                MessageBox.Show("Brand Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brand Not Deleted: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void boxListModel_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Model mdl = listModel[boxListModel.SelectedIndex];
                txtModelName.Text = mdl.Name;
                txtModelPrice.Text = mdl.Price.ToString();
                txtModelDescription.Text = mdl.Description; ;
                mModel.Id = mdl.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbxListBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbxListBrand.SelectedIndex != -1)
                LoadModelData();
        }

        private void LoadModelData()
        {
            listModel.Clear();
            boxListModel.Items.Clear();
            try
            {
                listModel = modelDAO.getModelsByBrandId(listBrand[cmbxListBrand.SelectedIndex].Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            foreach (Model item in listModel)
            {
                boxListModel.Items.Add(item.Name);
            }
        }

        private void ClearField()
        {
            txtModelName.Text = "";
            txtModelPrice.Text = "";
            txtModelDescription.Text = "";
            cmbxListBrand.SelectedIndex = -1;
            boxListModel.Items.Clear();
        }

        private void ValidateNumberEntred(object sender, KeyPressEventArgs e)
        {
            Utility.Utility.ValidateNumberEntred(sender, e);
        }
    }
}
