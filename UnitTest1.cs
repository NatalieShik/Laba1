using ClassLibraryDEMOPrepearing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectDEMOPrepearing
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ПолучитьКоличествоЗаявок_ВозвращаетПравильноеКоличество()
        {
            // Arrange
            int expected = 2;

            // Act
            int result = Statistic.ПолучитьКоличествоЗаявок(1);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
