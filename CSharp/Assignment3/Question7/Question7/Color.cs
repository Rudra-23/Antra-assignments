using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;
        public int Red {
            get {
                return red;
            }

            set { 
                red = value;
            }
        }

        public int Green
        {
            get
            {
                return green;
            }

            set
            {
                green = value;
            }
        }
        public int Blue
        {
            get
            {
                return blue;
            }

            set
            {
                blue = value;
            }
        }
        public int Alpha
        {
            get
            {
                return alpha;
            }

            set
            {
                alpha = value;
            }
        }

        public Color(int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

        public double GrayScale() { 
            double scale = (Red + Green + Blue) / 3.0;
            return scale;
        }
    }
}
