using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Rejestracja2
{
    public partial class UcLogin : UserControl
    {
        public UcLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsEmpty(textBoxLogin, textBoxPasswd))
            {
                ShowLoginError("Wypełnij wszystkie pola");
                return;
            }


            string username = textBoxLogin.Text;
            string password = textBoxPasswd.Text;

            List<User> users = UserDatabase.LoadUsers();

            bool loginCorrect = false;


            foreach (User user in users)
            {
                if (user.Username == username &&
                    user.Password == password)
                {
                    loginCorrect = true;
                    break;
                }
            }


            if (loginCorrect)
            {
                MessageBox.Show("Zalogowano pomyślnie");

                // tutaj otwarcie MainForm
            }
            else
            {
                ShowLoginError("Błędny login lub hasło");
                ClearLoginFields();
            }
        }



        private void labelRegister_Click(object sender, EventArgs e)
        {
            labelRegister.Visible = false;
            btnLogin.Visible = false;

            labelWrong.Visible = false;

            label4.Visible = true;
            textBoxPasswd2.Visible = true;
            btnRegister.Visible = true;
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (IsEmpty(textBoxLogin, textBoxPasswd, textBoxPasswd2))
            {
                ShowRegisterError("Wypełnij wszystkie pola");
                return;
            }


            string username = textBoxLogin.Text;
            string password = textBoxPasswd.Text;
            string password2 = textBoxPasswd2.Text;


            if (password != password2)
            {
                ShowRegisterError("Hasła nie są takie same");
                ClearRegisterFields();
                return;
            }


            List<User> users = UserDatabase.LoadUsers();


            foreach (User user in users)
            {
                if (user.Username == username)
                {
                    ShowRegisterError("Użytkownik już istnieje");
                    ClearRegisterFields();
                    return;
                }
            }


            users.Add(new User(username, password));

            UserDatabase.SaveUsers(users);


            MessageBox.Show("Rejestracja zakończona pomyślnie.");

            ClearRegisterFields();
        }


        // Metody pomocnicze


        private bool IsEmpty(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }

            return false;
        }



        private void ShowLoginError(string message)
        {
            if (!labelWrong.Visible)
            {
                labelWrong.Visible = true;

                btnLogin.Location = new Point(
                    btnLogin.Location.X,
                    btnLogin.Location.Y + 40
                );

                labelRegister.Location = new Point(
                    labelRegister.Location.X,
                    labelRegister.Location.Y + 40
                );
            }

            labelWrong.Text = message;
        }



        private void ShowRegisterError(string message)
        {
            if (!labelWrong2.Visible)
            {
                labelWrong2.Visible = true;

                btnRegister.Location = new Point(
                    btnRegister.Location.X,
                    btnRegister.Location.Y + 40
                );
            }

            labelWrong2.Text = message;
        }



        private void ClearLoginFields()
        {
            textBoxLogin.Clear();
            textBoxPasswd.Clear();
        }



        private void ClearRegisterFields()
        {
            textBoxLogin.Clear();
            textBoxPasswd.Clear();
            textBoxPasswd2.Clear();
        }
    }
}