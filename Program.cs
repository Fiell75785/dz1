using System;

namespace MaxValueFinder
{
    public class ArrayProcessor
    {
        private int[] _array;
        public ArrayProcessor(int[] array)
        {
            _array = array;
        }
        public int FindMax()
        {
            if (_array == null || _array.Length == 0)
                throw new InvalidOperationException("Массив пуст или не инициализирован.");
            int max = _array[0];
            for (int i = 1; i < _array.Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }
            return max;
        }
    }

    class Program
    {
        static void Main()
        {
            int[] array = { 4, 7, 1, 15, 3 };
            ArrayProcessor processor = new ArrayProcessor(array);
            int max = processor.FindMax();
            Console.WriteLine("Максимальное значение: " + max);
        }
    }
}