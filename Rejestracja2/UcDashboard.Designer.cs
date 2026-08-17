namespace Rejestracja2
{
    partial class UcDashboard
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
            components = new System.ComponentModel.Container();
            btnNewVisit = new Button();
            btnNewPatient = new Button();
            panelPatientNum = new Panel();
            labelNumOfPatients = new Label();
            label2 = new Label();
            panelNewPatients = new Panel();
            labelNumOfNewPatients = new Label();
            label1 = new Label();
            labelTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            dataGridView1 = new DataGridView();
            panelPatientNum.SuspendLayout();
            panelNewPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNewVisit
            // 
            btnNewVisit.BackColor = Color.FromArgb(46, 204, 113);
            btnNewVisit.FlatAppearance.BorderSize = 0;
            btnNewVisit.FlatStyle = FlatStyle.Flat;
            btnNewVisit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNewVisit.ForeColor = Color.White;
            btnNewVisit.Location = new Point(692, 578);
            btnNewVisit.Name = "btnNewVisit";
            btnNewVisit.Size = new Size(156, 58);
            btnNewVisit.TabIndex = 0;
            btnNewVisit.Text = "Umów wizytę";
            btnNewVisit.UseVisualStyleBackColor = false;
            // 
            // btnNewPatient
            // 
            btnNewPatient.BackColor = Color.FromArgb(241, 196, 15);
            btnNewPatient.FlatAppearance.BorderSize = 0;
            btnNewPatient.FlatStyle = FlatStyle.Flat;
            btnNewPatient.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNewPatient.ForeColor = Color.White;
            btnNewPatient.Location = new Point(854, 578);
            btnNewPatient.Name = "btnNewPatient";
            btnNewPatient.Size = new Size(156, 58);
            btnNewPatient.TabIndex = 1;
            btnNewPatient.Text = "Nowy Pacjent";
            btnNewPatient.UseVisualStyleBackColor = false;
            // 
            // panelPatientNum
            // 
            panelPatientNum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelPatientNum.AutoSize = true;
            panelPatientNum.BackColor = Color.FromArgb(46, 204, 113);
            panelPatientNum.Controls.Add(labelNumOfPatients);
            panelPatientNum.Controls.Add(label2);
            panelPatientNum.Location = new Point(615, 18);
            panelPatientNum.Name = "panelPatientNum";
            panelPatientNum.Size = new Size(233, 185);
            panelPatientNum.TabIndex = 10;
            // 
            // labelNumOfPatients
            // 
            labelNumOfPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNumOfPatients.AutoSize = true;
            labelNumOfPatients.Font = new Font("Segoe UI", 24F);
            labelNumOfPatients.ForeColor = Color.White;
            labelNumOfPatients.Location = new Point(94, 72);
            labelNumOfPatients.Name = "labelNumOfPatients";
            labelNumOfPatients.Size = new Size(45, 54);
            labelNumOfPatients.TabIndex = 2;
            labelNumOfPatients.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(165, 28);
            label2.TabIndex = 1;
            label2.Text = "Liczba wizyt dziś:";
            // 
            // panelNewPatients
            // 
            panelNewPatients.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelNewPatients.AutoSize = true;
            panelNewPatients.BackColor = Color.FromArgb(241, 196, 15);
            panelNewPatients.Controls.Add(labelNumOfNewPatients);
            panelNewPatients.Controls.Add(label1);
            panelNewPatients.Location = new Point(854, 18);
            panelNewPatients.Name = "panelNewPatients";
            panelNewPatients.Size = new Size(233, 185);
            panelNewPatients.TabIndex = 9;
            // 
            // labelNumOfNewPatients
            // 
            labelNumOfNewPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNumOfNewPatients.AutoSize = true;
            labelNumOfNewPatients.Font = new Font("Segoe UI", 24F);
            labelNumOfNewPatients.ForeColor = Color.White;
            labelNumOfNewPatients.Location = new Point(97, 72);
            labelNumOfNewPatients.Name = "labelNumOfNewPatients";
            labelNumOfNewPatients.Size = new Size(45, 54);
            labelNumOfNewPatients.TabIndex = 3;
            labelNumOfNewPatients.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 1;
            label1.Text = "Nowi pacjenci:";
            // 
            // labelTime
            // 
            labelTime.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelTime.Location = new Point(18, 23);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(352, 133);
            labelTime.TabIndex = 11;
            labelTime.Text = "time";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(583, 427);
            dataGridView1.TabIndex = 12;
            // 
            // UcDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(labelTime);
            Controls.Add(panelPatientNum);
            Controls.Add(panelNewPatients);
            Controls.Add(btnNewPatient);
            Controls.Add(btnNewVisit);
            Name = "UcDashboard";
            Size = new Size(1107, 667);
            panelPatientNum.ResumeLayout(false);
            panelPatientNum.PerformLayout();
            panelNewPatients.ResumeLayout(false);
            panelNewPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewVisit;
        private Button btnNewPatient;
        private Panel panelPatientNum;
        private Label labelNumOfPatients;
        private Label label2;
        private Panel panelNewPatients;
        private Label labelNumOfNewPatients;
        private Label label1;
        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dataGridView1;
    }
}
