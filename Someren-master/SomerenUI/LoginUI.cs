using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();    
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {
            showPanel("LogIn");
        }

        private void showPanel(string panelName)
        {
            if (panelName == "LogIn")
            {
                pnlUserRegister.Hide();
                pnlLogIn.Show();

            }
            else if(panelName == "RegisterUser")
            {
                pnlLogIn.Hide();
                pnlUserRegister.Show();
            }
        }

        private void RegisterUserButton_Click(object sender, EventArgs e)
        {
            if (registerSecondPassTextBox.Text != registerFirstPassTextBox.Text)
            {
                registerPasswEnteredWarningLabel.Show();
            }
            else
            {
                registerPasswEnteredWarningLabel.Hide();
            }

            if (registerFirstPassTextBox.Text == registerSecondPassTextBox.Text && registerFirstPassTextBox.Text != string.Empty &&
                registerAwnserTextBox.Text != string.Empty && registerQuestionTextBox.Text != string.Empty)
            {
                licenseKeyGroupBox.Show();
            }
            else
            {
                registerEnterAllFieldsWarningLabel.Show();
            }
        }

        private void FinalAddUserButton_Click(object sender, EventArgs e)
        {
            string licenseKey = "XsZAb - tgz3PsD - qYh69un - WQCEx";

            UserService userService = new UserService();
            if (compareLicenseTextBox.Text == licenseKey)
            {
                userService.CreateUser(registerUserNameTextBox.Text, registerFirstPassTextBox.Text,
                    registerQuestionTextBox.Text, registerAwnserTextBox.Text);
            }

            MessageBox.Show("Registration complete");
            showPanel("LogIn");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            List<User> users = userService.GetUsers();
            HashSalt hashSalt = new HashSalt();
            SomerenUI somerenUI = new SomerenUI();
           
            foreach (User user in users)
            {
                if (user.UserName == userNameTextBox.Text && user.Password == hashSalt.HashPassword(passwordTextBox.Text,
                    user.Salt, hashSalt.Iterations, hashSalt.Hash))
                {
                    LoginUI.ActiveForm.Hide();
                    somerenUI.Show();
                  
                    userNameTextBox.Clear();
                    passwordTextBox.Clear();
                }
                else
                {
                    wrongPassWarningLabel.Show();
                    ChangePassLinkLabel.Show();
                }
            }
        }

        private void ChangePassLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logInGroupBox.Hide();
            changePasswordGroupBox.Visible = true;
            changePasswordGroupBox.Show();
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showPanel("RegisterUser");
        }

        private void ChangePassBackToLogInButton_Click(object sender, EventArgs e)
        {
            changePasswordGroupBox.Hide();
            logInGroupBox.Show();
            wrongPassWarningLabel.Hide();
            ChangePassLinkLabel.Hide();
            changePassAllFieldsWarningLabel.Hide();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            List<User> users = userService.GetUsers();
            foreach (User user in users)
            {
                // if the username and anwser of the secret question are correct and all fields are correctly filled 
                // the password will be changed
                if (changePassSecondTextBox.Text != changePassFirstTextBox.Text)
                {
                    changePassNoMatchWarningLabel.Show();
                }
                else
                {
                    changePassNoMatchWarningLabel.Hide();
                }

                if (changePassUserNameTextBox.Text == user.UserName && secretAwnserTextBox.Text == user.SecretAwnser
                    && changePassFirstTextBox.Text == changePassSecondTextBox.Text && changePassFirstTextBox.Text != string.Empty)
                {
                    userService.ChangePassword(changePassUserNameTextBox.Text, secretAwnserTextBox.Text, changePassFirstTextBox.Text);
                    MessageBox.Show("Your password has been changed.");
                    logInGroupBox.Show();
                    changePasswordGroupBox.Hide();
                    changePassAllFieldsWarningLabel.Hide();
                }
                else
                {
                    changePassAllFieldsWarningLabel.Show();
                }
            }
        }

        private void changePassUserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            List<User> users = userService.GetUsers();
            foreach (User user in users)
            {
                if (user.UserName == changePassUserNameTextBox.Text)
                {
                    secretQuestionLabel.Text = user.SecretQuestion;
                }
            }
        }

        private void ReturnToLogInButton_Click(object sender, EventArgs e)
        {
            showPanel("LogIn");
        }
    }
}
