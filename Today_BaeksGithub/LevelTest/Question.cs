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



    }
}
