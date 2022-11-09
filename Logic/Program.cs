using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using TkachV.TaskPlanner.ConsoleRunner.Models;

namespace TkachV.TaskPlanner.ConsoleRunner.Logic
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            int n = 5; //int.Parse(System.Console.ReadLine());
            WorkItem[] items = new WorkItem[n];

            for (int i = 0; i < n; i++)
            {
                items[i] = new WorkItem();
            }

            SimpleTaskPlanner planner = new SimpleTaskPlanner();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(items[i].ToString());
            }
            WorkItem[] items1 = planner.CreatePlan(items);
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(items1[i].ToString());
            }
        }

      
    }
}
