using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ads_Listing_Manager_Software.Views
{
    public partial class AddModelForm : Form
    {
        private readonly BrandDAO brandDAO;
        private readonly ModelDAO modelDAO;
        private Model mModel = new Model();
        private List<Brand> listBrand;
        private List<Model> listModel;

        public AddModelForm()
        {
            InitializeComponent();
            brandDAO = BrandDAO.getInstance();
            modelDAO = ModelDAO.getInstance();
            mModel = new Model();
            listBrand = new List<Brand>();
            listModel = new List<Model>();
        }

        private void AddModelForm_Load(object sender, EventArgs e)
        {
            LoadBrandData();
        }

        private void LoadBrandData()
        {
            try
            {
                listBrand.Clear();
                listBrand = brandDAO.GetData();
                SetBrandListInComboBox();
            }
            catch (Exception ex)
            {
                Utility.Logging.ShowError(ex);
            }
        }

        private void SetBrandListInComboBox()
        {
            comboListBrand.Items.Clear();
            foreach (Brand item in listBrand)
            {
                comboListBrand.Items.Add(item.Name);
            }
        }

        private void ButtonAddModel_Click(object sender, EventArgs e)
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
            return txtName.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "" || comboListBrand.SelectedIndex == -1 || comboGrade.SelectedIndex == -1;
        }

        private void SaveModelData()
        {
            try
            {
                GetInputFieldValue();
                modelDAO.AddData(mModel);
                ClearField();
                LoadBrandData();
            }
            catch (Exception ex)
            {
                Utility.Logging.ShowError(ex);
            }
        }

        private void GetInputFieldValue()
        {
            mModel.Brand.Id = listBrand[comboListBrand.SelectedIndex].Id;
            mModel.Name = txtName.Text.Trim().ToUpper();
            mModel.Price = Convert.ToDouble(txtPrice.Text);
            mModel.Quantity = Convert.ToInt32(txtQuantity.Text);
            mModel.Grade = Convert.ToString(comboGrade.SelectedItem);
            mModel.Description = txtDescription.Text;
        }

        private void ButtonUpdateModel_Click(object sender, EventArgs e)
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
                GetInputFieldValue();
                modelDAO.UpdateData(mModel);
                ClearField();
                LoadBrandData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Utility.Utility.DATA_NOT_UPDATED + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void ButtonDeleteModel_Click(object sender, EventArgs e)
        {
            if (CheckAbilityForDelete())
                return;
            DeleteModelData();
        }

        private bool CheckAbilityForDelete()
        {
            if (txtName.Text == "" || mModel.Id <= 0)
            {
                MessageBox.Show("Check input values!");
                return true;
            }
            return ItHasProduct();
        }

        private bool ItHasProduct()
        {
            bool hasProduct = true;
            try
            {
                ProductDAO productDAO = ProductDAO.getInstance();
                hasProduct = productDAO.ProductCountByModel(mModel.Id) > 0;
                if (hasProduct)
                    MessageBox.Show("Model has product, Please delete all products first");
            }
            catch (Exception ex)
            {
                Utility.Logging.ShowError(ex);
            }
            return hasProduct;
        }

        private void DeleteModelData()
        {
            try
            {
                modelDAO.DeleteData(mModel);
                ClearField();
                LoadBrandData();
            }
            catch (Exception ex)
            {
                Utility.Logging.ShowError(ex);
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
                    DisplayItemsInViewListModel();
                }
                catch (Exception ex)
                {
                    Utility.Logging.ShowError(ex);
                }
            }
        }

        private void DisplayItemsInViewListModel()
        {
            viewListModel.Clear();
            viewListModel.Items.Clear();
            SetViewListModelColumns();
            foreach (Model model in listModel)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = model.Name;
                lvi.SubItems.Add(model.Grade);
                lvi.SubItems.Add(model.Price.ToString());
                lvi.SubItems.Add(model.Quantity.ToString());
                lvi.SubItems.Add(model.Description);
                viewListModel.Items.Add(lvi);
            }
        }

        private void SetViewListModelColumns()
        {
            viewListModel.Columns.Add("Model", 200, HorizontalAlignment.Left);
            viewListModel.Columns.Add("Grade", 80, HorizontalAlignment.Left);
            viewListModel.Columns.Add("Price", 100, HorizontalAlignment.Left);
            viewListModel.Columns.Add("Quantity", 100, HorizontalAlignment.Left);
            viewListModel.Columns.Add("Description", 260, HorizontalAlignment.Left);
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
            if (viewListModel.SelectedItems.Count > 0)
                selectModelForUpdateOrDelete();
        }

        private void selectModelForUpdateOrDelete()
        {
            try
            {
                mModel = listModel[viewListModel.Items.IndexOf(viewListModel.SelectedItems[0])];
                SetInputFieldValue();
                EnableUpdateAndDeleteButton();
            }
            catch (Exception ex)
            {
                Utility.Logging.ShowError(ex);
            }
        }

        private void SetInputFieldValue()
        {
            txtName.Text = mModel.Name;
            comboGrade.Text = mModel.Grade;
            txtPrice.Text = mModel.Price.ToString();
            txtQuantity.Text = mModel.Quantity.ToString();
            txtDescription.Text = mModel.Description; ;
        }
        private void ButtonClearFields_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void ClearField()
        {
            ClearInputFields();
            viewListModel.Items.Clear();
            ResetBrandComboBox();
            DisableUpdateAndDeleteButton();
        }

        private void ClearInputFields()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            comboGrade.SelectedIndex = -1;
            comboGrade.Text = "";
            txtDescription.Text = "";
        }

        private void ResetBrandComboBox()
        {
            comboListBrand.SelectedIndex = -1;
            comboListBrand.Text = "";
        }

        private void DisableUpdateAndDeleteButton()
        {
            buttonAddModel.Enabled = true;
            buttonUpdateModel.Enabled = false;
            buttonDeleteModel.Enabled = false;
        }

        private void EnableUpdateAndDeleteButton()
        {
            buttonAddModel.Enabled = false;
            buttonUpdateModel.Enabled = true;
            buttonDeleteModel.Enabled = true;
        }

    }
}
