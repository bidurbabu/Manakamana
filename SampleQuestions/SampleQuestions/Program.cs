using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort S = new Sort();
            int[] arr = { 90, 3, 4, 89, 76, 5 };
            S.selectionSort(arr);
            Helper.printIntArray(arr);
        }
    }
}
