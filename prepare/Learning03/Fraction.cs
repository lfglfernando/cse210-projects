public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
            _top = top;
            _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double) _top/ (double)_bottom;
    }

}

        // public class Account
        // {
        //     private List<int> _transactions = new List<int>();

        //     public void Deposit(int amount)
        //     {
        //         _transactions.Add(amount);
        //     }

        //     public int GetBalance()
        //     {

        //     }
        // }

        // public class Person
        // {
        //     private string _title;
        //     private string _firstName;
        //     private string _lastName;

        //     public string GetInformalSignature()
        //     {
        //         return "Thanks, " + _firstName;
        //     }

        //     public string GetFormalSignature()
        //     {
        //         return "Sincerely, " + GetFullName();
        //     }

            // private string GetFullName()
            // {
            //     return _title + " " + _firstName + " " + _lastName;
            // }

            // public string GetFirstName()
            // {
            //     return _firstName;
            // }

            // public void SetFirstName(string firstName)
            // {
            //     _firstName = firstName;
            // }

            // public Person()
            // {
            //     _title = "";
            //     _firstName = "Anonymous";
            //     _lastName = "Unknown"; 
            // }

            // public Person(string first, string last)
            // {
            //     _title = "";
            //     _firstName = first;
            //     _lastName = last;
            // }

            // public Person(string title, string first, string last)
            // {
            //     _title = title;
            //     _firstName = first;
            //     -lastName = last;
            // }
        // }