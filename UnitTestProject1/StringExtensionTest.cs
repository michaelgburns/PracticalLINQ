using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod]
        public void ConvertToTitleCase()
        {
            //Arrage 
            var source = "the return of the king";
            var expected = "The Return Of The King";

            //Act            
            var result = source.ConvertToTitleCase();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
