using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx5
{
    // 해당 타입을 자유롭게 사용!
    // Generic Delegate(일반화 대리자)
    delegate T CalDelegate<T>(T x, T y);
    class Program
    {
        static int Add (int x, int y)
        {
            return x + y;
        }

        static double Sub (double x, double y)
        {
            return x - y;
            
        }

        public static void Calc<T>(T x, T y, CalDelegate<T> cd)
        {
            Console.WriteLine(cd(x, y));
        }


        static void Main(string[] args)
        {

            CalDelegate<int> Plus = new CalDelegate<int>(Add);
            CalDelegate<double> Minus = Sub;

            Calc(11, 11, Plus);
            Calc(5.11, 1.18, Minus);
        }
    }
}
