using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRabota3
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int N, t;
            double x, y, chisl, z = 0;
            N = Convert.ToInt32(Console.ReadLine());
            t = Convert.ToInt32(Console.ReadLine());
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            int i, znam = 1, stepen = 2;
            if (t ==0)
                for (i = 1; i<=N; i++)
                {
                    if (i % 2 == 0)
                        chisl = Math.Pow(x, stepen);
                    else
                        chisl = -Math.Pow(y, stepen);
                    z += chisl / (znam * (znam + 2));
                    znam += 2;
                    stepen += 2;
                }
            if (t == 1)
            {
                i = 1;
                while (i <= N)
                {
                    if (i % 2 == 0)
                        chisl = Math.Pow(x, stepen);
                    else
                        chisl = -Math.Pow(y, stepen);
                    z += chisl / (znam * (znam + 2));
                    znam += 2;
                    stepen += 2;
                    i++;
                }
            }
            if (t == 2)
            {
                i = 1;
                do
                {
                    if (i % 2 == 0)
                        chisl = Math.Pow(x, stepen);
                    else
                        chisl = -Math.Pow(y, stepen);
                    z += chisl / (znam * (znam + 2));
                    znam += 2;
                    stepen += 2;
                    i++;
                } while (i <= N);
            }

            Console.WriteLine(String.Format("{0:0.0000000}", z));

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
