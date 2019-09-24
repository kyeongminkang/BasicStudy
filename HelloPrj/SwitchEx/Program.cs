using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchEx
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Switch문
             * 
             * switch (조건식){
             *      case 상수1 :
             *          실행코드
             *          break; // 코드 멈추고 빠져나감
             *      case 상수2 :
             *          실행코드
             *          break;
             *      case 상수3 :
             *          실행코드
             *          break;
             *      default:
             *          실행코드
             *          break;
             * }
             */

            Console.WriteLine("요일을 입력하세요(월, 화, 수, 목, 금, 토, 일)");
            string weekDay = Console.ReadLine();

            switch (weekDay)
            {
                case "월":
                    Console.WriteLine("Monday");
                    break;
                case "화":
                    Console.WriteLine("Thuesday");
                    break;
                case "수":
                    Console.WriteLine("Wendseday");
                    break;
                case "목":
                    Console.WriteLine("Thursday");
                    break;
                case "금":
                    Console.WriteLine("Friday");
                    break;
                case "토":
                    Console.WriteLine("Saturday");
                    break;
                case "일":
                    Console.WriteLine("Sinday");
                    break;
                default:
                    Console.WriteLine("요일을 입력하세요");
                    break;

            }
            
        }
    }
}
