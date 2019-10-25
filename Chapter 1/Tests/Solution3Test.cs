using NUnit.Framework;
using Problem3;

namespace Problem3Tests
{
    public class Solution3Test
    {
        [SetUp]
        public void SetUp()
        {}
        
        [Test]
        public void Test_Number_Greater_Than_Five()
        {
            Solution3 solution = new Solution3();
            bool status =(10>5);
            Assert.IsTrue(status);
        }
        [Test]
        public void Test_Number_Equal_To_Five()
        {
            Solution3 solution = new Solution3();
            bool status =(5>5);
            Assert.IsFalse(status);
        }
        [Test]
        public void Test_Negative_Number()
        {
            Solution3 solution = new Solution3();
            bool status =(-5>5);
            Assert.IsFalse(status);
        }
        [Test]
        public void Test_Number_Zero()
        {
            Solution3 solution = new Solution3();
            bool status =(0>5);
            Assert.IsFalse(status);
        }
    }
}