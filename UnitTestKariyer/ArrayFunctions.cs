using KariyerTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestKariyer
{
    [TestClass]
    public class ArrayFunctions
    {
        KariyerTest.ArrayFunctions arrayFunctions = new KariyerTest.ArrayFunctions();

        [TestMethod]
        public void TestMethod1()
        {
            List<DublicateModel> dublicateList = arrayFunctions.GetDublicateCount(new int[] { 1, 1, 1, 1, 1, 2 });

            List<DublicateModel> controlList = new List<DublicateModel>()
            {
                new DublicateModel { Item = 1, Count = 5 },
                new DublicateModel { Item = 2, Count = 1 }
            };

            Assert.AreEqual(CompareList(dublicateList, controlList), true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<DublicateModel> dublicateList = arrayFunctions.GetDublicateCount(new int[] { 1, 2, 3, 5, 2, 3, 4, 1, 1 });

            List<DublicateModel> controlList = new List<DublicateModel>()
            {
                new DublicateModel { Item = 1, Count = 3 },
                new DublicateModel { Item = 2, Count = 2 },
                new DublicateModel { Item = 3, Count = 2 },
                new DublicateModel { Item = 4, Count = 1 },
                new DublicateModel { Item = 5, Count = 1 }
            };

            Assert.AreEqual(CompareList(dublicateList, controlList), true);
        }

        public bool CompareList(List<DublicateModel> dublicateList, List<DublicateModel> controlList)
        {
            if (dublicateList.Count != controlList.Count)
                return false;

            for (int index = 0; index < dublicateList.Count; index++)
            {
                if (dublicateList[index].Item != controlList[index].Item)
                    return false;
                if (dublicateList[index].Count != controlList[index].Count)
                    return false;
            }
            return true;
        }
    }
}
