namespace prueba_inicio_sesion
{
    partial class formRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTituloRegister = new Label();
            txtPassReg1 = new TextBox();
            txtUserReg = new TextBox();
            lblPass = new Label();
            labelUser = new Label();
            txtPassReg2 = new TextBox();
            lblRepPass = new Label();
            btnGuardar = new Button();
            lblErrorReg = new Label();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lblTituloRegister
            // 
            lblTituloRegister.AutoSize = true;
            lblTituloRegister.Font = new Font("Segoe UI", 20F);
            lblTituloRegister.Location = new Point(272, 16);
            lblTituloRegister.Name = "lblTituloRegister";
            lblTituloRegister.Size = new Size(137, 37);
            lblTituloRegister.TabIndex = 1;
            lblTituloRegister.Text = "REGISTRO";
            lblTituloRegister.Click += labelTitulo_Click;
            // 
            // txtPassReg1
            // 
            txtPassReg1.Font = new Font("Segoe UI", 10F);
            txtPassReg1.Location = new Point(198, 151);
            txtPassReg1.Margin = new Padding(3, 2, 3, 2);
            txtPassReg1.Name = "txtPassReg1";
            txtPassReg1.PasswordChar = '*';
            txtPassReg1.Size = new Size(243, 25);
            txtPassReg1.TabIndex = 8;
            txtPassReg1.TextChanged += textBox2_TextChanged;
            // 
            // txtUserReg
            // 
            txtUserReg.Font = new Font("Segoe UI", 10F);
            txtUserReg.Location = new Point(174, 97);
            txtUserReg.Margin = new Padding(3, 2, 3, 2);
            txtUserReg.Name = "txtUserReg";
            txtUserReg.Size = new Size(266, 25);
            txtUserReg.TabIndex = 7;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 11F);
            lblPass.Location = new Point(94, 152);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(90, 20);
            lblPass.TabIndex = 6;
            lblPass.Text = "Contraseña: ";
            lblPass.Click += labelPassword_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 11F);
            labelUser.Location = new Point(94, 98);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(66, 20);
            labelUser.TabIndex = 5;
            labelUser.Text = "Usuario: ";
            // 
            // txtPassReg2
            // 
            txtPassReg2.Font = new Font("Segoe UI", 10F);
            txtPassReg2.Location = new Point(253, 208);
            txtPassReg2.Margin = new Padding(3, 2, 3, 2);
            txtPassReg2.Name = "txtPassReg2";
            txtPassReg2.PasswordChar = '*';
            txtPassReg2.Size = new Size(243, 25);
            txtPassReg2.TabIndex = 10;
            // 
            // lblRepPass
            // 
            lblRepPass.AutoSize = true;
            lblRepPass.Font = new Font("Segoe UI", 11F);
            lblRepPass.Location = new Point(94, 209);
            lblRepPass.Name = "lblRepPass";
            lblRepPass.Size = new Size(138, 20);
            lblRepPass.TabIndex = 9;
            lblRepPass.Text = "Repetir Contraseña:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(480, 281);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            btnGuardar.Enter += button1_Click;
            // 
            // lblErrorReg
            // 
            lblErrorReg.AutoSize = true;
            lblErrorReg.Font = new Font("Segoe UI", 11F);
            lblErrorReg.ForeColor = Color.Red;
            lblErrorReg.Location = new Point(97, 256);
            lblErrorReg.Name = "lblErrorReg";
            lblErrorReg.Size = new Size(0, 20);
            lblErrorReg.TabIndex = 12;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(591, 281);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(82, 22);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += button1_Click_1;
            // 
            // formRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(700, 338);
            Controls.Add(btnCerrar);
            Controls.Add(lblErrorReg);
            Controls.Add(btnGuardar);
            Controls.Add(txtPassReg2);
            Controls.Add(lblRepPass);
            Controls.Add(txtPassReg1);
            Controls.Add(txtUserReg);
            Controls.Add(lblPass);
            Controls.Add(labelUser);
            Controls.Add(lblTituloRegister);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formRegister";
            Text = "REGISTRO";
            Load += formRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloRegister;
        private TextBox txtPassReg1;
        private TextBox txtUserReg;
        private Label lblPass;
        private Label labelUser;
        private TextBox txtPassReg2;
        private Label lblRepPass;
        private Button btnGuardar;
        private Label lblErrorReg;
        private Button btnCerrar;
    }
}