using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;





namespace Homework
{
    public partial class Form1 : Form
    {
        
        public Guy[] Guys = new Guy[3];
        public Greyhound[] Greyhounds = new Greyhound[4];
        public Guy focusingGuy;

        int WinNum;

        public Form1()
        {
            
            InitializeComponent();
            Guys[0] = 
                new Guy { Name = "Joe",
                          MyBet = new Bet(),
                          Cash = 50,
                          MyLabel = this.label2, 
                          MyRadioButton = this.radioButton1 };
            Guys[1] =
                new Guy
                {
                    Name = "Bob",
                    MyBet = new Bet(),
                    Cash = 50,
                    MyLabel = this.label3,
                    MyRadioButton = this.radioButton2
                };
            Guys[2] =
                new Guy
                {
                    Name = "UI",
                    MyBet = new Bet(),
                    Cash = 50,
                    MyLabel = this.label4,
                    MyRadioButton = this.radioButton3
                };

            Random temp = new Random();

            Greyhounds[0] = new Greyhound { StartingPosition = BackGround.Height / 4,
                                            RacetrackLength = BackGround.Width,
                                            pictureBox = Dogpicture1,
                                            Location = 1 ,
                                            Randomizer = temp
            };
            Greyhounds[1] = new Greyhound{  StartingPosition = BackGround.Height / 3,
                                            RacetrackLength = BackGround.Width,
                                            pictureBox = Dogpicture2,
                                            Location = 2,
                                            Randomizer = temp
            }; 
            Greyhounds[2] = new Greyhound{  StartingPosition = BackGround.Height / 2,
                                            RacetrackLength = BackGround.Width,
                                            pictureBox = Dogpicture3,
                                            Location = 3,
                                            Randomizer = temp
            };
            Greyhounds[3] = new Greyhound{  StartingPosition = BackGround.Height / 1,
                                            RacetrackLength = BackGround.Width,
                                            pictureBox = Dogpicture4,
                                            Location = 4,
                                            Randomizer = temp
            };


//            Greyhounds[0].Randomizer.Next(1, 5);

            label1.Text += ": 5 bucks";

            label7.Text = Guys[0].Name;
            focusingGuy = Guys[0];


            for (int i = 0; i < 3; ++i)
                Guys[i].ClearBet();

            radioButton1.Text = Guys[0].Name + " has " + Guys[0].Cash.ToString() + " bucks";
            radioButton2.Text = Guys[1].Name + " has " + Guys[1].Cash.ToString() + " bucks";
            radioButton3.Text = Guys[2].Name + " has " + Guys[2].Cash.ToString() + " bucks";


            BetButton.Enabled = false;
            BetButton.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private int PrintGuysInformation(Guy guy)
        {
            guy.MyRadioButton.Text = guy.Name + " has " + (guy.Cash).ToString() + " bucks";
            return 0;
        }
        private void asdf_Click(object sender, EventArgs e)
        {
            bool IsFinish = false;
            while(!IsFinish)
            {
                System.Threading.Thread.Sleep(10);
                for (int i = 0; i < 4; ++i)
                {
                    if (Greyhounds[i].Run())
                    {
                        IsFinish = true;
                        WinNum = i;
                        break;
                    } 
                    BackGround.Update();
                }
            }
            for (int i = 0; i < 3; ++i)
            {
                Guys[i].MyBet.PayOut(WinNum);
            }
            radioButton1.Text = Guys[0].Name + " has " + Guys[0].Cash.ToString() + " bucks";
            radioButton2.Text = Guys[1].Name + " has " + Guys[1].Cash.ToString() + " bucks";
            radioButton3.Text = Guys[2].Name + " has " + Guys[2].Cash.ToString() + " bucks";
            radioButton1.Update();
            radioButton2.Update();
            radioButton3.Update();
        }

        private void BettingUpdown(object sender, EventArgs e)
        {
            if ((int)BettingControl.Value > 5)
                BettingControl.Value = 5;
            if ((int)BettingControl.Value > 0)
                BetButton.Enabled = true;
            if ((int)BettingControl.Value == 0 || (int)DogUpDown.Value == 0)
                BetButton.Enabled = false;
        }

        private void DogUpDownButton(object sender, EventArgs e)
        {
            if ((int)DogUpDown.Value > 4)
                DogUpDown.Value = 4;
            if ((int)DogUpDown.Value > 0)
                BetButton.Enabled = true;
            if ((int)DogUpDown.Value == 0 || (int)BettingControl.Value == 0)
                BetButton.Enabled = false;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

      
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            focusingGuy = Guys[0];
            label7.Text = focusingGuy.Name;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            focusingGuy = Guys[1];
            label7.Text = focusingGuy.Name;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            focusingGuy = Guys[2];
            label7.Text = focusingGuy.Name;
        }


        private void BetButton_Click(object sender, EventArgs e)
        {
            focusingGuy.PlaceBet((int)BettingControl.Value , (int)DogUpDown.Value);
            PrintGuysInformation(focusingGuy);
        }
    }
}
