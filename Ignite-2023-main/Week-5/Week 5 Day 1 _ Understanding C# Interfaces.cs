
//01 ------


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Stall Type:");
        Console.WriteLine("1.Gold Stall\n2.Executive Stall\n3.Premium Stall");
        int choice = Convert.ToInt32(Console.ReadLine());
        string name, details, owner_name;
        double cost;
		if (choice == 1)
		{
			Console.WriteLine("Enter the stall name");
            name = Console.ReadLine();
			Console.WriteLine("Enter the details");
            details = Console.ReadLine();
			Console.WriteLine("Enter the cost");
            cost = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter the owner name");
            owner_name = Console.ReadLine();
			//Fill your code here
            GoldStall gs = new GoldStall(name, details, cost, owner_name);
            gs.display();
		}
		else if (choice == 2)
		{
			Console.WriteLine("Enter the stall name");
            name = Console.ReadLine();
			Console.WriteLine("Enter the details");
            details = Console.ReadLine();
			Console.WriteLine("Enter the cost");
            cost = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter the owner name");
            owner_name = Console.ReadLine();
			Console.WriteLine("Enter the number of TV set");
            int noOfTV = Convert.ToInt32(Console.ReadLine());
            //Fill your code here
            ExecutiveStall gs = new ExecutiveStall(name, details, cost, owner_name, noOfTV);
            gs.display();
		}
		else if (choice == 3)
		{
			Console.WriteLine("Enter the stall name");
            name = Console.ReadLine();
			Console.WriteLine("Enter the details");
            details = Console.ReadLine();
			Console.WriteLine("Enter the cost");
            cost = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter the owner name");
            owner_name = Console.ReadLine();
			Console.WriteLine("Enter the number of projector");
            int noOfP = Convert.ToInt32(Console.ReadLine());
            //Fill your code here
            PremiumStall gs = new PremiumStall(name, details, cost, owner_name, noOfP);
            gs.display();
		}
		else
		{
			//Fill your code here
            Console.WriteLine("Invalid Input");
		}
    }
}

//////////////////////////////

using System;
public interface IStall
{
    void display();
}


////////////////////

using System;

class GoldStall : IStall
{
    private string _name;
    private string _details;
    private double _cost;
    private string _ownerName;

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public string Details
    {
        get { return this._details; }
        set { this._details = value; }
    }

    public double Cost
    {
        get { return this._cost; }
        set { this._cost = value; }
    }

    public string OwnerName
    {
        get { return this._ownerName; }
        set { this._ownerName = value; }
    }

    public GoldStall()
    {
    }

    public GoldStall(string _name, string _details, double _cost, string _ownerName)
    {
        this._name = _name;
        this._details = _details;
        this._cost = _cost;
        this._ownerName = _ownerName;
    }

    public void display(){
        Console.WriteLine($"Stall name:{this.Name}");
        Console.WriteLine($"Details:{this.Details}");
        Console.WriteLine($"Cost:{this.Cost.ToString("0.00")}");
        Console.WriteLine($"Owner:{this.OwnerName}");
    }

    //fill code here
}

////////////////////////


using System;

class ExecutiveStall : IStall{
    private string _name;
    private string _details;
    private double _cost;
    private string _ownerName;
    private int _numberOfTVSet;

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public string Details
    {
        get { return this._details; }
        set { this._details = value; }
    }

    public double Cost
    {
        get { return this._cost; }
        set { this._cost = value; }
    }

    public string OwnerName
    {
        get { return this._ownerName; }
        set { this._ownerName = value; }
    }

    public int NumberOfTVSet
    {
        get { return this._numberOfTVSet; }
        set { this._numberOfTVSet = value; }
    }

    public ExecutiveStall()
    {
    }

    public ExecutiveStall(string _name, string _details, double _cost, string _ownerName, int _numberOfTV)
    {
        this._name = _name;
        this._details = _details;
        this._cost = _cost;
        this._ownerName = _ownerName;
        this._numberOfTVSet = _numberOfTV;
    }

    //fill code here
    public void display()
    {
        Console.WriteLine($"Stall name:{this.Name}");
        Console.WriteLine($"Details:{this.Details}");
        Console.WriteLine($"Cost:{this.Cost.ToString("0.00")}");
        Console.WriteLine($"Owner:{this.OwnerName}");
        Console.WriteLine($"Number of TV set:{this.NumberOfTVSet}");
    }
}

////////////////////////////

using System;
class PremiumStall : IStall
{
    private string _name;
    private string _details;
    private double _cost;
    private string _ownerName;
    private int _numberOfProjector;

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public string Details
    {
        get { return this._details; }
        set { this._details = value; }
    }

    public double Cost
    {
        get { return this._cost; }
        set { this._cost = value; }
    }

    public string OwnerName
    {
        get { return this._ownerName; }
        set { this._ownerName = value; }
    }

    public int NumberOfProjector
    {
        get { return this._numberOfProjector; }
        set { this._numberOfProjector = value; }
    }

    public PremiumStall()
    {
    }

    public PremiumStall(string _name, string _details, double _cost, string _ownerName, int _numberOfProjector)
    {
        this._name = _name;
        this._details = _details;
        this._cost = _cost;
        this._ownerName = _ownerName;
        this._numberOfProjector = _numberOfProjector;
    }
    
