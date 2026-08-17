using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rejestracja2
{
    public partial class UcMainPanel : UserControl
    {
        public UcMainPanel()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelMainDashboard.Controls.Clear();
            UcDashboard mainPanel = new UcDashboard();
            mainPanel.Dock = DockStyle.Fill;
            panelMainDashboard.Controls.Add(mainPanel);
        }
    }
}
