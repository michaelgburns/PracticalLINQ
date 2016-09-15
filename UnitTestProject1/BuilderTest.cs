using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void BuildIntegerSequenceTest()
        {
            //Arrange 
            Builder listBuilder = new Builder();

            //act
            var result = listBuilder.BuidIntergerSequence();
            foreach (var item in result)
            {
                Debug.WriteLine(item.ToString());
            }

            //assert
            Assert.IsNotNull(result);
          
        }

        [TestMethod]
        public void BuildStringSequenceTest()
        {
            //Arrange 
            Builder listBuilder = new Builder();

            //act
            var result = listBuilder.BuildStringSequence();
            foreach (var item in result)
            {
                Debug.WriteLine(item.ToString());
            }

            //assert
            Assert.IsNotNull(result);

        }
    }
}
