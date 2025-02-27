﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_11._11
{
    class DictionaryDemo
    {

        static void Main(string[] args)
        {
            MyDict dict = new MyDict();
                Console.WriteLine("\t\t\tДоброго времени суток,вы запустили программу <Словарь>");
            int enter=-1;
            while (enter != 0)
            {
                Console.WriteLine("\tКакое действие хотите выполнить? : Создать словарь - 1; Добавить слово - 2; Найти слово - 3; Заменить перевод - 4; Заменить значение - 5; Вывести словарь - 6;");
                enter = int.Parse(Console.ReadLine());
                switch (enter)
                {
                    case 1:
                        Console.WriteLine("Введите тип вашего словаря : ");
                        dict.type = Console.ReadLine();
                        dict.savetype();
                        break;

                    case 2:
                        Console.WriteLine("Введите ваше слово : ");
                        string key = Console.ReadLine();
                        dict.savekey(key);
                        Console.WriteLine("Введите перевод вашего слова :");
                        string value = Console.ReadLine();
                        dict.append(key, value);
                        dict.savevalues(value);
                        break;
                    case 3:
                        Console.Write("Введите слово которого хотели бы найти перевод / значение :");
                        string keySearch = Console.ReadLine();
                        foreach (string word in dict.search(keySearch))
                        {
                            Console.WriteLine($"Ваш перевод / значение слова : {word}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Введите какое слово вы бы хотели заменить :");
                        string oldKey = Console.ReadLine();
                        Console.WriteLine("Введите на какое слово бы в хотели заменить :");
                        string newKey = Console.ReadLine();
                        dict.replace_key(oldKey, newKey);
                        break;
                    case 5:
                        Console.WriteLine("Введите слово у которого вы бы хотели заменить индекс");
                        string keyReplace = Console.ReadLine();
                        Console.WriteLine("Введите значение на которое вы хотите изменить");
                        string keyValue = Console.ReadLine();
                        Console.WriteLine("Введите индекс который вы бы хотели заменить");
                        int index = int.Parse(Console.ReadLine());
                        dict.replace_value(keyReplace, keyValue, index);
                        break;
                    case 6:
                        Console.WriteLine(dict.ToString());
                        break;
                    case 7:
                        dict.readingfile();
                        break;
                }
            }
        }
    }
}
 //    MyDict dict = new MyDict("Rus-Eng");
        //    dict.append("Трава", "Расслабляющая классная тема");
        //    dict.append("Трава", "Зеленая на земле штука");
        //    dict.append("Машина", "Крутой транспорт для хачей");
        //    foreach (string word in dict.search("машина"))
        //    {
        //        Console.WriteLine($"{word}");
        //    }
        //    foreach (string word in dict.search("ТРАВА"))
        //    {
        //        Console.WriteLine(($"{word}"));
        //    }
        //        dict.replace_key("машина", "автобус");
        //    Console.WriteLine(dict);
        //    Console.WriteLine(dict);
        //    }