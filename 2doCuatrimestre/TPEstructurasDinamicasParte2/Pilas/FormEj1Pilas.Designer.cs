namespace TPEstructurasDinamicasParte2.Pilas
{
    partial class FormEj1Pilas
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
            rdioMostrar = new RadioButton();
            rdioDesapilar = new RadioButton();
            rdioApilar = new RadioButton();
            lblTitulo = new Label();
            btnSalir = new Button();
            gboxAccion.SuspendLayout();
            SuspendLayout();
            // 
            // listMostrar
            // 
            listMostrar.FormattingEnabled = true;
            listMostrar.ItemHeight = 15;
            listMostrar.Location = new Point(87, 246);
            listMostrar.Name = "listMostrar";
            listMostrar.Size = new Size(443, 169);
            listMostrar.TabIndex = 25;
            listMostrar.SelectedIndexChanged += listMostrar_SelectedIndexChanged;
            // 
            // lblSeleccione
            // 
            lblSeleccione.AutoSize = true;
            lblSeleccione.Font = new Font("Segoe UI", 10F);
            lblSeleccione.Location = new Point(87, 74);
            lblSeleccione.Name = "lblSeleccione";
            lblSeleccione.Size = new Size(143, 19);
            lblSeleccione.TabIndex = 21;
            lblSeleccione.Text = "Seleccione una opcion";
//            lblSeleccione.Click += this.lblSeleccione_Click;
            // 
            // gboxAccion
            // 
            gboxAccion.Controls.Add(rdioMostrar);
            gboxAccion.Controls.Add(rdioDesapilar);
            gboxAccion.Controls.Add(rdioApilar);
            gboxAccion.Location = new Point(87, 95);
            gboxAccion.Margin = new Padding(3, 2, 3, 2);
            gboxAccion.Name = "gboxAccion";
            gboxAccion.Padding = new Padding(3, 2, 3, 2);
            gboxAccion.Size = new Size(639, 127);
            gboxAccion.TabIndex = 20;
            gboxAccion.TabStop = false;
            //gboxAccion.Enter += this.gboxAccion_Enter;
            // 
            // rdioMostrar
            // 
            rdioMostrar.AutoSize = true;
            rdioMostrar.Font = new Font("Segoe UI", 12F);
            rdioMostrar.Location = new Point(437, 51);
            rdioMostrar.Margin = new Padding(3, 2, 3, 2);
            rdioMostrar.Name = "rdioMostrar";
            rdioMostrar.Size = new Size(162, 25);
            rdioMostrar.TabIndex = 2;
            rdioMostrar.TabStop = true;
            rdioMostrar.Text = "Mostrar Plato Cima";
            rdioMostrar.UseVisualStyleBackColor = true;
            rdioMostrar.CheckedChanged += rdioMostrar_CheckedChanged;
            // 
            // rdioDesapilar
            // 
            rdioDesapilar.AutoSize = true;
            rdioDesapilar.Font = new Font("Segoe UI", 12F);
            rdioDesapilar.Location = new Point(227, 51);
            rdioDesapilar.Margin = new Padding(3, 2, 3, 2);
            rdioDesapilar.Name = "rdioDesapilar";
            rdioDesapilar.Size = new Size(132, 25);
            rdioDesapilar.TabIndex = 1;
            rdioDesapilar.TabStop = true;
            rdioDesapilar.Text = "Desapilar Plato";
            rdioDesapilar.UseVisualStyleBackColor = true;
            rdioDesapilar.CheckedChanged += rdioDesapilar_CheckedChanged;
            // 
            // rdioApilar
            // 
            rdioApilar.AutoSize = true;
            rdioApilar.Font = new Font("Segoe UI", 12F);
            rdioApilar.Location = new Point(22, 51);
            rdioApilar.Margin = new Padding(3, 2, 3, 2);
            rdioApilar.Name = "rdioApilar";
            rdioApilar.Size = new Size(108, 25);
            rdioApilar.TabIndex = 0;
            rdioApilar.TabStop = true;
            rdioApilar.Text = "Apilar Plato";
            rdioApilar.UseVisualStyleBackColor = true;
            rdioApilar.CheckedChanged += rdioApilar_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(87, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 28);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Simulador de Pila de Platos";
            //lblTitulo.Click += this.lblTitulo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 11F);
            btnSalir.Location = new Point(608, 348);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 33);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormEj1Pilas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(listMostrar);
            Controls.Add(lblSeleccione);
            Controls.Add(gboxAccion);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Name = "FormEj1Pilas";
            Text = "Formulario Ejercicio 1 Pilas";
            //Load += this.FormEj1Pilas_Load;
            gboxAccion.ResumeLayout(false);
            gboxAccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listMostrar;
        private Label lblSeleccione;
        private GroupBox gboxAccion;
        private RadioButton rdioMostrar;
        private RadioButton rdioDesapilar;
        private RadioButton rdioApilar;
        private Label lblTitulo;
        private Button btnSalir;
    }
}