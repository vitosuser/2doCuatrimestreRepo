namespace WinFormsApp1
{
    partial class FRMEJ1
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
            lbltitulo = new Label();
            lblresultado = new Label();
            lblnombre = new Label();
            lblapellido = new Label();
            textboxnombre = new TextBox();
            textBoxapellido = new TextBox();
            botonAdivinar = new Button();
            linkyt = new LinkLabel();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Location = new Point(48, 35);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(170, 20);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "PROGRAMA WINFORMS";
            lbltitulo.Click += label1_Click;
            // 
            // lblresultado
            // 
            lblresultado.Location = new Point(0, 0);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(100, 23);
            lblresultado.TabIndex = 0;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(48, 118);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(64, 20);
            lblnombre.TabIndex = 1;
            lblnombre.Text = "Nombre";
            lblnombre.Click += label1_Click_1;
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(48, 181);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(66, 20);
            lblapellido.TabIndex = 2;
            lblapellido.Text = "Apellido";
            lblapellido.Click += lblapellido_Click;
            // 
            // textboxnombre
            // 
            textboxnombre.Location = new Point(118, 118);
            textboxnombre.Name = "textboxnombre";
            textboxnombre.Size = new Size(234, 27);
            textboxnombre.TabIndex = 3;
            textboxnombre.TextChanged += textboxnombre_TextChanged;
            // 
            // textBoxapellido
            // 
            textBoxapellido.Location = new Point(120, 181);
            textBoxapellido.Name = "textBoxapellido";
            textBoxapellido.Size = new Size(234, 27);
            textBoxapellido.TabIndex = 4;
            textBoxapellido.TextChanged += textBoxapellido_TextChanged;
            // 
            // botonAdivinar
            // 
            botonAdivinar.Location = new Point(117, 268);
            botonAdivinar.Name = "botonAdivinar";
            botonAdivinar.Size = new Size(193, 29);
            botonAdivinar.TabIndex = 5;
            botonAdivinar.Text = "Adivinar nombre";
            botonAdivinar.UseVisualStyleBackColor = true;
            botonAdivinar.Click += button1_Click;
            // 
            // linkyt
            // 
            linkyt.AutoSize = true;
            linkyt.Location = new Point(805, 515);
            linkyt.Name = "linkyt";
            linkyt.Size = new Size(144, 20);
            linkyt.TabIndex = 6;
            linkyt.TabStop = true;
            linkyt.Text = "Mi canal de youtube";
            linkyt.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FRMEJ1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(421, 395);
            Controls.Add(lblresultado);
            Controls.Add(linkyt);
            Controls.Add(botonAdivinar);
            Controls.Add(textBoxapellido);
            Controls.Add(textboxnombre);
            Controls.Add(lblapellido);
            Controls.Add(lblnombre);
            Controls.Add(lbltitulo);
            Name = "FRMEJ1";
            Text = "Ejercicio 1 de escritorio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblresultado;
        private Label lbltitulo;
        private Label lblnombre;
        private Label lblapellido;
        private TextBox textboxnombre;
        private TextBox textBoxapellido;
        private Button botonAdivinar;
        private LinkLabel linkyt;
    }
}
