using System;

namespace EvenNumbersCounter
{
    public class RandomArray
    {
        private int[] _array;
        private static Random _random = new Random();

        public RandomArray(int size, int minValue, int maxValue)
        {
            _array = new int[size];
            GenerateArray(minValue, maxValue);
        }

        private void GenerateArray(int minValue, int maxValue)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = _random.Next(minValue, maxValue + 1);
            }
        }

        public int CountEvenNumbers()
        {
            int count = 0;
            foreach (int num in _array)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public void PrintArray()
        {
            Console.WriteLine("Массив: " + string.Join(", ", _array));
        }
    }

    class Program
    {
        static void Main()
        {
            RandomArray randArray = new RandomArray(10, 1, 100);

            randArray.PrintArray();

            int evenCount = randArray.CountEvenNumbers();
            Console.WriteLine("Количество чётных чисел: " + evenCount);
        }
    }
}