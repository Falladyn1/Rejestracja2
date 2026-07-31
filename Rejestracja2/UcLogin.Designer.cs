namespace Rejestracja2
{
    partial class UcLogin
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
            label2 = new Label();
            textBoxLogin = new TextBox();
            label3 = new Label();
            textBoxPasswd = new TextBox();
            btnLogin = new Button();
            labelRegister = new Label();
            labelWrong = new Label();
            textBoxPasswd2 = new TextBox();
            label4 = new Label();
            btnRegister = new Button();
            labelWrong2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(510, 136);
            label1.Name = "label1";
            label1.Size = new Size(263, 54);
            label1.TabIndex = 0;
            label1.Text = "LOGOWANIE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(510, 211);
            label2.Name = "label2";
            label2.Size = new Size(72, 31);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = SystemColors.Menu;
            textBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogin.Location = new Point(510, 245);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(263, 27);
            textBoxLogin.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(510, 283);
            label3.Name = "label3";
            label3.Size = new Size(74, 31);
            label3.TabIndex = 3;
            label3.Text = "Hasło";
            // 
            // textBoxPasswd
            // 
            textBoxPasswd.BackColor = SystemColors.Menu;
            textBoxPasswd.BorderStyle = BorderStyle.FixedSingle;
            textBoxPasswd.Location = new Point(510, 317);
            textBoxPasswd.Name = "textBoxPasswd";
            textBoxPasswd.Size = new Size(263, 27);
            textBoxPasswd.TabIndex = 4;
            textBoxPasswd.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Cyan;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(659, 350);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 33);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Zaloguj";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Cursor = Cursors.Hand;
            labelRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 238);
            labelRegister.ForeColor = SystemColors.MenuHighlight;
            labelRegister.Location = new Point(510, 386);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(159, 23);
            labelRegister.TabIndex = 6;
            labelRegister.Text = "Utwórz nowe konto";
            labelRegister.Click += labelRegister_Click;
            // 
            // labelWrong
            // 
            labelWrong.AutoSize = true;
            labelWrong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelWrong.ForeColor = Color.Brown;
            labelWrong.Location = new Point(548, 354);
            labelWrong.Name = "labelWrong";
            labelWrong.Size = new Size(188, 23);
            labelWrong.TabIndex = 7;
            labelWrong.Text = "Błędny login lub hasło";
            labelWrong.Visible = false;
            // 
            // textBoxPasswd2
            // 
            textBoxPasswd2.BackColor = SystemColors.Menu;
            textBoxPasswd2.BorderStyle = BorderStyle.FixedSingle;
            textBoxPasswd2.Location = new Point(510, 389);
            textBoxPasswd2.Name = "textBoxPasswd2";
            textBoxPasswd2.Size = new Size(263, 27);
            textBoxPasswd2.TabIndex = 8;
            textBoxPasswd2.UseSystemPasswordChar = true;
            textBoxPasswd2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(510, 355);
            label4.Name = "label4";
            label4.Size = new Size(161, 31);
            label4.TabIndex = 9;
            label4.Text = "Powtórz hasło";
            label4.Visible = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Cyan;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(659, 422);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(114, 33);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Zarejestruj";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Visible = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // labelWrong2
            // 
            labelWrong2.AutoSize = true;
            labelWrong2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelWrong2.ForeColor = Color.Brown;
            labelWrong2.Location = new Point(548, 426);
            labelWrong2.Name = "labelWrong2";
            labelWrong2.Size = new Size(188, 23);
            labelWrong2.TabIndex = 11;
            labelWrong2.Text = "Błędny login lub hasło";
            labelWrong2.Visible = false;
            // 
            // UcLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelWrong2);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(textBoxPasswd2);
            Controls.Add(labelWrong);
            Controls.Add(labelRegister);
            Controls.Add(btnLogin);
            Controls.Add(textBoxPasswd);
            Controls.Add(label3);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UcLogin";
            Size = new Size(1262, 673);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxLogin;
        private Label label3;
        private TextBox textBoxPasswd;
        private Button btnLogin;
        private Label labelRegister;
        private Label labelWrong;
        private TextBox textBoxPasswd2;
        private Label label4;
        private Button btnRegister;
        private Label labelWrong2;
    }
}
