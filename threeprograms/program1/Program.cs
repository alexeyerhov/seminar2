using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
           //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

           void FindSecondOfNumber(int num){
            if ( num > 99 && num < 1000 ){
                int figure2 = num/10%10;
                Console.WriteLine($"Second figure of number is {figure2}.");
            }
            else if( num<-99 && num > -1000 ) {
                num*=-1;
                int figure2 = num/10%10;
                Console.WriteLine($"Second figure of number is {figure2}.");
            }
            else {
                Console.WriteLine("Error, enter correct number!");
            }
           }


           Console.WriteLine("Please enter three-digit number:");
           int number = Convert.ToInt32(Console.ReadLine());
           FindSecondOfNumber(number);
        }
    }
}
