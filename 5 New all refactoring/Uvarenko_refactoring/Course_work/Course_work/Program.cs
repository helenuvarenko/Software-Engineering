using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Course_work
{
  public class Fenwick_Tree
    {
      
        private List<int>[] arr_list;
        // метод, що розраховує кумулятивну суму для кожного елементу масиву
        public int cumm_summ(int idx, int[] arr_inp)
        {

            int summ = 0;
            int end = idx - (idx & -idx);

            while (idx > end)
            {
                summ += arr_inp[idx];
                idx -= 1;

            }

            return summ;
        }
      // властивість, яка повертає довжину масиву списків
        public int Count
        {
            get
            {
                int count = arr_list.GetLength(0);
                return count;
            }
        }
      // властивість, яка повертає значення і-го елементу
        public List<int> this[int i]
        {
            get
            {
                return arr_list[i];
            }
        }

      // конструктор класу
        public Fenwick_Tree(int[] arr_inp)
        {
            List<int>[] arr_list = new List<int>[arr_inp.GetLength(0)];

            for (int i = 0; i < arr_inp.GetLength(0); i++)
            {

                List<int> tempList = new List<int>();
                tempList.Add(cumm_summ(i, arr_inp));
                arr_list[i] = tempList;

            }
            this.arr_list = arr_list;

        }
      // метод розрахунку кумулятивної суму від початку масиву до певного заданого значення
        public int read(int idx)
        {
            int sum = 0;
            while (idx > 0)
            {
                sum += arr_list[idx][0];
                idx -= (idx & -idx);
            }
            return sum;
        }
      // метод який змінює значення певної кумулятивнї суми, а також залежних від неї.
        public void update(int idx, int val)
        {
            while (idx < arr_list.GetLength(0))
            {
                arr_list[idx][0] += val;
                idx += (idx & -idx);
            }
        }
      
	// зчитування значення і-го елементу вхідного масиву через індекс масиву листів
        public int actual(int idx)
        {
            int sum = arr_list[idx][0];
            if (idx > 0)
            {
                int z = idx - (idx & -idx);
                idx--;
                while (idx != z)
                {
                    sum -= arr_list[idx][0];

                    idx -= (idx & -idx);
                }
            }
            return sum;
        }
      // зчитування кумулятивної суми на певному відрізку
        public int range_read(Fenwick_Tree t, int a, int b)
        {
            return t.read(b) - t.read(a - 1);
        }
    }
        class Program
        {
            static void Main(string[] args)
            {

            }
        }
    }
