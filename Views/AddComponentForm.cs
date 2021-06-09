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
            listComponent.Clear();
            boxListComponent.Items.Clear();
            try
            {
                listComponent = mComponentDAO.GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            foreach (Component item in listComponent)
            {
                boxListComponent.Items.Add(item.Name);
            }
        }

        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            if (txtComponentName.Text == "")
            {
                MessageBox.Show("Component name required");
                return;
            }
            try
            {
                Component item = new Component();
                item.Name = txtComponentName.Text.Trim().ToUpper();
                item.Description = txtComponentDescription.Text;
                mComponentDAO.AddData(item);
                MessageBox.Show("Component Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                ClearField();
                LoadComponentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Model Not Saved: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnUpdateComponent_Click(object sender, EventArgs e)
        {
            if (txtComponentName.Text == "")
            {
                MessageBox.Show("Brand name required");
                return;
            }
            try
            {
                mComponent.Name = txtComponentName.Text.Trim().ToUpper();
                mComponent.Description = txtComponentDescription.Text;
                mComponentDAO.UpdateData(mComponent);
                MessageBox.Show("Brand Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                ClearField();
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
                MessageBox.Show("Brand name required");
                return;
            }
            try
            {
                mComponentDAO.DeleteData(mComponent);
                MessageBox.Show("Brand Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
                ClearField();
                LoadComponentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brand Not Deleted: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void ClearField()
        {
            txtComponentName.Text = "";
            txtComponentDescription.Text = "";
        }

        private void boxListComponent_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtComponentName.Text = listComponent[boxListComponent.SelectedIndex].Name;
                txtComponentDescription.Text = listComponent[boxListComponent.SelectedIndex].Description; ;
                mComponent.Id = listComponent[boxListComponent.SelectedIndex].Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
