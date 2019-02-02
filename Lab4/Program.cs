﻿/*
 * Lab4 Коллекции. Ассоциативные массивы
 * 
 * Часть 1. Дан CSV файл с данными журнала по предмету в формате:
 *     Иванов Иван Иванович; ; н; н; 2; н; н; н; н; 3
 *     Петров Петр Петрович; ; 5; ; 4; 4; ; 5; 5; 5
 * Считать информацию о посещениях и оценках в словарь студентов.
 * Выдавать информацию об ошибках формата файла.
 * 
 * Часть 2. По данным полученным из файла, получить:
 *     1. Список аттестоваций студентов;
 *     2. Список результатов аттестованных студентов;
 *     4. Записать результаты всех студентов в новый файл в формате:
 *         Иванов Иван Иванович; н/а
 *         Петров Петр Петрович; 5
 */

using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Lab4Collections.RandomJournal("/Users/ilaloskarev/CSharp/RKSI-DotNet/Lab4/43.txt", 10);
            Lab4Collections.RandomJournal("/Users/ilaloskarev/CSharp/RKSI-DotNet/Lab4/32.txt", 10);
        }
    }
}
