using System;

namespace DemoApp {
    interface IClient {
        int id { get; set; }
        
        String name { get; set; }
        String lastName { get; set; }
        int age { get; set; }
    }
}