using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bhangu_Fire_game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhangu_Fire_game.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Bhangu_Fire_game.option.option obj = new Bhangu_Fire_game.option.option();
            obj.check();
            Assert.IsTrue(true);
        }


        [TestMethod()]
        public void Form2Test()
        {
            Bhangu_Fire_game.option.option obj = new Bhangu_Fire_game.option.option();
            obj.check();
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void Form1Test1()
        {
            Assert.Fail();
        }
    }
}