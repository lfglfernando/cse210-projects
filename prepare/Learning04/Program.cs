using System;

namespace homework_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment student1 = new Assignment("Fernando", "Programming with Classes");
            Console.WriteLine(student1.GetSummary());

            MathAssignment student2 = new MathAssignment("Fernando", "Programming with Classes", "7.3", "8-19");
            Console.WriteLine(student2.GetHomeworkList());

            WritingAssignment student3 = new WritingAssignment("Mary Waters", "European History", "The causes of World War II by Mary Waters" );
            Console.WriteLine(student3.GetWritingInformation());

            // Book book1 = new Book();
            // book1.SetAuthor("Smith");
            // book1.SetTitle("A Great Book");

            // Console.WriteLine(book1.GetBookInfo());


            // PictureBook book2 = new PictureBook();
            // book2.SetAuthor("Jones");
            // book2.SetTitle("A Wonderful Picture Book");
            // book2.SetIlustrator("Burton");

            // Console.WriteLine(book2.GetBookInfo());
            // Console.WriteLine(book2.GetPictureBookInfo());

            // Book book3 = new Book("Edwards", "Another Book");
            // Console.WriteLine(book3.GetBookInfo());

            // PictureBook book4 = new PictureBook();
            // Console.WriteLine(book4.GetBookInfo());

            // PictureBook book5 = new PictureBook("Fernando", "baby any", "the church");
            // Console.WriteLine(book5.GetPictureBookInfo());
            

        }
    }
}

// // a regular class called Person
// public class Person
// {   
//     private string _name;

//     public Person(string name)
//     {
//         _name = name;
//     }
//     public string GetName()
//     {
//         return _name;
//     }
// }

// //a class that inherits from Person
// public class Student : Person
// {
//     private string _number;

//     //calling the parent constructor using "base"!
//     public Student(string name, string number) : base(name)
//     {
//         _number = number;
//     }
    
//     public string GetStudentInfo()
//     {
//         //ERROR! This line doesn't work, because _name is private in the base class
//         return _name + " " + _number;
//     }
// }


// class Program
// {
//     static void Main(string[] args)
//     {
//         // the student instance automatically has the GetName() method!
//         Student student = new Student("Brigham", "234");
//         string name = student.GetName();
//         string number = base.GetName();
//         Console.WriteLine($"Student Number: {number}");
//         Console.WriteLine(name);
//         Console.WriteLine(number);

//     }

// }
