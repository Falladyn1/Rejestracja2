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

            loginPanel.LoginSucceeded += LoginPanel_LoginSucceeded;


        }

        private void LoginPanel_LoginSucceeded(object? sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UcDashboard ucDashboard = new UcDashboard();
            panelMain.Controls.Add(ucDashboard);
            
        }
    }
}
