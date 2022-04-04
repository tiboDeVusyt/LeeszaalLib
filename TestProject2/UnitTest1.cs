using LeeszaalLib;
using NUnit.Framework;

namespace TestProject2.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }
        [Test]
        public void Lanch()
        {
            ClassManger.Lanch();

            Assert.AreEqual(ClassManger.people.Count == 20 , ClassManger.people.Count == 20);
            Assert.AreEqual(MagazineColors.Colors().Count , 5);
           
            //Arange
            //Act
            //double Actual = _startingClass.Add(1, 2);
            //Assert
            //double expexted = 3;
            //Assert.AreEqual(expexted, Actual);
        }
        [Test]
        public void AddReaderTest()
        {
            ClassManger.Lanch();
            var actual = Reader.readers.Count +  2;
            ClassManger.Add(2); 

            Assert.AreEqual(Reader.readers.Count ,actual);
        }
        [Test]
        public void HatTests()
        {
            Hat.Hats();
            var expextedCount = 4 ;

            Assert.AreEqual(expextedCount, Hat.Hats().Count);
        }
    }
}