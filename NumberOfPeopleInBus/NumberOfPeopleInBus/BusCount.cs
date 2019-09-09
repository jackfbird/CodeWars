using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberOfPeopleInBus
{
    public class BusCount
    {
        public int Number(List<int[]> peopleListInOut)
        {
            int temp = 0;
            int temp2 = 0;
           
            foreach(int[] intarr in peopleListInOut)
            {
                temp += intarr[0];
                temp2 += intarr[1];
            }

            int result = temp - temp2;

            return result;
        }
    }
}
