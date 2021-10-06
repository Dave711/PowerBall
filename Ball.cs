using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Ball
    { 
        public int Number { get; set; }

        public Ball()
        {
            this.Number = 0;
        }

        public Ball(int number)
        {
            this.Number = number;
        }
    }
}
