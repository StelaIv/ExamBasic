using System;
using System.Collections.Generic;

namespace _04.perfectGirlfriend
{
    class perfectGirlfriend
    {
        static void Main()
        {
            var all = new List<string>();

            for (int i = 0; ; i++)
            {

                var input = Console.ReadLine();

                if (input == "Enough dates!")
                {
                    break;
                }

                all.Add(input);
            }

            int perfect = 0;
            foreach (string t in all)
            {
                var counter = 0;

                string[] splitInput = t.Split('\\');
                switch (splitInput[0])
                {
                    case "Monday": counter += 1; break;
                    case "Tuesday": counter += 2; break;
                    case "Wednesday": counter += 3; break;
                    case "Thursday": counter += 4; break;
                    case "Friday": counter += 5; break;
                    case "Saturday": counter += 6; break;
                    case "Sunday": counter += 7; break;
                }

                for (int j = 0; j < splitInput[1].Length; j++)
                {
                    string phone = splitInput[1];
                    counter += (Convert.ToInt32(phone[j].ToString()));
                }

                string bra = splitInput[2].Substring(0, splitInput[2].Length - 1);
                int braSize = Convert.ToInt32(bra);
                string size = splitInput[2];
                string bra1 = size[size.Length - 1].ToString();
                char bra2 = char.Parse(bra1);
                int bigSize = ((int)bra2);
                counter += (braSize * bigSize);
                var name = splitInput[3];
                int numberName = name[0] * name.Length;

                counter -= numberName;

                if (counter > 6000)
                {
                    perfect += 1;
                }

                Console.WriteLine(counter < 6000 ? "Keep searching, {0} is not for you." : "{0} is perfect for you.", name);
            }

            Console.WriteLine(perfect);
        }
    }
}

