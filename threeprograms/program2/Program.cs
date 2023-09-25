using System;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
               
            void checkForThirdDigit(int num){
                if ( num > 99 ) {
                    while (num > 999) {
                        num = num/10;
                    }
                    num = num%10;
                    Console.WriteLine($"Your digit is {num}");
                }
                else if (num < -99) {
                    while (num < -999) {
                        num = num/10;
                    }
                    num = num%10;
                    num*=-1;
                    Console.WriteLine($"Your digit is {num}");
                }
                else {
                    Console.WriteLine("Have no third digit, try again!");
                }
            }
            


            Console.WriteLine("Enter your number:");
            int number = Convert.ToInt32(Console.ReadLine());
            checkForThirdDigit(number);

        }
    }
}
