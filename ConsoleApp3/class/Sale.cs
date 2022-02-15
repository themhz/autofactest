using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Sale : ISale {

        public int id { get; set; }
        public Double amount { get; set; }
        public List<IProduct> product { get; set; }
        public DateTime transaction { get; set; }
        public IClient client { get; set; }        

        public Sale() {

        }
    }
}
