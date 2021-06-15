using NUnit.Framework;
using Assignment1;

namespace Assignment1_Tests
{
    [TestFixture]
    public class RectangleTest
    {
        Rectangle obj = new Rectangle();

        [Test]
        public void GetLength()
        {
            int length=0;      //arrange
            int result = obj.GetLength();//act
             Assert.AreEqual(1, result); //assert
        }

        [Test]
        public void SetLength(int new_length)
        {
             new_length = 5;      //arrange
            int result = obj.SetLength(new_length);//act
            Assert.AreEqual(5, result); //assert

        }

        [Test]
        public void GetWidth()
        {
            int width=0;      //arrange
            int result = obj.GetWidth();//act
            Assert.AreEqual(1, result); //assert
        }

        [Test]
        public void SetWidth(int new_width)
        {
            new_width = 7;      //arrange
            int result = obj.SetWidth(new_width);//act
            Assert.AreEqual(7, result); //assert
        }

        [Test]
        public void GetPerimeter()
        {
          // int length=5, width=3;       //arrange
            int result = obj.GetPerimeter();//act
            Assert.AreEqual(4, result); //assert
        }

        [Test]
        public void GetArea()
        {
            int length=3, width=3;       //arrange
            int result = obj.GetPerimeter();//act
            Assert.AreEqual(4, result); //assert

        }


    }
}
