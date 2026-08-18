namespace Rejestracja2
{
    partial class UcNewPatient
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label6 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnNewPatient = new Button();
            ucCalendar1 = new UcCalendar();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(241, 196, 15);
            label1.Location = new Point(28, 37);
            label1.Name = "label1";
            label1.Size = new Size(282, 54);
            label1.TabIndex = 0;
            label1.Text = "Nowy Pacjent";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(28, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 388);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane osobowe";
            // 
            // textBox3
            // 
            textBox3.AllowDrop = true;
            textBox3.Location = new Point(6, 289);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 60);
            textBox3.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(6, 261);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 10;
            label6.Text = "Adres";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(6, 222);
            maskedTextBox2.Mask = "000-000-000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(168, 27);
            maskedTextBox2.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(6, 152);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(168, 27);
            maskedTextBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(6, 194);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 7;
            label5.Text = "Telefon";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 27);
            textBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(6, 129);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 4;
            label4.Text = "PESEL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(6, 76);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 3;
            label3.Text = "Nazwisko";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 2;
            label2.Text = "Imię";
            // 
            // btnNewPatient
            // 
            btnNewPatient.BackColor = Color.FromArgb(241, 196, 15);
            btnNewPatient.FlatAppearance.BorderSize = 0;
            btnNewPatient.FlatStyle = FlatStyle.Flat;
            btnNewPatient.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNewPatient.ForeColor = Color.White;
            btnNewPatient.Location = new Point(922, 578);
            btnNewPatient.Name = "btnNewPatient";
            btnNewPatient.Size = new Size(156, 58);
            btnNewPatient.TabIndex = 2;
            btnNewPatient.Text = "Nowy Pacjent";
            btnNewPatient.UseVisualStyleBackColor = false;
            // 
            // ucCalendar1
            // 
            ucCalendar1.Location = new Point(290, 111);
            ucCalendar1.Name = "ucCalendar1";
            ucCalendar1.Size = new Size(742, 409);
            ucCalendar1.TabIndex = 3;
            // 
            // UserNewPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucCalendar1);
            Controls.Add(btnNewPatient);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "UserNewPatient";
            Size = new Size(1100, 665);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private Label label6;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private TextBox textBox2;
        private Button btnNewPatient;
        private UcCalendar ucCalendar1;
    }
}
