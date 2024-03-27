using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextModule;

namespace WindowsFormsApp_HW_6_Dynamically_Connected_Libraries
{
    public partial class Form_DLL_Task_2 : Form
    {
        public Form_DLL_Task_2()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            string text = inputTextBox.Text;

            // проверка на палиндром
            bool isPalindrome = TextModule.Text.IsPalindrome(text);
            palindromeLabel.Text = $"Palindrome: {isPalindrome}";

            // подсчет количества предложений
            int sentenceCount = TextModule.Text.CountSentences(text);
            sentencesLabel.Text = $"Number of sentences: {sentenceCount}";

            // переворот строки
            string reversedText = TextModule.Text.ReverseString(text);
            reversedLabel.Text = $"Reversed text: {reversedText}";
        }
    }
}
