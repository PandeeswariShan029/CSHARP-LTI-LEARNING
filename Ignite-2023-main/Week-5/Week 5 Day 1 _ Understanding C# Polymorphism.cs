
01-----------


using System;
public class Program
{
    public static void Main(string[] args)
    {
        TicketBooking tb = new TicketBooking();
        Console.WriteLine("Enter the mode of Payment:\n1.Cash Payment\n2.Wallet Payment\n3.Credit Card");

        int modee = Convert.ToInt32(Console.ReadLine());
        double amount;
        string creditCard, ccv, name, walletNumber;
        switch (modee)
        {
            case 1:
                //Fill your code here
                Console.WriteLine("Enter the Amount of Payment:");
                amount = Convert.ToDouble(Console.ReadLine());
                tb.MakePayment(amount);
                break;
            case 2:
                //Fill your code here
                Console.WriteLine("Enter the Wallet Number:");
                Console.WriteLine("Enter the Amount of Payment:");
                walletNumber = Console.ReadLine();
                amount = Convert.ToDouble(Console.ReadLine());
                tb.MakePayment(walletNumber,amount);
                break;
            case 3:
                //Fill your code here
                Console.WriteLine("Enter the Credit Card Number:");
                creditCard = Console.ReadLine();
                Console.WriteLine("Enter the Validity Date(dd/MM/yyyy):");
                ccv = Console.ReadLine();
                Console.WriteLine("Enter the Card Holder Name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter the Amount of Payment:");
                amount = Convert.ToDouble(Console.ReadLine());
                tb.MakePayment(creditCard, ccv, name,amount);
                break;
            case 4:
                Console.WriteLine("Please select the correct mode of payment...");
                break;
        }
    }
}

///////////////////////////

using System;
public class TicketBooking
{
    //Fill your code here
    public void MakePayment(double amount){
        Console.WriteLine("You have selected the Cash payment mode");
        Console.WriteLine($"The Amount is Rs.{amount}.");
    }

    public void MakePayment(string walletNumber, double amount){
        Console.WriteLine("You have selected the Wallet payment mode");
        Console.WriteLine($"Wallet Number: {walletNumber}");
        Console.WriteLine($"The Amount is Rs.{amount}.");
    }

    public void MakePayment(string creditCard, string ccv, string name, double amount){
        Console.WriteLine("You have selected the Credit Card payment mode");
        Console.WriteLine($"CreditCard Number:{creditCard}");
        Console.WriteLine($"Validity Date:{ccv}");
        Console.WriteLine($"Card Holder Name: {name}");
        Console.WriteLine($"The Amount is Rs.{amount}.");
    }
}



---------------------------------------------------------------------------

02 ---

using System;

class Program
{
    static void Main(string[] args)
    {
        //fill code here
        Stall s = new Stall();
        Console.WriteLine("Enter the stall type");
        string stallType = Console.ReadLine();
        Console.WriteLine("Enter the square feet");
        int squareFeet = Convert.ToInt32(Console.ReadLine());

        if(stallType == "Gold"){
            s.ComputeCost(stallType, squareFeet);
        }
        else if(stallType == "Diamond"){
            Console.WriteLine("Enter the number of TV");
            int numberOfTV = Convert.ToInt32(Console.ReadLine());
            s.ComputeCost(stallType, squareFeet,numberOfTV);
        }
        else if(stallType == "Platinum"){
            Console.WriteLine("Do you need a projector(yes/no)");
            bool projectorAvailability = Console.ReadLine() == "yes" ? true : false;
            s.ComputeCost(stallType, squareFeet, projectorAvailability);
        }
        else{
            Console.WriteLine("Invalid Type.");
        }
    }
}


////////////////////////


using System;

class Stall
{
    //Fill your code here

    public void ComputeCost(string stallType, int squareFeet){
        int amount = 100 * squareFeet;
        this.Display(stallType,amount);
    }

    public void ComputeCost(string stallType, int squareFeet, int numberOfTV){
        int amount = (150*squareFeet) + (numberOfTV*100);
        this.Display(stallType,amount);
    }

    public void ComputeCost(string stallType, int squareFeet, bool projectorAvailability){
        int amount = (200 * squareFeet) + (projectorAvailability ? 1000 : 0);
        this.Display(stallType,amount);
    }

    public void Display(string stallType, int amount){
        Console.WriteLine($"{stallType} costs Rs.{amount}");
    }

}


----------------------------------------------------------------------------------------

03 ------


using System;

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Event Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Detail");
            string detail = Console.ReadLine();
            Console.WriteLine("Enter Organizer");
            string organizer = Console.ReadLine();
            Console.WriteLine("Select Event Type 1.Exhibition 2.StageEvent");
            int ch = Convert.ToInt32(Console.ReadLine());
            //Fill Your Code Here
            if(ch == 1){
                Console.WriteLine("Enter stall count");
                int stallCount = Convert.ToInt32(Console.ReadLine());
                Exhibition ex = new Exhibition(name, detail, organizer, stallCount);
                Console.WriteLine(ex);
                ex.TotalCredit();
            }
            else if(ch == 2){
                Console.WriteLine("Enter Total shows");
                int TotalShow = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter seats per show");
                int SeatsPerShow = Convert.ToInt32(Console.ReadLine());
                StageEvent st = new StageEvent(name, detail, organizer, TotalShow, SeatsPerShow);
                Console.WriteLine(st);
                st.TotalCredit();
            }
            else{
                Console.WriteLine("Enter valid choice");
            }
        }
    }

