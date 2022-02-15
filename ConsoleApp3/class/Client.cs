using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp {
    class Client : Person, IClient {

        public int id { get; set; }

        public Client() {            
        }

    }
}
