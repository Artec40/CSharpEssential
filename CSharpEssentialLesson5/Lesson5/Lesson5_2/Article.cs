using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5_2
{
    public class Article
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }

        private string _shop;
        public string Shop
        {
            get
            {
                return _shop;
            }
        }

        private string _price;
        public string Price
        {
            get
            {
                return _price;
            }
        }

        public Article(string name, string shop, string price)
        {
            this._name = name;
            this._shop = shop;
            this._price = price;
        }
    }
}
