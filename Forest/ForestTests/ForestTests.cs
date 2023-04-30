using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Tests
{
    [TestClass()]
    public class ForestTests
    {
        [TestMethod()]
        public void SortArraysTest()
        {
            var forest = new Forest();
            int[] cols = {3, 4, 4 ,3, 6 };
            int[] rows = {1, 2, 5, 2, 5};
            int[] exCols = {4, 6, 3, 4, 3};
            int[] exRows = {5, 5, 2, 2, 1};

            forest.SortArrays(rows, cols);

            if(cols == exCols && rows == exRows)
            {
                Assert.AreEqual(1, 1);
            } else
            {
                Assert.Fail();
            }

        }
    }
}