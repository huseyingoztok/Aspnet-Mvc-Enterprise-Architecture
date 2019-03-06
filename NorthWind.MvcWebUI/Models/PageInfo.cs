using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthWind.MvcWebUI.Models
{
    public class PagingInfo
    {
        public int CurrPage { get; set; }
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrCategory { get;  set; }
    }
}