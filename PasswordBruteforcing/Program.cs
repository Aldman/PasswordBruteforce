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
            string passwordExample = null;
            string passwordSighns = null;
            while (true)
            {
                Console.WriteLine("Введите примерный пароль, заполняя звездочками");
                Console.WriteLine("неизвестные места, как в примере ниже:");
                Console.WriteLine("123****89");
                passwordExample = Console.ReadLine();
                //Console.WriteLine("Теперь введите набор предполагаемых подряд");
                passwordSighns = "123456789!@#$%";//Console.ReadLine();
                Console.WriteLine("Предполагаемый список паролей:");

                WritePasswordList(passwordExample, passwordSighns);

                Console.WriteLine();
            }
        }

        public static void WritePasswordList(string passwordExample, string passwordSighns)
        {
            int position = 0;
            WritePasswordList(passwordExample, passwordSighns, position);
        }

        public static void WritePasswordList(string passwordExample, string passwordSighns, int position)
        {
            var password = passwordExample.ToArray();

            if (position == password.Length)
            {
                Console.WriteLine(MakeString(password));
                return;
            }

            if (passwordExample[position] == '*')
            {
                for (int i = 0; i < passwordSighns.Length; i++)
                {
                    password[position] = passwordSighns[i];
                    WritePasswordList(MakeString(password), passwordSighns, position + 1);
                }
            }
            else
                WritePasswordList(MakeString(password), passwordSighns, position + 1);
        }

        public static string MakeString(char[] passwordSighns)
        {
            var stringToReturn = new StringBuilder();
            foreach (var sign in passwordSighns)
                stringToReturn.Append(sign);
            return stringToReturn.ToString();
        }
    }
}
