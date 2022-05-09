using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = " ";
            int arrayLenght = 0;
            int number;
            int[] array = new int[arrayLenght];
            int[] newArray = new int[arrayLenght];
            int sum = 0;

            do
            {
                Console.WriteLine("Введите число, sum или exit");
                userInput = Console.ReadLine();

                if (userInput != "sum" && userInput != "exit")
                {
                    number = Convert.ToInt32(userInput);
                    arrayLenght += 1;
                    array = new int[arrayLenght];

                    for (int i = 0; i < newArray.Length; i++)
                    {
                        array[i] = newArray[i];
                    }
                    array[arrayLenght - 1] = number;
                    newArray = array;
                }
                else if (userInput == "sum")
                {

                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i];
                    }
                    Console.WriteLine($"Сумма цифр {sum}");
                    sum = 0;
                }
            } while (userInput != "exit");
        }
    }
}