using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers
{
    class Program
    {
        static void Main()
        {
            //Exercise1();
            Exercise2();
        }

        static void Exercise1()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Duration());
            Console.ReadLine();
        }

        static void Exercise2()
        {
            // create a post first
            string postTitle = "How do i do this";
            string description = "Declare variable in C#";
            StackOverflowPost post = new StackOverflowPost(postTitle, description);

            post.VotePost(1);
            post.VotePost(1);
            post.VotePost(1);
            post.VotePost(-1);

            Console.WriteLine(post.ReturnVotes());
            Console.ReadLine();
        }
    }
}
