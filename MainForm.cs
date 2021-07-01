using Ads_Listing_Manager_Software.Database;
using Ads_Listing_Manager_Software.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ads_Listing_Manager_Software
{
    public partial class MainForm : Form
    {
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
            activeForm = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                //ComponentDAO b = ComponentDAO.getInstance();
                //ProductDAO b = ProductDAO.getInstance();
                //ModelDAO b = ModelDAO.getInstance();
                //b.CreateTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(childForm);
            PanelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnDesktopForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DesktopForm());
        }

        private void btnLaptopForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LaptopForm());
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddBrandForm());
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddModelForm());
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddComponentForm());
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddItemForm());
        }

        private void btnAddMultiProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddMultiProductForm());
        }

        private void btnAddOneProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddProductForm());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            activeForm.Close();
        }

        private void btnItemForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ItemForm());
        }

        private void btnAddMultiItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddMultiItemForm());
        }

        private void btnProductForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductForm());
        }
    }
}
