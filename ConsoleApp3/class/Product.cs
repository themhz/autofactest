using System;

namespace DemoApp {
    internal class Product : IProduct {
        private String _name;
        public String name {
            get { return _name; }
            set { _name = value; }
        }


        private Double _price;
        public Double price {
            get { return _price; }
            set { _price = value; }
        }

        public String description { get; set; }
        public int quantity { get; set; }
        

        public Product() {

        }
    }
}