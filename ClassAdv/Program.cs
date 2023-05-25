using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassAdv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 소멸자 예시
            Product prouduct1 = new Product("과자", 1000);
            Product prouduct2 = new Product("아이스크림", 1000);
            Product prouduct3 = new Product("케이크", 1000);

            // 속성(Property) 실습
            Box box = new Box(10, 10);
            box.Width = 100;
            box.Height = 100;
            box.GetArea();
            try
            {
                box.Width = -10; // 잘못된 값이 들어간 경우
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
