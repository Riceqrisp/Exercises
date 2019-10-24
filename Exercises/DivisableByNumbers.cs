using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercises
{
    class DivisableByNumbers
    {
        public int [] GenerateNumbers()
        {
            int[] RandomNumbers = new int[100];
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                RandomNumbers[i] = random.Next();
            }
            return RandomNumbers;
        }

        public List<int> CheckDivisability(int[] array, int number)
        {
            List<int> divisablebyNumber = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % number == 0)
                {
                    divisablebyNumber.Add(array[i]);
                }
            }
            return divisablebyNumber;
        }
    }
}
