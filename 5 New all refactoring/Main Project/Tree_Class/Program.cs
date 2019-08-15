using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Class
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Tree
    {

        private int[] arr_input;

        // властивість, яка повертає довжину масиву списків
        public int Count
        {
            get
            {
                int count = arr_input.GetLength(0);
                return count;
            }
        }

        public Tree(int[] arr_input)//конструктор
        {
            this.arr_input = arr_input;
        }

        public int actual(int idx)//витягує елемент по індексу
        {
            if (idx < 0 || idx > arr_input.GetLength(0))
            {
                throw new System.IndexOutOfRangeException("Out of range");
            }
            int value = arr_input[idx];
            return value;
        }

        // метод розрахунку кумулятивної суму від початку масиву до певного заданого значення
        public int read(int idx)
        {
            if (idx < 0 || idx > arr_input.GetLength(0))
            {
                throw new System.IndexOutOfRangeException("Out of range");
            }

            int sum = 0;

            for (int i = 0; i <= idx; i++)
            {
                sum += arr_input[i];
            }

            return sum;
        }

        // зчитування кумулятивної суми на певному відрізку
        public int range_read(Tree t, int idx1, int idx2)
        {
            if (idx1 < 0 || idx1 > arr_input.GetLength(0) || idx2 < 0 || idx2 > arr_input.GetLength(0))
            {
                throw new System.IndexOutOfRangeException("Out of range");
            }
            return t.read(idx2) - t.read(idx1 - 1);
        }

    }
}
