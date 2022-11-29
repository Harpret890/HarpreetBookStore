using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HarpreetsBooks.Models.ViewModels
{
    public class ProductVM
    {
        public Product Produt { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}
