using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortArrayOddsOnly;

namespace SortArrayOddsTest
{
    [TestClass()]
    public class ExercisesTests
    {
        Exercises exercise = new Exercises();

        [TestMethod]
        public void SortArray()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, exercise.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            CollectionAssert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, exercise.SortArray(new int[] { 5, 3, 1, 8, 0 }));
            CollectionAssert.AreEqual(new int[] { }, exercise.SortArray(new int[] { }));
        }
    }
}
