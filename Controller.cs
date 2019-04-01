using System;
using System.Collections.Generic;
using System.Text;

namespace RepChar
{
    class Controller
    {
        private Model M = new Model();
        public void Start()
        {
            do
            {
                Console.Clear();
                var userChar = "";
                while (userChar == "")
                {
                    Console.Write("Enter char in which to repeat: ");
                    userChar = Console.ReadLine();
                }
                
                var result = 0;
                while (true)
                {
                    string amount = null;
                    Console.Write("Enter amount of times to repeat: ");
                    amount = Console.ReadLine();
                    if (!int.TryParse(amount, out var check)) continue;
                    result = check;
                    break;
                }

                M.newRequest(userChar, result);

                Console.WriteLine(); 
                Console.WriteLine();
                Console.Write("Do you wish to continue? y/n");

                var again = Console.ReadLine();
                if (again != null && again.Substring(0, 1).ToLower() == "n")
                {
                    break;
                }

            } while (true);
        }
    }
}
