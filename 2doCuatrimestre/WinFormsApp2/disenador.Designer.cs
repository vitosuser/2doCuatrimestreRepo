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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelNoCuenta = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 20F);
            labelTitulo.Location = new Point(292, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(291, 46);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "INICIO DE SESION";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 13F);
            labelUser.Location = new Point(172, 143);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(97, 30);
            labelUser.TabIndex = 1;
            labelUser.Text = "Usuario: ";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 13F);
            labelPassword.Location = new Point(172, 273);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(133, 30);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Contraseña: ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(288, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 30);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(315, 273);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(304, 30);
            textBox2.TabIndex = 4;
            // 
            // labelNoCuenta
            // 
            labelNoCuenta.AutoSize = true;
            labelNoCuenta.Font = new Font("Segoe UI", 10F);
            labelNoCuenta.Location = new Point(288, 412);
            labelNoCuenta.Name = "labelNoCuenta";
            labelNoCuenta.Size = new Size(175, 23);
            labelNoCuenta.TabIndex = 5;
            labelNoCuenta.Text = "No tiene una cuenta?";
            // 
            // btnRegister
            // 
            btnRegister.ForeColor = SystemColors.HotTrack;
            btnRegister.Location = new Point(483, 409);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(137, 33);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Registrece aqui";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // disenador
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(900, 518);
            Controls.Add(btnRegister);
            Controls.Add(labelNoCuenta);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelPassword);
            Controls.Add(labelUser);
            Controls.Add(labelTitulo);
            Font = new Font("Segoe UI", 10F);
            Name = "disenador";
            Text = "ACCESO A SISTEMA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelUser;
        private Label labelPassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelNoCuenta;
        private Button btnRegister;
    }
}
