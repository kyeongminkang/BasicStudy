using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionEx2
{
    public static class MyExtension
    {
        public static void ShowMyIntList(this List<int> n)
        {
            foreach (int i in n)
            {
                Console.WriteLine($"값 : {i}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                11, 22, 33, 44, 55
            };

            li.ShowMyIntList();


        }
    }
}