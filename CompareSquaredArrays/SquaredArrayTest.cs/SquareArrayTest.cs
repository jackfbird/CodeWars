using CompareSquaredArrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SquaredArrayTest.cs
{
    [TestClass]
    public class SquareArrayTest
    {
        Exercises exercises = new Exercises();

        [TestMethod]
        public void CompareSquaredArrays()
        {
            Assert.AreEqual(true, exercises.Comp(new int[] { 1, 2, 9, 3, 4 }, new int[] { 1, 4, 81, 9, 16}));
            Assert.AreEqual(true, exercises.Comp(new int[] { 10, 5, 15, 1, 24 }, new int[] { 1, 576, 100, 25, 225 }));
            Assert.AreEqual(true, exercises.Comp(new int[] { 11, 26, 94, 32, 4 }, new int[] { 4*4, 26*26, 11*11, 94*94, 32*32 }));
            Assert.AreEqual(true, exercises.Comp(new int[] { 29, 0, 42, 221, 9424 }, new int[] { 9424*9424, 29*29, 0*0, 42*42, 221*221 }));

        }
    }
}
