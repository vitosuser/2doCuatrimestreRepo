namespace TPEstructurasDinamicasParte2.ListasEnlazadas.Ejercicio2
{
    partial class FormEj2ListasEnlazadas
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
            listMostrar = new ListBox();
            btnOk = new Button();
            lblSeleccione = new Label();
            gboxAccion = new GroupBox();
            rdioRehacer = new RadioButton();
            rdioDeshacer = new RadioButton();
            rdioEscribir = new RadioButton();
            txtTexto = new TextBox();
            lblTexto = new Label();
            lblTitulo = new Label();
            btnSalir = new Button();
            gboxAccion.SuspendLayout();
            SuspendLayout();
            // 
            // listMostrar
            // 
            listMostrar.FormattingEnabled = true;
            listMostrar.ItemHeight = 15;
            listMostrar.Location = new Point(109, 252);
            listMostrar.Name = "listMostrar";
            listMostrar.Size = new Size(303, 169);
            listMostrar.TabIndex = 43;
            // 
            // btnOk
            // 
            btnOk.Enabled = false;
            btnOk.Font = new Font("Segoe UI", 10F);
            btnOk.Location = new Point(533, 172);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(82, 36);
            btnOk.TabIndex = 41;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Visible = false;
            btnOk.Click += btnOk_Click;
            // 
            // lblSeleccione
            // 
            lblSeleccione.AutoSize = true;
            lblSeleccione.Font = new Font("Segoe UI", 10F);
            lblSeleccione.Location = new Point(109, 74);
            lblSeleccione.Name = "lblSeleccione";
            lblSeleccione.Size = new Size(143, 19);
            lblSeleccione.TabIndex = 40;
            lblSeleccione.Text = "Seleccione una opcion";
            // 
            // gboxAccion
            // 
            gboxAccion.Controls.Add(rdioRehacer);
            gboxAccion.Controls.Add(rdioDeshacer);
            gboxAccion.Controls.Add(rdioEscribir);
            gboxAccion.Location = new Point(109, 95);
            gboxAccion.Margin = new Padding(3, 2, 3, 2);
            gboxAccion.Name = "gboxAccion";
            gboxAccion.Padding = new Padding(3, 2, 3, 2);
            gboxAccion.Size = new Size(214, 133);
            gboxAccion.TabIndex = 39;
            gboxAccion.TabStop = false;
            // 
            // rdioRehacer
            // 
            rdioRehacer.AutoSize = true;
            rdioRehacer.Font = new Font("Segoe UI", 10F);
            rdioRehacer.Location = new Point(16, 90);
            rdioRehacer.Margin = new Padding(3, 2, 3, 2);
            rdioRehacer.Name = "rdioRehacer";
            rdioRehacer.Size = new Size(75, 23);
            rdioRehacer.TabIndex = 2;
            rdioRehacer.TabStop = true;
            rdioRehacer.Text = "Rehacer";
            rdioRehacer.UseVisualStyleBackColor = true;
            rdioRehacer.CheckedChanged += rdioRehacer_CheckedChanged;
            // 
            // rdioDeshacer
            // 
            rdioDeshacer.AutoSize = true;
            rdioDeshacer.Font = new Font("Segoe UI", 10F);
            rdioDeshacer.Location = new Point(16, 59);
            rdioDeshacer.Margin = new Padding(3, 2, 3, 2);
            rdioDeshacer.Name = "rdioDeshacer";
            rdioDeshacer.Size = new Size(83, 23);
            rdioDeshacer.TabIndex = 1;
            rdioDeshacer.TabStop = true;
            rdioDeshacer.Text = "Deshacer";
            rdioDeshacer.UseVisualStyleBackColor = true;
            rdioDeshacer.CheckedChanged += rdioDeshacer_CheckedChanged;
            // 
            // rdioEscribir
            // 
            rdioEscribir.AutoSize = true;
            rdioEscribir.Font = new Font("Segoe UI", 10F);
            rdioEscribir.Location = new Point(16, 27);
            rdioEscribir.Margin = new Padding(3, 2, 3, 2);
            rdioEscribir.Name = "rdioEscribir";
            rdioEscribir.Size = new Size(70, 23);
            rdioEscribir.TabIndex = 0;
            rdioEscribir.TabStop = true;
            rdioEscribir.Text = "Escribir";
            rdioEscribir.UseVisualStyleBackColor = true;
            rdioEscribir.CheckedChanged += rdioEscribir_CheckedChanged;
            // 
            // txtTexto
            // 
            txtTexto.Font = new Font("Segoe UI", 11F);
            txtTexto.Location = new Point(465, 111);
            txtTexto.Margin = new Padding(3, 2, 3, 2);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(227, 27);
            txtTexto.TabIndex = 38;
            txtTexto.Visible = false;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Segoe UI", 11F);
            lblTexto.Location = new Point(396, 114);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(52, 20);
            lblTexto.TabIndex = 37;
            lblTexto.Text = "Texto: ";
            lblTexto.Visible = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(109, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(275, 28);
            lblTitulo.TabIndex = 36;
            lblTitulo.Text = "Historial de un Editor de Texto";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.Location = new Point(551, 326);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 33);
            btnSalir.TabIndex = 35;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormEj2ListasEnlazadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(listMostrar);
            Controls.Add(btnOk);
            Controls.Add(lblSeleccione);
            Controls.Add(gboxAccion);
            Controls.Add(txtTexto);
            Controls.Add(lblTexto);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Name = "FormEj2ListasEnlazadas";
            Text = "Formulario Ejercicio 2 Listas Enlazadas";
            gboxAccion.ResumeLayout(false);
            gboxAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listMostrar;
        private Button btnEliminar;
        private Label lblSeleccione;
        private GroupBox gboxAccion;
        private RadioButton rdioRehacer;
        private RadioButton rdioDeshacer;
        private RadioButton rdioEscribir;
        private Label lblTexto;
        private Label lblTitulo;
        private Button btnSalir;
        private Button btnOk;
        private TextBox txtTexto;
    }
}