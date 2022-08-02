using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Rectangle4
{
    class Rectangle
    {
       //Declare the member veriables for the Rectangle class.
       private float height;
       private float width;
       private float area;
       private float perimeter;
       private bool right;

        //Define the constructors sturting with the default.
        public Rectangle()
       {
       }

       public Rectangle(float paramHeight, float paramWidth)
       {
       height = paramHeight;
       width = paramWidth;
       }

        public float GetHeight()
        {
            return height;
        }

        public void SetHeigh(float theHeight)
        {
            height = theHeight;
        }

        public float GetWidth()
        {
            return width;
        }

        public void SetWidth(float theWidth)
        {
            height = theWidth;
        }

        
        public float Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public float Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public float Area
        {
            get
            {
                return area;
            }
           
        }
        public float Perimeter
        {
            get
            {
                return perimeter;
            }
            
        }
        public bool Right
        {
            get
            {
                return right;
            }
           
        }
        //Define the instance methods.
        public float ComputeArea()
        {
            float area = width * height;
            return area;
        }

        public float ComputePerimeter()
        {
            float perimeter = (width + height) * 2;
            return perimeter;
        }

        public bool IsSquare()
        {
            bool question = height == width;
            return question;
        }
        public override string ToString ()
        {
            
            return "Rectangle's height: " + height +
            ", \nwidth: " + width +
            ", \narea: " + ComputeArea() +
            ", \nperimeter: " + ComputePerimeter() + "."+
            "\nIs it a square? Answer: " + IsSquare();



        }
    }

}

