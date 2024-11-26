using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CanDriveTests
{
    [TestClass]
    public class CanDriveTests
    {
        [TestMethod]
        public void Test_CanDrive_True_For_Age_16()
        {
            Assert.IsTrue(CanDrive(16));
        }

        [TestMethod]
        public void Test_CanDrive_True_For_Age_18()
        {
            Assert.IsTrue(CanDrive(18));
        }

        [TestMethod]
        public void Test_CanDrive_False_For_Age_15()
        {
            Assert.IsFalse(CanDrive(15));
        }

        private bool CanDrive(int age)
        {
            const int drivingAge = 16;
            return age >= drivingAge;
        }
    }
}