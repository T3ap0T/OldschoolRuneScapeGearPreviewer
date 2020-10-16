using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSGPData;

namespace OSGPUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DBConnection()
        {
            // Arrange
            // Database.OpenGeneralConnection a static method thus not needing any prior declaration of a class

            // Act
            bool openDatabase = Connection.connect();

            // Assert
            Assert.AreEqual(true, openDatabase);
        }
    }
}
