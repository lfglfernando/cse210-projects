using System;

class Program
{
    static void Main(string[] args)
    {

        // Account savings = new Account();
        // savings._balance = 50;
        // savings.Deposit(100);

        // Person p = new Person();
        // p.SetFirstName("Fernando");
        // Console.WriteLine(p.GetFirstName());

        // Person p1 = new Person(); //Dont pass any information to get the default values
        // Person p2 = new Person("Jane", "Doe"); // pass the first and last names
        // Person p3 = new Person("Mrs", "Jane", "Doe"); //pass all three variables

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3,4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());


    
    }
}