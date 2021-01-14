using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuestions_Jan2021
{
    class Program
    {
        //  Given an unsorted array which has a number in the majority(a number appears more than 50% in the array), find that number

        public static int GetMajorityElement(params int[] x)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int majority = x.Length / 2;

            foreach (int i in x)
                if (d.ContainsKey(i))
                {
                    d[i]++;
                    //Checks if element just added is the majority element
                    if (d[i] > majority)
                        return i;
                }
                else
                    d.Add(i, 1);
            //No majority element
            throw new Exception("No majority element in array");
        }
        static void Main(string[] args)
        {
            int[]
        }
    }
}
