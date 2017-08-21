using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CasosParte01
{
    public class OrderRange
    {
        int[] array1 = new int[] { 58, 60, 55, 48, 57, 73 };
        List<int> array2 = new List<int>();
        List<int> array3 = new List<int>();
        List<List<int>> result = new List<List<int>>();

        public List<List<int>> build(int[] array)
        {
            List<List<int>> result = new List<List<int>>();

            foreach (int variable in array)
            {
                if (variable % 2 == 0)
                {
                    //par
                    array2.Add(variable);
                }
                else
                {
                    //inpar
                    array3.Add(variable);
                }
            }

            result.Add(array2);
            result.Add(array3);

            return result;
        }


    }
}