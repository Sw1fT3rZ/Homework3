using System;
using System.Text;

namespace Task3
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

    interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }

    class MyArray : IOutput, IMath, ISort
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

        public void SortAsc()
        {
            Array.Sort(arr);
        }

        public void SortDesc()
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] myNumbers = { 5, 2, 8, 3, 1 };
            MyArray myArray = new MyArray(myNumbers);

            Console.WriteLine("Завдання 3");

            myArray.Show("Оригінальний масив");

            myArray.SortAsc();
            myArray.Show("Сортування за зростанням");

            myArray.SortDesc();
            myArray.Show("Сортування за спаданням");

            myArray.SortByParam(true);
            myArray.Show("Сортування за зростанням (через параметр)");

            myArray.SortByParam(false);
            myArray.Show("Сортування за спаданням (через параметр)");

            Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}
