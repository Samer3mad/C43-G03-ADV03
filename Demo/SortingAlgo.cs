using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate bool CustomFun<T>(T arg01, T arg02);
    internal class SortingAlgo
    {
        public static void BubbleSort(int[] nums, CustomFun<int>func) 
        {
            if (nums is null || func is null)
                return;
            for (int i = 0;  i < nums.Length; i++)
            {
                for (int j = 0; j <  nums.Length - 1 - i; j++)
                {
                    //if ( nums[j] > nums[j + 1])
                    if(func.Invoke(nums[j], nums[j + 1]))
                        SWAP(ref nums[j], ref nums[j + 1]);
                }
            }
        } 

        private static void SWAP(ref int x,  ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }

    class SortingTypes
    {
        public static bool CompareGrt(int x, int y) => x > y;
        public static bool CompareLes(int x, int y) => x < y;
    }
}
