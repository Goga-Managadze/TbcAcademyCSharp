// See https://aka.ms/new-console-template for more information

using System.Xml;
using Task;

List<Product> products = new List<Product>
                                         {new Product {ProductId = 1, ProductName = "Product1", PriceInGEL = 100, ShopId = 1},
                                          new Product {ProductId = 2, ProductName = "Product2", PriceInGEL = 200, ShopId = 2},
                                          new Product {ProductId = 3, ProductName = "Product3", PriceInGEL = 300, ShopId = 1},
                                          new Product {ProductId = 4, ProductName = "Product4", PriceInGEL = 400, ShopId = 4},
                                          new Product {ProductId = 5, ProductName = "Product5", PriceInGEL = 500, ShopId = 3},
                                          new Product {ProductId = 6, ProductName = "Product6", PriceInGEL = 500, ShopId = 3},
                                          new Product {ProductId = 7, ProductName = "Product7", PriceInGEL = 700, ShopId = 5}
                                         };

List<Shop> shops = new List<Shop>
                                 {new Shop {ShopId = 1, ShopName = "Shop1"},
                                  new Shop {ShopId = 2, ShopName = "Shop2" },
                                  new Shop {ShopId = 3, ShopName = "Shop3" },
                                  new Shop {ShopId = 4, ShopName = "Shop4" },
                                  new Shop {ShopId = 5, ShopName = "Shop5" }
                                 };

List<Shop> shops2 = new List<Shop>
                                 {new Shop {ShopId = 6, ShopName = "Shop6"},
                                  new Shop {ShopId = 7, ShopName = "Shop7" },
                                 };

//Union
Console.WriteLine("Union");

var shopsUnion = shops.Union(shops2);
var shopsUnion1 = shops.Union(shops2, new ShopComparer());

foreach (var shop in shopsUnion)
{
    Console.WriteLine($"ShopId: {shop.ShopId}, Name: {shop.ShopName}");
}
Console.WriteLine();

var shopsUnionWithLinq = (from shop in shops
                          select shop).Union(shops2);

foreach (var shop in shopsUnionWithLinq)
{
    Console.WriteLine($"ShopId: {shop.ShopId}, Name: {shop.ShopName}");
}

//Join
Console.WriteLine("Join");
var joinLinq = from shop in shops
                 join product in products
                 on shop.ShopId equals product.ShopId
                 select new
                 {
                     ShopName = shop.ShopName,
                     ShopId = shop.ShopId,
                     ProductName = product.ProductName,
                     ProductId = product.ProductId,
                 };

foreach (var list in joinLinq)
{
    Console.WriteLine(list);
}

Console.WriteLine();

var joinMethod = shops.Join(products,
                            shop => shop.ShopId,
                            product => product.ShopId,
                            (shop, product) =>
                            new {
                                ShopName = shop.ShopName,
                                ShopId = shop.ShopId,
                                ProductName = product.ProductName,
                                ProductId = product.ProductId,
                            });

foreach (var list in joinMethod)
{
    Console.WriteLine(list);
}

//GroupJoin
Console.WriteLine("GroupJoin");

var groupJoinMethod = shops.GroupJoin(products,
                                      shop => shop.ShopId,
                                      product => product.ShopId,
                                      (shop, productsGroup) =>
                                      new
                                      {
                                          Products = productsGroup,
                                          ShopName = shop.ShopName,
                                      });

foreach (var item in groupJoinMethod)
{
    Console.WriteLine(item.ShopName);

    foreach (var product in item.Products)
        Console.WriteLine(product.ProductName);
}

Console.WriteLine();
var groupJoinLinq = from shop in shops
                join product in products
                on shop.ShopId equals product.ShopId
                into productsGroup
                select new
                {
                    Products = productsGroup,
                    ShopName = shop.ShopName,
                };

foreach (var item in groupJoinMethod)
{
    Console.WriteLine(item.ShopName);

    foreach (var product in item.Products)
        Console.WriteLine(product.ProductName);
}

//GroupBy
Console.WriteLine();
Console.WriteLine("GroupBy");

var groupByMethod = products.GroupBy(product => product.PriceInGEL);
foreach (var group in groupByMethod)
{
    Console.WriteLine("Price: {0}", group.Key); 

    foreach (Product p in group)  
        Console.WriteLine("Product Name: {0}", p.ProductName);
}

Console.WriteLine();
var groupByLinq = from product in products
                  group product by product.PriceInGEL;

foreach (var group in groupByLinq)
{
    Console.WriteLine("Price: {0}", group.Key);

    foreach (Product p in group)  
        Console.WriteLine("Product Name: {0}", p.ProductName);
}

//GroupBy with multiple properties
Console.WriteLine();
Console.WriteLine("GroupBy with multiple properties");
var groupByMultipleMethods = products.GroupBy(p => new { p.ProductId, p.PriceInGEL });
foreach (var group in groupByMultipleMethods)
{
    Console.WriteLine($"ProductId: {group.Key.ProductId}, Price: {group.Key.PriceInGEL}");
    foreach (var product in group)
    {
        Console.WriteLine($"ProductID: {product.ProductId}, ProductName: {product.ProductName}");
    }
}

Console.WriteLine();

var groupByMultipleLinq = from p in products
                          group p by new { p.ProductId, p.PriceInGEL };
                          

foreach (var g in groupByMultipleLinq)
{
    Console.WriteLine($"ProductId: {g.Key.ProductId}, Price: {g.Key.PriceInGEL}");
    foreach (var product in g)
    {
        Console.WriteLine($"ProductID: {product.ProductId}, ProductName: {product.ProductName}");
    }
}

//Groupby with aggregate methods
Console.WriteLine();
Console.WriteLine("Groupby with aggregate methods");

var sumPrice = products.Sum(p => p.PriceInGEL);
Console.WriteLine("Sum: " + sumPrice);

var sumPriceQuery = (from p in products
                     select p).Sum(p => p.PriceInGEL);

Console.WriteLine("Sum: " + sumPriceQuery);

var productsCount = products.Count();
Console.WriteLine("Count: " + productsCount);

var maxPrice = products.Max(p => p.PriceInGEL);
Console.WriteLine("Max price: " + maxPrice);

var minPrice = products.Min(p => p.PriceInGEL);
Console.WriteLine("Min price: " + minPrice);

var avgPrice = products.Average(p => p.PriceInGEL);
Console.WriteLine("Average price: " + avgPrice);
