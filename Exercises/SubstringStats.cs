using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class SubstringStats
    {
        // Under construction part
        public string GenerteString (int number)
        {
            string randomString;
            Random random = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyz";

            return new string(Enumerable
                .Repeat(chars, number)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        //Under construction
    }
}
