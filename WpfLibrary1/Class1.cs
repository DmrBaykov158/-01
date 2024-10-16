using System;
namespace Lib_1
{

    public static class CalculationModule
    {

        public static (int[] numbers, int sum, int count) CalculateSum(int K)
        {
            int sum = 0;
            int count = 0;
            int[] numbers = new int[100]; // Максимальное количество чисел 

            Random random = new Random();

            while (sum < K)
            {
                int number = random.Next(2, 11); // Случайное число от 2 до 10
                numbers[count] = number;
                sum += number;
                count++;
            }

            return (numbers, sum, count);
        }
    }
}