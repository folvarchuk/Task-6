using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
             *Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом
             *без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).*/

            Console.WriteLine("Введите предложение без использования знаков препинания:");
            string sentence = Console.ReadLine();
            //Разбиваем предложение на слова
            string[] sentenceArray = sentence.Split();
            //Приводим все символы в предложении к одному регистру (нижнему) и удаляем пробелы между словами:
            string resultSentence = "";
            foreach (string s in sentenceArray)
                resultSentence += s.ToLower();
            //Проверяем является ли строка палиндромом.
            //Разбиваем получившуюся строку без пробелов на две половины.
            string firstHalfOfSentence = "";
            string secondHalfOfSentence = "";
            for (int i = 0; i <= resultSentence.Length / 2; i++)
                firstHalfOfSentence += resultSentence[i];
            for (int j = resultSentence.Length - 1; j >= resultSentence.Length / 2; j--)
                secondHalfOfSentence += resultSentence[j];
            if (firstHalfOfSentence == secondHalfOfSentence)
                Console.WriteLine("Палиндром!");
            else
                Console.WriteLine("Не палиндром!");
            Console.ReadKey();
        }
    }
}