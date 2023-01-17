using System;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Verilmiş N tam ədədinin rəqəmləri cəmini tapan proqram
            Console.WriteLine("Ededi daxil edin...");
            int N = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            while (N>0)
            {
                result += N % 10;
                N = (N - N % 10) / 10;
            }
            Console.WriteLine("Netice..." + result);
            #endregion

            #region Task2
            //Verilmiş M dəyərindən verilmiş K dəyərinədək 21-ə bölünən ədədlərin ədədi ortasını tapan proqram
            Console.WriteLine("Birinci ededi daxil edin...");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin...");
            int K = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            for (int i = M; i < K; i++)
            {
                if (i % 21 == 0)
                {
                    sum += i;
                    count++;
                }
            }
            if (count==0)
            {
                Console.WriteLine("21-e bolunen eded yoxdur.");
            }
            else
            {
                Console.WriteLine("21-e bolunen ededlerin ededi ortasi..." + sum/count);
            }
            #endregion

            #region Task3
            //Verilmis yazıda a herfi olub olmadigini tapan metod
            Console.WriteLine("Yazi daxil edin...");
            string word = Console.ReadLine();   
            bool hasWantedChar = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    hasWantedChar = true;
                    break;
                }
            }
            if (hasWantedChar == true)
            {
                Console.WriteLine("Yazida a herfi var.");
            }
            else
            {
                Console.WriteLine("Yazida a herfi yoxdur.");
            }
            #endregion
        }
    }
}
