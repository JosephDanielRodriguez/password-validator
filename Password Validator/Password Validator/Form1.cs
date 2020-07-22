using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Password Validator Program
// Written by Joseph Rodriguez

// This program takes roughly 2000 of the most common passwords
// from a list found on GitHub by danielmiessler 10k-most-common.txt
// It is currently only two thousand of them simply due to it being
// my first time doing something like this. It will be updated in the future
// with more robust password list choices. For now, I'm trying to keep it simple.

namespace Password_Validator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare variables

                string test;             // Holds each password in .txt file
                string pass;             // Get input and store in a variable
                StreamReader inputFile;  // Streamreader variable
                bool wasFound = false;   // Determines if password was found or not

                // Stores input into pass variable
                pass = passwordInput.Text;

                // Open the file
                inputFile = File.OpenText("1932passwordList.txt");

                while (!inputFile.EndOfStream)
                {
                    // Get a password and store it for testing
                    test = inputFile.ReadLine();

                    if (test == pass)
                    {
                        // wasFound is set to true
                        wasFound = true;

                        // Break the while loop
                        break;
                    }
                    else
                    {
                        // wasFound is set to false
                        wasFound = false;
                    }
                }

                // Close the file
                inputFile.Close();

                if (wasFound == true)
                {
                    // Prompts the user and states their password was found in the list
                    MessageBox.Show("Your password is subject to a brute force attack!");
                }
                else
                {
                    // Prompts the user and states their password was not found in the list
                    MessageBox.Show("Your password wasn't found. Good job!");
                }
            }
            catch (Exception ex)
            {
                // Display an error message
                MessageBox.Show(ex.Message);
            }
        }
    }
}
