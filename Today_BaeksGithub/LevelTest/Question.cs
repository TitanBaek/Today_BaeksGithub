using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today_BaeksGithub.LevelTest
{
    internal class Question
    {
        public static void Question1()
        {
            Console.Write("문자열을 입력하세요 :");
            string dataStr = Console.ReadLine();
            Console.WriteLine();
            Console.Write($"\"{dataStr}\" 에서 검색 할 단어를 입력하세요 :");
            string searchStr = Console.ReadLine();

            // 대,소문자에 따라 검색결과가 달라지기 때문에, 문자열과 검색어를 소문자로 만들어 주고 IndexOf를 진행
            dataStr = dataStr.ToLower();
            searchStr = searchStr.ToLower();

            Console.WriteLine(dataStr.IndexOf(searchStr));

        }


        public static void Question2()
        {
            Console.Write("문자열을 입력하세요 :");
            string dataStr = Console.ReadLine();
            string[] arrayStr = dataStr.Split(" ");

            Console.WriteLine(arrayStr.Length);
        }


        public static bool Question3(int n)
        {
            //주어진 숫자가 소수인지 확인하는 함수구현
            for (int i = n; i >= 1; i--)
            {
                // n % i 의 나머지가 0이고 i와 n은 다른 수이며, i 가 1보다 크면 소수가 아니다.
                if (n % i == 0 && i != n && i > 1)
                {
                    return true;
                }
            }
            return false;
        }


        public static void Question4(int inputNumber)
        {
            int sumNumber = 0;
            inputNumber = int.Parse(Console.ReadLine());
            while (inputNumber > 0)
            {
                sumNumber += inputNumber % 10;
                inputNumber = inputNumber / 10;
            }

            Console.WriteLine(sumNumber);
        }


        public static void Question5(int[] array1, int[] array2, int[] array3)
        {
            string sameNumber = "";
            int[] sumArray = array1.Concat(array2).ToArray();
            sumArray = sumArray.Concat(array3).ToArray();

            for (int i = 0; i < sumArray.Length; i++)
            {
                for (int y = 1; y < sumArray.Length; y++)
                {
                    if (i == y)
                    {
                        continue;
                    }
                    else
                    {
                        if (sameNumber.IndexOf(sumArray[y].ToString()) < 0 && sumArray[i] == sumArray[y])
                        {
                            sameNumber += $"{sumArray[y]} ";
                        }
                    }
                }
            }
            Console.WriteLine(sameNumber);
        }






    }
}
