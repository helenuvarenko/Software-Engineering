using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Course_work;
using System.Collections.Generic;

namespace OldUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_actual_good_data()
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Fenwick_Tree ft = new Fenwick_Tree(arr_input);  
            Assert.AreEqual(3, ft.actual(3));
        }

        [TestMethod]
        public void test_actual_bad_data()
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Fenwick_Tree ft = new Fenwick_Tree(arr_input);
            Assert.AreEqual(false, ft.actual(3)==4);
        }

        [TestMethod]//кнопка - значення за індексом
        [DataRow(0, 0)]
        [DataRow(4, 4)]
        [DataRow(7, 7)]
        public void test_actual_param_good(int idx, int expected)
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Fenwick_Tree ft = new Fenwick_Tree(arr_input);
            Assert.AreEqual(expected, ft.actual(idx));

        }

        [TestMethod]
        public void test_read_good_data()
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Fenwick_Tree ft = new Fenwick_Tree(arr_input);
            Assert.AreEqual(6, ft.read(3));
        }

        [TestMethod]
        public void test_read_bad_data()
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Fenwick_Tree ft = new Fenwick_Tree(arr_input);
            Assert.AreEqual(false, ft.read(3)==9);
        }

        [TestMethod]
        public void test_range_read_good_data()
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Fenwick_Tree ft = new Fenwick_Tree(arr_input);
            Assert.AreEqual(9, ft.range_read(ft, 2, 4));
        }

        [TestMethod]
        public void test_range_read_bad_data()
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Fenwick_Tree ft = new Fenwick_Tree(arr_input);
            Assert.AreEqual(false, ft.range_read(ft, 2, 4)==8);
        }

        [TestMethod]
        public void test_count_prop_good()
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Fenwick_Tree ft = new Fenwick_Tree(arr_input);
            Assert.AreEqual(arr_input.GetLength(0), ft.Count);

        }

        [TestMethod]
        public void test_count_prop_bad()
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Fenwick_Tree ft = new Fenwick_Tree(arr_input);
            Assert.AreEqual(false, ft.Count==ft.Count+1);

        }

        [TestMethod]
        public void test_update()
        {
            int[] arr_input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Fenwick_Tree ft = new Fenwick_Tree(arr_input);
            ft.update(4, 26);
            Assert.AreEqual(30, ft.actual(4));
        }

        //[TestMethod]
        //public void test_NULL()
        //{
        //    int[] arr_input = new int[] { , null };
        //    int y = null;
        //    Fenwick_Tree ft = new Fenwick_Tree(arr_input);
        //    Assert.AreEqual(false, ft.Count == ft.Count + 1);

        //}
    }
}
