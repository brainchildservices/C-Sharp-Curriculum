using NUnit.Framework;
using Problem2;
namespace Solution1Test
{
    public class Solution2Test
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test_Add_Three_Different_Numbers()
        {
            Solution2 solution=new Solution2();
            int Total=solution.AddThree(5,10,15);
            Assert.AreEqual(30,Total);
        } 
        [Test]
        public void Test_Add_Three_Same_Numbers()
        {
            Solution2 solution=new Solution2();
            int Total=solution.AddThree(5,5,5);
            Assert.AreEqual(15,Total);
        } 
        [Test]
        public void Test_Add_Three_Negative_Numbers()
        {
            Solution2 solution=new Solution2();
            int Total=solution.AddThree(-5,-10,-15);
            Assert.AreEqual(-30,Total);
        } 
        [Test]
        public void Test_Add_Three_Numbers_Different_Sign()
        {
            Solution2 solution=new Solution2();
            int Total=solution.AddThree(5,-10,15);
            Assert.AreEqual(10,Total);
        } 
    }
}