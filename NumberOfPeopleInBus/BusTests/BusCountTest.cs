using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NumberOfPeopleInBus;

namespace BusTests
{
    [TestClass]
    public class PeopleInBusTests
    {
        [TestMethod]
        public void BusPeopleTest()
        {
            BusCount Kata = new BusCount();
            List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
            Assert.AreEqual(5, Kata.Number(peopleList));
            List<int[]> peopleList2 = new List<int[]>() { new[] { 5, 0 }, new[] { 13, 5 }, new[] { 5, 8 } };
            Assert.AreEqual(10, Kata.Number(peopleList2));
            List<int[]> peopleList3 = new List<int[]>() { new[] { 1, 0 }, new[] { 12, 2 }, new[] { 5, 8 } };
            Assert.AreEqual(8, Kata.Number(peopleList3));
            List<int[]> peopleList4 = new List<int[]>() { new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 } };
            Assert.AreEqual(0, Kata.Number(peopleList4));
        }
    }
}
