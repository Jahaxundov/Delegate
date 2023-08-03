using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class PracticeDelegate
    {
        //public delegate bool CheckNums(int num);

        //public delegate void ChangeStr(string str);

        //public delegate int CheckLength(string str);


        public  int GetLength(string str,int num)
        {
            return str.Length+num ;
        }
            

        //public void StrToLower(string str)
        //{
        //    Console.WriteLine(str.ToLower());
        //}

        //public void StrToUpper(string str)
        //{
        //    Console.WriteLine(str.ToUpper());
        //}

        //public bool CheckOddNums(int number)
        //{
        //    return number % 2 == 1;
        //}

        //public bool CheckEvenNums(int number)
        //{
        //    return number % 2 ==0;
        //}

        //public bool CheckGreaterFiveNums(int number)
        //{
        //    return number >5;
        //}


        //private void GetString(string str,Action<string> func)
        //{
        //    func(str);
        //}

        //private void GetStringLength(string str, Func<string,int,int> func)
        //{
        //    Console.WriteLine(func(str,12));
        //}








        public void ExecuteMethod()
        {
            Func<string, int, int> func = GetLength;
          
            Console.WriteLine(func.Invoke("salam", 12));

            //GetStringLength("salam", GetLength);

            //Action<string> func = new Action<string>(StrToUpper);
            //func += StrToLower;
            //func.Invoke("Salamlar");

            //GetString("Salam", StrToUpper );
            //List<int> nums = new List<int> { 1, 2, 3, 5, 7, 9, 12 };
            //var result = nums.Where(m => m % 2 == 1).Sum(m => m);
            //Console.WriteLine(result);
            //SumNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, CheckEvenNums);
            //SumNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, CheckGreaterFiveNums);
        }

        //private void SumNumbers(List<int> numbers, Predicate<int> func)
        //{
        //    int sum = 0;
        //    foreach (var item in numbers)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}

        //private void SumOfEvenNumbers(List<int> numbers)
        //{
        //    int sum = 0;
        //    foreach (var item in numbers)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            sum += item;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}

        //private void SumOfGreaterofNumbers(List<int> numbers)
        //{
        //    int sum = 0;
        //    foreach (var item in numbers)
        //    {
        //        if (item>4)
        //        {
        //            sum += item;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}
    }
}
