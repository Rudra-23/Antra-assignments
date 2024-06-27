using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    public class Ball
    {
        public int size { get; private set; }
        public Color color { get; private set; }
        private int throwCount { get; set; }


        public Ball(int size, Color color) {
            this.size = size;
            this.color = color;
            this.throwCount = 0;
        }
        
        public void Pop()
        {
            this.size = 0;
        }

        public void Throw() { 
            if(this.size != 0)
            {
                this.throwCount += 1;
            }
        }

        public int GetThrowCount()
        {
            return this.throwCount;
        }

        
    }
}
