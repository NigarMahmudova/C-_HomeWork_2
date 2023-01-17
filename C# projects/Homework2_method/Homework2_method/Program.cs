using System;

namespace Homework2_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("Ededi daxil edin...");
            int N = Convert.ToInt32(Console.ReadLine());
            int result = DigitsOfSum(N);
            Console.WriteLine("Netice..." + result);
            //Task2
            Console.WriteLine("Birinci ededi daxil edin...");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin...");
            int K = Convert.ToInt32(Console.ReadLine());
            int avg = AvgOfNumbers(M, K);
            if (avg==0)
            {
                Console.WriteLine("21-e bolunen eded yoxdur.");
            }
            else 
            {
                Console.WriteLine("21-e bolunen ededlerin ededi ortasi..." + avg);
            }
            //Task3
            Console.WriteLine("Yazi daxil edin...");
            string word = Console.ReadLine();
            string checkingChar = HasWantedChar(word);
            Console.WriteLine(checkingChar);    
        }
        //Verilmiş N tam ədədinin rəqəmləri cəmini tapan metod 
        static int DigitsOfSum (int N)
        {
            int result = 0;
            while (N > 0)
            {
                result += N % 10;
                N = (N - N % 10) / 10;
            }
            return result;
        }
        //Verilmiş M dəyərindən verilmiş N dəyərinədək 21-ə bölünən ədədlərin ədədi ortasını tapan metod
        static int AvgOfNumbers (int M, int K) 
        {
            int sum = 0;
            int count = 0;
            int result = 0;
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
                return 0;
            }
            else
            {
                result = sum / count;
                return result;
            }
                
            
        }
        //Verilmis yazıda a herfi olub olmadigini tapan metod
        static string HasWantedChar(string word)
        {
            bool hasWantedA = false;
            string yes = "Yazida a herfi var.";
            string no = "Yazida a herfi yoxdur.";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    hasWantedA = true;
                    break;
                }
            }
            if (hasWantedA == true)
            {
                return yes;
            }
            else
            {
                return no;
            }
        }

    }
}
