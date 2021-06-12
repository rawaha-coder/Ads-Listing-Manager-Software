using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ads_Listing_Manager_Software.Utility
{
    class Utility
    {

        public const string CHECK_INPUT_VALUE = "Check input values ";
        public const string DATA_NOT_SAVED = "Data not saved ";
        public const string DATA_NOT_DELETED = "Data not deleted ";
        public const string DATA_NOT_UPDATED = "Data not updated ";

        public static void ValidateNumberEntred(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void ValidateIntegerNumberEntred(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
