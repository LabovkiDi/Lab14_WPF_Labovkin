using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_WPF_Labovkin
{

    class Product
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public ProductCategorys ProductCategory { get; set; }
    }
    public enum ProductCategorys
    {
        Food,
        Appliances
    }
}
