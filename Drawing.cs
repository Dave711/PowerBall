using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms; 


namespace WinFormsApp1
{
    class Drawing
    {
        public Ball Ball1 { get; set; }
        public Ball Ball2 { get; set; }
        public Ball Ball3 { get; set; }
        public Ball Ball4 { get; set; }
        public Ball Ball5 { get; set; }
        public Ball PowerBall { get; set; }
        public int Multiplier { get; set; }


        public Drawing()
        {
            this.Ball1 = new Ball();
            this.Ball2 = new Ball();
            this.Ball3 = new Ball();
            this.Ball4 = new Ball();
            this.Ball5 = new Ball();
            this.PowerBall = new Ball();
            this.Multiplier = 0;
        }

        public Drawing(Ball ball1, Ball ball2, Ball ball3, Ball ball4, Ball ball5, Ball powerball, int multiplier)
        {
            this.Ball1 = ball1;
            this.Ball2 = ball2;
            this.Ball3 = ball3;
            this.Ball4 = ball4;
            this.Ball5 = ball5;
            this.PowerBall = powerball;
            this.Multiplier = multiplier;
        }

        public bool ContainsBall(int number)
        {
            if (Ball1.Number == number || 
                Ball2.Number == number || 
                Ball3.Number == number || 
                Ball4.Number == number || 
                Ball5.Number == number) { return true; }
            else { return false; }
        }

        public bool ContainsPowerBall(int number)
        {
            if (PowerBall.Number == number ||
                PowerBall.Number == number ||
                PowerBall.Number == number ||
                PowerBall.Number == number ||
                PowerBall.Number == number) { return true; }
            else { return false; }
        }


        public void displayVals()
        {
            MessageBox.Show("drawing class ball values b1: " + this.Ball1.Number.ToString() +
                " b2: " + this.Ball2.Number.ToString() + 
                " b3: " + this.Ball3.Number.ToString() + 
                " b4: " + this.Ball4.Number.ToString() + 
                " b5: " + this.Ball5.Number.ToString() + 
                " Pow: " + this.PowerBall.Number.ToString() + 
                " Mult: " + this.Multiplier.ToString());
        }

    }
}
