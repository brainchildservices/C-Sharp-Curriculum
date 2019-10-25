using NUnit.Framework;
using Curriculum;

namespace Curriculum
{
    public class Solution1Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Add_Two_Different_Numbers()
        {
            Solution1 solution=new Solution1();
            int Total=solution.Add(5,10);
            Assert.AreEqual(15,Total);
        }
        [Test]
        public void Test_Add_Two_Same_Numbers()
        {
            Solution1 solution=new Solution1();
            int Total=solution.Add(5,5);
            Assert.AreEqual(10,Total);
        }
        [Test]
        public void Test_Add_Two_Sign_Numbers()
        {
            Solution1 solution=new Solution1();
            int Total=solution.Add(5,-5);
            Assert.AreEqual(0,Total);
        }
        [Test]
        public void Test_Add_Two_Negative_Numbers()
        {
            Solution1 solution=new Solution1();
            int Total=solution.Add(-5,-5);
            Assert.AreEqual(-10,Total);
        }
    }
}