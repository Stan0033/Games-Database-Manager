using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Records_Manager
{
    public class Search_Filter
    {
       public int Search_Dev { get; private set; }
        public int Search_Pub { get; private set; }
        public int Search_Series { get; private set; }
        public int Search_Image { get; private set; }
        public Search_Filter()
        {
            Search_Dev = 0;
            Search_Pub = 0;
            Search_Series = 0;
            Search_Image = 0;
        }
        public void setFilter(
            RadioButton Search_Dev_NO, RadioButton Search_DEV_PASS, RadioButton Search_DEV_YES,
            RadioButton Search_Pub_NO, RadioButton Search_Pub_Pass, RadioButton Search_PUB_YES,
            RadioButton Search_SER_NO, RadioButton Search_SER_Pass, RadioButton Search_SER_YES,
            RadioButton Search_IMG_NO, RadioButton Search_IMG_Pass, RadioButton Search_IMG_YES
            )
        {
            if ( Search_Dev_NO.Checked ) { Search_Dev = -1; }
            if (Search_DEV_PASS.Checked ) { Search_Dev = 0; }
            if (Search_DEV_YES.Checked ) { Search_Dev = 1; }
            //------------------------------------------------
            if (Search_Pub_NO.Checked) { Search_Pub = -1; }
            if (Search_Pub_Pass.Checked) { Search_Pub = 0; }
            if (Search_PUB_YES.Checked) { Search_Pub = 1; }
            //------------------------------------------------
            if (Search_SER_NO.Checked) { Search_Series = -1; }
            if (Search_SER_Pass.Checked) { Search_Series = 0; }
            if (Search_SER_YES.Checked) { Search_Series = 1; }
            //------------------------------------------------
            if (Search_IMG_NO.Checked) { Search_Image = -1; }
            if (Search_IMG_Pass.Checked) { Search_Image = 0; }
            if (Search_IMG_YES.Checked) { Search_Image = 1; }
            //------------------------------------------------
        }
    }
}
