using System;

namespace CuttingARod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cutting a Rod!");
            Console.WriteLine("--------------");


            Console.WriteLine("Enter the length of the rod");
            try
            {
                int length = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the prices of the different lengths separated by space");
                String[] elements = Console.ReadLine().Split(' ');
                int[] array = new int[length];
                for (int i = 0; i < length; i++) {
                    array[i] = int.Parse(elements[i]);
                }
                Console.WriteLine("The maximum cost is "+MaxCost(array));
            }
            catch (Exception exception) {
                Console.WriteLine("Exception thrown is "+exception.Message);
            }

            Console.ReadLine();
        }

        private static int MaxCost(int[] array) {
            int[] value = new int[array.Length+1];
            value[0] = 0;
            for (int i = 1; i <= array.Length; i++) {
                int maxVal = int.MinValue;
                for (int j = 0; j < i; j++) {
                    maxVal = Math.Max(maxVal, value[j]+array[i-j-1]);
                }
                value[i] = maxVal;
            }
            
            return value[array.Length];
        }
    }
}
