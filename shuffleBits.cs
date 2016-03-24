using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.ShuffleBits
{
    class shuffleBits
    {
        static void Main(string[] args)
        {
            uint first = uint.Parse(Console.ReadLine());
            uint second = uint.Parse(Console.ReadLine());
            string fNumber = Convert.ToString(first, 2);
            string bitFirst = fNumber.PadLeft(32, '0');
            string sNumber = Convert.ToString(second, 2);
            string bitSecond = sNumber.PadLeft(32, '0');
            var result = new List<string>();

            for (int i = 0; i < 32; i++)
            {
                if (first >= second)
                {
                    result.Add(bitFirst[i].ToString());
                    result.Add(bitSecond[i].ToString());
                }
                else
                {
                    result.Add(bitFirst[i].ToString());
                    result.Add(bitFirst[i + 1].ToString());
                    result.Add(bitSecond[i].ToString());
                    result.Add(bitSecond[i + 1].ToString());
                    i++;
                }
            }

            string some = result.Aggregate<string, string>(null, (current, t) => current + t);
            ulong output = Convert.ToUInt64(some, 2);
            Console.WriteLine(output);
        }
    }
}
