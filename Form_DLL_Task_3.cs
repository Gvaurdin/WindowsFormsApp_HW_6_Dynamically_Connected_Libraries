using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactDataValidationLibrary;

namespace WindowsFormsApp_HW_6_Dynamically_Connected_Libraries
{
    public partial class Form_DLL_Task_3 : Form
    {
        public Form_DLL_Task_3()
        {
            InitializeComponent();
        }


        private void validateButton_Click_1(object sender, EventArgs e)
        {
            string fullName = fullNameTextBox.Text;
            string age = ageTextBox.Text;
            string phoneNumber = phoneTextBox.Text;
            string email = emailTextBox.Text;

            // проверка ФИО, возвраста, номера телефона, имейла
            bool isValidFullName = ContactDataValidator.IsValidFullName(fullName);
            fullNameLabel.Text = $"Full name is valid: {isValidFullName}";


            bool isValidAge = ContactDataValidator.IsValidAge(age);
            ageLabel.Text = $"Age is valid: {isValidAge}";

            bool isValidPhoneNumber = ContactDataValidator.IsValidPhoneNumber(phoneNumber);
            phoneLabel.Text = $"Phone number is valid: {isValidPhoneNumber}";

            bool isValidEmail = ContactDataValidator.IsValidEmail(email);
            emailLabel.Text = $"Email is valid: {isValidEmail}";
        }
    }
}
