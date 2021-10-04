using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private PowerBall pb = new PowerBall();


        public Form1()
        {
            InitializeComponent();
        }

        //function to loads all data into the powerball object
        private void LoadListboxesintoPowerballClass()
        {

            Ball b1 = new Ball(0);
            Ball b2 = new Ball(0);
            Ball b3 = new Ball(0);
            Ball b4 = new Ball(0);
            Ball b5 = new Ball(0);
            Ball power = new Ball(0);

            Drawing dr = new Drawing(b1,b2,b3,b4,b5,power,0);

            for (int i = 0; i < lstBalls.Items.Count; i++)
            {
                string[] strNumbers = lstBalls.Items[i].ToString().Split(' ');

                b1.Number = int.Parse(strNumbers[0]);
                b2.Number = int.Parse(strNumbers[2]);
                b3.Number = int.Parse(strNumbers[4]);
                b4.Number = int.Parse(strNumbers[6]);
                b5.Number = int.Parse(strNumbers[8]);
                power.Number = int.Parse(lstPowerball.Items[i].ToString());
                dr.Multiplier = int.Parse(lstMultiplier.Items[i].ToString());
                
                dr.Ball1 = b1;
                dr.Ball2 = b2;
                dr.Ball3 = b3;
                dr.Ball4 = b4;
                dr.Ball5 = b5;

                pb.AddDrawing(dr);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
         
            //Is good. loads powerball game date into the master class.
            LoadListboxesintoPowerballClass();





            //May need be removed soon--------------------
            int[] intMultipliers = { 0,0,0,0,0};

            foreach (string i in lstMultiplier.Items)
            {

                if (i.ToString() == "2")
                {
                    intMultipliers[0]++; 
                }
                else if (i.ToString() == "3")
                {
                    intMultipliers[1]++;
                }
                else if (i.ToString() == "4")
                {
                    intMultipliers[2]++;
                }
                else if (i.ToString() == "5")
                {
                    intMultipliers[3]++;
                }
                else if (i.ToString() == "10")
                {
                    intMultipliers[4]++;
                }
            }
            //---------------------------------------



            //Displays howmany drawings theres been
            lblTotalDrawings.Text = "Total drawings count: " + pb.DrawingsCount().ToString();



            //show multipliers 
            lblComMult1.Text = "2X Multiplier count is:  " + intMultipliers[0].ToString();
            lblComMult2.Text = "3X Multiplier count is:  " + intMultipliers[1].ToString();
            lblComMult3.Text = "4X Multiplier count is:  " + intMultipliers[2].ToString();
            lblComMult4.Text = "5X Multiplier count is:  " + intMultipliers[3].ToString();
            lblComMult5.Text = "10X Multiplier count is:  " + intMultipliers[4].ToString();



            //Function to append text to the txtOutput textbox with linefeed at the end of each line. 
           void SendToOutputBox(string strString)
            {
                txtOutput.Text = txtOutput.Text + strString + "\r\n";
            }

            //Ball info outputs
            SendToOutputBox("===========BALL INFO=========================");

            SendToOutputBox("Balls that have been drawn 10 times are " + pb.GetBallsByDrawsCount(10));
            SendToOutputBox("Balls that have been drawn 9 are times " + pb.GetBallsByDrawsCount(9));
            SendToOutputBox("Balls that have been drawn 8 are times " + pb.GetBallsByDrawsCount(8));
            SendToOutputBox("Balls that have been drawn 7 are times " + pb.GetBallsByDrawsCount(7));
            SendToOutputBox("Balls that have been drawn 6 are times " + pb.GetBallsByDrawsCount(6));
            SendToOutputBox("Balls that have been drawn 5 are times " + pb.GetBallsByDrawsCount(5));
            SendToOutputBox("Balls that have been drawn 4 are times " + pb.GetBallsByDrawsCount(4));
            SendToOutputBox("Balls that have been drawn 3 are times " + pb.GetBallsByDrawsCount(3));
            SendToOutputBox("Balls that have been drawn 2 are times " + pb.GetBallsByDrawsCount(2));
            SendToOutputBox("Balls that have been drawn 1 are times " + pb.GetBallsByDrawsCount(1));
            SendToOutputBox("Ball or balls that never been drawn are " + pb.GetBallsByDrawsCount(0));

            //Powertball info outputs
            SendToOutputBox("===========POWERBALL INFO====================");
            SendToOutputBox("Powerballs that have been drawn 4 are times " + pb.GetPowerballsByDrawsCount(4));
            SendToOutputBox("Powerballs that have been drawn 3 are times " + pb.GetPowerballsByDrawsCount(3));
            SendToOutputBox("Powerballs that have been drawn 2 are times " + pb.GetPowerballsByDrawsCount(2));
            SendToOutputBox("Powerballs that have been drawn 1 are times " + pb.GetPowerballsByDrawsCount(1));
            SendToOutputBox("PowerBalls that have never been drawn are " + pb.GetPowerballsByDrawsCount(0));





            //currently working on
            //MessageBox.Show(pb.MostCommonPickedBalls());





        }




        //Working on-------------------------------

        //Gets a string of balls from the drawings list
        private string getDrawing(int intDrawing)
        {
            string[] strNumbers = lstBalls.Items[intDrawing-1].ToString().Split(' ');
            return strNumbers[0] + strNumbers[1] + strNumbers[2] + strNumbers[3] + strNumbers[4] + strNumbers[5] + strNumbers[6] + strNumbers[7] + strNumbers[8];
        }

        //Gets a spacific ball from a drawing (ball 1-5)
        private int getBall(string strDrawing, int intBall)
        {
            string[] strBalls = strDrawing.Split('-');
            return int.Parse(strBalls[intBall-1]);
        }
        //------------------------------







        private void button1_Click(object sender, EventArgs e)
        {
            int intTimes = int.Parse(txtBallDrawed.Text);
            MessageBox.Show(pb.NumberOfTimesBallHasBeenDrawn(intTimes).ToString());
        }
    }
}
