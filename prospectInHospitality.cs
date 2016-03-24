using System;

namespace exam
{
    class prospectInHospitality
    {
        static void Main(string[] args)
        {
            var b = decimal.Parse(Console.ReadLine());
            var r = decimal.Parse(Console.ReadLine());
            var c = decimal.Parse(Console.ReadLine());
            var t = decimal.Parse(Console.ReadLine());
            var o = decimal.Parse(Console.ReadLine());
            var n = decimal.Parse(Console.ReadLine());
            var u = decimal.Parse(Console.ReadLine());
            var s = decimal.Parse(Console.ReadLine());
            var m = decimal.Parse(Console.ReadLine());
            var builders = b * 1500.04m;
            var recep = r * 2102.10m;
            var chamb = c * 1465.46m;
            var tech = t * 2053.33m;
            var others = o * 3010.98m;
            var sum = builders + recep + chamb + tech + others + (n * u) + s;
            var left = m - sum;
            var more = sum - m;

            Console.WriteLine("The amount is: {0:F2} lv.", sum);

            if (left >= 0)
            {
                Console.WriteLine("YES \\ Left: {0:F2} lv.", left);
            }
            else
            {
                Console.WriteLine("NO \\ Need more: {0:F2} lv.", more);
            }
        }
    }
}
