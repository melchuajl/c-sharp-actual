public class Customer
{
    public string CustomerID { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Customer> customers = new List<Customer>();

        //FileStream fs = new FileStream(@"D:\C# Training\Class\Data.csv", FileMode.Open, FileAccess.Read);
        //StreamReader sr = new StreamReader(fs);

        //while (!sr.EndOfStream)
        //{
        //    string data = sr.ReadLine();
        //    string[] array = data.Split(","); // generate an array where each column is an index in the array 
        //    customers.Add(new Customer { CustomerID = array[0], CompanyName = array[1], ContactName = array[2], ContactTitle = array[3], Address = array[4], City = array[5] });
        //}

        string[] allLines = File.ReadAllLines(@"D:\C# Training\Class\Data.csv");

        foreach (string line in allLines)
        {
            string[] array = line.Split(",");
            customers.Add(new Customer { CustomerID = array[0], CompanyName = array[1], ContactName = array[2], ContactTitle = array[3], Address = array[4], City = array[5] });
        }

        // at the end of this stage, all rows in the Excel file have been saved in my customers List

        Console.WriteLine("Please enter Customer ID (not case sensitive)");
        string userInput = Console.ReadLine().ToUpper();
        bool exists = false;

        foreach (Customer customer in customers)
        {
            if (customer.CustomerID == userInput)
            {
                Console.WriteLine($"{customer.CustomerID} {customer.CompanyName} \nContact Name: {customer.ContactName}, {customer.ContactTitle} \nAddress: {customer.Address}, {customer.City}");
                exists = true;
                break;
            }
        }

        if (exists == false)
        {
            Console.WriteLine("Customer ID does not exist"); 
        }

        //sr.Close();
        //fs.Close();
    }
}
