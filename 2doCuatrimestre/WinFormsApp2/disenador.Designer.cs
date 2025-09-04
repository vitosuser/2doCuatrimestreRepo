namespace WinFormsApp2
{
    partial class disenador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitulo = new Label();
            labelUser = new Label();
            labelPassword = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            labelNoCuenta = new Label();
            btnRegister = new Button();
            btnLogIn = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 20F);
            labelTitulo.Location = new Point(326, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(231, 37);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "INICIO DE SESION";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 13F);
            labelUser.Location = new Point(191, 145);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(81, 25);
            labelUser.TabIndex = 1;
            labelUser.Text = "Usuario: ";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 13F);
            labelPassword.Location = new Point(172, 273);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(110, 25);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Contraseña: ";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 10F);
            txtUser.Location = new Point(288, 146);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(304, 25);
            txtUser.TabIndex = 3;
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 10F);
            txtPass.Location = new Point(292, 273);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(304, 25);
            txtPass.TabIndex = 4;
            // 
            // labelNoCuenta
            // 
            labelNoCuenta.AutoSize = true;
            labelNoCuenta.Font = new Font("Segoe UI", 10F);
            labelNoCuenta.Location = new Point(288, 455);
            labelNoCuenta.Name = "labelNoCuenta";
            labelNoCuenta.Size = new Size(139, 19);
            labelNoCuenta.TabIndex = 5;
            labelNoCuenta.Text = "No tiene una cuenta?";
            // 
            // btnRegister
            // 
            btnRegister.ForeColor = SystemColors.HotTrack;
            btnRegister.Location = new Point(482, 447);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(137, 33);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Registrece aqui";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(396, 357);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(111, 34);
            btnLogIn.TabIndex = 7;
            btnLogIn.Text = "Iniciar sesion";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // disenador
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(900, 518);
            Controls.Add(btnLogIn);
            Controls.Add(btnRegister);
            Controls.Add(labelNoCuenta);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(labelPassword);
            Controls.Add(labelUser);
            Controls.Add(labelTitulo);
            Font = new Font("Segoe UI", 10F);
            Name = "disenador";
            Text = "ACCESO A SISTEMA";
            Load += disenador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelUser;
        private Label labelPassword;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label labelNoCuenta;
        private Button btnRegister;
        private Button btnLogIn;
    }
}
