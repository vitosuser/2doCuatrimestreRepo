namespace EjPracticaParcialClase
{
    partial class Form1
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
            lblNombre = new Label();
            lblPBase = new Label();
            txtPasajero = new TextBox();
            txtPBase = new TextBox();
            gboxDestino = new GroupBox();
            rdioCiudad = new RadioButton();
            rdioMontana = new RadioButton();
            rdioPlaya = new RadioButton();
            gboxAdicionales = new GroupBox();
            chkComidas = new CheckBox();
            chkTraslado = new CheckBox();
            chkGuia = new CheckBox();
            btnCotizar = new Button();
            txtInfo = new TextBox();
            gboxDestino.SuspendLayout();
            gboxAdicionales.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F);
            lblNombre.Location = new Point(30, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(193, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del pasajero:";
            // 
            // lblPBase
            // 
            lblPBase.AutoSize = true;
            lblPBase.Font = new Font("Segoe UI", 11F);
            lblPBase.Location = new Point(30, 108);
            lblPBase.Name = "lblPBase";
            lblPBase.Size = new Size(186, 25);
            lblPBase.TabIndex = 1;
            lblPBase.Text = "Precio Base Paquete:";
            // 
            // txtPasajero
            // 
            txtPasajero.Font = new Font("Segoe UI", 11F);
            txtPasajero.Location = new Point(240, 35);
            txtPasajero.Name = "txtPasajero";
            txtPasajero.Size = new Size(258, 32);
            txtPasajero.TabIndex = 2;
            // 
            // txtPBase
            // 
            txtPBase.Font = new Font("Segoe UI", 11F);
            txtPBase.Location = new Point(240, 109);
            txtPBase.Name = "txtPBase";
            txtPBase.Size = new Size(258, 32);
            txtPBase.TabIndex = 3;
            txtPBase.TextAlign = HorizontalAlignment.Right;
            // 
            // gboxDestino
            // 
            gboxDestino.Controls.Add(rdioCiudad);
            gboxDestino.Controls.Add(rdioMontana);
            gboxDestino.Controls.Add(rdioPlaya);
            gboxDestino.Location = new Point(30, 192);
            gboxDestino.Name = "gboxDestino";
            gboxDestino.Size = new Size(279, 186);
            gboxDestino.TabIndex = 4;
            gboxDestino.TabStop = false;
            gboxDestino.Text = "Destino";
            // 
            // rdioCiudad
            // 
            rdioCiudad.AutoSize = true;
            rdioCiudad.Location = new Point(17, 131);
            rdioCiudad.Name = "rdioCiudad";
            rdioCiudad.Size = new Size(77, 24);
            rdioCiudad.TabIndex = 2;
            rdioCiudad.Text = "Ciudad";
            rdioCiudad.UseVisualStyleBackColor = true;
            // 
            // rdioMontana
            // 
            rdioMontana.AutoSize = true;
            rdioMontana.Location = new Point(17, 88);
            rdioMontana.Name = "rdioMontana";
            rdioMontana.Size = new Size(89, 24);
            rdioMontana.TabIndex = 1;
            rdioMontana.Text = "Montaña";
            rdioMontana.UseVisualStyleBackColor = true;
            // 
            // rdioPlaya
            // 
            rdioPlaya.AutoSize = true;
            rdioPlaya.Checked = true;
            rdioPlaya.Location = new Point(17, 43);
            rdioPlaya.Name = "rdioPlaya";
            rdioPlaya.Size = new Size(65, 24);
            rdioPlaya.TabIndex = 0;
            rdioPlaya.TabStop = true;
            rdioPlaya.Text = "Playa";
            rdioPlaya.UseVisualStyleBackColor = true;
            // 
            // gboxAdicionales
            // 
            gboxAdicionales.Controls.Add(chkComidas);
            gboxAdicionales.Controls.Add(chkTraslado);
            gboxAdicionales.Controls.Add(chkGuia);
            gboxAdicionales.Location = new Point(370, 192);
            gboxAdicionales.Name = "gboxAdicionales";
            gboxAdicionales.Size = new Size(279, 186);
            gboxAdicionales.TabIndex = 5;
            gboxAdicionales.TabStop = false;
            gboxAdicionales.Text = "Servicios Adicionales";
            // 
            // chkComidas
            // 
            chkComidas.AutoSize = true;
            chkComidas.Location = new Point(33, 132);
            chkComidas.Name = "chkComidas";
            chkComidas.Size = new Size(89, 24);
            chkComidas.TabIndex = 8;
            chkComidas.Text = "Comidas";
            chkComidas.UseVisualStyleBackColor = true;
            // 
            // chkTraslado
            // 
            chkTraslado.AutoSize = true;
            chkTraslado.Location = new Point(33, 89);
            chkTraslado.Name = "chkTraslado";
            chkTraslado.Size = new Size(87, 24);
            chkTraslado.TabIndex = 7;
            chkTraslado.Text = "Traslado";
            chkTraslado.UseVisualStyleBackColor = true;
            // 
            // chkGuia
            // 
            chkGuia.AutoSize = true;
            chkGuia.Location = new Point(33, 44);
            chkGuia.Name = "chkGuia";
            chkGuia.Size = new Size(118, 24);
            chkGuia.TabIndex = 6;
            chkGuia.Text = "Guia turistico";
            chkGuia.UseVisualStyleBackColor = true;
            chkGuia.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnCotizar
            // 
            btnCotizar.Font = new Font("Segoe UI", 18F);
            btnCotizar.Location = new Point(540, 34);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(207, 115);
            btnCotizar.TabIndex = 6;
            btnCotizar.Text = "COTIZAR";
            btnCotizar.UseVisualStyleBackColor = true;
            btnCotizar.Click += btnCotizar_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(30, 427);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(619, 241);
            txtInfo.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(771, 680);
            Controls.Add(txtInfo);
            Controls.Add(btnCotizar);
            Controls.Add(gboxAdicionales);
            Controls.Add(gboxDestino);
            Controls.Add(txtPBase);
            Controls.Add(txtPasajero);
            Controls.Add(lblPBase);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            gboxDestino.ResumeLayout(false);
            gboxDestino.PerformLayout();
            gboxAdicionales.ResumeLayout(false);
            gboxAdicionales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblPBase;
        private TextBox txtPasajero;
        private TextBox txtPBase;
        private GroupBox gboxDestino;
        private RadioButton rdioCiudad;
        private RadioButton rdioMontana;
        private RadioButton rdioPlaya;
        private GroupBox gboxAdicionales;
        private CheckBox chkGuia;
        private CheckBox chkComidas;
        private CheckBox chkTraslado;
        private Button btnCotizar;
        private TextBox txtInfo;
    }
}
