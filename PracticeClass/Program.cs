using PracticeClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopWW shop = new ShopWW();
            shop.Address = "Кунаева 24";
            shop.Phone = "546456";

            Catalog catalog = new Catalog() { Name = "Smartphones" };

            Product product = new Product();
            product.Name="xfhfxh";

            product.Manifacture = "hjhj";
            product.Price = 45646;
            product.TypeSecurity = TypeSecurity.Type1;
            catalog.Products.Add(product);
            shop.Catalogs.Add(catalog);
            shop.PrintCatalog();

            
        }
    }
}
