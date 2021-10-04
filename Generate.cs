using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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



        private Drawing GeneratedDrawing()
        {

            Drawing d = new Drawing();

            d.Ball1.Number = rnd.Next(1, 69);
            d.Ball2.Number = rnd.Next(1, 69);
            d.Ball3.Number = rnd.Next(1, 69);
            d.Ball4.Number = rnd.Next(1, 69);
            d.Ball5.Number = rnd.Next(1, 69);
            d.PowerBall.Number = rnd.Next(1, 69);

            return d;
        }





        private void button1_Click(object sender, EventArgs e)
        { 

            //Balls
            lblB1.Text = rnd.Next(1, 69).ToString();
            lblB2.Text = rnd.Next(1, 69).ToString();
            lblB3.Text = rnd.Next(1, 69).ToString();
            lblB4.Text = rnd.Next(1, 69).ToString();
            lblB5.Text = rnd.Next(1, 69).ToString();

            //Powerball
            lblP.Text = rnd.Next(1, 26).ToString();

        }

    }
}
