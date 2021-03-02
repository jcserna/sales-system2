using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_system
{
    class Store
    {
        public SalesMan[] SalesMen = new SalesMan[3];
        int salesMenCount = 0;
        public Product[] Products = new Product[20];
        int productsCount = 0;
        public Sale[] Sales = new Sale[12];
        int salesCount = 0;

        public void AddSalesMan(SalesMan newSalesMan)
        {
            SalesMen[salesMenCount] = newSalesMan;
            salesMenCount++;
        }
        public void AddProducts(Product newProduct)
        {
            Products[productsCount] = newProduct;
            productsCount++;
        }
        public void AddSales(Sale newSale)
        {
            Sales[salesCount] = newSale;
            salesCount++;
        }

        //Who's the seller (sales man name), who has sold the cheapest product.
        public string SellerCheapest(Sale[] sales)
        {
            double cheapestPrice = sales[0].Product.Price;
            string Seller = "";
            for (int i = 0; i < salesCount; i++)
            {
                if (Sales[i].Product.Price <= cheapestPrice)
                {
                    cheapestPrice = Sales[i].Product.Price;
                    Seller = Sales[i].SalesMan.Name;
                }
            }
            
            return  Seller;
        }
        
        //Products price average.
        public double PriceAverage(Product[]products)
        {
            double sumPrices=0;
            double average;
            for (int i = 0; i < productsCount; i++)
            {
                sumPrices = sumPrices + products[i].Price;
            }
            average = sumPrices / productsCount;
            return average;
        }

        //How many unit of the product has been sold.
        public int QuantityProductSold(Sale[] sales)
        {
            Console.WriteLine("Ingrese el nombre de producto a consultar");
            string ProductName=Console.ReadLine().ToLower();
            int ProductSoldCount = 0;
            for (int i = 0; i < salesCount; i++)
            {
                if (sales[i].Product.Name == ProductName)
                {
                    ProductSoldCount++;
                }
            }
            return ProductSoldCount;
        }

        //What's the most expensive product.
        public Product MostExpensiveProduct(Product[] products)
        {
            Product expensiveProduct = products[0];
            for (int i = 0; i < productsCount; i++)
            {
                if (products[i].Price >= expensiveProduct.Price)
                {
                    expensiveProduct = products[i];
                }
            }
            return expensiveProduct;
        }
    }
}