////////////////////////

using System;
class Event
{
    protected string _name;
    protected string _detail;
    protected string _organizer;
    //Fill your code here

    public Event() { }
    public Event(string _name, string _detail, string _organizer){
        this._name = _name;
        this._detail = _detail;
        this._organizer = _organizer;
    }

    public virtual void TotalCredit(){
        Console.WriteLine("Credit Details");
    }
}


/////////////////////

using System;
class StageEvent : Event
{
    public int TotalShow { get; set; }
    public int SeatsPerShow { get; set; }
    
    public StageEvent(){}
    public StageEvent(string _name, string _detail, string _organizer, int _totalShow, int _seats)
    :base(_name, _detail, _organizer){
        this.TotalShow = _totalShow;
        this.SeatsPerShow = _seats;
    }
    
    public override void TotalCredit()
    {
        base.TotalCredit();
        Console.WriteLine($"Total Credit Gained is {((this.TotalShow * this.SeatsPerShow ) * 100)}");
    }
    public override string ToString()
    {
        string details = "";
        details += $"Event Name : {this._name}\n";
        details += $"Event Detail : {this._detail}\n";
        details += $"Event Organizeer : {this._organizer}\n";
        details += $"Total Events : {this.TotalShow}\n";
        details += $"Total Seats : {this.SeatsPerShow}";
        return details;
    }
}

///////////////////////

using System;
class Exhibition : Event
{
    public int StallCount { get; set; }
    //Fill your code here

    public Exhibition(string _name, string _detail, string _organizer, int _stallCount)
    :base(_name, _detail, _organizer){
        this.StallCount = _stallCount;
    }
    public override void TotalCredit(){
        base.TotalCredit();
        Console.WriteLine($"Total Credit Gained is {this.StallCount * 50}");
    }
    public override string ToString()
    {
        string details = "";
        details += $"Event Name : {this._name}\n";
        details += $"Event Detail : {this._detail}\n";
        details += $"Event Organizer : {this._organizer}\n";
        details += $"Stall Count : {this.StallCount}";
        return details;
    }

}




---------------------------------------------------------------------------------------------
05 ---

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Shapes\n1.Square\n2.Rectangle\n3.Circle\nEnter your choice");
        int choice = Convert.ToInt32(Console.ReadLine());
        //Fill your code here
        switch (choice){
            case 3 :
                Console.WriteLine("Enter the radius of the circle");
                double radious = Convert.ToDouble(Console.ReadLine());
                Circle cr = new Circle(radious);
                Console.WriteLine($"Perimeter of circle is {cr.Perimeter().ToString("0.00")}");
                break;
            case 2 :
                Console.WriteLine("Enter the length of the rectangle");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the width of the rectangle");
                double width = Convert.ToDouble(Console.ReadLine());
                Rectangle r = new Rectangle(length, width);
                Console.WriteLine($"Perimeter of rectangle is {r.Perimeter().ToString("0.00")}");
                break;
            case 1 :
                Console.WriteLine("Enter the side of the square");
                double side = Convert.ToDouble(Console.ReadLine());
                Square s = new Square(side);
                Console.WriteLine($"Perimeter of square is {s.Perimeter().ToString("0.00")}");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}

///////////////////

using System;
public abstract class Shape
{
    public abstract double Perimeter();
}


//////////////

using System;

class Circle : Shape
{
    private double _radius;

    public double Radius
    {
        get { return this._radius; }
        set { this._radius = value; }
    }
    public Circle(){}
    
    public Circle(double _radius){
        this._radius = _radius;
    }

    // Fill your code here. Define the abstract method Perimeter() 
    public override double  Perimeter(){
        double ans = (2 * 3.14 * this.Radius);
        return ans;
    }
}


//////////////////

using System;

class Square : Shape
{
    private double _side;

    public double Side
    {
        get { return this._side; }
        set { this._side = value; }
    }

    public Square(){}
    
    public Square(double _side){
        this._side = _side;
    }
    
    // Fill your code here. Define the abstract method Perimeter() 
    public override double  Perimeter(){
        double ans = (4 * this.Side);
        return ans;
    }
}


//////////////////

using System;

class Rectangle : Shape{
    private double _length;
    private double _width;

    public double Length
    {
        get { return this._length; }
        set { this._length = value; }
    }

    public double Width
    {
        get { return this._width; }
        set { this._width = value; }
    }
    public Rectangle(){}

    public Rectangle(double _length,double _width){
        this._length = _length;
        this._width = _width;
    }

    // Fill your code here. Define the abstract method Perimeter() 
    public override double  Perimeter(){
        double ans = 2 * (this.Length + this.Width);
        return ans;
    }
}
