using NUnit.Framework;
using Problem4;

namespace Problem4Tests
{
    public class Solution4Test
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void Test_Add_Two_Numbers()
        {
            Solution4 solution= new Solution4();
            double Total = solution.Add(2.9,3.1);
            Assert.AreEqual(6.0,Total);
        }
        [Test]
        public void Test_Add_Three_Numbers()
        {
            Solution4 solution= new Solution4();
            double Total = solution.Add(2.9,3.1,5.2);
            Assert.AreEqual(11.2,Total);
        }
    }
}
