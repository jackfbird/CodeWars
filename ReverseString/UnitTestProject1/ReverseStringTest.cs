using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseString;

namespace UnitTestProject1
{
    [TestClass()]
    public class ExercisesTests
    {
        Exercises exercises = new Exercises();

        [TestMethod]
        public void GoogleKataTest()
        {
            Assert.AreEqual(true, exercises.ReverseString("ala"));
            Assert.AreEqual(true, exercises.ReverseString("mom"));
            Assert.AreEqual(false, exercises.ReverseString("mdsdfoaaam"));
            Assert.AreEqual(false, exercises.ReverseString("12531"));
        }
    }
}


