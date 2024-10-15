using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CiP
{
    using System.IO;

   public class ReadFile 
    {
        public static string ReadFileFunction()
        {
            string path = "C:\\Users\\gustav.franchell\\OneDrive - Forefront Consulting\\Dokument\\CodeIsPresident\\adventofcode2015day3\\CiP\\CiP\\data.txt";
            if (File.Exists(path))
            {
                string fileContents = File.ReadAllText(path);
                Console.WriteLine("Here are the contents of the file: ");
                Console.WriteLine(fileContents);

                return fileContents;
            }
            else
            {
                Console.WriteLine("File wasn't found!");
                return "";
            }
        }
    }
}
