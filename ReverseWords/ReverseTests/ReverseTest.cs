using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ReverseWords;
using System;

namespace ReverseTests
{
    [TestClass]
    public class ReverseTest
    {
        [TestMethod]
        public void ReverseWords()
        {
            var mockService = new Mock<Reverse>(MockBehavior.Strict);
            var mockDelegate = new Mock<Func<Reverse>>();
            mockDelegate.Setup(x => x()).Returns(mockService.Object);
            Assert.AreEqual("sihT si", mockService.Object.ReverseWords("This is"));
            Assert.AreEqual("This is", mockService.Object.ReverseWords("sihT si"));
            Assert.AreEqual("The wind blows this way!", mockService.Object.ReverseWords("ehT dniw swolb siht !yaw"));
            Assert.AreEqual("Chicago Texas Amsterdam", mockService.Object.ReverseWords("ogacihC saxeT madretsmA"));
            Assert.AreEqual("012345 9876 123", mockService.Object.ReverseWords("543210 6789 321"));
        }
    }
}
