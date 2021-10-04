
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBalls = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPowerball = new System.Windows.Forms.ListBox();
            this.lstMultiplier = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalDrawings = new System.Windows.Forms.Label();
            this.lblPBall3 = new System.Windows.Forms.Label();
            this.lblPBall4 = new System.Windows.Forms.Label();
            this.lblPBall5 = new System.Windows.Forms.Label();
            this.lblPBallLast = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblComMult5 = new System.Windows.Forms.Label();
            this.lblComMult4 = new System.Windows.Forms.Label();
            this.lblComMult3 = new System.Windows.Forms.Label();
            this.lblComMult2 = new System.Windows.Forms.Label();
            this.lblComMult1 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtBallDrawed = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBalls
            // 
            this.lstBalls.FormattingEnabled = true;
            this.lstBalls.ItemHeight = 25;
            this.lstBalls.Items.AddRange(new object[] {
            "2 - 7 - 11 - 17 - 32",
            "21 - 22 - 39 - 44 - 60",
            "22 - 23 - 37 - 62 - 63",
            "20 - 40 - 47 - 55 - 63",
            "37 - 51 - 54 - 58 - 60",
            "5 - 36 - 39 - 45 - 57",
            "1 - 4 - 18 - 46 - 62",
            "37 - 40 - 50 - 61 - 63",
            "20 - 31 - 38 - 40 - 49",
            "9 - 22 - 41 - 47 - 61",
            "11 - 20 - 22 - 33 - 54",
            "32 - 35 - 40 - 52 - 54",
            "10 - 20 - 29 - 48 - 51",
            "3 - 15 - 45 - 51 - 61",
            "12 - 22 - 26 - 46 - 59",
            "27 - 39 - 54 - 56 - 59",
            "17 - 36 - 47 - 60 - 61",
            "16 - 28 - 36 - 39 - 59",
            "35 - 36 - 51 - 55 - 61",
            "6 - 21 - 49 - 65 - 67",
            "12 - 18 - 20 - 29 - 30",
            "7 - 24 - 36 - 54 - 60",
            "5 - 21 - 32 - 36 - 58",
            "1 - 21 - 22 - 34 - 47",
            "25 - 30 - 53 - 59 - 60",
            "1 - 4 - 11 - 59 - 67",
            "27 - 28 - 44 - 67 - 68",
            "15 - 22 - 38 - 54 - 66",
            "33 - 46 - 52 - 59 - 62",
            "1 - 5 - 29 - 54 - 62",
            "8 - 21 - 30 - 49 - 57",
            "26 - 40 - 41 - 55 - 65",
            "24 - 29 - 50 - 65 - 66",
            "8 - 31 - 39 - 43 - 60",
            "13 - 20 - 40 - 51 - 63",
            "4 - 22 - 35 - 38 - 39",
            "19 - 29 - 34 - 44 - 50",
            "8 - 25 - 34 - 38 - 41",
            "19 - 28 - 46 - 50 - 54",
            "44 - 52 - 54 - 64 - 69",
            "6 - 7 - 11 - 66 - 67",
            "11 - 13 - 22 - 27 - 46",
            "2 - 8 - 21 - 34 - 62",
            "3 - 19 - 27 - 37 - 40",
            "11 - 13 - 55 - 56 - 69",
            "4 - 10 - 37 - 39 - 69",
            "1 - 19 - 20 - 38 - 54",
            "12 - 17 - 20 - 21 - 26",
            "16 - 23 - 28 - 40 - 63",
            "35 - 36 - 47 - 61 - 63",
            "16 - 18 - 35 - 39 - 53",
            "22 - 36 - 48 - 59 - 61",
            "21 - 25 - 32 - 63 - 67",
            "10 - 21 - 26 - 41 - 49",
            "13 - 30 - 33 - 45 - 61",
            "14 - 16 - 23 - 50 - 53",
            "27 - 35 - 39 - 51 - 66"});
            this.lstBalls.Location = new System.Drawing.Point(35, 59);
            this.lstBalls.Name = "lstBalls";
            this.lstBalls.Size = new System.Drawing.Size(238, 704);
            this.lstBalls.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drawings";
            // 
            // lstPowerball
            // 
            this.lstPowerball.FormattingEnabled = true;
            this.lstPowerball.ItemHeight = 25;
            this.lstPowerball.Items.AddRange(new object[] {
            "11",
            "12",
            "19",
            "5",
            "19",
            "11",
            "25",
            "21",
            "21",
            "21",
            "24",
            "1",
            "17",
            "8",
            "26",
            "24",
            "15",
            "4",
            "26",
            "18",
            "16",
            "23",
            "14",
            "4",
            "5",
            "10",
            "11",
            "3",
            "10",
            "3",
            "8",
            "24",
            "14",
            "17",
            "1",
            "20",
            "25",
            "10",
            "9",
            "26",
            "19",
            "20",
            "16",
            "8",
            "4",
            "24",
            "17",
            "8",
            "1",
            "3",
            "21",
            "22",
            "6",
            "25",
            "14",
            "3",
            "16"});
            this.lstPowerball.Location = new System.Drawing.Point(299, 59);
            this.lstPowerball.Name = "lstPowerball";
            this.lstPowerball.Size = new System.Drawing.Size(110, 704);
            this.lstPowerball.TabIndex = 2;
            // 
            // lstMultiplier
            // 
            this.lstMultiplier.FormattingEnabled = true;
            this.lstMultiplier.ItemHeight = 25;
            this.lstMultiplier.Items.AddRange(new object[] {
            "3",
            "2",
            "3",
            "3",
            "2",
            "2",
            "3",
            "3",
            "2",
            "2",
            "2",
            "5",
            "2",
            "2",
            "2",
            "3",
            "3",
            "2",
            "2",
            "2",
            "3",
            "2",
            "2",
            "2",
            "3",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "4",
            "3",
            "3",
            "2",
            "2",
            "3",
            "2",
            "3",
            "3",
            "2",
            "2",
            "2",
            "2",
            "3",
            "2",
            "3",
            "2",
            "3",
            "3",
            "3",
            "2",
            "2",
            "2",
            "3",
            "5"});
            this.lstMultiplier.Location = new System.Drawing.Point(440, 59);
            this.lstMultiplier.Name = "lstMultiplier";
            this.lstMultiplier.Size = new System.Drawing.Size(81, 704);
            this.lstMultiplier.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Powerball";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Multiplier";
            // 
            // lblTotalDrawings
            // 
            this.lblTotalDrawings.AutoSize = true;
            this.lblTotalDrawings.Location = new System.Drawing.Point(595, 110);
            this.lblTotalDrawings.Name = "lblTotalDrawings";
            this.lblTotalDrawings.Size = new System.Drawing.Size(180, 25);
            this.lblTotalDrawings.TabIndex = 6;
            this.lblTotalDrawings.Text = "Total drawings count:";
            // 
            // lblPBall3
            // 
            this.lblPBall3.AutoSize = true;
            this.lblPBall3.Location = new System.Drawing.Point(677, 368);
            this.lblPBall3.Name = "lblPBall3";
            this.lblPBall3.Size = new System.Drawing.Size(0, 25);
            this.lblPBall3.TabIndex = 14;
            // 
            // lblPBall4
            // 
            this.lblPBall4.AutoSize = true;
            this.lblPBall4.Location = new System.Drawing.Point(677, 413);
            this.lblPBall4.Name = "lblPBall4";
            this.lblPBall4.Size = new System.Drawing.Size(0, 25);
            this.lblPBall4.TabIndex = 15;
            // 
            // lblPBall5
            // 
            this.lblPBall5.AutoSize = true;
            this.lblPBall5.Location = new System.Drawing.Point(677, 448);
            this.lblPBall5.Name = "lblPBall5";
            this.lblPBall5.Size = new System.Drawing.Size(0, 25);
            this.lblPBall5.TabIndex = 16;
            // 
            // lblPBallLast
            // 
            this.lblPBallLast.AutoSize = true;
            this.lblPBallLast.Location = new System.Drawing.Point(677, 507);
            this.lblPBallLast.Name = "lblPBallLast";
            this.lblPBallLast.Size = new System.Drawing.Size(0, 25);
            this.lblPBallLast.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblComMult5);
            this.groupBox1.Controls.Add(this.lblComMult4);
            this.groupBox1.Controls.Add(this.lblComMult3);
            this.groupBox1.Controls.Add(this.lblComMult2);
            this.groupBox1.Controls.Add(this.lblComMult1);
            this.groupBox1.Location = new System.Drawing.Point(1152, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 223);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multipliers";
            // 
            // lblComMult5
            // 
            this.lblComMult5.AutoSize = true;
            this.lblComMult5.Location = new System.Drawing.Point(23, 174);
            this.lblComMult5.Name = "lblComMult5";
            this.lblComMult5.Size = new System.Drawing.Size(193, 25);
            this.lblComMult5.TabIndex = 16;
            this.lblComMult5.Text = "10X multiplier count is:";
            // 
            // lblComMult4
            // 
            this.lblComMult4.AutoSize = true;
            this.lblComMult4.Location = new System.Drawing.Point(23, 136);
            this.lblComMult4.Name = "lblComMult4";
            this.lblComMult4.Size = new System.Drawing.Size(183, 25);
            this.lblComMult4.TabIndex = 15;
            this.lblComMult4.Text = "5X multiplier count is:";
            // 
            // lblComMult3
            // 
            this.lblComMult3.AutoSize = true;
            this.lblComMult3.Location = new System.Drawing.Point(23, 99);
            this.lblComMult3.Name = "lblComMult3";
            this.lblComMult3.Size = new System.Drawing.Size(183, 25);
            this.lblComMult3.TabIndex = 14;
            this.lblComMult3.Text = "4X multiplier count is:";
            // 
            // lblComMult2
            // 
            this.lblComMult2.AutoSize = true;
            this.lblComMult2.Location = new System.Drawing.Point(23, 65);
            this.lblComMult2.Name = "lblComMult2";
            this.lblComMult2.Size = new System.Drawing.Size(183, 25);
            this.lblComMult2.TabIndex = 13;
            this.lblComMult2.Text = "3X multiplier count is:";
            // 
            // lblComMult1
            // 
            this.lblComMult1.AutoSize = true;
            this.lblComMult1.Location = new System.Drawing.Point(23, 30);
            this.lblComMult1.Name = "lblComMult1";
            this.lblComMult1.Size = new System.Drawing.Size(183, 25);
            this.lblComMult1.TabIndex = 12;
            this.lblComMult1.Text = "2X multiplier count is:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(542, 368);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(897, 379);
            this.txtOutput.TabIndex = 17;
            // 
            // txtBallDrawed
            // 
            this.txtBallDrawed.Location = new System.Drawing.Point(1046, 138);
            this.txtBallDrawed.Name = "txtBallDrawed";
            this.txtBallDrawed.Size = new System.Drawing.Size(58, 31);
            this.txtBallDrawed.TabIndex = 23;
            this.txtBallDrawed.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1018, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 72);
            this.button1.TabIndex = 24;
            this.button1.Text = "Times Ball drawed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 798);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBallDrawed);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPBallLast);
            this.Controls.Add(this.lblPBall5);
            this.Controls.Add(this.lblPBall4);
            this.Controls.Add(this.lblPBall3);
            this.Controls.Add(this.lblTotalDrawings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstMultiplier);
            this.Controls.Add(this.lstPowerball);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBalls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBalls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPowerball;
        private System.Windows.Forms.ListBox lstMultiplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalDrawings;
        private System.Windows.Forms.Label lblPBall3;
        private System.Windows.Forms.Label lblPBall4;
        private System.Windows.Forms.Label lblPBall5;
        private System.Windows.Forms.Label lblPBallLast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblComMult5;
        private System.Windows.Forms.Label lblComMult4;
        private System.Windows.Forms.Label lblComMult3;
        private System.Windows.Forms.Label lblComMult2;
        private System.Windows.Forms.Label lblComMult1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtBallDrawed;
        private System.Windows.Forms.Button button1;
    }
}

