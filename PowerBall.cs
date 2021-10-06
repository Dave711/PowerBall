using System.Collections.Generic;

namespace WinFormsApp1
{
    class PowerBall
    {
        //Main list for drawings
        private List<Drawing> lstDrawings = new List<Drawing>();


        //Drawings functions
        public void AddDrawing(Drawing drawing)
        {
            Ball b1 = new Ball(drawing.Ball1.Number);
            Ball b2 = new Ball(drawing.Ball2.Number);
            Ball b3 = new Ball(drawing.Ball3.Number);
            Ball b4 = new Ball(drawing.Ball4.Number);
            Ball b5 = new Ball(drawing.Ball5.Number);
            Ball pwr = new Ball(drawing.PowerBall.Number);
            int mult = drawing.Multiplier;

            Drawing dr = new Drawing();

            dr.Ball1 = b1;
            dr.Ball2 = b2;
            dr.Ball3 = b3;
            dr.Ball4 = b4;
            dr.Ball5 = b5;
            dr.PowerBall = pwr;
            dr.Multiplier = mult;

            lstDrawings.Add(dr);
        }//Adds a drawing to the list

        public int DrawingsCount()
        {
            return lstDrawings.Count;
        }//Returnms the total number of drawings in the list

        public Drawing GetDrawing(int index)
        {
            return lstDrawings[index];
        }//Returns a drawing from the list selected by index


        //For game balls
        public int NumberOfTimesBallHasBeenDrawn(int ballnumber)
        {
            int intTimes = 0;

            foreach (Drawing d in lstDrawings)
            {
                if (d.ContainsBall(ballnumber))
                { intTimes++; }
            }

            return intTimes;
        } //Returns howmany times a spacific ball has shown up in all the drawings.  Enter 0 to get the balls that have never been drawn.

        public string GetBallsByDrawsCount(int draws)
        {
            string strBalls = "";

            for (int i = 1; i < 69; i++)
            {
                if (this.NumberOfTimesBallHasBeenDrawn(i) == draws)
                {
                    if (strBalls != "")
                    {
                        strBalls = strBalls + ", " + i.ToString();
                    }
                    else
                    {
                        strBalls = i.ToString();
                    }
                }
            }

            return strBalls;
        }//Returns balls that have been drawn an x number of times.



        //For powerballs
        public int NumberOfTimesPowerballHasBeenDrawn(int ballnumber)
        {
            int intTimes = 0;

            foreach (Drawing d in lstDrawings)
            {
                if (d.ContainsPowerBall(ballnumber))
                { intTimes++; }
            }

            return intTimes;
        } //Returns howmany times a spacific Powerball has shown up in all the drawings..  Enter 0 to get the powerballs that have never been drawn

        public string GetPowerballsByDrawsCount(int draws)
        {
            string strBalls = "";

            for (int i = 1; i < 26; i++)
            {
                if (this.NumberOfTimesPowerballHasBeenDrawn(i) == draws)
                {
                    if (strBalls != "")
                    {
                        strBalls = strBalls + ", " + i.ToString();
                    }
                    else
                    {
                        strBalls = i.ToString();
                    }
                }
            }

            return strBalls;
        }









        //Needs Work
        public string MostCommonPickedBalls()
        {

            int intHighestCount = 0;
            string strBalls = "";
            for (int i = 1; i < 69; i++)
            {
                if (intHighestCount < this.NumberOfTimesBallHasBeenDrawn(i))
                {
                    intHighestCount++;
                }
            }

            for (int i = 1; i < 69; i++)
            {
                if (this.NumberOfTimesBallHasBeenDrawn(i) == intHighestCount)
                {
                    if (strBalls != "")
                    {
                        strBalls = i.ToString();
                    }
                    else
                    {
                        strBalls = strBalls + ", " + i.ToString();
                    }

                }
            }

            return strBalls;
        }























        //Ball fib returns the number of diffrent ball come up places.  ie, 1st most common ball, 2nd most most common ball, and howmany diffent places there is.
        //private int BallFib()
        //{
        //    // int intHighestCount = 0;
        //    //string strBalls = "";

        //    int[] intBallsDrawCount = new int[69];

        //    for (int i = 1; i < 69; i++)
        //    {
        //        intBallsDrawCount[i] = this.NumberOfTimesBallHasBeenDrawn(i);
        //    }

        //    for (int i = 1; i < 69; i++)
        //    {
        //        for (int c =0, c <69; c++)
        //        {

        //            IF (intBallsDrawCount[i] == c){

        //            }
        //        }

        //    }

        //    return 0;
        //}

    }






}
