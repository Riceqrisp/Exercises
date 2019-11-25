using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Part for Divisibility
namespace Exercises
{
    class DigitGenerator
    {
        public void Generator()
        {
            int x = 0;
            int y = 0;
            int z = 0;

            for (int i = 0; i < 10; i++)
            {
                if(i > 0)
                {
                    x = x + 1;

                    if (x == 10)
                    {
                        x = 0;
                    }
                }

                for (int j = 0; j < 10; j++)
                {
                    if(j > 0)
                    {
                        y = y + 1;

                        if (y == 10)
                        {
                            y = 0;
                        }
                    }

                    for (int k = 0; k < 10; k++)
                    {
                        Console.Write($"{x}");
                        Console.Write($"{y}");
                        Console.Write($"{z}.");

                        z = z + 1;
                        if (z == 10)
                        {
                            z = 0;
                        }
                    }
                }
            }
        }
    }
}
