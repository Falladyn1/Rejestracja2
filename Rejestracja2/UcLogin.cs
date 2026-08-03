using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Rejestracja2
{
    public partial class UcLogin : UserControl
    {
        private Point loginButtonLocation;
        private Point registerButtonLocation;
        private Point registerLabelLocation;

        public UcLogin()
        {
            InitializeComponent();

            loginButtonLocation = btnLogin.Location;
            registerButtonLocation = btnRegister.Location;
            registerLabelLocation = labelRegister.Location;

            ShowLoginMode();
        }

        public bool IsLoggedIn { get; private set; } = false;

        public event EventHandler? LoginSucceeded;

        public bool TryLogin()
        {
            if (IsEmpty(textBoxLogin, textBoxPasswd))
            {
                ShowLoginError("Wypełnij wszystkie pola");
                return false;
            }

            string username = textBoxLogin.Text;
            string password = textBoxPasswd.Text;

            List<User> users = UserDatabase.LoadUsers();

            foreach (User user in users)
            {
                if (user.Username == username &&
                    user.Password == password)
                {
                    MessageBox.Show("Zalogowano pomyślnie");

                    IsLoggedIn = true;
                    return true;
                }
            }

            ShowLoginError("Błędny login lub hasło");
            ClearLoginFields();

            IsLoggedIn = false;
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (TryLogin())
            {
                LoginSucceeded?.Invoke(this, EventArgs.Empty);
            }
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            ShowRegisterMode();
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

            ShowLoginMode();
        }

        // Widoki

        private void ShowLoginMode()
        {
            labelRegister.Visible = true;
            btnLogin.Visible = true;

            label4.Visible = false;
            textBoxPasswd2.Visible = false;
            btnRegister.Visible = false;

            labelWrong.Visible = false;
            labelWrong2.Visible = false;

            btnLogin.Location = loginButtonLocation;
            btnRegister.Location = registerButtonLocation;
            labelRegister.Location = registerLabelLocation;

            ClearRegisterFields();
        }

        private void ShowRegisterMode()
        {
            labelRegister.Visible = false;
            btnLogin.Visible = false;

            labelWrong.Visible = false;
            labelWrong2.Visible = false;

            label4.Visible = true;
            textBoxPasswd2.Visible = true;
            btnRegister.Visible = true;

            btnRegister.Location = registerButtonLocation;

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
                    loginButtonLocation.X,
                    loginButtonLocation.Y + 40);

                labelRegister.Location = new Point(
                    registerLabelLocation.X,
                    registerLabelLocation.Y + 40);
            }

            labelWrong.Text = message;
        }

        private void ShowRegisterError(string message)
        {
            if (!labelWrong2.Visible)
            {
                labelWrong2.Visible = true;

                btnRegister.Location = new Point(
                    registerButtonLocation.X,
                    registerButtonLocation.Y + 40);
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