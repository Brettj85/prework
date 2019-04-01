using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepChar
{
    class Model
    {
        View V = new View();
        public void newRequest(string userSelection, int amount)
        {
            Console.Clear();
            char appendMe;
            StringBuilder result = new StringBuilder();
            if (char.TryParse(userSelection, out appendMe))
            {
                result.Append(appendMe, amount);
                V.DisplayResults(result.ToString());
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }
    }
}
