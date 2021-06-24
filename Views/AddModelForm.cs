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
            txtName.Text = "";
            txtPrice.Text = "";
            txtDescription.Text = "";
            viewListModel.Items.Clear();
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
            return txtName.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "" || comboListBrand.SelectedIndex == -1 || comboGrade.SelectedIndex ==-1;
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
            mModel.Name = txtName.Text.Trim().ToUpper();
            mModel.Price = Convert.ToDouble(txtPrice.Text);
            mModel.Quantity = Convert.ToInt32(txtQuantity.Text);
            mModel.Grade = Convert.ToString(comboGrade.SelectedItem);
            mModel.Description = txtDescription.Text;
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

        private void comboListBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
                LoadModelData();
        }

        private void LoadModelData()
        {
            if (comboListBrand.SelectedIndex != -1)
            {
                try
                {
                    listModel.Clear();
                    listModel = modelDAO.getModelsByBrandId(listBrand[comboListBrand.SelectedIndex].Id);
                    getItemsList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Load Model Data: " + ex.Message);
                }
            }
        }

        private void getItemsList()
        {
            viewListModel.Clear();
            viewListModel.Items.Clear();
            viewListModel.Columns.Add("Model", 200, HorizontalAlignment.Left);
            viewListModel.Columns.Add("Grade", 80, HorizontalAlignment.Left);
            viewListModel.Columns.Add("Price", 100, HorizontalAlignment.Left);
            viewListModel.Columns.Add("Quantity", 100, HorizontalAlignment.Left);
            foreach (Model model in listModel)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = model.Name;
                lvi.SubItems.Add(model.Grade);
                lvi.SubItems.Add(model.Price.ToString());
                lvi.SubItems.Add(model.Quantity.ToString());
                viewListModel.Items.Add(lvi);
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

        private void viewListModel_DoubleClick(object sender, EventArgs e)
        {
            selectModelForUpdateOrDelete();
        }

        private void selectModelForUpdateOrDelete()
        {
            if (viewListModel.SelectedItems.Count > 0)
            {
                try
                {
                    mModel = listModel[viewListModel.Items.IndexOf(viewListModel.SelectedItems[0])];
                    txtName.Text = mModel.Name;
                    comboGrade.Text = mModel.Grade;
                    txtPrice.Text = mModel.Price.ToString();
                    txtQuantity.Text = mModel.Quantity.ToString();
                    txtDescription.Text = mModel.Description; ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
