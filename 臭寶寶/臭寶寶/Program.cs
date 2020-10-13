using System;

namespace 臭寶寶
{
    class Program
    {
        public static int[] sort(int[] array,int length)
        {
            var min = 1;
            var place = -1;
            var k = 0;
            for (var j = 0; j < length - 1; j++)   
            {
                place = -1;
                min = 1000000;
                for (k = j ; k < length; k++)
                {
                    if (array[k] < min)
                    {
                        min= array[k];
                        place = k;
                    }
                    
                }
                array[place] = array[j];
                array[j] = min;
            }
            //for (var j = 0; j < length - 1; j++)
            //{
                //Console.Write(list[length] + " ") ;
                return array;
            //}
                
        }
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入要排列幾個數字：");
            int num = Int32.Parse(Console.ReadLine());
            int[] list = new int[num];
            for (var i = 0; i < num; i++)
                list[i] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("---------------------");
            var output = sort(list,list.Length);
            foreach (var i in output)
                Console.WriteLine(i);
        }
    }
}
