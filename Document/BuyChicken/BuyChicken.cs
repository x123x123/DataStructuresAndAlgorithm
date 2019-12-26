using System;

namespace baiqianmaibaiji
{
    class MainClass 
    {
        public static void Main(string[] args)
        {
            //公鸡的上线
            for (int x = 0; x < 20; x++)
            {
                //母鸡的上线
                for (int y = 0; y < 33; y++)
                {
                    //剩余小鸡
                    int z = 100 - x - y;
                    if ((z % 3 == 0) && (x * 5 + y * 3 + z / 3 == 100))
                    {
                        System.Console.WriteLine("公鸡:{0}只，母鸡:{1}只,小鸡:{2}只", x, y, z);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}