// Q1

using System;

class Program{
    //fill code here
    delegate void rectangleDelegate(double width, double height);
    public void PrintArea(double height, double width){
        //fill code here
        Console.WriteLine("Area is: "+ (width*height));
    }

    public void PrintPerimeter(double height, double width){
        //fill code here
        Console.WriteLine("Perimeter is: "+ 2*(width+height));
    }

    static void Main(string[] args){
        Program p = new Program();    
        rectangleDelegate RactMethod = p.PrintArea;
        RactMethod += p.PrintPerimeter;

        Console.WriteLine("Enter the width");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height");
        double height = Convert.ToDouble(Console.ReadLine());

        RactMethod.Invoke(width, height);
    }
}

//-------------------------------------------------------------------

//Q2

using System;

class Program{
    //fill code here
    delegate void CalculateDelegate(double width, double height);
    public void Addition(double num1, double num2){
        //fill code here
        Console.WriteLine("The sum is : "+ (num1+num2));
    }

    public void Subtract(double num1, double num2){
        //fill code here
        Console.WriteLine("The subtraction is : "+ (num1-num2));
    }

    static void Main(string[] args){
        Program p = new Program();    
        CalculateDelegate CalcMethod = p.Addition;
        CalcMethod += p.Subtract;

        Console.WriteLine("Enter the num1");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the num2");
        double num2 = Convert.ToDouble(Console.ReadLine());

        CalcMethod.Invoke(num1, num2);
    }
}


//-------------------------------------------------------------------

//Q3

using System;

class Program
{
    delegate void NameDelegate();
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the first name:");
        string fName = Console.ReadLine();
        Console.WriteLine("Enter the last name:");
        string lName = Console.ReadLine();
        Customer cm = new Customer(fName, lName);
        
        //fill code here
        NameDelegate printName = cm.DisplayFirstName;
        printName += cm.DisplayLastName;

        Console.WriteLine("Customer Details");
        printName.Invoke();
    }
}

//////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;

class Customer
{
    public string _firstName;
    public string _lastName;

    public Customer(string _firstName, string _lastName)
    {
        this._firstName = _firstName;
        this._lastName = _lastName;
    }

    public void DisplayFirstName()
    {
        Console.WriteLine("First Name: "+this._firstName);
    }

    public void DisplayLastName()
    {
        Console.WriteLine("Last Name: "+this._lastName);
    }
}


//-------------------------------------------------------------------

//Q4

using System;
using System.Collections.Generic;

class Program
{
    public delegate int CompareBookDelegate(Book b1,Book b2);
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the book 1 details");
        Console.WriteLine("Enter the title");
        string title1 = Console.ReadLine();
        Console.WriteLine("Enter the author");
        string author1 = Console.ReadLine();
        Console.WriteLine("Enter the price");
        double price1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the noOfPages");
        int noOfPages1 = Convert.ToInt32(Console.ReadLine());
        Book b1 = new Book(title1, author1, price1, noOfPages1);

        Console.WriteLine("Enter the book 2 details");
        Console.WriteLine("Enter the title");
        string title2 = Console.ReadLine();
        Console.WriteLine("Enter the author");
        string author2 = Console.ReadLine();
        Console.WriteLine("Enter the price");
        double price2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the noOfPages");
        int noOfPages2 = Convert.ToInt32(Console.ReadLine());
        Book b2 = new Book(title2, author2, price2, noOfPages2);

        //Fill your code here
        CompareBookDelegate compare = Book.CompareBook;
        if(compare(b1,b2) == 0)
            Console.WriteLine("Books are equal");
        else
            Console.WriteLine("Books are not equal");
    }
}

////////////////////////////////

using System;
using System.Collections.Generic;

public class Book
{
    private string _title;
    private string _author;
    private double _amount;
    private int _noOfPages;

    public Book(string _title, string _author, double _amount, int _noOfPages)
    {
        this._title = _title;
        this._author = _author;
        this._amount = _amount;
        this._noOfPages = _noOfPages;
    }
    public string Title
    {
        get{
            return this._title;
        }
        set{
            this._title = value;
        }
    }

    public string Author
    {
        get{
            return this._author;
        }
        set{
            this._author = value;
        }
    }

    public double Amount
    {
        get{
            return this._amount;
        }
        set{
            this._amount = value;
        }
    }

    public int NoOfPages
    {
        get{
            return this._noOfPages;
        }
        set{
            this._noOfPages = value;
        }
    }

    public static int CompareBook(Book book1,Book book2)
    {
        //Fill your code here
        return book1.Title.CompareTo(book2.Title);
    }
}


//-------------------------------------------------------------------

//Q5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of halls:");
        int n = Convert.ToInt32(Console.ReadLine());
        List<Hall> hallList = new List<Hall>();
        //fill code here
        Hall hall = new Hall();
        Func<string, Hall> create = Hall.CreateHall;
        Action<List<Hall>> display = hall.DisplayHallDetails;

        for (int i = 0; i < n; i++){
            Console.WriteLine("Enter hall-"+(i+1)+" details:");
            string details = Console.ReadLine();
            hallList.Add(create(details));
        }
        
        Console.WriteLine("Enter the minimum price to filter:");
        double min = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the maximum price to filter:");
        double max = Convert.ToDouble(Console.ReadLine());
        
        //fill code here
        Predicate<double> predicate = (costPerDay) => {return (costPerDay >= min && costPerDay <= max); };
        hallList = hall.FilterHall(hallList, predicate);
        display.Invoke(hallList);
    }
}


//////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hall
{
    string _hallName;
    double _costPerDay;
    DateTime _bookingDate;
    string _ownerName;

    //fill code here
    public Hall(){}
    public Hall(string _hallName, double _costPerDay, DateTime _bookingDate, string _ownerName){
        this._hallName = _hallName;
        this._costPerDay = _costPerDay;
        this._bookingDate = _bookingDate;
        this._ownerName = _ownerName;
    }
    public static Hall CreateHall(string hallDetail)
    {
        //fill code here
        string []data = hallDetail.Split(",");
        string []date = data[2].Split("-");
        Hall hall = new Hall(data[0], Convert.ToDouble(data[1]), Convert.ToDateTime(date[1]+"-"+date[0]+"-"+date[2]), data[3]);
        return hall;
    }

    public List<Hall> FilterHall(List<Hall> hallList, Predicate<double> predicate)
    {
        //fill code here
        List<Hall> newHall = new List<Hall>();
        for (int i = 0; i < hallList.Count; i++){
            if(predicate(hallList[i]._costPerDay))
                newHall.Add(hallList[i]);
        }
        return newHall;
    }

    public void DisplayHallDetails(List<Hall> hallList)
    {
        //fill code here
        if(hallList.Count > 0){
        Console.WriteLine("{0} {1,15} {2,15} {3,15}", "Hall name", "Cost per day", "Booking date", "Owner name");
        //fill code here
        foreach (Hall hall in hallList){
            Console.WriteLine("{0} {1,15} {2,15} {3,15}", hall._hallName, hall._costPerDay.ToString("0.0"), hall._bookingDate.ToString("dd-MM-yyyy"), hall._ownerName);
        }
        }
        else    
            Console.WriteLine("No hall for that range.");
    }

}

//---------------------------------------------------------------------------

