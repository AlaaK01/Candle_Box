using System;
using System.Data;

namespace Candle_Box
{

    class program
    {
        static void Main(string[] args)
        {
            int D = 0;
            int R = 0;
            int T = 0;
            bool IsTrue = true;


            while (IsTrue)
            {
                Console.Write("Please enter the ifference between the ages of Rita and Theo: ");
                string input1 = Console.ReadLine();
                if (int.TryParse(input1, out D)) break;
            }

            while (IsTrue)
            {
                Console.Write("Please enter the number of candles in Rita’s box: ");
                string input2 = Console.ReadLine();
                if (int.TryParse(input2, out R)) break;
            }

            while (IsTrue)
            {
                Console.Write("Please enter the number of candles in Theo’s box: ");
                string input3 = Console.ReadLine();
                if (int.TryParse(input3, out T)) break;
            }

            var D_Array = new int[20];
            var R_Array = new int[1000];
            var T_Array = new int[1000];

            var result = new List<int>();

            for (int i = 4; i < 1000; i++) R_Array[i] = R_Array[i - 1] + i;
            for (int i = 3; i < 1000; i++) T_Array[i] = T_Array[i - 1] + i;
            for (int i = D; i < 1000; i++)
            {
                if (R_Array[i] + T_Array[i - D] == R + T) Console.WriteLine($"the number of candles Rita must remove from her box is: {R - R_Array[i]}");
            }


            Console.ReadLine();
        }


    }
}