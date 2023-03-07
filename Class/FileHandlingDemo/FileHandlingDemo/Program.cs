//public class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Email { get; set; }
//    public int Age { get; set; }
//}


//public class Program
//{
//    public static void Main(string[] args)
//    {
//        List<Employee> employees = new List<Employee>();
//        employees.Add(new Employee { Id = 9, Name = "Amanda", Email = "zamanda@work.com", Age = 20 });
//        employees.Add(new Employee { Id = 8, Name = "Ben", Email = "fben@work.com", Age = 30 });
//        employees.Add(new Employee { Id = 3, Name = "Charlie", Email = "tcharlie@work.com", Age = 45 });
//        employees.Add(new Employee { Id = 5, Name = "Daphne", Email = "hdaphne@work.com", Age = 33 });
//        employees.Add(new Employee { Id = 4, Name = "Elaine", Email = "yelaine@work.com", Age = 27 });
//        employees.Add(new Employee { Id = 6, Name = "Frederick", Email = "qfred@work.com", Age = 25 });
//        employees.Add(new Employee { Id = 7, Name = "Gerard", Email = "kgerard@work.com", Age = 41 });
//        employees.Add(new Employee { Id = 2, Name = "Holly", Email = "pholly@work.com", Age = 29 });
//        employees.Add(new Employee { Id = 1, Name = "Ian", Email = "zian@work.com", Age = 49 });
//        employees.Add(new Employee { Id = 10, Name = "Jeremy", Email = "rjeremy@work.com", Age = 1350 });

//        FileStream fs = new FileStream(@"D:\C# Training\Class\Employees.csv", FileMode.Create, FileAccess.ReadWrite); // if the file already exists, it will Create and overwrite. to edit, use FileMode.Append and FileAccess.Write
//        StreamWriter sw = new StreamWriter(fs);
//        //Console.WriteLine("Enter some information");
//        //string text = Console.ReadLine();
//        //sw.WriteLine(text);
//        sw.WriteLine("Id,Name,Email,Age");
//        foreach (Employee emp in employees)
//        {
//            sw.WriteLine($"{emp.Id},{emp.Name},{emp.Email},{emp.Age}");
//        }
//        sw.Close(); // this is very important to secure your data. once closed you need to reopen the file to read/write again. 
//        fs.Close();
//    }
//}

public class Program
{
    public static void Main(string[] args)
    {
        FileStream fs = new FileStream(@"D:\C# Training\Class\Employees.csv", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        string data = sr.ReadLine();

        while (data != null)
        {
            Console.WriteLine(data);
        }

        sr.Close();
        fs.Close();
    }
}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        //FileInfo f = new FileInfo(@"D:\C# Training\Class\File.txt");

//        //// Properties
//        //Console.WriteLine(f.CreationTime);
//        //Console.WriteLine(f.Length); // returns the size of the file in bytes

//        //// Methods
//        //f.CopyTo(@"desired destination");
//        //f.MoveTo(@"desired destination");
//        //f.Delete();

//        //DirectoryInfo d = new DirectoryInfo(@"C:\Windows");
//        //FileInfo[] files = d.GetFiles("*.exe"); // searches with specific patterns. optional. GetFiles(); will return all files. 
//        //foreach (FileInfo file in files)
//        //{
//        //    Console.WriteLine(file.Name); 
//        //}

//        // File class has pre-defined static methods we can use to read/write without explicitly creating a stream
//        File.Create(@"D:\C# Training\Class\NewText.txt");
//        File.AppendAllText(@"D:\C# Training\Class\NewText.txt", "Hello World"); 

//    }
//}