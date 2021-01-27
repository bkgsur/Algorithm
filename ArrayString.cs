using System;
using System.Collections.Generic;
namespace Algorithm
{
    public class ArrayString: IRun
    {

        public void Run()
        {
           twoSum();
        }
        private  void twoSum() 
        {

            int[] numbers = new []{2,3};
            int target = 5;
            Dictionary<int,int> map = new Dictionary<int,int>();
            for (int i = 0; i < numbers.Length; i++) 
            {
                int x = numbers[i];

                if (map.ContainsKey(target - x)) 
                {
                    Console.WriteLine(map[target - x] + 1);
                    Console.WriteLine(i + 1);
                    return;
                }
                map.Add(x, i);
            }
            
            throw new Exception("No two sum solution");      

        }
    }
}