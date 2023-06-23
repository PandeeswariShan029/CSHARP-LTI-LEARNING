// 01

using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Enter the number of accounts :");
        int n = Convert.ToInt32(Console.ReadLine());
        List<Account> accList = new List<Account>(n);

        System.Console.WriteLine("Enter accounts :");
        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine("Account Number :");
            string account = Console.ReadLine();
            System.Console.WriteLine("Premium :");
            double premium = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Discount Percent :");
            int discount = Convert.ToInt32(Console.ReadLine());

            accList.Add(new Account(account, premium, discount));
        }

        System.Console.WriteLine("Account Details :");
        foreach(Account acc in accList){
            acc.Display();
        }
    }
}


//////////////////////////////////////////////////////////////////////////

using System;

public class Account{
    // Write your Code
    private string aNumber;
    private double premium;
    private int discountPercent;

    public Account(string account, double premium, int discount)
    {
        this.aNumber = account;
        this.premium = premium;
        this.discountPercent = discount;
    }

    Func<double, int, double> ActualPrice = (premium, dis) => {return (premium*(100-dis))/100;};

    public void Display(){
        System.Console.WriteLine("Account : "+this.aNumber);
        System.Console.WriteLine("Premium : Rs."+this.premium.ToString("0.0"));
        System.Console.WriteLine("Discount :{0}%",this.discountPercent);
        System.Console.WriteLine("Amount to be paid : Rs."+this.ActualPrice(this.premium,this.discountPercent).ToString("0.0"));
    }
}

//----------------------------------------------------------------------------------------------

//02


using System;

class Program
{
    public static void Main()
    {
        Func<int,int,int> collect_coins = (total,add) => {return total+add;};
        Func<int,int,int> attack_enemies = (total,sub) => {return total-sub;};
    
        System.Console.WriteLine("Enter Soldier Number :");
        string num = Console.ReadLine();
        System.Console.WriteLine("Enter Initial coins :");
        int t = Convert.ToInt32(Console.ReadLine());
        Soldier s = new Soldier(num, t);
        int ch;
        do{
            System.Console.WriteLine("1. Collect Coins\n2. Attack Enemies\n3. End war");
            ch = Convert.ToInt32(Console.ReadLine());
            if(ch == 1){
                System.Console.WriteLine("Enter Coins :");
                int add = Convert.ToInt32(Console.ReadLine());
                s.Playgame(collect_coins, add);
            }
            else if(ch == 2){
                System.Console.WriteLine("Enter Coins :");
                int sub = Convert.ToInt32(Console.ReadLine());
                s.Playgame(attack_enemies, sub);
            }
            else if(ch == 3){
                System.Console.WriteLine("Balance coins for next war: "+s.Coins);
            }
            else{
                System.Console.WriteLine("Invalid Choice");
            }

        }while(ch != 3);
    }
}

//////////////////////////////////////////////////////

using System;

public class Soldier{
    // Write your Code
    public string SoldierNumber { get; set; }
    public int Coins;

    public Soldier(string number, int coins){
        this.SoldierNumber = number;
        this.Coins = coins;
    }

    public void Playgame(Func<int,int,int> Expression,int coins){
        this.Coins = Expression(this.Coins,coins);
    }
}


//----------------------------------------------------------------------------------------------

//03

using System;
using System.Collections.Generic;

