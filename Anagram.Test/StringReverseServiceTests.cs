using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;

namespace AngramTest
{
    [TestClass]
    public class StringReverseServiceTests
    {
        [TestMethod]
        [DataRow("asdf hjkl", "fdsa lkjh ")]
        [DataRow("234? 78!5", "234? 78!5 ")]
        [DataRow("2asd 9fjkg", "2dsa 9gkjf ")]
        [DataRow("asd2 fjkg9", "dsa2 gkjf9 ")]
        [DataRow(null, null)]
        [DataRow("     ", "      ")]
        [DataRow("", "")]
        public void StringReverseService_ValidData_Tests(string value, string result) 
        {
            string actual = StringReverseService.Reverse(value);

            Assert.AreEqual(result, actual);            
        }       
    }
}