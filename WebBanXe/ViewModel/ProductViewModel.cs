using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanXe.ViewModel
{
    public class ProductViewModel
    {
        public int IdProduct { get; set; }
        public string NameProduct { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public string IdBrand { get; set; }
        public string IdType { get; set; }
        public IList<ProductImageViewModel> Images { get; set; }
    }

    public class ProductImageViewModel
    {
        public string LinkImg { get; set;}
    }
}