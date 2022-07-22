using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordBruteforcing
{
    class Program
    {
        public static void Main()
        {
            WriteAllWordsOfSize(1);
            WriteAllWordsOfSize(2);
            WriteAllWordsOfSize(0);
            WriteAllWordsOfSize(4);
        }

        static void WriteAllWordsOfSize(int size)
        {
            MakeSubsets(new char[size]);
        }

        static void MakeSubsets(char[] subset, int position = 0)
        {
            if (position == subset.Length)
            {
                Console.WriteLine(new string(subset));
                return;
            }
            subset[position] = 'a';
            MakeSubsets(subset, position + 1);
            subset[position] = 'b';
            MakeSubsets(subset, position + 1);
            subset[position] = 'c';
            MakeSubsets(subset, position + 1);
        }
    }
}
