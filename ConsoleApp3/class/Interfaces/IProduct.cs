namespace DemoApp {
    internal interface IProduct {
        string description { get; set; }
        string name { get; set; }
        double price { get; set; }
        int quantity { get; set; }        
    }
}