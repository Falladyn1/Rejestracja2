namespace Rejestracja2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserDatabase.LoadUsers();
            UcLogin loginPanel = new UcLogin();
            loginPanel.Dock = DockStyle.Fill;
            panelMain.Controls.Add(loginPanel);
        }
        

    }
}
