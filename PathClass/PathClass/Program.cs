using System;
using System.IO;

namespace PathClass
{
    class Program
    {
        static void Main()
        {
            // this class is useful when working with a string representing a path
            string path = @"C:\Users\arisp\Documents\CSharp_Tutorials\Chainable_Methods\Chainable_Methods.sln";

            string extension = Path.GetExtension(path); // return the file extension from the path above
            string fileName = Path.GetFileName(path); // file name and extension
            string exclExt = Path.GetFileNameWithoutExtension(path);
            string filePath = Path.GetFullPath(path);
            string fileDirectory = Path.GetDirectoryName(path);
        }
    }
}
