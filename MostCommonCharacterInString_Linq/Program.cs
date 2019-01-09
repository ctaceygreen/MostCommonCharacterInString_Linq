using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostCommonCharacterInString_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> testInputs = new List<string>
            {
                "",
                "a",
                "z",
                "zz",
                "sadjafnfdkgfgjdfkgooodasdbsdgjsdgoooosdajsdooooosad",
                "zz ",
                "zz2",
                "z22",
                "z!!",
                "!",
                "aazz",
                "zzaa"
            };
            foreach(var input in testInputs)
            {
                Console.WriteLine($"{input} : {MostCommonCharInStringLinq(input)}");
            }
            Console.ReadLine();
        }

        public static char MostCommonCharInStringLinq(string input)
        {
            var grouping = input.Where(x=>char.IsLetter(x)).GroupBy(x => x).OrderByDescending(x => x.Count()).ThenBy(x=>x.Key).FirstOrDefault();
            if(grouping == null)
            {
                return char.MinValue;
            }
            return grouping.Key;
        }
    }
}
