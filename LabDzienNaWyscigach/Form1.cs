using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabDzieńNaWyścigach
{
    public partial class Form1 : Form
    {
        Brownhound[] BrownhoundArray = new Brownhound[4];
        Guy[] GuyArray = new Guy[3];
        Random Randomizer = new Random();
        public Form1()
        {
            InitializeComponent();
            BrownhoundArray[0] = new Brownhound()
            {
                MyPictureBox = pictureDog1,
                StartingPosition = pictureDog1.Left,
                RacetrackLength = torWyscigowy.Width - pictureDog1.Width,
                MyRandom = Randomizer
            };

            BrownhoundArray[1] = new Brownhound()
            {
                MyPictureBox = pictureDog2,
                StartingPosition = pictureDog2.Left,
                RacetrackLength = torWyscigowy.Width - pictureDog2.Width,
                MyRandom = Randomizer
            };
            BrownhoundArray[2] = new Brownhound()
            {
                MyPictureBox = pictureDog3,
                StartingPosition = pictureDog3.Left,
                RacetrackLength = torWyscigowy.Width - pictureDog3.Width,
                MyRandom = Randomizer
            };
            BrownhoundArray[3] = new Brownhound()
            {
                MyPictureBox = pictureDog4,
                StartingPosition = pictureDog4.Left,
                RacetrackLength = torWyscigowy.Width - pictureDog4.Width,
                MyRandom = Randomizer
            };
            GuyArray[0] = new Guy()
            {
                Name = "Janek",
                Cash = 100,
                MyBet = null,
                MyRadioButton = janekButton,
                MyLabel = janekBetLabel              
                
            };
            GuyArray[1] = new Guy()
            {
                Name = "Bartek",
                Cash = 150,
                MyBet = null,
                MyRadioButton = bartekButton,
                MyLabel = bartekBetLabel
                
            };
            GuyArray[2] = new Guy()
            {
                Name = "Arek",
                Cash = 125,
                MyBet = null,
                MyRadioButton = arekButton,
                MyLabel = arekBetLabel
            };
            for(int i = 0; i < 3; i++)
            {
                GuyArray[i].ClearBet();
                GuyArray[i].UpdateLabels();
            }
            nameLabel.Text = "Janek";
            minimumBetLabel.Text = "Minimalna zakład: " + numericBetAmout.Minimum + " zł";
        }
        

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            for (int i = 0; i < 4; i++)
            {
                if (BrownhoundArray[i].Run())
                {
                    timer1.Stop();
                    int NumerPsa = i + 1;
                    MessageBox.Show("Chart numer " + NumerPsa + " zwycięrzył");

                    for (int k = 0; k < 4; k++)
                    {
                        BrownhoundArray[k].TakeStartingPosition();
                    }

                    for (int j = 0; j < 3; j++)
                    {
                        GuyArray[j].Collect(NumerPsa);
                        GuyArray[j].ClearBet();
                        GuyArray[j].UpdateLabels();
                    }
                    groupBox1.Enabled = true;                    
                }
            }            
        }

        private void janekButton_CheckedChanged(object sender, EventArgs e)
        {
            if (janekButton.Checked)
            {
                nameLabel.Text = "Janek";
            }
        }

        private void bartekButton_CheckedChanged(object sender, EventArgs e)
        {
            if(bartekButton.Checked)
            {
                nameLabel.Text = "Bartek";
            }
        }

        private void arekButton_CheckedChanged(object sender, EventArgs e)
        {
            if (arekButton.Checked)
            {
                nameLabel.Text = "Arek";
            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (janekButton.Checked)
                GuyArray[0].PlaceBet((int)numericBetAmout.Value, (int)numericDog.Value);
            if (bartekButton.Checked)
                GuyArray[1].PlaceBet((int)numericBetAmout.Value, (int)numericDog.Value);
            if (arekButton.Checked)
                GuyArray[2].PlaceBet((int)numericBetAmout.Value, (int)numericDog.Value);

            for(int i = 0; i < 3; i++)
            {
                GuyArray[i].UpdateLabels();
            }
        }
    }
}
