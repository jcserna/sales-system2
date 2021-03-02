using System;

namespace Sales_system
{
    class Program
    {
        static void Main(string[] args)
        {

            Store store = new Store();
            
            SalesMan salesMan1 = new SalesMan();
            salesMan1.Name = "Juan";
            salesMan1.Age = 22;
            store.AddSalesMan(salesMan1);

            SalesMan salesMan2 = new SalesMan();
            salesMan2.Name = "Luis";
            salesMan2.Age = 30;
            store.AddSalesMan(salesMan2);

            SalesMan salesMan3 = new SalesMan();
            salesMan3.Name = "Andrea";
            salesMan3.Age = 28;
            store.AddSalesMan(salesMan3);

            Product p1 = new Product();
            p1.Name = "computer";
            p1.Price = 4327167;
            store.AddProducts(p1);

            Product p2 = new Product();
            p2.Name = "earphones";
            p2.Price = 699000;
            store.AddProducts(p2);

            Product p3 = new Product();
            p3.Name = "cellphone";
            p3.Price = 1546985;
            store.AddProducts(p3);

            Sale s1 = new Sale();
            s1.SalesMan = salesMan3;
            s1.Product = p3;
            s1.Comments = "Venta de celular";
            store.AddSales(s1);

            Sale s2 = new Sale();
            s2.SalesMan = salesMan2;
            s2.Product = p2;
            s2.Comments = "producto antiguo";
            store.AddSales(s2);

            Sale s3 = new Sale();
            s3.SalesMan = salesMan1;
            s3.Product = p1;
            s3.Comments = "Producto nuevo";
            store.AddSales(s3);



            //   double salesTotalAmount = s1.Product.Price + s2.Product.Price + s3.Product.Price;
            //  System.Console.WriteLine("El valor de las ventas es de: " + salesTotalAmount + " pesos");





            //string SellerCheapest = store.SellerCheapest(store.Sales);
            //System.Console.WriteLine("El vendedor que vendió el producto mas barato fue: " + SellerCheapest);

            //double Average = store.PriceAverage(store.Products);
            //System.Console.WriteLine("El precio promedio de los productos es: " + Average);


            //System.Console.WriteLine("De este producto se han vendido " + store.QuantityProductSold(store.Sales) + " unidades");

            Product MostExpensiveProduct = store.MostExpensiveProduct(store.Products);
            System.Console.WriteLine("El producto más caro es " + MostExpensiveProduct.Name + " con un precio de $" + MostExpensiveProduct.Price);

        }
    }
}
