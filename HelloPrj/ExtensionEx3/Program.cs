using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionEx3
{
    public class Myclass
    {
        public int speed;
        public void AddSpeed(int s)
        {
            this.speed += s;
        }
        public void DisplaySpeed()
        {
            Console.WriteLine($"현재속도는 {this.speed} ");
        }
    }

    public static class MyClassExt
    {
        public static void MinusSpeed(this Myclass mc, int s)
        {
            mc.speed -= s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Myclass mc = new Myclass();
            mc.AddSpeed(100);
            mc.DisplaySpeed();

            // 원래 minusspeed는 myclass에 없었지만 사용할 수 있게 되었음!
            mc.MinusSpeed(10);
            mc.DisplaySpeed();
        }
    }
}
