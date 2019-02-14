using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class EndScreen : UserControl
    {
        public EndScreen()
        {
            InitializeComponent();
            OriginalLabel.Text = "Unsorted Guesses:\n~~~~~~~~~~~~~";
            SortedLabel.Text = "Sorted Guesses: \n~~~~~~~~~~~~~";
            for (int i = 0; i < Form1.Guesses.Count(); i++)
            {
                OriginalLabel.Text += "\n" + Form1.Guesses[i];
            }

            Form1.Guesses.Sort();
            for (int i = 0; i < Form1.Guesses.Count(); i++)
            {
                SortedLabel.Text += "\n" + Form1.Guesses[i];
            }

            guessLabel.Text = "Number of Guesses: " + Form1.Guesses.Count();
        }
    }
}
