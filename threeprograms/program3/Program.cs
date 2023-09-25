using System;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

            void checkForWeekend(int numOfDay){
                if (numOfDay==6 || numOfDay==7){
                    Console.WriteLine("Yes, your day is a weekend!");
                }
                else {
                    Console.WriteLine("No, it`s not a weekend!");
                }

            }


            Console.WriteLine("Enter the number of day:");
            int number = Convert.ToInt32(Console.ReadLine());
            checkForWeekend(number);
        }
    }
}
