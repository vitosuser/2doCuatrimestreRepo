namespace EjPracticaParcialClase_2
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
            lblCliente = new Label();
            lblCostoBase = new Label();
            txtCliente = new TextBox();
            txtCostoBase = new TextBox();
            gboxCPU = new GroupBox();
            rdioIntel5 = new RadioButton();
            rdioIntel7 = new RadioButton();
            rdioRyzen7 = new RadioButton();
            groupBox1 = new GroupBox();
            chkRAM = new CheckBox();
            chkSSD = new CheckBox();
            chkGrafica = new CheckBox();
            btnCotizar = new Button();
            txtCotizacion = new TextBox();
            gboxCPU.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(44, 42);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(121, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Nombre Cliente: ";
            // 
            // lblCostoBase
            // 
            lblCostoBase.AutoSize = true;
            lblCostoBase.Location = new Point(356, 42);
            lblCostoBase.Name = "lblCostoBase";
            lblCostoBase.Size = new Size(85, 20);
            lblCostoBase.TabIndex = 1;
            lblCostoBase.Text = "Costo Base:";
            lblCostoBase.Click += label1_Click;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(162, 39);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(188, 27);
            txtCliente.TabIndex = 2;
            // 
            // txtCostoBase
            // 
            txtCostoBase.Location = new Point(447, 39);
            txtCostoBase.Name = "txtCostoBase";
            txtCostoBase.Size = new Size(188, 27);
            txtCostoBase.TabIndex = 3;
            txtCostoBase.TextAlign = HorizontalAlignment.Right;
            // 
            // gboxCPU
            // 
            gboxCPU.Controls.Add(rdioRyzen7);
            gboxCPU.Controls.Add(rdioIntel7);
            gboxCPU.Controls.Add(rdioIntel5);
            gboxCPU.Location = new Point(44, 112);
            gboxCPU.Name = "gboxCPU";
            gboxCPU.Size = new Size(597, 102);
            gboxCPU.TabIndex = 4;
            gboxCPU.TabStop = false;
            gboxCPU.Text = "Procesador";
            // 
            // rdioIntel5
            // 
            rdioIntel5.AutoSize = true;
            rdioIntel5.Checked = true;
            rdioIntel5.Location = new Point(17, 43);
            rdioIntel5.Name = "rdioIntel5";
            rdioIntel5.Size = new Size(75, 24);
            rdioIntel5.TabIndex = 0;
            rdioIntel5.TabStop = true;
            rdioIntel5.Text = "Intel i5";
            rdioIntel5.UseVisualStyleBackColor = true;
            // 
            // rdioIntel7
            // 
            rdioIntel7.AutoSize = true;
            rdioIntel7.Location = new Point(241, 43);
            rdioIntel7.Name = "rdioIntel7";
            rdioIntel7.Size = new Size(75, 24);
            rdioIntel7.TabIndex = 1;
            rdioIntel7.Text = "Intel i7";
            rdioIntel7.UseVisualStyleBackColor = true;
            rdioIntel7.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdioRyzen7
            // 
            rdioRyzen7.AutoSize = true;
            rdioRyzen7.Location = new Point(441, 43);
            rdioRyzen7.Name = "rdioRyzen7";
            rdioRyzen7.Size = new Size(81, 24);
            rdioRyzen7.TabIndex = 2;
            rdioRyzen7.Text = "Ryzen 7";
            rdioRyzen7.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkGrafica);
            groupBox1.Controls.Add(chkSSD);
            groupBox1.Controls.Add(chkRAM);
            groupBox1.Location = new Point(44, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(597, 102);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Procesador";
            // 
            // chkRAM
            // 
            chkRAM.AutoSize = true;
            chkRAM.Location = new Point(17, 55);
            chkRAM.Name = "chkRAM";
            chkRAM.Size = new Size(100, 24);
            chkRAM.TabIndex = 0;
            chkRAM.Text = "RAM Extra";
            chkRAM.UseVisualStyleBackColor = true;
            // 
            // chkSSD
            // 
            chkSSD.AutoSize = true;
            chkSSD.Location = new Point(241, 55);
            chkSSD.Name = "chkSSD";
            chkSSD.Size = new Size(99, 24);
            chkSSD.TabIndex = 1;
            chkSSD.Text = "Disco SSD";
            chkSSD.UseVisualStyleBackColor = true;
            // 
            // chkGrafica
            // 
            chkGrafica.AutoSize = true;
            chkGrafica.Location = new Point(441, 55);
            chkGrafica.Name = "chkGrafica";
            chkGrafica.Size = new Size(126, 24);
            chkGrafica.TabIndex = 2;
            chkGrafica.Text = "Tarjeta Grafica";
            chkGrafica.UseVisualStyleBackColor = true;
            // 
            // btnCotizar
            // 
            btnCotizar.Location = new Point(284, 357);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(100, 46);
            btnCotizar.TabIndex = 6;
            btnCotizar.Text = "COTIZAR";
            btnCotizar.UseVisualStyleBackColor = true;
            btnCotizar.Click += btnCotizar_Click;
            // 
            // txtCotizacion
            // 
            txtCotizacion.Location = new Point(44, 433);
            txtCotizacion.Multiline = true;
            txtCotizacion.Name = "txtCotizacion";
            txtCotizacion.Size = new Size(591, 223);
            txtCotizacion.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(662, 698);
            Controls.Add(txtCotizacion);
            Controls.Add(btnCotizar);
            Controls.Add(groupBox1);
            Controls.Add(gboxCPU);
            Controls.Add(txtCostoBase);
            Controls.Add(txtCliente);
            Controls.Add(lblCostoBase);
            Controls.Add(lblCliente);
            Name = "Form1";
            Text = "Form1";
            gboxCPU.ResumeLayout(false);
            gboxCPU.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Label lblCostoBase;
        private TextBox txtCliente;
        private TextBox txtCostoBase;
        private GroupBox gboxCPU;
        private RadioButton rdioIntel7;
        private RadioButton rdioIntel5;
        private RadioButton rdioRyzen7;
        private GroupBox groupBox1;
        private CheckBox chkRAM;
        private CheckBox chkSSD;
        private CheckBox chkGrafica;
        private Button btnCotizar;
        private TextBox txtCotizacion;
    }
}
