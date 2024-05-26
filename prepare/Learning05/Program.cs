using System;
using System.Collections.Generic; 

class Program
{
    static void Main(string[] arg)
    {

        //Create a list to hold Shapes
        List<Shape> shapes = new List<Shape>();

        Square formula1 = new Square("Red", 3.77);
        shapes.Add(formula1);

        Rectangle formula2 = new Rectangle("Green", 5, 5);
        shapes.Add(formula2);

        Circle formula3 = new Circle("Blue", 10);
        shapes.Add(formula3);

        //Get a custom calculation for each one
        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            
            Console.WriteLine($"The {color} shape has an area of {area}.");

        }



        // Square formula1 = new Square("Red", 3.77);
        // Console.WriteLine(formula1.GetColor());
        // Console.WriteLine(formula1.GetArea());

        // Rectangle formula2 = new Rectangle("Green", 5, 5);
        // Console.WriteLine(formula2.GetColor());
        // Console.WriteLine(formula2.GetArea());

        // Circle formula3 = new Circle("Blue", 10);
        // Console.WriteLine(formula3.GetColor());
        // Console.WriteLine(formula3.GetArea());

        // MathAssignment student2 = new MathAssignment("Fernando", "Programming with Classes", "7.3", "8-19");
        // Console.WriteLine(student2.GetHomeworkList());

        // WritingAssignment student3 = new WritingAssignment("Mary Waters", "European History", "The causes of World War II by Mary Waters" );
        // Console.WriteLine(student3.GetWritingInformation());
    }
}
// // public class Program
// // {
// //     // ...

// //     static void DisplayPayCheck(Employee e)
// //     {
// //         float pay = e.CalculatePay();
// //         // ...
// //     }
// // }


// // public class Program
// // {
// //     // ...

// //     static Employee GetManager()
// //     {
// //         // ... code here to find the manager ...
// //         return theManager;
// //     }

// //     static void DisplayManagerPay()
// //     {
// //         Employee manager = GetManager();
// //         float pay = manager.CalculatePay();
// //         // ...
// //     }
// // }


// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Learning05 World!");

//         //Create a list of Employees
//         List<Employee> employees = new List<Employee>();

//         static Employee GetManager()
//         {
//             //... code here to find the manager ...
//             return theManager;
//         }

//         static void DisplayManagerPay()
//         {
//             Employee manager = GetManager();
//             float pay = manager.CalculatePay();
//             Console.WriteLine(pay);
//         }

//         //Create a different kinds of employees and add them to the same list
//         employees.Add(new Employee());
//         employees.Add(new HourlyEmployee());

//         //Get a custom calculation for each one
//         foreach(Employee employee in employees)
//         {
//             float pay = employee.CalculatePay();
//             Console.WriteLine(pay);
//         }
//     }
// }

// //clase base the parent class showing the "virtual" keyboard included
// public abstract class Employee
// {
//     private string _employeeName;

//     //Notice the abstract method doesn't have a body at all (not even an empty one)
//     // and it is followed by a semicolon.
//     public abstract float CalculatePay();
// }


// // a child class

// public class SalaryEmployee : Employee
// {
//     private float salary = 100f;

//     public override float CalculatePay()
//     {
//         return salary;
//     }
// }

// public class HourlyEmployee : Employee
// {
//     private float rate = 9f;
//     private float hours = 100f;

//     public override float CalculatePay()
//     {
//         return rate * hours; // pay is calculated differently
//     }
// }

// //the Employee interface
// // The C# convention is that interface names begin with an I
// public interface IEmployee
// {
//     float CalculatePay(); //interface method does not have a body
// }

// //a specific implementation of the Employee interface
// public class SalariedEmployee : IEmployee
// {
//     private float salary = 100f;
//     public float CalculatePay()
//     {
//         return salary;
//     }
// }

// // another implementation of tbe Employee interface
// public class HourlyEmployee : IEmployee
// {
//     private float rate = 9f;
//     private float hours = 100f;

//     public float CalculatePay()
//     {
//         return rate * hours;
//     }
// }