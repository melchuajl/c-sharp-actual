public class Product : IComparable<Product> // also referred to as a data model class, IComparable must be defined within the data model
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }

    public int CompareTo(Product? p)
    {
        if (this.Quantity > p.Quantity)
        {
            return 1;
        } 
        else if (this.Quantity < p.Quantity)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}

public class SortByQuantity : IComparer<Product> // this creates a separate sorter that can be reused by other lists
{
    public int Compare(Product? x, Product? y)
    {
        if (x.Quantity > y.Quantity)
        {
            return 1; 
        }
        else if (x.Quantity < y.Quantity)
        {
            return -1; 
        }
        else
        {
            return 0;
        }
    }
}

public class SortByPrice : IComparer<Product> // this creates a separate sorter that can be reused by other lists
{
    public int Compare(Product? x, Product? y)
    {
        if (x.Price > y.Price)
        {
            return 1;
        }
        else if (x.Price < y.Price)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}

public class SortByBrand : IComparer<Product> // this creates a separate sorter that can be reused by other lists
{
    public string Compare(Product? x, Product? y)
    {
        if (x.Brand[0] > y.Brand[0])
        {
            return 1;
        }
        else if (x.Brand[0] < y.Brand[0])
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        List<Product> products = new List<Product>();
//        Product p1 = new Product { Id = 1, Name = "Laptop", Brand = "Lenovo", Quantity = 1, Price = 1200 };
//        Product p2 = new Product();
//        products.Add(p1);
//        products.Add(p2);
//        products.Add(new Product { Id = 3, Name = "Tablet", Brand = "Dell", Quantity = 5, Price = 500 }); // anon variable is created with respective Property fields

//        Console.WriteLine(products[1].Name); // returns the specific Property

//        foreach (Product p in products)
//        {
//            Console.WriteLine(p.Name);
//        }
//    }
//}

public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        products.Add(new Product { Id = 1, Name = "Laptop", Brand = "Lenovo", Quantity = 10, Price = 1200});
        products.Add(new Product { Id = 2, Name = "Mouse", Brand = "Lenovo", Quantity = 26, Price = 30 });
        products.Add(new Product { Id = 3, Name = "Tablet", Brand = "Dell", Quantity = 5, Price = 560});
        products.Add(new Product { Id = 4, Name = "Laptop", Brand = "Dell", Quantity = 10, Price = 700 });
        products.Add(new Product { Id = 5, Name = "Laptop", Brand = "Apple", Quantity = 1, Price = 1200 });
        products.Add(new Product { Id = 6, Name = "Tablet", Brand = "Apple", Quantity = 10, Price = 800 });
        products.Add(new Product { Id = 7, Name = "Desktop", Brand = "Asus", Quantity = 2, Price = 2100 });
        products.Add(new Product { Id = 8, Name = "Laptop", Brand = "Asus", Quantity = 11, Price = 1299 });
        products.Add(new Product { Id = 9, Name = "Phone", Brand = "Google", Quantity = 8, Price = 1200 });
        products.Add(new Product { Id = 10, Name = "Phone", Brand = "Samsung", Quantity = 3, Price = 1800 });

        //foreach (Product p in products)
        //{
        //    if (p.Quantity > 5)
        //    {
        //        Console.WriteLine($"There are {p.Quantity} {p.Brand} {p.Name} devices left of unit price ${p.Price}");
        //    }
        //}

        //products.Sort(); // refer to CompareTo method defined in the Product class, which was inherited from IComparable  
        products.Sort(new SortByPrice()); // instantiates an IComparer class (helps to give them meaningful names when creating the class)
        foreach (Product p in products)
        {
            Console.WriteLine($"There are {p.Quantity} {p.Brand} {p.Name} devices left of unit price ${p.Price}");

        }

    }
}
