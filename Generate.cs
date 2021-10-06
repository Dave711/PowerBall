using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Generate : Form
    {

        Random rnd = new Random();

        public Generate()
        {
            InitializeComponent();
        }


        //sloppy
        public int[] BallsToExcludeArray()
        {
            int[] BallstoExclude = new int [64];

            string txt = txtExclude.Text;

            string [] strInts = new string[64];

            strInts = txt.Split(',');

            
            for (int i = 0; i < strInts.Length; i++)
            {
                BallstoExclude[i] = int.Parse(strInts[i]);
            }

            return BallstoExclude;

        }

        //sloppy
        public int[] PBallsToExcludeArray()
        {
            int[] PBallstoExclude = new int[26];

            string txt = txtExcludePowerBall.Text;

            string[] strInts = new string[26];

            strInts = txt.Split(',');


            for (int i = 0; i < strInts.Length; i++)
            {
                PBallstoExclude[i] = int.Parse(strInts[i]);
            }

            return PBallstoExclude;

        }



        private Drawing GenerateDrawing()
        {

            Drawing d = new Drawing();

            d.Ball1.Number = rnd.Next(1, 69);
            d.Ball2.Number = rnd.Next(1, 69);
            d.Ball3.Number = rnd.Next(1, 69);
            d.Ball4.Number = rnd.Next(1, 69);
            d.Ball5.Number = rnd.Next(1, 69);
            d.PowerBall.Number = rnd.Next(1, 26);

            return d;
        }





        private void button1_Click(object sender, EventArgs e)
        {

            Drawing d = new Drawing();

            int[] BallsToExclude = BallsToExcludeArray();

            bool blnContainsABall = true;

            //this needs improvements
            do
            {

                d = GenerateDrawing();

                for (int i = 0; i < BallsToExclude.Length; i++)
                {
                    if (d.ContainsBall(BallsToExclude[i]))
                    {
                        d = GenerateDrawing();
                        blnContainsABall = true;
                        i = 0;
                    }
                    else
                    {
                        blnContainsABall = false;
                    }
                }
            } while (blnContainsABall == true);


            //Sloppy code here remove it latter on and use a diffrent method excluding powerballs
            d.PowerBall.Number = CheckPowerballfoExcluding(d.PowerBall.Number);


            //Balls
            lblB1.Text = d.Ball1.Number.ToString();
            lblB2.Text = d.Ball2.Number.ToString();
            lblB3.Text = d.Ball3.Number.ToString();
            lblB4.Text = d.Ball4.Number.ToString();
            lblB5.Text = d.Ball5.Number.ToString();


            //Powerball
            lblP.Text = d.PowerBall.Number.ToString(); ;


        }







        /// for cheking the pball needs some romoving at some point
        private int CheckPowerballfoExcluding(int intPbal)
        {
            int[] BallsToExclude = PBallsToExcludeArray();

            bool blnContainsABall = true;

            int intNewP = intPbal;

          

            do
            {


                for (int i = 0; i < BallsToExclude.Length; i++)
                {
                   // MessageBox.Show("current pball" + intPbal +"  ----"+ intNewP+ "---     match " + BallsToExclude[i].ToString());
                     
                    if (intPbal == BallsToExclude[i])
                    {
                        
                        intNewP = rnd.Next(1, 26);
                        blnContainsABall = true;
                        i = 0;
                    }
                    else
                    {
                        blnContainsABall = false;
                    }
                }
            } while (blnContainsABall == true);

            return intNewP;

        }


        private void Generate_Load(object sender, EventArgs e)
        {

        }

        private void txtExcludePowerBall_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
