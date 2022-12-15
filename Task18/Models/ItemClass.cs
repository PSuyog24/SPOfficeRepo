using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task18.Models
{
    public class ItemClass
    {
        public int[] SelectedItemName { get; set; }
        public IEnumerable<SelectListItem> ItemList { get; set; }
    }
}