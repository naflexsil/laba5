
/***********************************
*                                  *
*     работа Стариковой Алины      *  
*       "Строки и коллекции"       *
*              5 лаба              *      
*                                  *
***********************************/

using System;
using System.IO;

namespace laba5 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("\n\t -------------------------------------------\n" +
                          "\t |           какую папку выбираем?         |\n" + "\t -------------------------------------------\n\n");
            string FilePath = @"C:\";
            bool Success = false;
            while (Success == false) {
                FilePath = Console.ReadLine();
                if (Directory.Exists(FilePath) && FilePath != string.Empty) {
                    Success = true;
                }
                else {
                    Console.WriteLine(" \n почти похоже на путь к папке.. давай ты еще раз попробуешь");
                }
            }

            int Choice = 0; int Option = 2;
            while (Choice != Option) {
                Console.Clear();
                Console.WriteLine($"\n\t -------------------------------------------\n " +
                                   $"\t |\t         что желаем?               |\n\t -------------------------------------------");
                Console.WriteLine("\t\n -----------------------\n | 1) исправить ошибки |\n | 2) заменить номера  |\n -----------------------");
                while (Choice < 1 || Choice > Option) {
                    if (int.TryParse(Convert.ToString(Console.ReadLine()), out Choice) == false) {
                        Console.WriteLine(" ..ты цифру выбери, родной");
                    }
                }
                Console.Clear();
                switch (Choice) {
                    case 1:
                        Phone.EditorOfPhoneNumbers(Path);
                        Choice = 0;
                        break;

                    case 2:
                        Console.Clear();
                        Mistakes.SearchingWrongWords(Path);
                        Choice = 0;
                        break;
                }
            }
        }
    }
}
