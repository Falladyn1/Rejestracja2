namespace Rejestracja2
{
    partial class UcMainPanel
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            button1 = new Button();
            btnDashboard = new Button();
            panelMainDashboard = new Panel();
            label1 = new Label();
            panelMenu.SuspendLayout();
            panelMainDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(33, 43, 54);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(146, 673);
            panelMenu.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 78);
            button1.Name = "button1";
            button1.Size = new Size(146, 60);
            button1.TabIndex = 1;
            button1.Text = "Lista Pacjentów";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 12);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(146, 60);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Panel Główny";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelMainDashboard
            // 
            panelMainDashboard.Controls.Add(label1);
            panelMainDashboard.Location = new Point(152, 3);
            panelMainDashboard.Name = "panelMainDashboard";
            panelMainDashboard.Size = new Size(1107, 667);
            panelMainDashboard.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(346, 284);
            label1.Name = "label1";
            label1.Size = new Size(428, 41);
            label1.TabIndex = 0;
            label1.Text = "System Rezerwacji Pacjentów";
            // 
            // UcMainPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMainDashboard);
            Controls.Add(panelMenu);
            Name = "UcMainPanel";
            Size = new Size(1262, 673);
            panelMenu.ResumeLayout(false);
            panelMainDashboard.ResumeLayout(false);
            panelMainDashboard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelMainDashboard;
        private Button button1;
        private Button btnDashboard;
        private Label label1;
    }
}
