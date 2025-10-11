namespace TPEstructurasDinamicasParte2.Colas
{
    partial class FormEj2Colas
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
            rdioAtender = new RadioButton();
            rdioAgregar = new RadioButton();
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
            listMostrar.TabIndex = 35;
            
            // 
            // lblSeleccione
            // 
            lblSeleccione.AutoSize = true;
            lblSeleccione.Font = new Font("Segoe UI", 10F);
            lblSeleccione.Location = new Point(81, 77);
            lblSeleccione.Name = "lblSeleccione";
            lblSeleccione.Size = new Size(143, 19);
            lblSeleccione.TabIndex = 34;
            lblSeleccione.Text = "Seleccione una opcion";
            
            // 
            // gboxAccion
            // 
            gboxAccion.Controls.Add(rdioAtender);
            gboxAccion.Controls.Add(rdioAgregar);
            gboxAccion.Location = new Point(81, 98);
            gboxAccion.Margin = new Padding(3, 2, 3, 2);
            gboxAccion.Name = "gboxAccion";
            gboxAccion.Padding = new Padding(3, 2, 3, 2);
            gboxAccion.Size = new Size(639, 127);
            gboxAccion.TabIndex = 33;
            gboxAccion.TabStop = false;
            
            // 
            // rdioAtender
            // 
            rdioAtender.AutoSize = true;
            rdioAtender.Font = new Font("Segoe UI", 12F);
            rdioAtender.Location = new Point(423, 49);
            rdioAtender.Margin = new Padding(3, 2, 3, 2);
            rdioAtender.Name = "rdioAtender";
            rdioAtender.Size = new Size(151, 25);
            rdioAtender.TabIndex = 1;
            rdioAtender.TabStop = true;
            rdioAtender.Text = "Antender llamada";
            rdioAtender.UseVisualStyleBackColor = true;
            rdioAtender.CheckedChanged += rdioAtender_CheckedChanged;
            // 
            // rdioAgregar
            // 
            rdioAgregar.AutoSize = true;
            rdioAgregar.Font = new Font("Segoe UI", 12F);
            rdioAgregar.Location = new Point(22, 49);
            rdioAgregar.Margin = new Padding(3, 2, 3, 2);
            rdioAgregar.Name = "rdioAgregar";
            rdioAgregar.Size = new Size(203, 25);
            rdioAgregar.TabIndex = 0;
            rdioAgregar.TabStop = true;
            rdioAgregar.Text = "Agregar llamada a la cola";
            rdioAgregar.UseVisualStyleBackColor = true;
            rdioAgregar.CheckedChanged += rdioAgregar_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(81, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(228, 28);
            lblTitulo.TabIndex = 32;
            lblTitulo.Text = "Simulador de Call Center";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.Location = new Point(602, 351);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 33);
            btnSalir.TabIndex = 31;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormEj2Colas
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
            Name = "FormEj2Colas";
            Text = "Formulario Ejercicio 2 Colas";
            gboxAccion.ResumeLayout(false);
            gboxAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listMostrar;
        private Label lblSeleccione;
        private GroupBox gboxAccion;
        private RadioButton rdioAtender;
        private RadioButton rdioAgregar;
        private Label lblTitulo;
        private Button btnSalir;
    }
}