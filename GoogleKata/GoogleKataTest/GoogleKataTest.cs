using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoogleKata;

namespace GoogleKataTest
{
    [TestClass()]
    public class ExercisesTests
    {
        Exercises exercises = new Exercises();

        [TestMethod]
        public void GoogleKataTest()
        {
            Assert.AreEqual("c:**,h:*,i:*,a:*,g:*,o:*", exercises.GetStrings("Chicago"));
            Assert.AreEqual("c:*,o:*,l:*,u:**,m:*,b:*,s:*", exercises.GetStrings("Columbus"));
            Assert.AreEqual("f:**,r:**,a:*,n:*,k:*,o:*,t:*", exercises.GetStrings("Frankfort"));
            Assert.AreEqual("s:*,e:**,a:*,t:**,l:*", exercises.GetStrings("Seattle"));
            Assert.AreEqual("a:***,s:*,d:*,f:*,e:**,n:*,w:**,r:*,g:*", exercises.GetStrings("asdfaenwargwe"));
        }
    }
}

