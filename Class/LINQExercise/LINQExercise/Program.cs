namespace LINQExercise
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            
            FileStream fs = new FileStream(@"D:\C# Training\Class\Data.csv", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string data = sr.ReadLine();
                string[] array = data.Split(","); // generate an array where each column is an index in the array 
                customers.Add(new Customer { CustomerID = array[0], CompanyName = array[1], ContactName = array[2], ContactTitle = array[3], Address = array[4], City = array[5] });
            }

            Console.WriteLine("Please enter Customer ID (not case sensitive)");
            string userInput = Console.ReadLine();

            var query = customers.Find(x => x.CustomerID == userInput.ToUpper()); 

            if (query != null)
            {
                Console.WriteLine($"{query.CustomerID} {query.CompanyName} \nContact Name: {query.ContactName}, {query.ContactTitle} \nAddress: {query.Address}, {query.City}");
            } 
            else
            {
                Console.WriteLine("Customer ID does not exist");
            }

            sr.Close();
            fs.Close();
        }
    }
}
