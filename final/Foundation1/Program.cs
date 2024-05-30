using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Wolves vs Mavericks", "ESPN", 12000);
        Video video2 = new Video("C# Tutorial for Beginners", "Fernando Galvez", 10000);
        Video video3 = new Video("Real Madrid vs Borrussia D", "Paramount+", 20000);
        Video video4 = new Video("Python for Beginners", "Luis Lopez", 30000);


        video1.AddComment(new Comments("Alice", "Great Game!"));
        video1.AddComment(new Comments("Bob", "They tried so hard."));
        video1.AddComment(new Comments("Charlie", "Yes! Wolves are going to win this serie"));


        video2.AddComment(new Comments("Dave", "This tutorial is very helpful."));
        video2.AddComment(new Comments("Eve", "Thank you for this!"));
        video2.AddComment(new Comments("Frank", "Clear and concise explanation."));


        video3.AddComment(new Comments("Grace", "Hala Madrid!"));
        video3.AddComment(new Comments("Hank", "Great Quality Video, thanks."));
        video3.AddComment(new Comments("Ivy", "I hate Real Madrid, they have the refferies with them all the time."));


        video4.AddComment(new Comments("Jack", "Amazing ideas!"));
        video4.AddComment(new Comments("Karen", "I'm going follow your tips."));
        video4.AddComment(new Comments("Leo", "Where did you learned that?"));

        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDataFromTheVideo());
            Console.WriteLine(new string('=', 40) + "\n");
        }
        

    }
}