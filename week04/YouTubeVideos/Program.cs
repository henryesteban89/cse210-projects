using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video();
        video1._title = "Learning C# Basics";
        video1._author = "Programming Hub";
        video1._length = 600;

        video1._comments.Add(new Comment { _commenterName = "Henry", _text = "Great tutorial!" });
        video1._comments.Add(new Comment { _commenterName = "Maria", _text = "Very helpful." });
        video1._comments.Add(new Comment { _commenterName = "Carlos", _text = "Thanks for sharing." });

        videos.Add(video1);

        // Video 2
        Video video2 = new Video();
        video2._title = "Object-Oriented Programming";
        video2._author = "Code Academy";
        video2._length = 850;

        video2._comments.Add(new Comment { _commenterName = "Ana", _text = "Excellent explanation." });
        video2._comments.Add(new Comment { _commenterName = "Luis", _text = "I finally understand classes." });
        video2._comments.Add(new Comment { _commenterName = "Pedro", _text = "Nice examples." });

        videos.Add(video2);

        // Video 3
        Video video3 = new Video();
        video3._title = "Abstraction in C#";
        video3._author = "Tech World";
        video3._length = 720;

        video3._comments.Add(new Comment { _commenterName = "Sofia", _text = "This helped with my homework." });
        video3._comments.Add(new Comment { _commenterName = "David", _text = "Very clear explanation." });
        video3._comments.Add(new Comment { _commenterName = "Jose", _text = "Good content." });

        videos.Add(video3);

        // Video 4
        Video video4 = new Video();
        video4._title = "Encapsulation Explained";
        video4._author = "Code Masters";
        video4._length = 900;

        video4._comments.Add(new Comment { _commenterName = "Laura", _text = "Awesome video!" });
        video4._comments.Add(new Comment { _commenterName = "Miguel", _text = "Learned a lot." });
        video4._comments.Add(new Comment { _commenterName = "Elena", _text = "Please make more videos." });

        videos.Add(video4);

        // Display Videos and Comments
        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("\nComments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"- {comment._commenterName}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}