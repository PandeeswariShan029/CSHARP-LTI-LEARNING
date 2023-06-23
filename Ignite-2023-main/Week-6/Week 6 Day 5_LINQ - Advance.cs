//01

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Fill your code here
        List<Customer> customerList = new List<Customer>();
        List<Purchase> purchaseList = new List<Purchase>();

        Console.WriteLine("Enter Number of Customers :");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter Id :");
            Console.WriteLine("Enter First Name :");
            Console.WriteLine("Enter Last Name :");
            //Fill your code here
            int id = int.Parse(Console.ReadLine());
            string fName = Console.ReadLine();
            string lName = Console.ReadLine();
            customerList.Add(new Customer(id, fName, lName));
        }

        Console.WriteLine("Enter Number of Entry in database :");
        int m = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            Console.WriteLine("Enter Customer Id :");
            Console.WriteLine("Enter Purchased Date :");
            Console.WriteLine("Enter Amount :");
            //Fill your code here
            int id = int.Parse(Console.ReadLine());
            DateTime date = DateTime.Parse(Console.ReadLine());
            long amount = Int64.Parse(Console.ReadLine());
            purchaseList.Add(new Purchase(id, date, amount));
        }

        
        var res1 = (from cu in customerList join
                   pu in purchaseList on cu.Id equals pu.CustomerId
                   into result
                   from res in result 
                   group res by res.CustomerId into grp
                   select new{
                    Id = grp.Key,
                    Orders = grp 
                   }).OrderByDescending(o => o.Orders.Count()).Take(1);
        var name = new List<string>();
        foreach (var item in res1)
        {
            name = customerList.Where(c => c.Id == item.Id).Select(o => o.FirstName+" "+o.LastName).ToList();
        }
        

        System.Console.WriteLine("Favorite Customer : "+name[0]);
                         
    }
}

//-----------------------------------------------------------------------------

//02


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program{
	public static void Main(string[] args) {
		//Fill your code here
		System.Console.WriteLine("Enter number of companies");
		int num = Convert.ToInt32(Console.ReadLine());
		List<PlacedStudent> placedList = new List<PlacedStudent>(num);

		for (int i = 0; i < num; i++){
			System.Console.WriteLine("Enter company name");
			System.Console.WriteLine("Enter student name");
			string company = Console.ReadLine();
			string student = Console.ReadLine();
			placedList.Add(new PlacedStudent(company, student));
		}

		var resultSet = from student in placedList
						group student by student.CompanyName into grp
						select new {
							Company = grp.Key, 
							Students = from g in grp orderby g.StudentName select g
						};
		foreach (var set in resultSet){
			System.Console.WriteLine("Company Name : "+set.Company);
			foreach (var student in set.Students){
				System.Console.WriteLine(student.StudentName);
			}
		}
	}
}

//-------------------------------------------------------------------------------------
