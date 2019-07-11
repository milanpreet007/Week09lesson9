using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                                           //Step 1
namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteFile("Test.txt");
            ReadFile("Test.txt");
        }
        static void WriteFile(string filename)
        {
            TextWriter writer = new StreamWriter(filename);// Step 2
            writer.WriteLine("Hello World");                //step 3
            writer.WriteLine("Milanpreet Singh");
            
            for(int i=1;i<=12;i++)
            {
                writer.WriteLine($"{i}*2= {i*2}");
            }
            writer.Close();                                 //Step 4
        }
        static void ReadFile(string filename)
        {
            TextReader reader = new StreamReader(filename); //Step 2 to read
            string input=reader.ReadLine();                 //Step 3 to read
            int lineNumber = 1;
            while (input != null)
            {
                Console.WriteLine($"{lineNumber++,2} - {input}");
                input = reader.ReadLine();
            }
            reader.Close();
        }
    }
}