    //fill code here
    public void display()
    {
        Console.WriteLine($"Stall name:{this.Name}");
        Console.WriteLine($"Details:{this.Details}");
        Console.WriteLine($"Cost:{this.Cost.ToString("0.00")}");
        Console.WriteLine($"Owner:{this.OwnerName}");
        Console.WriteLine($"Number of projector:{this.NumberOfProjector}");
    }
}




--------------------------------------------------------------------------------------------------------



using System;
public class Program{
    public static void Main(){
        Console.WriteLine("Select your choice...\n1. Make My Trip\n2. Trivago\n3. Clear Trip");
        int ch = Convert.ToInt32(Console.ReadLine());
        string city;
        switch(ch)
        {
			case 1:
				//Fill your code here
                MakeMyTrip mt = new MakeMyTrip();
				Console.WriteLine("Available Cities:");
                mt.CityList();
				Console.WriteLine("Enter a city to view hotels:");
                city = Console.ReadLine();
                mt.ShowTariff(city);
				break;
			case 2:
				//Fill your code here
				Trivago tv = new Trivago();
				Console.WriteLine("Available Cities:");
                tv.CityList();
				Console.WriteLine("Enter a city to view hotels:");
                city = Console.ReadLine();
                tv.ShowTariff(city);
				break;
			case 3:
				//Fill your code here
				ClearTrip ct = new ClearTrip();
				Console.WriteLine("Available Cities:");
                ct.CityList();
				Console.WriteLine("Enter a city to view hotels:");
                city = Console.ReadLine();
                ct.ShowTariff(city);
				break;
            default :
                Console.WriteLine("Invalid Input");
                break;
        }
    }
}

//////////////////////////////


using System;
public interface HotelTariff
{
    //Fill your code here
    void ShowTariff(string city);
}

//////////////////////


using System;
using System.Collections.Generic;
class MakeMyTrip : HotelTariff{
    Dictionary<string,Dictionary<string, double>> HotelList = new Dictionary<string,Dictionary<string, double>>
    {
        {
        "Tokyo",
        new Dictionary<string,double>
        {
            {"Tokyo Residency",10000},
            {"Heritage Tokyo",15000},
            {"Germanus",20000}
        }
        },

        {
        "Singapore",
        new Dictionary<string,double>
        {
            {"Hotel CAG Pride",15000},
            {"Heritage Inn",25000}
        }
        }
    };
	public void CityList()
    {
        //Fill your code here
        foreach(var elem in this.HotelList)
            Console.WriteLine(elem.Key);
    }
    
    public void ShowTariff(string city)
    {
        //Fill your code here
        foreach(var elem in this.HotelList){
            String cityName = elem.Key;
            if(cityName == city){
                Console.WriteLine("Hotel List with Tariff:");
                foreach(var ct in elem.Value){
                    Console.WriteLine($"{ct.Key} - Rs.{ct.Value}");
                }
                return;
            } 
        }
        Console.WriteLine("Selected City not found...");
    }
}

////////////////////////////////


using System;
using System.Collections.Generic;
public class Trivago : HotelTariff{
    Dictionary<string, Dictionary<string, double>> HotelList = new Dictionary<string, Dictionary<string, double>>
    {
        {
        "Hyderabad",
        new Dictionary<string,double>
        {
            {"Park Hyatt",12000},
            {"Courtyard By Marriott",10000},
            {"Taj Krishna",14500}
        }
        },

        {
        "Mysore",
        new Dictionary<string,double>
        {
            {"Hotel Royal Orchid",20000},
            {"Hotel Kings Kourt",18000}
        }
        }
    };
    //Fill your code here
	public void CityList()
    {
        //Fill your code here
        foreach(var elem in this.HotelList)
            Console.WriteLine(elem.Key);
    }
    
    public void ShowTariff(string city)
    {
        //Fill your code here
        foreach(var elem in this.HotelList){
            String cityName = elem.Key;
            if(cityName == city){
                Console.WriteLine("Hotel List with Tariff:");
                foreach(var ct in elem.Value){
                    Console.WriteLine($"{ct.Key} - Rs.{ct.Value}");
                }
                return;
            } 
        }
        Console.WriteLine("Selected City not found...");
    }
}

////////////////////////////


using System;
using System.Collections.Generic;

public class ClearTrip : HotelTariff {
    Dictionary<string, Dictionary<string, double>> HotelList = new Dictionary<string, Dictionary<string, double>>
    {
        {
        "Chennai",
        new Dictionary<string,double>
        {
            {"Leela Palace",25000},
            {"Hilton",20000},
            {"WoodLands",18000}
        }
        },

        {
        "Bangalore",
        new Dictionary<string,double>
        {
            {"Adarsh Hamilton",12000},
            {"Wonderla Resort",15000},
            {"Olde Bangalore Resort",20000}
        }
        }
    };
	//Fill your code here

	public void CityList()
    {
        //Fill your code here
        foreach(var elem in this.HotelList)
            Console.WriteLine(elem.Key);
    }
    
    public void ShowTariff(string city)
    {
        //Fill your code here
        foreach(var elem in this.HotelList){
            String cityName = elem.Key;
            if(cityName == city){
                Console.WriteLine("Hotel List with Tariff:");
                foreach(var ct in elem.Value){
                    Console.WriteLine($"{ct.Key} - Rs.{ct.Value}");
                }
                return;
            } 
        }
        Console.WriteLine("Selected City not found...");
    }
    
}

-----------------------------------------------------------------------------
