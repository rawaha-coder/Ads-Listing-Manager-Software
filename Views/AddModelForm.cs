using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
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
            ClearField();
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

        private void ClearField()
        {
            txtModelName.Text = "";
            txtModelPrice.Text = "";
            txtModelDescription.Text = "";
            boxListModel.Items.Clear();
            comboListBrand.Items.Clear();
            comboListBrand.SelectedIndex = -1;
            comboListBrand.Text = "";
            listBrand.Clear();
        }

        private void getBrandList()
        {
            foreach (Brand item in listBrand)
            {
                comboListBrand.Items.Add(item.Name);
            }
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            if (InputIsNotValide())
            {
                MessageBox.Show(Utility.Utility.CHECK_INPUT_VALUE);
                return;
            }
            SaveModelData();
        }
        private bool InputIsNotValide()
        {
            return txtModelName.Text == "" || txtModelPrice.Text == "" || comboListBrand.SelectedIndex == -1;
        }

        private void SaveModelData()
        {
            try
            {
                GetFieldsInput();
                modelDAO.AddData(mModel);
                LoadBrandData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Utility.Utility.DATA_NOT_SAVED + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void GetFieldsInput()
        {
            mModel.Name = txtModelName.Text.Trim().ToUpper();
            mModel.Price = Convert.ToDouble(txtModelPrice.Text);
            mModel.Description = txtModelDescription.Text;
            mModel.Brand.Id = listBrand[comboListBrand.SelectedIndex].Id;
        }

        private void btnUpdateModel_Click(object sender, EventArgs e)
        {
            if (InputIsNotValide())
            {
                MessageBox.Show(Utility.Utility.CHECK_INPUT_VALUE);
                return;
            }
            UpdateModelData();
        }

        private void UpdateModelData()
        {
            try
            {
                GetFieldsInput();
                modelDAO.UpdateData(mModel);
                LoadBrandData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Utility.Utility.DATA_NOT_UPDATED + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnDeleteModel_Click(object sender, EventArgs e)
        {
            if (InputIsNotValide() || mModel.Id <= 0)
            {
                MessageBox.Show(Utility.Utility.CHECK_INPUT_VALUE);
                return;
            }
            DeleteModelData();
        }

        private void DeleteModelData()
        {
            try
            {
                modelDAO.DeleteData(mModel);
                LoadBrandData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Utility.Utility.DATA_NOT_DELETED + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
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

        private void comboListBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboListBrand.SelectedIndex != -1)
                LoadModelData();
        }

        private void LoadModelData()
        {
            listModel.Clear(); boxListModel.Items.Clear();
            try
            {
                listModel = modelDAO.getModelsByBrandId(listBrand[comboListBrand.SelectedIndex].Id);
                getModelList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getModelList()
        {
            foreach (Model item in listModel)
            {
                boxListModel.Items.Add(item.Name);
            }
        }

        private void ValidateNumberEntred(object sender, KeyPressEventArgs e)
        {
            Utility.Utility.ValidateNumberEntred(sender, e);
        }
    }
}
