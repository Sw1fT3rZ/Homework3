using System;
using System.Text;

namespace Task2
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }

    interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }

    class MyArray : IOutput, IMath
    {
        private int[] arr;

        public MyArray(int[] arr)
        {
            this.arr = arr;
        }

        public void Show()
        {
            Console.WriteLine("Елементи масиву: " + string.Join(", ", arr));
        }

        public void Show(string info)
        {
            Console.WriteLine($"{info}: {string.Join(", ", arr)}");
        }

        public int Max()
        {
            return arr.Max();
        }

        public int Min()
        {
            return arr.Min();
        }

        public float Avg()
        {
            return (float)arr.Sum() / arr.Length;
        }

        public bool Search(int valueToSearch)
        {
            return Array.Exists(arr, element => element == valueToSearch);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] myNumbers = { 1, 2, 3, 4, 5 };
            MyArray myArray = new MyArray(myNumbers);

            Console.WriteLine("Завдання 2");

            myArray.Show();
            myArray.Show("Мій масив");

            Console.WriteLine("Максимальне значення: " + myArray.Max());
            Console.WriteLine("Мінімальне значення: " + myArray.Min());
            Console.WriteLine("Середнє значення: " + myArray.Avg());
            Console.WriteLine("Чи є значення 3 в масиві? " + myArray.Search(3));
            Console.WriteLine("Чи є значення 7 в масиві? " + myArray.Search(7));

            Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}
