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
        private bool SideMenuIsHide = false;
        private Form activeForm = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //ComponentDAO b = ComponentDAO.getInstance();
            //b.CreateTable();
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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddItemForm());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            activeForm.Close();
        }
    }
}
