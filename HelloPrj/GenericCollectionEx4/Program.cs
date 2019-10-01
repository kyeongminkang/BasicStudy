using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionEx4
{
    //Dictionary<TKey, TValue>
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic["apple"] = "사과";
            dic["banana"] = "바나나";
            dic["orange"] = "오렌지";

            Console.WriteLine(dic["banana"]);
            Console.WriteLine(dic["orange"]);
            Console.WriteLine(dic["apple"]);



        }
    }
}
