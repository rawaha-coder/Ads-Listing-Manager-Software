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
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void HideShowSideMenu_Click(object sender, EventArgs e)
        {
            if (SideMenuIsHide)
            {

            }
            else
            {

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
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
    }
}
