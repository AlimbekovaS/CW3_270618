using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass.Model
{
    public enum TypeSecurity { Type1, Type2,Type3}
    public class Product
    {

        //цепочка конструкторов
        public Product() : this(0) { }
        public Product(double Price):this(Price, "") { }
        public Product(double Price, string Name) : this(Price, Name,"") { }
        public Product(double Price, string Name, string Manifacture)
        {
            this.Price = Price;
            this.Name = Name;
            this.Manifacture = Manifacture;


        }
        private double Price_;

        public double Price
        {
            get { return Price_; }
            set
            {
                if (value < 0)
                    Price_ = 0;
                else
                {
                    Price_ = value;
                    PriceInShop = PriceInShop - (PriceInShop * 0.03);
                }

            }
        }
        public double PriceInShop { get; set; }
        public double Color { get; set; }
        

        public string Name { get; set; }
        public string Manifacture { get; set; }
        public TypeSecurity TypeSecurity { get; set; }
        /// <summary>
        /// возвращает информацияю продукте
        /// </summary>
        public void GetProductInfo()
        {
            Console.WriteLine("{0}\t{1}", Name, Price);
        }
}
}
