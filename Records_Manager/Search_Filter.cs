﻿using System;
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
        public int Search_Missing { get; private set; }
        public int Search_Broken { get; private set; }
        public Search_Filter()
        {
            Search_Dev = 0;
            Search_Pub = 0;
            Search_Series = 0;
            Search_Image = 0;
        }
        public void SetFilter(
            RadioButton Search_Dev_NO, RadioButton Search_DEV_PASS, RadioButton Search_DEV_YES,
            RadioButton Search_Pub_NO, RadioButton Search_Pub_Pass, RadioButton Search_PUB_YES,
            RadioButton Search_SER_NO, RadioButton Search_SER_Pass, RadioButton Search_SER_YES,
            RadioButton Search_IMG_NO, RadioButton Search_IMG_Pass, RadioButton Search_IMG_YES,
            RadioButton SEARCH_BROKEN_NO, RadioButton SEARCH_BROKEN_PASS, RadioButton SEARCH_BROKEN_YES,
            RadioButton SEARCH_MISSING_NO, RadioButton SEARCH_MISSING_PASS, RadioButton SEARCH_MISSING_YES

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
             
            if (SEARCH_BROKEN_NO.Checked) { Search_Broken = -1; }
            if (SEARCH_BROKEN_PASS.Checked) { Search_Broken = 0; }
            if (SEARCH_BROKEN_YES.Checked) { Search_Broken = 1; }
            //------------------------------------------------

            if (SEARCH_MISSING_NO.Checked) { Search_Missing = -1; }
            if (SEARCH_MISSING_PASS.Checked) { Search_Missing = 0; }
            if (SEARCH_MISSING_YES.Checked) { Search_Missing = 1; }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Search_Dev == -1) { sb.AppendLine($"Must have developer: NO"); }
            if (Search_Dev == 0) { sb.AppendLine($"Must have developer: PASS"); }
            if (Search_Dev == 1) { sb.AppendLine($"Must have developer: YES"); }
            if (Search_Pub == -1) { sb.AppendLine($"Must have publisher: NO"); }
            if (Search_Pub == 0) { sb.AppendLine($"Must have publisher: PASS"); }
            if (Search_Pub == 1) { sb.AppendLine($"Must have publisher: YES"); }
            if (Search_Series == -1) { sb.AppendLine($"Must be part of series: NO"); }
            if (Search_Series == 0) { sb.AppendLine($"Must be part of series: PASS"); }
            if (Search_Series == 1) { sb.AppendLine($"Must be part of series: YES"); }
            if (Search_Image == -1) { sb.AppendLine($"Must have preview image: NO"); }
            if (Search_Image == 0) { sb.AppendLine($"Must have preview image: PASS"); }
            if (Search_Image == 1) { sb.AppendLine($"Must have preview image: YES"); }
            if (Search_Missing == -1) { sb.AppendLine($"Must be missing: NO"); }
            if (Search_Missing == 0) { sb.AppendLine($"Must be missing: PASS"); }
            if (Search_Missing == 1) { sb.AppendLine($"Must be missing: YES"); }
            if (Search_Broken == -1) { sb.AppendLine($"Must be broken: NO"); }
            if (Search_Broken == 0) { sb.AppendLine($"Must be broken: PASS"); }
            if (Search_Broken == 1) { sb.AppendLine($"Must be broken: YES"); }
            return sb.ToString();
        }
    }
}
