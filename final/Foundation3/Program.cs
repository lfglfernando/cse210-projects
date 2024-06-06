using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("915 N 150 E", "Provo", "UT", " USA");
        Address address2 = new Address("Cerrada Milan", "Culiacan", "SN", "Mexico");
        Address address3 = new Address("789 Oak St", "Miami", "FL", "USA");

        Event lecture = new Lecture("Book of Mormon Lecture", "Mosiah 29- Alma 5", "Jun 05 2024", "11:00 Am", address1, "Brother. Smith", 100);
        Event reception = new Reception("Wedding Reception", "Fernando & Amy", "April 12th 2024", "6:00 pm", address2, "fernando&amy@theknot.com");
        Event outdoorGathering = new OutdoorGathering("Bonfire", "Home Evening", "June 03 2024", "6:00 pm", address3, "Cold");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var ev in events)
        {
            Console.WriteLine($"STANDARD DETAILS:\n{ev.GetStandardDetails()}\n");
            Console.WriteLine($"FULL DETAILS:\n{ev.GetFullDetails()}\n");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}