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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblPass = new Label();
            labelUser = new Label();
            textBox3 = new TextBox();
            lblRepPass = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblTituloRegister
            // 
            lblTituloRegister.AutoSize = true;
            lblTituloRegister.Font = new Font("Segoe UI", 20F);
            lblTituloRegister.Location = new Point(311, 22);
            lblTituloRegister.Name = "lblTituloRegister";
            lblTituloRegister.Size = new Size(171, 46);
            lblTituloRegister.TabIndex = 1;
            lblTituloRegister.Text = "REGISTRO";
            lblTituloRegister.Click += labelTitulo_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(226, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 30);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(199, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 30);
            textBox1.TabIndex = 7;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 11F);
            lblPass.Location = new Point(107, 202);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(117, 25);
            lblPass.TabIndex = 6;
            lblPass.Text = "Contraseña: ";
            lblPass.Click += labelPassword_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 11F);
            labelUser.Location = new Point(107, 130);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(86, 25);
            labelUser.TabIndex = 5;
            labelUser.Text = "Usuario: ";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10F);
            textBox3.Location = new Point(289, 278);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 30);
            textBox3.TabIndex = 10;
            //textBox3.TextChanged += this.textBox3_TextChanged;
            // 
            // lblRepPass
            // 
            lblRepPass.AutoSize = true;
            lblRepPass.Font = new Font("Segoe UI", 11F);
            lblRepPass.Location = new Point(107, 279);
            lblRepPass.Name = "lblRepPass";
            lblRepPass.Size = new Size(176, 25);
            lblRepPass.TabIndex = 9;
            lblRepPass.Text = "Repetir Contraseña:";
            //lblRepPass.Click += this.label1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(548, 375);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            // 
            // formRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(textBox3);
            Controls.Add(lblRepPass);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblPass);
            Controls.Add(labelUser);
            Controls.Add(lblTituloRegister);
            Name = "formRegister";
            Text = "REGISTRO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloRegister;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblPass;
        private Label labelUser;
        private TextBox textBox3;
        private Label lblRepPass;
        private Button btnGuardar;
    }
}