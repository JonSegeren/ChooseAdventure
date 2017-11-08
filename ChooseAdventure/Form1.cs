/// created by :  jon and aturt
/// date       :  october 30th
/// description: A basic text adventure game engine

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
using System.Media;

namespace ChooseAdventure
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;
        int randomNumber;
        string winLose;

        // random number generator
        Random randGen = new Random();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            #region scene change M
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0)
                {

                    randomNumber = randGen.Next(1, 11);
                    if (randomNumber >= 2)
                    {
                        scene = 1;
                    }
                    else
                    {
                        scene = 2;
                    }
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 4)
                {
                    scene = 7;
                }
                else if (scene == 5)
                {
                    scene = 12;
                }
                else if (scene == 3)
                {
                    scene = 26;
                }
                else if (scene == 26)
                {
                    scene = 27;
                }
                else if (scene == 13)
                {
                    scene = 23;
                }
                else if (scene == 23)
                {
                    scene = 25;
                    
                }
                else if (scene == 3)
                {
                    scene = 26;
                }
                else if (scene == 26)
                {
                    scene = 27;
                }
                else if (scene == 14)
                {
                    scene = 18;
                }
                else if (scene == 18)
                {
                    scene = 20;
                }
                else if (scene == 20)
                {
                    scene = 21;
                }
                else if (scene == 15)
                {
                    scene = 17;
                }
                else if (scene == 30)
                {
                    scene = 0;
                }
                else if(scene==2)
                {
                    scene = 30;
                }
                else if (scene == 6)
                {
                    scene = 30;
                }
                else if (scene==7)
                {
                    scene = 30;
                }
                else if (scene == 8)
                {
                    scene = 30;
                }
                else if (scene == 10)
                {
                    scene = 30;
                }
                else if (scene == 11)
                {
                    scene = 0;
                }
                else if (scene == 12)
                {
                    scene = 30;
                }
                else if (scene == 16)
                {
                    scene = 30;
                }
                else if (scene == 17)
                {
                    scene = 30;
                }
                else if (scene == 19)
                {
                    scene = 30;
                }
                else if (scene == 21)
                {
                    scene = 30;
                }
                else if (scene == 22)
                {
                    scene = 30;
                }
                else if (scene == 24)
                {
                    scene = 30;
                }
                else if (scene == 25)
                {
                    scene = 3;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 30;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 31)
                {
                    scene = 30;
                }
            }
            #endregion

            #region B scenes
            if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                { scene = 13; }
                else if (scene == 13)
                {
                    scene = 14;
                }
                else if (scene == 14)
                {
                    scene = 15;
                }
                else if (scene == 15)
                {
                    scene = 16;
                }
                else if (scene == 18)
                {
                    scene = 19;
                }
                else if (scene == 20)
                {
                    scene = 22;
                }
                else if (scene == 23)
                {
                    scene = 24;
                }
                else if (scene == 3)
                {
                    scene = 31;
                }
                else if (scene == 26)
                {
                    scene = 29;
                }
                else if (scene == 1)
                {
                    scene = 5;
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
                else if (scene == 5)
                {
                    scene = 8;
                }
                else if (scene == 30)
                {
                    this.Close();
                }
            }

            #endregion


            #region space

            if (e.KeyCode == Keys.Space) //green button press
            {
                if (scene == 0)
                {
                    scene = 3;
                }
                else if (scene == 26)
                {
                    scene = 28;
                }
                else if (scene == 5)
                {
                    randomNumber = randGen.Next(1, 11);
                    if (randomNumber >= 7)
                    {
                        scene = 11;

                    }
                    else
                    {
                        scene = 10;
                    }
                }
            }

            #endregion
            /// Display text and game options to screen based on the current scene

            switch (scene) //every scene in the story
            {
                case 0:  //start scene  
                    sceneLabel.Text = "You are lost in a forest. Where do you go?";
                    redLabel.Text = "Mountians";
                    blueLabel.Text = "River";
                    spaceLabel.Text = "Forest";
                    SoundPlayer forest = new SoundPlayer(Properties.Resources.Forest);
                    forest.Play();
                    break;
                case 1:
                    sceneLabel.Text = "You encounter a secret hideout. Do you enter?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    spaceLabel.Text=" ";

                    break;
                case 2:
                    sceneLabel.Text = "You froze to death in the mountians";
                    redLabel.Text="Continue";
                    blueLabel.Text = " ";
                    spaceLabel.Text = " "; 
                    winLose = "You Lose!";
                    break;
                case 3:
                    sceneLabel.Text = "It is getting dark. What do you do?";
                    redLabel.Text = "Look for a road";
                    blueLabel.Text = "Stay the night";
                    spaceLabel.Text = " ";
                    break;
                case 4:
                    sceneLabel.Text = "You encounter the remenants of the USSR";
                    sceneLabel.Text += "\n" + "Do you pledge allegiance?";
                    redLabel.Text = "Yes";
                   blueLabel.Text = "No";
                    spaceLabel.Text = " ";
                    break;
                case 5:
                    sceneLabel.Text = "You come across the town Blagoveshchensk ";
                    sceneLabel.Text += "\n" + "What do you do with your remaining money?";
                    redLabel.Text = "Spend it all on herring and throw it at unsuspecting victims";
                    blueLabel.Text = "Open a cheese shop";
                    spaceLabel.Text = " ";
                    spaceLabel.Text = "Buy a plance ticket";
                    break;
                case 6:
                    sceneLabel.Text = "You get shot by USSR agents";
                    redLabel.Text = "Continue ";
                    blueLabel.Text = " ";
                    spaceLabel.Text = " ";
                    winLose = "RIP, you lost.";
                    SoundPlayer russian = new SoundPlayer(Properties.Resources.Russian);
                    russian.Play();
                    break;
                case 7:
                    sceneLabel.Text = "The USSR leads you to Moscow where you live the rest of your ";
                    sceneLabel.Text += "\n" + "as a diplomat for the communist regime";
                    redLabel.Text = "Continue ";
                    blueLabel.Text = " ";
                    spaceLabel.Text = " ";
                    winLose = "Good job, comrade. ";
                    break;
                case 8:
                    sceneLabel.Text = "You live the rest of your life making ";
                    sceneLabel.Text += "\n" + "delicous artisan cheeses";
                    redLabel.Text = "Continue ";
                    blueLabel.Text = " ";
                    spaceLabel.Text = " ";
                    winLose = "You Win! ";
                    break;
                case 9:
                    sceneLabel.Text = "You encounter a secret hideout. Do you enter?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    spaceLabel.Text = " ";
                    break;
                case 10:
                    sceneLabel.Text = "You land safely in LAX airport and return home";
                    redLabel.Text = "Continue";
                    blueLabel.Text = " ";
                    spaceLabel.Text = " ";
                    winLose = "You Win!! ";
                    break;
                case 11:
                    sceneLabel.Text = "Your plane crashed";
                    redLabel.Text = "Continue";
                    blueLabel.Text = " ";
                    spaceLabel.Text = " ";
                    break;
                case 12:
                    sceneLabel.Text = "The police arrest you after 3 years of fish tossing";
                    redLabel.Text = "Continue ";
                    blueLabel.Text = " ";
                    spaceLabel.Text = " ";
                    winLose = "The fish man shall return. ";
                    break;
                case 13:
                    sceneLabel.Text = "You make it to the river. What do you do?";
                    redLabel.Text = "Try and cross";
                    blueLabel.Text = "Follow the river";
                    spaceLabel.Text = " ";
                    SoundPlayer brook = new SoundPlayer(Properties.Resources.Brook);
                    brook.Play();
                    break;
                case 14:
                    sceneLabel.Text = "You find a small log cabin. Do you Enter?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    spaceLabel.Text = " ";
                    break;
                case 15:
                    sceneLabel.Text = "You stepped in a bear trap. Your leg is stuck. Amputate?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    spaceLabel.Text = " ";
                    break;
                case 16:
                    sceneLabel.Text = "You stay stuck in the trap and die.";
                    redLabel.Text = "Continue";
                    blueLabel.Text = " ";
                    spaceLabel.Text = " ";
                    winLose = "You Lose. ";
                    break;
                case 17:
                    sceneLabel.Text = "You return to cvilization but are useless without a leg";
                    sceneLabel.Text += "\n" + "you live the rest of your life as a hermit";
                    winLose = "You Lose. ";
                    redLabel.Text = "Continue";
                    break;
                case 18:
                    sceneLabel.Text = "Inside you meet an ax murderer. Do you befriend him?";
                    redLabel.Text = "Sit and chat";
                    blueLabel.Text = "Try and kill him";
                    spaceLabel.Text = " ";
                    break;
                case 19:
                    sceneLabel.Text = "You kill the murderer and become a bloodthirsty killer. ironic.";
                    redLabel.Text = " Continue";
                    blueLabel.Text = " ";
                    spaceLabel.Text = " ";
                    break;
                case 20:
                    sceneLabel.Text = "After months of living together you two fall in love";
                    sceneLabel.Text += "\n" + "The murderer proposes. Do you accept?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    spaceLabel.Text = " ";
                    break;
                case 21:
                    sceneLabel.Text = "You live happilly ever after.";
                    redLabel.Text = "Continue ";
                    blueLabel.Text = " ";
                    spaceLabel.Text = " ";
                    winLose = "A happy ending. ";
                    break;
                case 22:
                    sceneLabel.Text = "In an upset rage you become the murderers next victim";
                    redLabel.Text = "Continue ";
                    blueLabel.Text = " ";
                    spaceLabel.Text = " ";
                    winLose = "RIP. ";
                    break;
                case 23:
                    sceneLabel.Text = "You see a massive fish. Kill it for food?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    spaceLabel.Text = " ";
                    break;
                case 24:
                    sceneLabel.Text = "Its eat or be eaten out here kiddo. The fish eats you";
                    redLabel.Text = "Continue ";
                    blueLabel.Text = " ";
                    spaceLabel.Text = " ";
                    winLose = "RIP";
                    break;
                case 25:
                    sceneLabel.Text = "You had a nice salmon dinner";
                    redLabel.Text = "Continue ";
                    blueLabel.Text = "";
                    spaceLabel.Text = " ";
                    break;
                case 26:
                    sceneLabel.Text = "You encounter a bear. What do you do?";
                    redLabel.Text = "Run away";
                    blueLabel.Text = "Give the bear a hug";
                    spaceLabel.Text = " ";
                    spaceLabel.Text = "Square up";
                    SoundPlayer bear = new SoundPlayer(Properties.Resources.Bear);
                    bear.Play();
                    break;
                case 27:
                    sceneLabel.Text = "You run into a bear den that had 3 more bears in it.";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    spaceLabel.Text = " ";
                    winLose = "Big L. ";
                    break;
                case 28:
                    sceneLabel.Text = "You challenge the bear to a dance off and you beat the bear.";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    spaceLabel.Text = " ";
                    winLose = "You Win. ";
                    break;
                case 29:
                    sceneLabel.Text = "You and the bear become best friends and livee the rest of your lives together";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    spaceLabel.Text = " ";
                    winLose = "You Win. ";
                    break;
                case 30:
                    sceneLabel.Text = winLose+"Would you like to play again?"; //end scene you win or lose
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    spaceLabel.Text = " ";
                    break;
                case 31:
                    sceneLabel.Text = "You slept, got a ton of mosquito bites and die of malaria.";
                    redLabel.Text = "Copntinue";
                    blueLabel.Text = "";
                    winLose = "You lose. ";
                    break;
            }
        }
    }
}
