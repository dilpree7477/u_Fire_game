using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bhangu_Fire_gameTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bhangu_Fire_game.option.option obj = new Bhangu_Fire_game.option.option();
            obj.check();
            Assert.IsTrue(true);
        }
    }
}
