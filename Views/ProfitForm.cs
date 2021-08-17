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
    public partial class ProfitForm : Form
    {
        List<Profit> list;

        public ProfitForm()
        {
            InitializeComponent();
            list = new List<Profit>();
        }

        private void ValidateNumberEntred(object sender, KeyPressEventArgs e)
        {
            Utility.Utility.ValidateNumberEntred(sender, e);
        }

        private void ValidateIntegerNumberEntred(object sender, KeyPressEventArgs e)
        {
            Utility.Utility.ValidateIntegerNumberEntred(sender, e);
        }

        private void textMaxPrice1_TextChanged(object sender, EventArgs e)
        {
            textMinPrice2.Text = textMaxPrice1.Text;

        }

        private void textMaxPrice2_TextChanged(object sender, EventArgs e)
        {
            textMinPrice3.Text = textMaxPrice2.Text;

        }

        private void textMaxPrice3_TextChanged(object sender, EventArgs e)
        {
            textMinPrice4.Text = textMaxPrice3.Text;

        }

        private void textMaxPrice4_TextChanged(object sender, EventArgs e)
        {
            textMinPrice5.Text = textMaxPrice4.Text;

        }

        private void textMaxPrice5_TextChanged(object sender, EventArgs e)
        {
            textMinPrice6.Text = textMaxPrice5.Text;

        }

        private void textMaxPrice6_TextChanged(object sender, EventArgs e)
        {
            textMinPrice7.Text = textMaxPrice6.Text;

        }

        private void textMaxPrice7_TextChanged(object sender, EventArgs e)
        {
            textMinPrice8.Text = textMaxPrice7.Text;

        }

        private void textMaxPrice8_TextChanged(object sender, EventArgs e)
        {
            textMinPrice9.Text = textMaxPrice8.Text;

        }

        private void textMaxPrice9_TextChanged(object sender, EventArgs e)
        {
            textMinPrice10.Text = textMaxPrice9.Text;

        }
    }
}
