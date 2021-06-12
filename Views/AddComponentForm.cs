using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ads_Listing_Manager_Software.Views
{
    public partial class AddComponentForm : Form
    {
        ComponentDAO mComponentDAO = ComponentDAO.getInstance();
        Component mComponent = new Component();
        List<Component> listComponent = new List<Component>();

        public AddComponentForm()
        {
            InitializeComponent();
        }

        private void AddComponentForm_Load(object sender, EventArgs e)
        {
            LoadComponentData();
        }

        private void LoadComponentData()
        {
            ClearField();
            try
            {
                listComponent = mComponentDAO.SelectData();
                getComponentList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearField()
        {
            txtComponentID.Text = "";
            txtComponentName.Text = "";
            txtComponentDescription.Text = "";
            listComponent.Clear();
            boxListComponent.Items.Clear();
        }

        private void getComponentList()
        {
            foreach (Component item in listComponent)
            {
                boxListComponent.Items.Add(item.Id + ": " + item.Name);
            }
        }

        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            if (InputIsNotValide())
            {
                MessageBox.Show("Component Id and Name required");
                return;
            }
            try
            {
                mComponent.Id = Convert.ToInt32(txtComponentID.Text);
                mComponent.Name = txtComponentName.Text.Trim().ToUpper();
                mComponent.Description = txtComponentDescription.Text;
                mComponentDAO.AddData(mComponent);
                MessageBox.Show("Component Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadComponentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Model Not Saved: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private bool InputIsNotValide()
        {
            return txtComponentName.Text == "" || txtComponentID.Text == "";
        }

        private void btnUpdateComponent_Click(object sender, EventArgs e)
        {
            if (InputIsNotValide())
            {
                MessageBox.Show("Component Id and Name required");
                return;
            }
            try
            {
                mComponent.Id = Convert.ToInt32(txtComponentID.Text);
                mComponent.Name = txtComponentName.Text.Trim().ToUpper();
                mComponent.Description = txtComponentDescription.Text;
                mComponentDAO.UpdateData(mComponent);
                MessageBox.Show("Brand Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadComponentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brand Not Updated: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnDeleteComponent_Click(object sender, EventArgs e)
        {
            if (mComponent.Id <= 0)
            {
                MessageBox.Show("Component Id and Name required");
                return;
            }
            try
            {
                mComponentDAO.DeleteData(mComponent);
                MessageBox.Show("Brand Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadComponentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brand Not Deleted: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }



        private void boxListComponent_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                mComponent = listComponent[boxListComponent.SelectedIndex];
                FillTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillTextBox()
        {
            txtComponentID.Text = mComponent.Id.ToString();
            txtComponentName.Text = mComponent.Name;
            txtComponentDescription.Text = mComponent.Description; ;
        }

        private void txtComponentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.Utility.ValidateIntegerNumberEntred(sender, e);
        }
    }
}
