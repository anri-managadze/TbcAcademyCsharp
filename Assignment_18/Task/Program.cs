using System.Linq;
using Task;
using static System.Formats.Asn1.AsnWriter;

var products = new List<Product>()
        {
            new Product { Id = 1, Name = "Book", Price = 99.99m, StoreId =4 },
            new Product { Id = 2, Name = "Wine", Price = 25.99m, StoreId =2 },
            new Product { Id = 3, Name = "Moto", Price = 1500.99m, StoreId =1 },
            new Product { Id = 4, Name = "Fruits", Price = 15.99m, StoreId =3 },
        };

 var stores = new List<Store>()
        {
            new Store { Id = 1, Name = "Sport Store", Address = "Tbilisi" },
            new Store { Id = 2, Name = "Super Store", Address = "Qutaisi" },
            new Store { Id = 3, Name = "Super Market", Address = "Batumi" },
            new Store { Id = 4, Name = "Books Store", Address = "Rustavi" },
        };

var stores2 = new List<Store>()
        {
            new Store { Id = 1, Name = "Store 5", Address = "Telavi" },
            new Store { Id = 2, Name = "Store 6", Address = "Borjomi" },
            new Store { Id = 3, Name = "Market 7", Address = "Zugdidi" },
            new Store { Id = 4, Name = "Store 8", Address = "Khashuri" },
        };

//Union Method 
var unionMethod = stores.Union(stores2);
Console.WriteLine("Union:");
foreach (var item in unionMethod)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine();
//Union Query
var unionQuery = (from store1 in stores select store1.Id)
                            .Union(from store2 in stores2 select store2.Id);

Console.WriteLine("Union with query:");
foreach (var item in unionQuery)
{
    Console.WriteLine(item);
}
Console.WriteLine();

//Join Method
var joinMethod = products.Join(stores, x => x.Id,x =>x.Id, (p, s)=> new {productname=p.Name,storename=s.Name });

Console.WriteLine("Join Method:");
foreach (var item in joinMethod)
{
    Console.WriteLine($"Product: {item.productname}, Store: {item.storename}");
}
Console.WriteLine();

//Join Query
var joinQuery = from product in products
                join store in stores on product.StoreId equals store.Id
                select new { product.Name, store.Address};
Console.WriteLine("Join Query:");
foreach (var item in joinQuery)
{
    Console.WriteLine($"Product: {item.Name}, Store Address: {item.Address}");
}
Console.WriteLine();

//Group join

var groupJoin = products.GroupJoin(stores,  
                                p => p.StoreId, 
                                s => s.Id,     
                                (s, productgroup) => new 
                                {
                                    products=productgroup,
                                    name=s.Name,
                                });
foreach (var item in groupJoin)
{
    Console.WriteLine(item.name);

    foreach (var items in item.products)
        Console.WriteLine(items.Name);
}
//group by method
var groupBy = products.GroupBy(p => p.Id);
Console.WriteLine("Group By Product Id:");
foreach (var group in groupBy)
{
    Console.WriteLine($"Product ID: {group.Key}");
    foreach (var product in group)
    {
        Console.WriteLine($"Product: {product.Name}");
    }
}
Console.WriteLine();

//group by query
var groupbyQuery = from product in products
                          group product by product.Id into group1
                          select group1;
Console.WriteLine("Group By Query Product Id:");
foreach (var group in groupbyQuery)
{
    Console.WriteLine($"Product ID: {group.Key}");
    foreach (var product in group)
    {
        Console.WriteLine($"Product: {product.Name}");
    }
}

//Group By Multiple Properties

var groupByMultiple = products.GroupBy(p => new { p.Id, p.Price });
Console.WriteLine("Group By Multiple Properties:");
foreach (var group in groupByMultiple)
{
    Console.WriteLine($"Product ID: {group.Key.Id}, Price: {group.Key.Price}");
    foreach (var product in group)
    {
        Console.WriteLine($"Product: {product.Name}");
    }
}
Console.WriteLine();

// Group By + Aggregate Methods
var groupByAggregateQuery = products.GroupBy(p => p.StoreId)
                                    .Select(g => new
                                    {
                                        ShopId = g.Key,
                                        TotalPrice = g.Sum(p => p.Price),
                                        AveragePrice = g.Average(p => p.Price)
                                    });
Console.WriteLine("Group By + Aggregate Methods:");
foreach (var item in groupByAggregateQuery)
{
    Console.WriteLine($"Shop ID: {item.ShopId}");
    Console.WriteLine($"Total Price: {item.TotalPrice}");
    Console.WriteLine($"Average Price: {item.AveragePrice}");
}

