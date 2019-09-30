using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableInitialEx
{
    // Hashtable 초기화할때 딕셔너리 초기자(dictionary Initializar) 이용가능
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable ht = new Hashtable()
            //{
            //    ["seoul"] = "서울",
            //    ["incheon"] = "인천",
            //    ["kwangju"] = "광주" 

            //};

            Hashtable ht = new Hashtable()
            {
                { "seoul", "서울"},
                { "incheon", "인천"}
            };


            Console.WriteLine(ht["seoul"]);

        }
    }
}
