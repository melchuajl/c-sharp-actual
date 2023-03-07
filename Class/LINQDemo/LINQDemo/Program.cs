namespace LINQDemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Specify data source
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Laptop", Brand = "Lenovo", Quantity = 10, Price = 1200 });
            products.Add(new Product { Id = 2, Name = "Mouse", Brand = "Lenovo", Quantity = 26, Price = 30 });
            products.Add(new Product { Id = 3, Name = "Tablet", Brand = "Dell", Quantity = 5, Price = 560 });
            products.Add(new Product { Id = 4, Name = "Laptop", Brand = "Dell", Quantity = 10, Price = 700 });
            products.Add(new Product { Id = 5, Name = "Laptop", Brand = "Apple", Quantity = 1, Price = 1200 });
            products.Add(new Product { Id = 6, Name = "Tablet", Brand = "Apple", Quantity = 10, Price = 800 });
            products.Add(new Product { Id = 7, Name = "Desktop", Brand = "Asus", Quantity = 2, Price = 2100 });
            products.Add(new Product { Id = 8, Name = "Laptop", Brand = "Asus", Quantity = 11, Price = 1299 });
            products.Add(new Product { Id = 9, Name = "Phone", Brand = "Google", Quantity = 8, Price = 1200 });
            products.Add(new Product { Id = 10, Name = "Phone", Brand = "Samsung", Quantity = 3, Price = 1800 });

            // Step 2: Create the query
            //var query = from p in products where p.Quantity > 5 && p.Quantity < 20 select p;
            //var query = from p in products orderby p.Price descending select p;
            var query = products.Where(p => p.Name.ToLower().Contains('a')); ;


            // Step 3: Execute the query
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Brand} {item.Name} \nQuantity: {item.Quantity} \nPrice: {item.Price}"); 
            }
        }
    }
}