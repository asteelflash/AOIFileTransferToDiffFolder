using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOIFileTransferToDiffFolder.Model
{
    class BasicData
    {
        public static string SouceFolder { get; set; }
        //public static string TargetFolder1 { get; set; }
        //public static string TargetFolder2 { get; set; }
        //public static string TargetFolder3 { get; set; }     
        public static List<string> TargetFolderList { get; set; }

        public static int SouceFileQty { get; set; }
        //public static int Target1FileQty { get; set; }
        //public static int Target2FileQty { get; set; }
        //public static int Target3FileQty { get; set; }

        public static List<int> TargetFileQtyList { get; set; }


    }
}
