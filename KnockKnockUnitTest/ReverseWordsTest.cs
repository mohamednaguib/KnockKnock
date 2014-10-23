using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KnockKnock;

namespace KnockKnockUnitTest
{
    [TestClass]
    public class ReverseWordsTest
    {
        [TestMethod]
        public void CatAndDog()
        {
            RedPillService rp = new RedPillService();
            var actual = rp.ReverseWords("cat and dog");
            Assert.AreEqual("tac dna god", actual);
        }
        [TestMethod]
        public void SingleWord()
        {
            RedPillService rp = new RedPillService();
            var actual = rp.ReverseWords("SingleWord");
            Assert.AreEqual("droWelgniS", actual);
        }
        [TestMethod]
        public void SpaceSingleWord()
        {
            RedPillService rp = new RedPillService();
            var actual = rp.ReverseWords(" SingleWord");
            Assert.AreEqual(" droWelgniS", actual);
        }

        [TestMethod]
        public void SpaceSingleWordSpace()
        {
            RedPillService rp = new RedPillService();
            var actual = rp.ReverseWords(" SingleWord ");
            Assert.AreEqual(" droWelgniS ", actual);
        }
        [TestMethod]
        public void SpaceWordSpaceAnotherWord()
        {
            RedPillService rp = new RedPillService();
            var actual = rp.ReverseWords(" Two words");
            Assert.AreEqual(" owT sdrow", actual);
        }

    }
}
