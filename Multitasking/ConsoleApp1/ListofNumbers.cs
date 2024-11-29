using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ListofNumbers
    {
        private List<int> Numbers;

        public ListofNumbers()
        {
            Numbers = new List<int>();
        }

        public int CalculateSimplesum()
        {
            int sum = 0;
            foreach (int i in Numbers)
            {
                sum += i;
            }
            return sum;
        }
        public int CalculateParallelsum(int Threads)
        {

            List<int> list = new List<int>();
            Task[] tasks1 = new Task[Threads];


            for (int i = 0; i < Threads; i++)
            {
                tasks1[i] = new Task(() =>
                {
                    list.Add(0);
                    for (int j = i * (Numbers.Count() / Threads); j < (i + 1) * (Numbers.Count() / Threads); j++)
                    {
                        list[i] += Numbers[j];

                    }
                });

            }

            foreach (var t in tasks1)
                t.Start();

            Task.WaitAll(tasks1);
            return list.Sum();
        }
        public void AddNumbers(int lenght)
        {
            Random rnd = new Random();
            for (int i = 0; i < lenght; i++)
            {
                Numbers.Add(rnd.Next(1, 1000));
            }
        }
        public List<int> GetNumbers()
        {
            return this.Numbers;
        }




    }
}
