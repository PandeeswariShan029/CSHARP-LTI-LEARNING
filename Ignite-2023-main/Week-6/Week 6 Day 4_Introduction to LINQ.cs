//----------------------------------------------------------------------------------------------

//01

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of Courses");
        int n = Convert.ToInt32(Console.ReadLine());
        List<Course> courseList = new List<Course>(n);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Course {0} Details",(i+1));
            
            Console.WriteLine("Enter the id");
            string id = Console.ReadLine();
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the category");
            string cat = Console.ReadLine();
            Console.WriteLine("Enter the price");
            int price = Convert.ToInt32(Console.ReadLine());
            //Fill your code here
            courseList.Add(new Course(id, name, cat, price));
        }
        //Fill your code here
        var result = (from course in courseList
                      group course by course.Category into newC
                      select new{
                        Name = newC.Key,
                        Price = newC.Min(e => e.Price)
                        });
        
        foreach (var item in result)
        {
            System.Console.WriteLine("Course " + item);
        }
    }
}

/////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;

class Course
{
    private string _id;
    private string _name;
    private string _category;
    private int _price;

    public Course()
    {
    }

    public Course(string _id, string _name, string _category, int _price)
    {
        this._id = _id;
        this._name = _name;
        this._category = _category;
        this._price = _price;
    }

    public string Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public string Category { get => _category; set => _category = value; }
    public int Price { get => _price; set => _price = value; }
}


//----------------------------------------------------------------------------------------------

//02

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //fill code here
        System.Console.WriteLine("Enter the number of names");
        int num = Convert.ToInt32(Console.ReadLine());
        string []nameList = new string[num];

        System.Console.WriteLine("Enter the names");
        for (int i = 0; i < num; i++)
        {
            nameList[i] = Console.ReadLine();
        }

        System.Console.WriteLine("Enter the min string size");
        int minLength = Convert.ToInt32(Console.ReadLine());
        string []ans = UserProgramCode.FilterArray(nameList, minLength);
        if(ans.Length > 0){
            System.Console.WriteLine("Filtered Names");
            foreach (string name in ans)
            {
                System.Console.WriteLine(name);
            }
        }
        else{
            System.Console.WriteLine("No names present in the minimum size "+minLength);
        }

    }
}

////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class UserProgramCode
{
    public static string[] FilterArray(string[] nameList, int minLength) {
        //fill code here
        var resultset = (from name in nameList
                        where name.Length < minLength
                        select name).ToArray();
        
        
        return resultset;
    }
}


//----------------------------------------------------------------------------------------------

//03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of students");
        int n = Convert.ToInt32(Console.ReadLine());
        List<Student> studentList = new List<Student>();
        string name;
        int id, age;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Student {0} Details", (i + 1));
            Console.WriteLine("Enter the id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age");
            age = Convert.ToInt32(Console.ReadLine());
            
            //fill code here
            studentList.Add(new Student(id,name, age));
        }

        //fill code here
        string []sortedName = (from student in studentList
                              orderby student.Name
                              select student.Name).ToArray();

        Console.WriteLine("Sorted student names");
        
        foreach (string sName in sortedName)
        {
            System.Console.WriteLine(sName);
        }
    }
}


////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    private int _id;
    private string _name;
    private int _age;

    public Student()
    {
    }

    public Student(int _id, string _name, int _age)
    {
        this._id = _id;
        this._name = _name;
        this._age = _age;
    }

    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public int Age { get => _age; set => _age = value; }
}


//----------------------------------------------------------------------------------------------

//04

using System.Collections;
using System;
using System.Linq;
public class Program
{
    public static void Main(){
        //Fill your code here
        Console.WriteLine("Enter the number of Courses");
        int n = int.Parse(Console.ReadLine());
        ArrayList courseList = new ArrayList(n);

        for(int i=1;i<=n;i++)
        {
            Console.WriteLine("Course {0} Details", i);
            Console.WriteLine("Enter the id");
            string id = Console.ReadLine();
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the category");
            string cat = Console.ReadLine();
            Console.WriteLine("Enter the price");
            int price = Convert.ToInt32(Console.ReadLine());
            //Fill your code here
            courseList.Add(new Course(id, name, cat, price));
        }
        Console.WriteLine("Enter the price limit");
        Console.WriteLine("Enter the min limit");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the max limit");
        int max = Convert.ToInt32(Console.ReadLine());
        //Fill your code here

        var courseAns = (from Course course in courseList
                        where course.Price >= min && course.Price <= max
                        select course);
        
        if(courseAns.Any()){
            System.Console.WriteLine($"Courses which is in limit {min} to {max}");
            int i = 0;
            foreach (Course course in courseAns)
            {
                i++;
                System.Console.WriteLine($"Course {i} Details");
                System.Console.WriteLine("Course Id : "+course.Id);
                System.Console.WriteLine("Course Name : "+course.Name);
                System.Console.WriteLine("Course Category : "+course.Category);
                System.Console.WriteLine("Course Price : "+course.Price);
            }
        }
        else
            System.Console.WriteLine("No course available in this limit");
    }
 }



//----------------------------------------------------------------------------------------------

//05

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of purchase");
        int n = int.Parse(Console.ReadLine());
        //Fill your code here
        List<Purchase> purchaseList = new List<Purchase>(n);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter customer id");
            int cId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter purchased date");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount");
            int amount = int.Parse(Console.ReadLine());
            //Fill your code here
            purchaseList.Add(new Purchase(cId, date, amount));
        }
        Console.WriteLine("Start date");
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("End date");
        DateTime endDate = DateTime.Parse(Console.ReadLine());
        
        var ResultSet = from purchase in purchaseList
                        where purchase.PurchasedDate >= startDate && purchase.PurchasedDate <= endDate
                        select purchase;
        if(ResultSet.Any()){
            Console.WriteLine("{0,-10}{1,-15}{2,-10}","Customer","PurchasedDate","Amount");
            foreach (Purchase item in ResultSet){
                Console.WriteLine("{0,-10}{1,-15}{2,-10}",item.CustomerId,item.PurchasedDate.ToString("yyyy-MM-dd"),item.Amount);
            }
        }
        else   
            System.Console.WriteLine("No purchase found");
    }
}


//----------------------------------------------------------------------------------------------
