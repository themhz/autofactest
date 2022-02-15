using System;
using System.Collections.Generic;
using Autofac;

namespace DemoApp {
    class Program {
        private static IContainer Container { get; set; }

        static void Main(string[] args) {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<OtherWriter>().As<IDateWriter>();

            builder.RegisterType<Client>().As<IClient>();            
            builder.RegisterType<Product>().As<IProduct>();
            builder.RegisterType<Sale>().As<ISale>();
            builder.RegisterType<List<IProduct>>();


            Container = builder.Build();
           
            runmyprogram();
            //Console.WriteLine("Hello World!");
        }

        public static void runmyprogram() {
            using (var scope = Container.BeginLifetimeScope()) {
                var client = scope.Resolve<IClient>();
                var sale = scope.Resolve<ISale>();                
                var product1 = scope.Resolve<IProduct>();
                var product2 = scope.Resolve<IProduct>();

                sale.product = scope.Resolve<List<IProduct>>();

                client.id = 1;
                client.lastName = "theotokatos";
                client.name = "themhz";

                product1.description = "Intel I9 12th generation";
                product1.name = "Intel I9";
                product1.price = 512.12;
                product1.quantity = 10;


                product2.description = "GTX 2300 GRAPHIC CARD";
                product2.name = "GTX 2300";
                product2.price = 210;
                product2.quantity = 10;

                sale.id = 1;
                sale.amount = 12.34;
                sale.client = client;                
                sale.product.Add(product1);
                sale.product.Add(product2);

                var output = scope.Resolve<IOutput>();
                output.Write(sale.product[1].name);
                output.Write(sale.product[2].name);
                output.Write(sale.client.name);


            }
        }

        public static void WriteDate() {
            // Create the scope, resolve your IDateWriter,
            // use it, then dispose of the scope.
            using (var scope = Container.BeginLifetimeScope()) {
                var writer = scope.Resolve<IDateWriter>();
                writer.WriteDate();

                var output = scope.Resolve<IOutput>();
                output.Write("hello world");                
            }
        }
    }
}
