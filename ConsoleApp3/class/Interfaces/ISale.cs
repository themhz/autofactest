using System;
using System.Collections.Generic;

namespace DemoApp {
    interface ISale {
        double amount { get; set; }
        IClient client { get; set; }
        int id { get; set; }
        List<IProduct> product { get; set; }
        DateTime transaction { get; set; }        
    }
}