class Program{
    public static void Main(){
        Predicate<int> CountLessthan100 = (problemCount) => { return (problemCount < 100); };
        Predicate<int> CountBet100to200  = (problemCount) => { return (problemCount >= 100 && problemCount <= 200); };
        Predicate<int> CountGreaterthan200 = (problemCount) => { return (problemCount > 200); };
    
        System.Console.WriteLine("Enter the number of students :");
        int n = Convert.ToInt32(Console.ReadLine());
        List<Student> studentList = new List<Student>(n);

        System.Console.WriteLine("Enter the students :");
        for (int i = 0; i < n; i++){
            System.Console.WriteLine("Name :");
            string name = Console.ReadLine();
            System.Console.WriteLine("ProblemCount :");
            int problems = Convert.ToInt32(Console.ReadLine());
            studentList.Add(new Student(){Name = name, ProblemCount = problems});
        }

        System.Console.WriteLine("Students with ProblemCount less than 100 :");
        foreach (Student student in studentList)
        {
            if(CountLessthan100(student.ProblemCount))
                System.Console.WriteLine($"{student.Name} - {student.ProblemCount}");
        }
        System.Console.WriteLine("Students with ProblemCount between 100 to 200(both inclusive) :");
        foreach (Student student in studentList)
        {
            if(CountBet100to200(student.ProblemCount))
                System.Console.WriteLine($"{student.Name} - {student.ProblemCount}");
        }
        System.Console.WriteLine("Students with ProblemCount greater than 200 :");
        foreach (Student student in studentList)
        {
            if(CountGreaterthan200(student.ProblemCount))
                System.Console.WriteLine($"{student.Name} - {student.ProblemCount}");
        }
    }
}   

//////////////////////////////

using System;

public class Student{
    // Write your Code
    private string _name;
    public string Name { 
        get{return _name;} set{this._name = value;} 
        }
    private int _problemCount;
    public int ProblemCount { 
        get{return _problemCount;} set{this._problemCount = value;} 
        }
}


//----------------------------------------------------------------------------------------------

//04

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
	Console.WriteLine("Enter the number of events");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter event details in CSV(Event Name,Organiser Name,Event Cost)");
        //fill code here
        List<Event> eventList = new List<Event>(n);

        for (int i = 0; i < n; i++){
            string []data = Console.ReadLine().Split(",");
            eventList.Add(new Event(data[0], data[1], Convert.ToDouble(data[2])));
        }
        new Event().Display(eventList);
    }
}

//////////////////////////

using System;
using System.Collections.Generic;
using System.Text;

class Event
{
    private string _eventName;
    private string _organiserName;
    private double _eventCost;

    public Event(string eventName, string organiserName, double eventCost)
    {
        EventName = eventName;
        OrganiserName = organiserName;
        EventCost = eventCost;
    }

    public Event()
    {
    }

    public string EventName { get => _eventName; set => _eventName = value; }
    public string OrganiserName { get => _organiserName; set => _organiserName = value; }
    public double EventCost { get => _eventCost; set => _eventCost = value; }

    public override string ToString() {
        //fill code here
        string details = this.EventName + "|";
        details += this.OrganiserName + "|";
        details += this.EventCost;
        return details;
    }

    public void Display(List<Event> eventList) {
        //fill code here
        System.Console.WriteLine("List of events");
        eventList.ForEach(e => Console.WriteLine(e));
    }
}


//----------------------------------------------------------------------------------------------

//05

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates1
{
    
    class Program
    {
        public delegate void EventDelegate(List<Event> list);
        
        static void Main(string[] args)
        {

            Console.WriteLine("Enter total number of events");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Event> eventList = new List<Event>(n);

            Console.WriteLine("Enter event details");
            for (int i = 0; i < n; i++)
            {
                string []d = Console.ReadLine().Split(",");
                eventList.Add(new Event(d[0], d[1], d[2]));
            }

            System.Console.WriteLine("{0,-15}{1,-15}{2,-15}", "EventName", "EventType", "EventOrganizer");
            EventDelegate printEvent = (events) => {events.ForEach(e => Console.WriteLine(e));};
            printEvent.Invoke(eventList);
        }
    }
}

////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Delegates1
{
    public class Event
    {
        private string _name;
        private string _type;
        private string _organizer;
        public Event(string _name, string _type, string _organizer)
        {
            this._name = _name;
            this._type = _type;
            this._organizer = _organizer;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public string Organizer
        {
            get
            {
                return _organizer;
            }
            set
            {
                _organizer = value;
            }
        }
        // fill your code

        public override string ToString()
        {
            string details = string.Format("{0,-15}{1,-15}{2,-15}", this.Name, this.Type, this.Organizer);
            return details;
        }
    }
}


//-------------------------------------------------------------------------------

//----------------------------------------------------------------------------------------------
