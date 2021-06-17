using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class Rectangle
    {
        private int length;
        private int width;
        public int perimeter;
        public int area;

      public Rectangle()
        {
            length = 1;
            width = 1;
        }

       public Rectangle(int l, int w)
        {
            this.length = l;
            this.width = w;
        }

        public int GetLength()
        {
            return length;
        }
           public int SetLength(int length)
        {
            try
            {
                this.length = length;
                return this.length;
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input exception is captured against \"SetLength()\"");
                Console.WriteLine(e.Message);
                return this.length;
            }
        }
        public int GetWidth()
        {
            return width;
        }
        
        public int SetWidth(int width)
        {
            try
            {
                this.width = width;
                return this.width;
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input exception is captured under \"SetWidth()\"");
                Console.WriteLine(e.Message);
                return this.width;
            }
        }
        public int GetPerimeter()
        {
            try
            {
                perimeter = 2 * (length + width);
                return perimeter;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input exception is captured under GetPerimeter()");
                Console.WriteLine(e.Message);
                return perimeter;
            }
        }
        public int GetArea()
        {
            try
            {
                area = length * width;
                return area;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input exception is captured in GetArea()");
                Console.WriteLine(e.Message);
                return area;
            }

        }

    }
}
