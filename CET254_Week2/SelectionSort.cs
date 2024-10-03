using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CET254_Week2
{
    internal class SelectionSort
    {
        public static void Perform(List<double> listToSort)
        {
            int mindex;
            double temp;
            for (int i = 0; i < listToSort.Count-1; i++)
            {
                mindex = 1;
                for (int j = i+1; j < listToSort.Count; j++)
                {
                    if (listToSort[j] < listToSort[mindex])
                    {
                        mindex = j;
                    }
                }
                if (mindex != i)
                {
                    temp = listToSort[i];
                    listToSort[i] = listToSort[mindex];
                    listToSort[mindex] = temp;
                }
            }
        }
    }
}
