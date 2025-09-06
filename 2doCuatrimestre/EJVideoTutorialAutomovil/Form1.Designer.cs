namespace EJVideoTutorialAutomovil
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gboxSeguro = new System.Windows.Forms.GroupBox();
            this.rbTerceros = new System.Windows.Forms.RadioButton();
            this.rbTodoRiesgo = new System.Windows.Forms.RadioButton();
            this.rbRespCivil = new System.Windows.Forms.RadioButton();
            this.gbEquip = new System.Windows.Forms.GroupBox();
            this.ckbAudio = new System.Windows.Forms.CheckBox();
            this.ckbAire = new System.Windows.Forms.CheckBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.txtCotizacion = new System.Windows.Forms.TextBox();
            this.gboxSeguro.SuspendLayout();
            this.gbEquip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre.Location = new System.Drawing.Point(15, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // gboxSeguro
            // 
            this.gboxSeguro.Controls.Add(this.rbTerceros);
            this.gboxSeguro.Controls.Add(this.rbTodoRiesgo);
            this.gboxSeguro.Controls.Add(this.rbRespCivil);
            this.gboxSeguro.Location = new System.Drawing.Point(32, 76);
            this.gboxSeguro.Name = "gboxSeguro";
            this.gboxSeguro.Size = new System.Drawing.Size(229, 138);
            this.gboxSeguro.TabIndex = 2;
            this.gboxSeguro.TabStop = false;
            this.gboxSeguro.Text = "Seleccion Seguro:";
            this.gboxSeguro.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbTerceros
            // 
            this.rbTerceros.AutoSize = true;
            this.rbTerceros.Location = new System.Drawing.Point(25, 65);
            this.rbTerceros.Name = "rbTerceros";
            this.rbTerceros.Size = new System.Drawing.Size(101, 17);
            this.rbTerceros.TabIndex = 2;
            this.rbTerceros.Text = "Contra Terceros";
            this.rbTerceros.UseVisualStyleBackColor = true;
            this.rbTerceros.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbTodoRiesgo
            // 
            this.rbTodoRiesgo.AutoSize = true;
            this.rbTodoRiesgo.Location = new System.Drawing.Point(25, 104);
            this.rbTodoRiesgo.Name = "rbTodoRiesgo";
            this.rbTodoRiesgo.Size = new System.Drawing.Size(86, 17);
            this.rbTodoRiesgo.TabIndex = 1;
            this.rbTodoRiesgo.Text = "Todo Riesgo";
            this.rbTodoRiesgo.UseVisualStyleBackColor = true;
            this.rbTodoRiesgo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbRespCivil
            // 
            this.rbRespCivil.AutoSize = true;
            this.rbRespCivil.Checked = true;
            this.rbRespCivil.Location = new System.Drawing.Point(25, 28);
            this.rbRespCivil.Name = "rbRespCivil";
            this.rbRespCivil.Size = new System.Drawing.Size(157, 17);
            this.rbRespCivil.TabIndex = 0;
            this.rbRespCivil.TabStop = true;
            this.rbRespCivil.Text = "Responsabilidad Civil (base)";
            this.rbRespCivil.UseVisualStyleBackColor = true;
            this.rbRespCivil.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gbEquip
            // 
            this.gbEquip.Controls.Add(this.ckbAudio);
            this.gbEquip.Controls.Add(this.ckbAire);
            this.gbEquip.Location = new System.Drawing.Point(334, 76);
            this.gbEquip.Name = "gbEquip";
            this.gbEquip.Size = new System.Drawing.Size(229, 101);
            this.gbEquip.TabIndex = 3;
            this.gbEquip.TabStop = false;
            this.gbEquip.Text = "Equipamento:";
            this.gbEquip.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // ckbAudio
            // 
            this.ckbAudio.AutoSize = true;
            this.ckbAudio.Location = new System.Drawing.Point(34, 65);
            this.ckbAudio.Name = "ckbAudio";
            this.ckbAudio.Size = new System.Drawing.Size(107, 17);
            this.ckbAudio.TabIndex = 1;
            this.ckbAudio.Text = "Sistema de audio";
            this.ckbAudio.UseVisualStyleBackColor = true;
            // 
            // ckbAire
            // 
            this.ckbAire.AutoSize = true;
            this.ckbAire.Location = new System.Drawing.Point(34, 28);
            this.ckbAire.Name = "ckbAire";
            this.ckbAire.Size = new System.Drawing.Size(117, 17);
            this.ckbAire.TabIndex = 0;
            this.ckbAire.Text = "Aire acondicionado";
            this.ckbAire.UseVisualStyleBackColor = true;
            this.ckbAire.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCosto.Location = new System.Drawing.Point(29, 241);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(48, 17);
            this.lblCosto.TabIndex = 4;
            this.lblCosto.Text = "Costo:";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(79, 241);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(135, 20);
            this.txtCosto.TabIndex = 5;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(400, 241);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(75, 23);
            this.btnCotizar.TabIndex = 6;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.Location = new System.Drawing.Point(32, 327);
            this.txtCotizacion.Multiline = true;
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.Size = new System.Drawing.Size(531, 196);
            this.txtCotizacion.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(624, 555);
            this.Controls.Add(this.txtCotizacion);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.gbEquip);
            this.Controls.Add(this.gboxSeguro);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxSeguro.ResumeLayout(false);
            this.gboxSeguro.PerformLayout();
            this.gbEquip.ResumeLayout(false);
            this.gbEquip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gboxSeguro;
        private System.Windows.Forms.RadioButton rbTerceros;
        private System.Windows.Forms.RadioButton rbTodoRiesgo;
        private System.Windows.Forms.RadioButton rbRespCivil;
        private System.Windows.Forms.GroupBox gbEquip;
        private System.Windows.Forms.CheckBox ckbAudio;
        private System.Windows.Forms.CheckBox ckbAire;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.TextBox txtCotizacion;
    }
}

