using System;
using System.Linq;

namespace LinqAndExtensionMethods {
    class Program {
        static void Main(string[] args) {
            int[] numbers = {
                        3524,    7436,    7815,    8881,    4972,
                        5662,    1106,    7676,    1806,    4933,
                        1557,    9323,    4655,    4389,    2562,
                        1925,    1884,    8738,    9403,    5531,
                        3641,    4690,    8722,    1221,    8818,
                        6533,    9993,    3986,    4129,    5338,
                        5077,    8951,    2729,    2115,    3995,
                        2134,    3439,    7144,    4724,    5282,
                        6405,    2733,    4964,    5317,    8428,
                        7826,    3267,    8112,    1948,    3323
                        };


            Console.WriteLine(
                $"The result of numbers.Sum() is:  " +
                             $"{numbers.Sum()}\n" +

                $"The result of numbers.Where(x => x % 3 ==0).Sum() is:  " +
                             $"{numbers.Where(x => x % 3 ==0).Sum()}\n" +

                $"The result of numbers.Average() is:  " +
                             $"{numbers.Average()}\n" +

                $"The result of numbers.Max() is:  " +
                             $"{numbers.Max()}"
                );


            Product[] productList = {
                new Product { Code = "Echo", Name = "Amazon Echo", Quantity = 3, Taxible = true },
                new Product { Code = "EchoDot", Name = "Amazon Echo Dot", Quantity = 7, Taxible = true },
                new Product { Code = "EchoShow5", Name = "Amazon Echo Show 5", Quantity = 5, Taxible = true },
                new Product { Code = "3Way", Name = "Skyline 3-Way", Quantity = 2, Taxible = false },
                new Product { Code = "4Way", Name = "Skyline 4-Way", Quantity = 1, Taxible = false },
                new Product { Code = "5Way", Name = "Skyline 5-Way", Quantity = 2, Taxible = false },
                new Product { Code = "5DayClass", Name = "MAX 5-day class", Quantity = 6, Taxible = true }
            };
            Pricing[] priceList = {
                new Pricing { ProductCode = "Echo", Price = 99.99m },
                new Pricing { ProductCode = "EchoDot", Price = 39.99m },
                new Pricing { ProductCode = "EchoShow5", Price = 119.99m },
                new Pricing { ProductCode = "3Way", Price = 6.99m },
                new Pricing { ProductCode = "4Way", Price = 7.99m },
                new Pricing { ProductCode = "5Way", Price = 8.99m },
                new Pricing { ProductCode = "5DayClass", Price = 2995.00m }
            };

            var products_with_prices = from prod in productList
                                       join price in priceList
                                       on prod.Code equals price.ProductCode
                                       select new {
                                           Code = prod.Code,
                                           Name = prod.Name,
                                           Quantity = prod.Quantity,
                                           Price = price.Price,
                                           Total = price.Price * prod.Quantity
                                       };
            foreach (var p in products_with_prices) {
                Console.Write($"\n{p.Code} | {p.Name} | {p.Quantity} | {p.Price} | {p.Total}\n");
            }
        }
    }
}
