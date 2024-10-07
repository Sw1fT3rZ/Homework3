using System;
using System.Text;

namespace Task1
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }

    class MyArray : IOutput
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
    }

    class Part1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] myNumbers = { 1, 2, 3, 4, 5 };
            MyArray myArray = new MyArray(myNumbers);

            Console.WriteLine("Завдання 1:");
            myArray.Show();
            myArray.Show("Мій масив");

            Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}
