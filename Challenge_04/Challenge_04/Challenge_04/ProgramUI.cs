using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
    class ProgramUI
    {
        public static void Main()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>()
                                                            {
                                                                {1,"a1, a5, d4"},
                                                                {2, "a1, a4, b1, b2"},
                                                                {3,"a4, a5"}
                                                            };

            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine($"Badge ID #: {item.Key} Door Access: { item.Value}");
            }
            Console.ReadLine();
        }
    }
}
