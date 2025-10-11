namespace TPEstructurasDinamicasParte2.Colas
{
    partial class FormEj3Colas
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
            lblSeleccione = new Label();
            gboxAccion = new GroupBox();
            rdioEjecutar = new RadioButton();
            rdioNuevo = new RadioButton();
            lblTitulo = new Label();
            btnSalir = new Button();
            gboxAccion.SuspendLayout();
            SuspendLayout();
            // 
            // listMostrar
            // 
            listMostrar.FormattingEnabled = true;
            listMostrar.ItemHeight = 15;
            listMostrar.Location = new Point(81, 249);
            listMostrar.Name = "listMostrar";
            listMostrar.Size = new Size(443, 169);
            listMostrar.TabIndex = 40;
            // 
            // lblSeleccione
            // 
            lblSeleccione.AutoSize = true;
            lblSeleccione.Font = new Font("Segoe UI", 10F);
            lblSeleccione.Location = new Point(81, 77);
            lblSeleccione.Name = "lblSeleccione";
            lblSeleccione.Size = new Size(143, 19);
            lblSeleccione.TabIndex = 39;
            lblSeleccione.Text = "Seleccione una opcion";
            // 
            // gboxAccion
            // 
            gboxAccion.Controls.Add(rdioEjecutar);
            gboxAccion.Controls.Add(rdioNuevo);
            gboxAccion.Location = new Point(81, 98);
            gboxAccion.Margin = new Padding(3, 2, 3, 2);
            gboxAccion.Name = "gboxAccion";
            gboxAccion.Padding = new Padding(3, 2, 3, 2);
            gboxAccion.Size = new Size(639, 127);
            gboxAccion.TabIndex = 38;
            gboxAccion.TabStop = false;
            // 
            // rdioEjecutar
            // 
            rdioEjecutar.AutoSize = true;
            rdioEjecutar.Font = new Font("Segoe UI", 12F);
            rdioEjecutar.Location = new Point(397, 48);
            rdioEjecutar.Margin = new Padding(3, 2, 3, 2);
            rdioEjecutar.Name = "rdioEjecutar";
            rdioEjecutar.Size = new Size(142, 25);
            rdioEjecutar.TabIndex = 1;
            rdioEjecutar.TabStop = true;
            rdioEjecutar.Text = "Ejecutar Proceso";
            rdioEjecutar.UseVisualStyleBackColor = true;
            rdioEjecutar.CheckedChanged += rdioEjecutar_CheckedChanged;
            // 
            // rdioNuevo
            // 
            rdioNuevo.AutoSize = true;
            rdioNuevo.Font = new Font("Segoe UI", 12F);
            rdioNuevo.Location = new Point(62, 48);
            rdioNuevo.Margin = new Padding(3, 2, 3, 2);
            rdioNuevo.Name = "rdioNuevo";
            rdioNuevo.Size = new Size(133, 25);
            rdioNuevo.TabIndex = 0;
            rdioNuevo.TabStop = true;
            rdioNuevo.Text = "Nuevo Proceso";
            rdioNuevo.UseVisualStyleBackColor = true;
            rdioNuevo.CheckedChanged += rdioNuevo_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(81, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(372, 28);
            lblTitulo.TabIndex = 37;
            lblTitulo.Text = "Cola de Procesos en el Sistema Operativo";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.Location = new Point(602, 351);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 33);
            btnSalir.TabIndex = 36;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormEj3Colas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 450);
            Controls.Add(listMostrar);
            Controls.Add(lblSeleccione);
            Controls.Add(gboxAccion);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Name = "FormEj3Colas";
            Text = "Formulario Ejercicio 3 Colas";
            gboxAccion.ResumeLayout(false);
            gboxAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listMostrar;
        private Label lblSeleccione;
        private GroupBox gboxAccion;
        private RadioButton rdioEjecutar;
        private RadioButton rdioNuevo;
        private Label lblTitulo;
        private Button btnSalir;
    }
}