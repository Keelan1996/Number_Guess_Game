using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DuddyKeelanGuessGame
{
    public partial class MainPage : ContentPage
    {
        int _iNumGo = 7;
        const int NUMBER_GO = 7;


        public MainPage()
        {
            InitializeComponent();
            lblNumGo.Text = "You have " + _iNumGo.ToString() + " Goes left";

        }

        private void BtnGuess_Clicked(object sender, EventArgs e)
        {
            float fGuessNumber;

            fGuessNumber = (float)Convert.ToInt32(EntryNumber.Text);

            Random rnd = new Random();
            int month = rnd.Next(1, 10);

            
          
            if (_iNumGo == 0)
            {
                LblGuessValue.Text = "GAME OVER";
                return;

            }
            else if (_iNumGo < 0)
            {
                _iNumGo = NUMBER_GO;
            }


            _iNumGo--; // decrement by 1
            lblNumGo.Text = "You have " + _iNumGo.ToString() + " goes left";


            if (fGuessNumber < month)
            {
                LblGuessValue.Text = "Guess was: " + fGuessNumber.ToString("TOO LOW!");
            }
            else if (fGuessNumber > month)
            {
                LblGuessValue.Text = "Guess was: " + fGuessNumber.ToString("TOO HIGH");
            }
            else if (fGuessNumber == month)
            {

                LblGuessValue.Text = "Guess was: " + fGuessNumber.ToString("CORRECT!");
            }


        }
    }
}