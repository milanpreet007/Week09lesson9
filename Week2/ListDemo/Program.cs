﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ListStringDemo();
        }
        static void ListStringDemo()
        {
            //Creating a list with five strings
            List<string> pms = new List<string>() { "Trudeau", "Harper", "Martin", "Chretien", "Campbell" };
            PrintStringList(pms);

            string pm = "Mulroney";
            Console.WriteLine($"\nAdding {pm} to list");
            pms.Add(pm);
            PrintStringList(pms);

             pm = "King";
            int position = 3;
            Console.WriteLine($"\ninsterting {pm} @{position} to list");
            pms.Insert(position,pm);
            PrintStringList(pms);

            Console.WriteLine($"\nremoving {pm} from list");
            pms.Remove(pm);
            PrintStringList(pms);

            //loop to remove all the names that starts with "M"
            pm = "M";
            Console.WriteLine($"\nRemoving all the names starting with {pm}");
            //loop goes here
            for(int i=0;i<pms.Count;i++)
            {
                if(pms[i].StartsWith(pm))
                {
                    pms.RemoveAt(i);
                }
            }
            PrintStringList(pms);
        }
        static void PrintStringList(List<string> list )
        {
            foreach(string pm in list)
            {
                Console.Write(pm + ", ");
            }
        }
    }
}
