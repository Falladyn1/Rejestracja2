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
    public partial class UcDashboard : UserControl
    {
        public UcDashboard()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = System.DateTime.Now.ToString("dd.MM.yyyy\nHH:mm:ss");
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            Panel parentPanel = (Panel)this.Parent;

            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();

                UcNewPatient newPatientPanel = new UcNewPatient();

                newPatientPanel.Dock = DockStyle.Fill;

                parentPanel.Controls.Add(newPatientPanel);
            }
        }
    }
}
