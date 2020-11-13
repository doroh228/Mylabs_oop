using System;
using System.Collections.Generic;
using System.Text;

namespace LABA5
{
    public static class  Controller
    {
        public static void Sum(List<Plans> list)
        {
            double sum = 0;
            foreach (var res in list)
            {
                sum += ((flower)res).HowMuch;
            }
            Console.WriteLine($"sum = {sum}");
        }
    }
}
