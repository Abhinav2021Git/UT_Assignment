using Assignment1;
using NUnit.Framework;

namespace Assignment1_Tests
{
    [TestFixture]
    public class RectangleTest
    {
        Rectangle obj = new Rectangle();

        [Test]
        public void GetLength()
        {
            int length = 5;  //arrange
            int result = obj.GetLength(); //act
          //  Assert.AreEqual(5, result); //assert
           
            /* We can also perform Assertion like this */
            Assert.AreEqual(length, result); //assert
        }

        [Test]
        public void SetLength()
        {
            int newLength = 4; //arrange
            int result = obj.SetLength(newLength); //act
            Assert.AreEqual(4, result); //assert
        }

        [Test]
        public void GetWidth()
        {
            int width = 6;      //arrange
            int result = obj.GetWidth();//act
           // Assert.AreEqual(6, result); //assert
            
            /* We can also perform Assertion like this */
            Assert.AreEqual(width, result); //assert
        }

        [Test]
        public void SetWidth()
        {
            int newWidth = 7;      //arrange
            int result = obj.SetWidth(newWidth);//act
            Assert.AreEqual(7, result); //assert
        }

        [Test]
        public void GetPerimeter()
        {
            obj.SetLength(5);   //arrange
            obj.SetWidth(6);   //arrange
            int result = obj.GetPerimeter();  //act
            Assert.AreEqual(22, result); //assert
        }

        [Test]
        public void GetArea()
        {
            obj.SetLength(5);   //arrange
            obj.SetWidth(7);   //arrange       
            int result = obj.GetArea(); //act
            Assert.AreEqual(35, result); //assert

        }



    }
}
