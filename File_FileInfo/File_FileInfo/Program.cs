using System;
using System.IO;

namespace File_FileInfo
{
    class Program
    {
        static void Main()
        {
            /* File is a static class and it is preferred over the instance class in cases where the number 
             * of operations on the file is small. This is because whenever the File method is called, the 
             * operating system carries a few security checks to see if the file is safe to work on. By calling
             * the static method repeatedly we impose a significant overhead on the machine which could have been
             * avoided had we used the FileInfo instance method */

            string path = @"C:\Users\arisp\Documents\CSharp_Tutorials\File_FileInfo\fool_around.txt";

            // examples of the static class
            File.Copy(path, @"C:\Users\arisp\Documents\CSharp_Tutorials\File_FileInfo\fool_around_copy.txt", true);
            File.Delete(@"C:\Users\arisp\Documents\CSharp_Tutorials\File_FileInfo\fool_around_copy.txt");
            if (File.Exists(@"C:\Users\arisp\Documents\CSharp_Tutorials\File_FileInfo\fool_around_copy.txt"))
            {
                Console.WriteLine("Something went wrong");
            }

            // examples of the instance class
            FileInfo fileInfo = new FileInfo(path);
            DateTime creation = fileInfo.CreationTime;
            if (fileInfo.Exists) { Console.WriteLine("All kewl"); }

            Console.ReadLine();
        }
    }
}
