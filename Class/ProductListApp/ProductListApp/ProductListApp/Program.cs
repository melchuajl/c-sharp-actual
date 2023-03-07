using Microsoft.VisualBasic;

namespace ProductListApp
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }

    internal class Program
    {
        public static List<Product> products = new List<Product>();

        static void AddProduct()
        {
            Console.WriteLine("Enter product id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter brand");
            string brand = Console.ReadLine();
            Console.WriteLine("Enter quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter unit price");
            float price = Convert.ToSingle(Console.ReadLine());

            products.Add(new Product { Id = id, Name = name, Brand = brand, Quantity = quantity, Price = price });

            // Just to personally confirm the details of the added product
            Console.WriteLine($"New product added! Product Id: {id}, {brand} {name}, Quantity: {quantity}, Price: ${price}");

        }

        static void FindProduct(int id)
        {
            try
            {
                var pF = products.Find(x => x.Id == id);

                if (pF == null)
                {
                    throw new Exception($"Product Id {id} does not exist");
                }

                Console.WriteLine($"Product Id: {pF.Id}, {pF.Brand} {pF.Name}, Quantity: {pF.Quantity}, Price: ${pF.Price}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void GetAllProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("There are no products to display");
            }

            foreach (Product p in products)
            {
                Console.WriteLine($"Product Id: {p.Id}, {p.Brand} {p.Name}, Quantity: {p.Quantity}, Price: ${p.Price}");
            }
        }

        static void UpdateProduct(int id)
        {
            try
            {
                var pU = products.Find(x => (x.Id == id));

                if (pU == null)
                {
                    throw new Exception($"Product Id {id} does not exist");
                }

                Console.WriteLine("Enter new product name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter new brand");
                string brand = Console.ReadLine();
                Console.WriteLine("Enter new quantity");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter new unit price");
                float price = Convert.ToSingle(Console.ReadLine());

                // Replacing original property values with new user inputs
                pU.Name = name;
                pU.Brand = brand;
                pU.Quantity = quantity;
                pU.Price = price;

                Console.WriteLine($"Product Id {id} updated successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void DeleteProduct(int id)
        {
            try
            {
                var pD = products.Find(x => (x.Id == id));

                if (pD == null)
                {
                    throw new Exception($"Product Id {id} does not exist");
                }

                products.Remove(pD);
                Console.WriteLine($"Product Id {id} deleted successfully");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            string cont;

            do
            {
                Console.WriteLine($"Select one of the following options:\n1. Add product\n2. Find product\n3. Get all products\n4. Update product\n5. Delete product");
                int userInput = Convert.ToInt16(Console.ReadLine());

                switch(userInput)
                {
                    // Add product
                    case 1:
                        AddProduct();

                        Console.WriteLine("Would you like to restart from the main menu? y/n"); 
                        cont = Console.ReadLine();
                        break;

                    // Find product
                    case 2:
                        Console.WriteLine("Please enter product Id"); 
                        int idFind = Convert.ToInt32(Console.ReadLine());
                        FindProduct(idFind);

                        Console.WriteLine("Would you like to restart from the main menu? y/n");
                        cont = Console.ReadLine();
                        break;

                    // Get all products 
                    case 3:
                        GetAllProducts();
                        Console.WriteLine("Would you like to restart from the main menu? y/n");
                        cont = Console.ReadLine();
                        break;

                    // Update product
                    case 4:
                        Console.WriteLine("Please enter product Id to update");
                        int idUpdate = Convert.ToInt32(Console.ReadLine());
                        UpdateProduct(idUpdate);

                        Console.WriteLine("Would you like to restart from the main menu? y/n");
                        cont = Console.ReadLine();
                        break;

                    // Delete product
                    case 5:
                        Console.WriteLine("Please enter product Id to delete");
                        int idDelete = Convert.ToInt32(Console.ReadLine());
                        DeleteProduct(idDelete);

                        Console.WriteLine("Would you like to restart from the main menu? y/n");
                        cont = Console.ReadLine();
                        break;

                    // If invalid option is selected
                    default:
                        Console.WriteLine($"Invalid choice \nWould you like to restart from the main menu? y/n");
                        cont = Console.ReadLine(); 
                        break;
                }

            } while (cont == "y" || cont == "Y");
        }
    }
}