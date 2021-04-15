using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileText = @"C:\Users\rajendra_kumar_vanka\source\repos\Phase1_Project\Storing_Updating_Teacher_Data.txt";

            List<string> teachersdata = new List<string>();
            teachersdata = File.ReadAllLines(fileText).ToList();
            Console.WriteLine("Rainbow school teachers data: ");
            Console.WriteLine("Enter Teacher ID : ");
            var Id = Console.ReadLine();
            Console.WriteLine("Enter Teacher Name : ");
            var Name = Console.ReadLine();
            Console.WriteLine("Enter Teacher Class : ");
            var Class = Console.ReadLine();
            Console.WriteLine("Enter Teacher Section : ");
            var Section = Console.ReadLine();
            teachersdata.Add(@"Id : " + Id.ToString() + ", Name : " + Name + ", Class : " + Class + ", Section : " + Section);
            File.WriteAllLines(fileText, teachersdata);
            //retrieving teacher data from text file.
            Console.WriteLine("-------------------------");
            Console.WriteLine("Existing teacher data in Rainbow school : ");
            for (int i = 0; i < teachersdata.Count(); i++)
            {
                Console.WriteLine(teachersdata[i]);
            }
            Console.ReadLine();
        }

    }
}
