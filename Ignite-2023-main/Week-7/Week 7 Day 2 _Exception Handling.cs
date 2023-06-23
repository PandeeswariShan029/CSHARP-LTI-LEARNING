// ----------- 01 

using System;
class Program
{
    static void Main(string[] args)
    {
        string type;
        int deposit, costPerDay;
        try{
            //fill code here

            Console.WriteLine("Enter the item type name");
            type = Console.ReadLine();

            Console.WriteLine("Enter the deposit");
            deposit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the cost per day");
            costPerDay = Convert.ToInt32(Console.ReadLine());

           //Console.WriteLine("Item type details");
            Console.WriteLine("Item type details");
            Console.WriteLine("Name:"+type);
            Console.WriteLine("Deposit:"+deposit);
            Console.WriteLine("Cost per day:"+costPerDay);
        }
        catch(Exception e){
            Console.WriteLine("Input string was not in the correct format");
        }
        
    }
}


//--------------------------------------------------------------------------

//---02

using System;
public class Program{
    public static void Main(){
        Console.WriteLine("Enter the Event Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the Event Organizer:");
        string organizer = Console.ReadLine();
        Console.WriteLine("Enter the Event Type(Exhibition/Others):");
        string type = Console.ReadLine();
        //fill your code
        Event ev = null;
        try{
            if(type == "Exhibition"){
                System.Console.WriteLine("Enter No.of Stalls:");
                int stalls = Convert.ToInt32(Console.ReadLine());
               Exhibition exh = new Exhibition(name, type, organizer, stalls);
                exh.Display();
            }
            else if(type=="Others"){
                ev = new Event(name, type, organizer);
                throw  new Exception("Null Reference Exception... Event Type is not Exhibition");
            }
            else{
                throw new Exception("Invalid event type...");
            }
        }
        catch(Exception e){
            System.Console.WriteLine(e.Message); 
            ev?.Display();
        }
       
    }
}

////////////////////////

using System;
public class Event
{
    private string name;
    private string type;
    private string organizer;
    //fill your code
    public string Name { get{return this.name;} set{this.name = value;} }
    public string Type { get{return this.type;} set{this.type = value;} }
    public string Organizer { get{return this.organizer;} set{this.organizer = value;} }
    public Event(){}
    public Event(string _name, string _type, string _organizer){
        this.Name = _name;
        this.Type = _type;
        this.Organizer = _organizer;
    }
    public void Display(){
        Console.WriteLine("Event Name: "+this.Name);
        Console.WriteLine("Event organizer: "+this.Organizer);
        Console.WriteLine("Event Type: "+this.Type);
    }
}

///////////////////////

using System;
public class Exhibition : Event
{
    private int noOfStalls;
    //fill your code
    public int NoOfStalls { get{return this.noOfStalls;} set{this.noOfStalls = value;} }
    public Exhibition(string _name, string _type, string _organizer, int _noOfStalls): base(_name, _type, _organizer){
        this.NoOfStalls = _noOfStalls;
    }
    public void Display(){
        base.Display();
        System.Console.WriteLine("No of Stalls: "+this.NoOfStalls);
    }
}


//--------------------------------------------------------------------------


//---04

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the booking details");
        //fill code here
        string seats = Console.ReadLine();
        int total = seats.Length;
        Console.WriteLine("Enter the seat number to book");
        int seatNo = Convert.ToInt32(Console.ReadLine())-1;

        try{
            if(seatNo < total && seats[seatNo] == '0')
                System.Console.WriteLine("Booked successfully");
            else if(seatNo < total && seats[seatNo] == '1')
                throw new SeatNotAvailableException("Seat booked already");
                
            else
                throw new SeatNotAvailableException("Array index is out of range.");
        }
        catch(SeatNotAvailableException snae){
            System.Console.WriteLine(snae.Message);
        }
    }
}

////////////////////////////////////////

using System;

class SeatNotAvailableException : Exception
{
    //fill code here
    public SeatNotAvailableException(string msg) : base(msg){}
}


//--------------------------------------------------------------------------


//---06

using System;
public class Program{
    public static void Main(){
        Console.WriteLine("Enter the start date(dd/MM/yyyy hh:mm:ss tt):");
        string start = Console.ReadLine();
        Console.WriteLine("Enter the end date(dd/MM/yyyy hh:mm:ss tt):");
        string end = Console.ReadLine();
        //fill your code
        try{
            DateTime startDate = DateTime.ParseExact(start, "dd/MM/yyyy hh:mm:ss tt", null);
            DateTime endDate = DateTime.ParseExact(end, "dd/MM/yyyy hh:mm:ss tt", null);
            System.Console.WriteLine("Starting Date: "+start);
            System.Console.WriteLine("Ending Date: "+end);
        }
        catch(FormatException e){
            System.Console.WriteLine("Invalid Date Format...");
        }
    }
}




//--------------------------------------------------------------------------

