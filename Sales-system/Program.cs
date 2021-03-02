using System;

namespace Sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesMan salesMan1 = new SalesMan();
            salesMan1.Name = "Juan";
            salesMan1.Age = 22;

            SalesMan salesMan2 = new SalesMan();
            salesMan2.Name = "Luis";
            salesMan2.Age = 30;

            SalesMan salesMan3 = new SalesMan();
            salesMan3.Name = "Andrea";
            salesMan3.Age = 28;

            Product p1 = new Product();
            p1.Name = "Computer";
            p1.Price = 4327167;

            Product p2 = new Product();
            p2.Name = "Earphones";
            p2.Price = 699000;

            Product p3 = new Product();
            p3.Name = "Cellphone";
            p3.Price = 1546985;

            Sale s1 = new Sale();
            s1.SalesMan = salesMan3;
            s1.Product = p3;
            s1.Comments = "Venta de celular";

            Sale s2 = new Sale();
            s2.SalesMan = salesMan2;
            s2.Product = p2;
            s2.Comments = "Buen producto";

            Sale s3 = new Sale();
            s3.SalesMan = salesMan1;
            s3.Product = p1;
            s3.Comments = "Producto nuevo";

            double salesTotalAmount = s1.Product.Price + s2.Product.Price + s3.Product.Price;

            System.Console.WriteLine("El valor de las ventas es de: " + salesTotalAmount + " pesos");
            
        }
    }
}
