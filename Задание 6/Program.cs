using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. Найти самое длинное слово в строке.*/

            Console.WriteLine("Введите предложение без использования знаков препинания:");
            string sentence = Console.ReadLine();
            //Разбиваем предложение на слова
            string[] sentenceArray = sentence.Split();
            //Посчитаем количество слов в предложении:
            int count = 0;
            foreach(string s in sentenceArray)
            {
                count++;
            }
            //Ищем максимальное количество символов в каждом слове:
            int max = sentenceArray[0].Length;
            for(int i = 0; i < count; i++)
            {
                if (max < sentenceArray[i].Length)
                    max = sentenceArray[i].Length;
            }
            //Выводим слово или слова с наибольшим количеством символов:
            Console.WriteLine("Вот самое длинное слово или самые длинные слова в предложении:");
            foreach(string k in sentenceArray)
            {
                if(k.Length == max)
                    Console.WriteLine("{0}, в нём {1} символов", k, max);
            }    
            Console.ReadKey();
        }
    }
}
