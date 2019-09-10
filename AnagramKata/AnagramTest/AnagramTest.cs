using Anagram;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AnagramTest
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void AnagramTestClass()
        {
            AnagramKata Kata = new AnagramKata();
            CollectionAssert.AreEqual(new List<string> { "a" }, Kata.Anagrams("a", new List<string> { "a", "b", "c", "d" }));
            CollectionAssert.AreEqual(new List<string> { "carer", "arcre", "carre" }, Kata.Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }));
            CollectionAssert.AreEqual(new List<string> { "asdf", "fdsa", "dsaf" }, Kata.Anagrams("asdf", new List<string> { "fdsaaa", "asdf", "fdsa", "dsaf", "racers", "arceer", "raccer", "carrer", "cerarr" }));

        }
    }
}
