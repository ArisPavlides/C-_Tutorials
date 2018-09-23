using System;
using System.IO;
namespace Document_DocumentInfo
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

            string pathEmpty = @"C:\Users\arisp\Documents\CSharpTest";
                        
            if (Directory.Exists(pathEmpty)) { Directory.Delete(pathEmpty); } // delete directory if it exists
            else
            {
                Directory.CreateDirectory(pathEmpty); // if it doesnt exist then create
                Directory.Delete(pathEmpty); // and delete immediately
            }

            // show the exact directory of all .sln files in the folder CSharp_Tutorials
            string[] folderFiles = Directory.GetFiles(@"C:\Users\arisp\Documents\CSharp_Tutorials", "*.sln", SearchOption.AllDirectories);
            foreach (string file in folderFiles) { Console.WriteLine(file); }

            // return the name of all the directories containing any file name of any format
            string[] folderDirectories = Directory.GetDirectories(@"C:\Users\arisp\Documents\CSharp_Tutorials", "*.*", SearchOption.AllDirectories);
            foreach (string directory in folderDirectories) { Console.WriteLine(directory); }

            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\arisp\Documents\CSharp_Tutorials");
            DirectoryInfo[] allDirectories = directoryInfo.GetDirectories();
        }
    }
}
