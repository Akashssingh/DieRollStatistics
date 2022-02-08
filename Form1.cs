using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieRollAkashResubmission
{
    public partial class Form1 : Form
    {
        //the both die objects needed
        private aDie die1;
        private aDie die2;
        public Form1()
        {
            InitializeComponent();
            die1 = new aDie(Int16.Parse(seedText.Text));
            die2 = new aDie(Int16.Parse(seedText.Text));
        }

        /// <summary>
        /// This function resets all stat values of die 1
        /// </summary>
        public void resetDie1Stats()
        {
            die1MeanText.Text = "0";
            die1MinvalText.Text = "0";
            die1MinfaceText.Text = "-";
            die1MaxvalText.Text = "0";
            die1MaxfaceText.Text = "-";
        }

        /// <summary>
        /// This function resets all stat values of die 2
        /// </summary>
        public void resetDie2Stats()
        {
            die2MeanText.Text = "0";
            die2MinvalText.Text = "0";
            die2MinfaceText.Text = "-";
            die2MaxvalText.Text = "0";
            die2MaxfaceText.Text = "-";
        }

        //
        /// <summary>
        /// This function resets all stat values of sum of two dice
        /// Sot = Sum of Two
        /// </summary>
        public void resetSotStats()
        {
            sotMeanText.Text = "0";
            sotMinvalText.Text = "0";
            sotMinfaceText.Text = "-";
            sotMaxvalText.Text = "0";
            sotMaxfaceText.Text = "-";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The Roll button Functionality.
        /// resets all the stats first and then loads appropriate pictures from the imagelist based on Roll() function defined in aDie class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rollButton_Click(object sender, EventArgs e)
        {
            //Here before each roll we will have to reset all the stats so the dice can be rolled
            resetDie1Stats();
            resetDie2Stats();
            resetSotStats();

            die1Pic.Image = dieImageList.Images[die1.Roll() - 1]; //-1 since the random numbers are being generated from 1 - 7. So 0 to 5 since 7 is excluded so last element will be 5.
            die2Pic.Image = dieImageList.Images[die2.Roll() - 1]; // Similar reason as above
        }

        /// <summary>
        /// This is the statistics button functionality which produces histogram and also updates it.
        /// It then computes mean, min value, min face, max value and max face for each die and displays the stats.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statButton_Click(object sender, EventArgs e)
        {
            //We will reset the sum stats here
            resetDie1Stats();
            resetDie2Stats();
            resetSotStats();

            //We will check if the seed input is empty. If so then use default constructor
            if (String.IsNullOrEmpty(seedText.Text)) 
            {
                die1 = new aDie();
                die2 = new aDie();
            }
            else if (seedText.Equals("999"))
            {
                die1 = new aDie();
                die2 = new aDie();
            }
            else //Otherwise we will parse the value of given text and use the constructor with accept string
            {
                die1 = new aDie(Int16.Parse(seedText.Text));
                die2 = new aDie(Int16.Parse(seedText.Text));
            }

            //before moving forward we have to reset all other gui stuff
            foreach (var series in statHistogram.Series)
            {
                series.Points.Clear(); //This will clear all points and make a new plane to generate a new histogram
            }

            //This is where we hold the actual lists of outcomes. We are not using if-else or switch statements and all magic will happen using integer arrays
            //size of the array will be 6, 6 faces but indexed from 0 to 5
            int[] die1Rolls = new int[6];
            int[] die2Rolls = new int[6];

            //Now we will use the number of rolls from ComboBox
            int rollNumber = Int32.Parse(listBox.SelectedItem.ToString()); //Takes the string and convert it and parse
            int chartUpdateVal = 1;
            float sumdie1 = 0;
            float sumdie2 = 0;

            //Now for each roll we need to generate statistics. hence we will be using for loop to iterate through those rolls
            for (int i = 0; i < rollNumber; i++)
            {
                int dieFace1 = die1.Roll();
                int dieFace2 = die2.Roll();

                //We need the mean so calculate their sum
                sumdie1 += dieFace1;
                sumdie2 += dieFace2;

                //We need to display the histogram now and update it with each iteration
                statHistogram.Series["Die 1 Stats"].Points.AddXY(dieFace1, ++die1Rolls[dieFace1 - 1]);
                statHistogram.Series["Die 2 Stats"].Points.AddXY(dieFace2, ++die2Rolls[dieFace2 - 1]);

                //We need to update the histogram every 100th time or after each successful 10% display
                if (chartUpdateVal == (rollNumber * 0.1))
                {
                    statHistogram.Update();
                    chartUpdateVal = 0;
                }
                chartUpdateVal++; //Need it to be 1 again
            }

            //*********These are the display items for Die 1************

            //Check for die 1 mean
            float meanDie1 = sumdie1 / rollNumber;
            die1MeanText.Text = meanDie1.ToString();

            //check and set min Count
            int minDie1Val = die1Rolls.Min();
            die1MinvalText.Text = minDie1Val.ToString();

            //check and set min Face
            int minDie1face = die1Rolls.ToList().IndexOf(minDie1Val) + 1;
            die1MinfaceText.Text = minDie1face.ToString();

            //check and set max Count
            int maxDie1Val = die1Rolls.Max();
            die1MaxvalText.Text = maxDie1Val.ToString();

            //check and set max Face
            int maxDie1face = die1Rolls.ToList().IndexOf(maxDie1Val) + 1;
            die1MaxfaceText.Text = maxDie1face.ToString();



            //*********These are the display items for Die 2************

            //Check for die 2 mean
            float meanDie2 = sumdie2 / rollNumber;
            die2MeanText.Text = meanDie2.ToString();

            //check and set min Count
            int minDie2Val = die2Rolls.Min();
            die2MinvalText.Text = minDie2Val.ToString();

            //check and set min Face
            int minDie2face = die2Rolls.ToList().IndexOf(minDie2Val) + 1;
            die2MinfaceText.Text = minDie2face.ToString();

            //check and set max Count
            int maxDie2Val = die2Rolls.Max();
            die2MaxvalText.Text = maxDie2Val.ToString();

            //check and set max Face
            int maxDie2face = die2Rolls.ToList().IndexOf(maxDie2Val) + 1;
            die2MaxfaceText.Text = maxDie2face.ToString();
        }

        /// <summary>
        /// This button will reset everything
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            //set the seed as default value of 999.
            seedText.Text = "999";

            //All the stats need to be reset again
            resetDie1Stats();
            resetDie2Stats();
            resetSotStats();

            //We need to reset the histogram as well
            foreach (var currentSeries in statHistogram.Series)
            {
                currentSeries.Points.Clear();
            }

            //We have to reset the die as well. Default face is 1 in both dice
            die1Pic.Image = dieImageList.Images[0];
            die2Pic.Image = dieImageList.Images[0];
        }

        /// <summary>
        /// This functions displays the modified histogram and the values associated with the sum of the two dice. Similar to the stats we had 
        /// provided for the each die but now both die sum will be considered as a single unit and be treated as such.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sotButton_Click(object sender, EventArgs e)
        {
            //reset both dice before continuing
            resetDie1Stats();
            resetDie2Stats();
            resetSotStats();

            //We have to initialize the dice now. Similar to earlier when we had to determine if default or paramenter constructor be used
            if (String.IsNullOrEmpty(seedText.Text))
            {
                die1 = new aDie();
                die2 = new aDie();
            }
            else if (seedText.Equals("999"))
            {
                die1 = new aDie();
                die2 = new aDie();
            }
            else //Otherwise we will parse the value of given text and use the constructor with accept string
            {
                die1 = new aDie(Int16.Parse(seedText.Text));
                die2 = new aDie(Int16.Parse(seedText.Text));
            }

            //reset all chart attributes now

            foreach (var currSeries in statHistogram.Series)
            {
                currSeries.Points.Clear();
            }

            //Similar to Statistics button function implementation, we have to hold the rolls in arrays
            int[] die1Rolls = new int[6];
            int[] die2Rolls = new int[6];
            int[] combinedRolls = new int[12]; //for combination/total of the rolls

            //Similar to Statistics button function implementation, we get the number of rolls time from combobox
            float rollNumber = Int32.Parse(listBox.SelectedItem.ToString()); //Takes the string and convert it and parse
            int chartUpdateVal = 1;
            float totalSum = 0;
            float iterSum = 0;
            float sumdie1 = 0;
            float sumdie2 = 0;

            for (int i = 0; i < rollNumber; i++)
            {
                int dieFace1 = die1.Roll();
                int dieFace2 = die2.Roll();

                //We need the mean so calculate their sum, die 1 sum and die 2 sum for their individual stats
                //I am using the understanding that the SOTD chart will have one display but all stats must be calculated
                //irrespective of what button one use, either Statistics or Sum of 2 Dice. All stats will be presented. 
                //Except the statistics will have default values for sum of two dice until the Sum of two dice button is pressed.
                sumdie1 += dieFace1;
                sumdie2 += dieFace2;
                iterSum = dieFace1 + dieFace2;
                totalSum += iterSum;
                combinedRolls.Append((int)(iterSum - 1));

                //We need to display the histogram now and update it with each iteration
                ++die1Rolls[dieFace1 - 1];
                ++die2Rolls[dieFace2 - 1];
                statHistogram.Series["SOTD Stats"].Points.AddXY(iterSum, ++combinedRolls[(int)iterSum - 1]);

                //We need to update the histogram after each successful 10% display
                if (chartUpdateVal == (rollNumber * 0.1))
                {
                    statHistogram.Update();
                    chartUpdateVal = 0;
                }
                chartUpdateVal++; //Need it to be 1 again
            }

            //*********These are the display items for Die 1************

            //Check for die 1 mean
            float meanDie1 = sumdie1 / rollNumber;
            die1MeanText.Text = meanDie1.ToString();

            //check and set min Count
            int minDie1Val = die1Rolls.Min();
            die1MinvalText.Text = minDie1Val.ToString();

            //check and set min Face
            int minDie1face = die1Rolls.ToList().IndexOf(minDie1Val) + 1;
            die1MinfaceText.Text = minDie1face.ToString();

            //check and set max Count
            int maxDie1Val = die1Rolls.Max();
            die1MaxvalText.Text = maxDie1Val.ToString();

            //check and set max Face
            int maxDie1face = die1Rolls.ToList().IndexOf(maxDie1Val) + 1;
            die1MaxfaceText.Text = maxDie1face.ToString();



            //*********These are the display items for Die 2************

            //Check for die 2 mean
            float meanDie2 = sumdie2 / rollNumber;
            die2MeanText.Text = meanDie2.ToString();

            //check and set min Count
            int minDie2Val = die2Rolls.Min();
            die2MinvalText.Text = minDie2Val.ToString();

            //check and set min Face
            int minDie2face = die2Rolls.ToList().IndexOf(minDie2Val) + 1;
            die2MinfaceText.Text = minDie2face.ToString();

            //check and set max Count
            int maxDie2Val = die2Rolls.Max();
            die2MaxvalText.Text = maxDie2Val.ToString();

            //check and set max Face
            int maxDie2face = die2Rolls.ToList().IndexOf(maxDie2Val) + 1;
            die2MaxfaceText.Text = maxDie2face.ToString();

            //*********These are the display items for Combined Stat SOT************

            //Check for die 2 mean
            float meanSot = totalSum / rollNumber;
            sotMeanText.Text = meanSot.ToString();

            //check and set min Count
            int minSotVal = combinedRolls.Min();
            sotMinvalText.Text = minSotVal.ToString();

            //check and set min Face
            int minSotCface = combinedRolls.ToList().IndexOf(minSotVal) + 1;
            sotMinfaceText.Text = minSotCface.ToString();

            //check and set max Count
            int maxSotVal = combinedRolls.Max();
            sotMaxvalText.Text = maxSotVal.ToString();

            //check and set max Face
            int maxSotCface = combinedRolls.ToList().IndexOf(maxSotVal) + 1;
            sotMaxfaceText.Text = maxSotCface.ToString();
        }
    }
}
