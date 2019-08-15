using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tree_Class;

namespace MainUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]//кнопка - значення за індексом
        [DataRow(0, 0)]
        [DataRow(4, 4)]
        [DataRow(7, 7)]
        public void test_actual_param_good(int idx, int expected)
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Tree ft = new Tree(arr_input);
            Assert.AreEqual(expected, ft.actual(idx));

        }

        [TestMethod]
        [DataRow(-5)]
        [DataRow(89)]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void test_actual_bad(int idx)
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Tree ft = new Tree(arr_input);
            ft.actual(idx);
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(4, 10)]
        [DataRow(7, 28)]
        public void test_read_good_data(int idx, int expected)
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Tree ft = new Tree(arr_input);
            Assert.AreEqual(expected, ft.read(idx));
        }

        [TestMethod]
        [DataRow(-5)]
        [DataRow(89)]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void test_read_bad(int idx)
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Tree ft = new Tree(arr_input);
            ft.read(idx);
        }

        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 4, 9)]
        [DataRow(3, 6, 18)]
        public void test_range_read_good_data(int idx1, int idx2, int expected)
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Tree ft = new Tree(arr_input);
            Assert.AreEqual(expected, ft.range_read(ft, idx1, idx2));
        }

        [TestMethod]
        [DataRow(-5, 98)]
        [DataRow(89, 45)]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void test_range_read_bad(int idx1, int idx2)
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Tree ft = new Tree(arr_input);
            ft.range_read(ft, idx1, idx2);
        }

        [TestMethod]
        public void test_count_prop_good()
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Tree ft = new Tree(arr_input);
            Assert.AreEqual(arr_input.GetLength(0), ft.Count);
        }

        
    }
}
