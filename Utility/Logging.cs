using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ads_Listing_Manager_Software.Utility
{
    class Logging
    {
        public static void LogError(Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
