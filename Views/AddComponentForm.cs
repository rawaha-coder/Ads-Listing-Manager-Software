using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ads_Listing_Manager_Software.Views
{
    public partial class AddComponentForm : Form
    {
        private readonly ComponentDAO mComponentDAO;
        private Component mComponent;
        private List<Component> listComponent;

        public AddComponentForm()
        {
            InitializeComponent();
            mComponentDAO = ComponentDAO.getInstance();
            mComponent = new Component();
            listComponent = new List<Component>();
        }

        private void AddComponentForm_Load(object sender, EventArgs e)
        {
            LoadComponentData();
        }

        private void LoadComponentData()
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
            viewListComponent.Clear();
            viewListComponent.Items.Clear();
            SetHeaderStyle();
            foreach (Component item in listComponent)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Id.ToString();
                lvi.SubItems.Add(item.Name);
                lvi.SubItems.Add(item.Description);
                viewListComponent.Items.Add(lvi);
            }
        }

        private void SetHeaderStyle()
        {
            ColumnHeader id, name, description;
            id = new ColumnHeader();
            name = new ColumnHeader();
            description = new ColumnHeader();
            id.Text = "ID";
            id.TextAlign = HorizontalAlignment.Left;
            id.Width = 40;
            name.Text = "Name";
            name.TextAlign = HorizontalAlignment.Left;
            name.Width = 160;
            description.TextAlign = HorizontalAlignment.Left;
            description.Text = "Description";
            description.Width = 400;
            viewListComponent.Columns.Add(id);
            viewListComponent.Columns.Add(name);
            viewListComponent.Columns.Add(description);
        }

        private void ButtonAddComponent_Click(object sender, EventArgs e)
        {
            if (InputIsNotValide())
            {
                MessageBox.Show(Utility.Utility.CHECK_INPUT_VALUE);
                return;
            }
            SaveComponentData();
            ClearField();
        }

        private void SaveComponentData()
        {
            try
            {
                GetInputFieldValue();
                mComponentDAO.AddData(mComponent);
                LoadComponentData();
            }
            catch (Exception ex)
            {
                Utility.Logging.ShowError(ex);
            }
        }

        private void GetInputFieldValue()
        {
            mComponent.Id = Convert.ToInt32(txtComponentID.Text);
            mComponent.Name = txtComponentName.Text.Trim().ToUpper();
            mComponent.Description = txtComponentDescription.Text;
        }

        private bool InputIsNotValide()
        {
            return txtComponentName.Text == "" || txtComponentID.Text == "";
        }

        private void ButtonUpdateComponent_Click(object sender, EventArgs e)
        {
            if (InputIsNotValide())
            {
                MessageBox.Show(Utility.Utility.CHECK_INPUT_VALUE);
                return;
            }
            UpdateComponentdata();
            ClearField();
            DisableUpdateAndDeleteButton();
        }

        private void UpdateComponentdata()
        {
            try
            {
                GetInputFieldValue();
                mComponentDAO.UpdateData(mComponent);
                LoadComponentData();
            }
            catch (Exception ex)
            {
                Utility.Logging.ShowError(ex);
            }
        }

        private void btnDeleteComponent_Click(object sender, EventArgs e)
        {
            if (mComponent.Id <= 0)
            {
                MessageBox.Show(Utility.Utility.CHECK_INPUT_VALUE);
                return;
            }
            DeleteComponentData();
            ClearField();
            DisableUpdateAndDeleteButton();
        }

        private void DeleteComponentData()
        {
            try
            {
                mComponentDAO.DeleteData(mComponent);
                LoadComponentData();
            }
            catch (Exception ex)
            {
                Utility.Logging.ShowError(ex);
            }
        }

        private void viewListComponent_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                mComponent = listComponent[viewListComponent.Items.IndexOf(viewListComponent.SelectedItems[0])];
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
            txtComponentID.Text = mComponent.Id.ToString();
            txtComponentName.Text = mComponent.Name;
            txtComponentDescription.Text = mComponent.Description; ;
        }

        private void txtComponentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.Utility.ValidateIntegerNumberEntred(sender, e);
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            ClearField();
            DisableUpdateAndDeleteButton();
        }

        private void ClearField()
        {
            txtComponentID.Text = "";
            txtComponentName.Text = "";
            txtComponentDescription.Text = "";
        }

        private void EnableUpdateAndDeleteButton()
        {
            buttonAddComponent.Enabled = false;
            buttonUpdateComponent.Enabled = true;
            buttonDeleteComponent.Enabled = true;
        }

        private void DisableUpdateAndDeleteButton()
        {
            buttonAddComponent.Enabled = true;
            buttonUpdateComponent.Enabled = false;
            buttonDeleteComponent.Enabled = false;
        }

        private void lblAddComponent_Click(object sender, EventArgs e)
        {

        }
    }
}
