using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstCentral.Util;
namespace FirstCentral.Focus.Tests.KataTest
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void KataDescendingOrderTest()
        {
            const int toReverse = 123;
            const int expected = 321;
            var result = Kata.DescendingOrder(toReverse);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LikesTest()
        {
            Assert.AreEqual("no one likes this", Kata.Likes(new string[0]));
            Assert.AreEqual("Peter likes this", Kata.Likes(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", Kata.Likes(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", Kata.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", Kata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
    }
}
