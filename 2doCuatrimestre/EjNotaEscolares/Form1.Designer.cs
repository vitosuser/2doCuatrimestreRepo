namespace EjNotaEscolares
{
    partial class formNotas
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
            components = new System.ComponentModel.Container();
            lblAlumno = new Label();
            lblMateria = new Label();
            txtName = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            txtMateria = new TextBox();
            txtNota = new TextBox();
            lblNota = new Label();
            gboxTipo = new GroupBox();
            rdioFinal = new RadioButton();
            rdioParcial = new RadioButton();
            rdioTP = new RadioButton();
            mnstrp1 = new MenuStrip();
            notasToolStripMenuItem = new ToolStripMenuItem();
            planillaToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            btn = new Button();
            ctxMenu = new ContextMenuStrip(components);
            limpiarEntradasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            gboxTipo.SuspendLayout();
            mnstrp1.SuspendLayout();
            ctxMenu.SuspendLayout();
            SuspendLayout();
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Segoe UI", 12F);
            lblAlumno.Location = new Point(44, 82);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(153, 21);
            lblAlumno.TabIndex = 0;
            lblAlumno.Text = "Nombre del alumno:";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 12F);
            lblMateria.Location = new Point(44, 149);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(70, 21);
            lblMateria.TabIndex = 1;
            lblMateria.Text = "Materia: ";
            lblMateria.Click += lblMateria_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(203, 82);
            txtName.Name = "txtName";
            txtName.Size = new Size(197, 23);
            txtName.TabIndex = 2;
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(120, 151);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(197, 23);
            txtMateria.TabIndex = 3;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(112, 217);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(106, 23);
            txtNota.TabIndex = 4;
            txtNota.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Segoe UI", 12F);
            lblNota.Location = new Point(44, 215);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(47, 21);
            lblNota.TabIndex = 5;
            lblNota.Text = "Nota:";
            lblNota.Click += label1_Click;
            // 
            // gboxTipo
            // 
            gboxTipo.Controls.Add(rdioFinal);
            gboxTipo.Controls.Add(rdioParcial);
            gboxTipo.Controls.Add(rdioTP);
            gboxTipo.Location = new Point(44, 272);
            gboxTipo.Name = "gboxTipo";
            gboxTipo.Size = new Size(200, 129);
            gboxTipo.TabIndex = 6;
            gboxTipo.TabStop = false;
            gboxTipo.Text = "Tipo";
            // 
            // rdioFinal
            // 
            rdioFinal.AutoSize = true;
            rdioFinal.Location = new Point(15, 84);
            rdioFinal.Name = "rdioFinal";
            rdioFinal.Size = new Size(50, 19);
            rdioFinal.TabIndex = 2;
            rdioFinal.Text = "Final";
            rdioFinal.UseVisualStyleBackColor = true;
            // 
            // rdioParcial
            // 
            rdioParcial.AutoSize = true;
            rdioParcial.Location = new Point(15, 59);
            rdioParcial.Name = "rdioParcial";
            rdioParcial.Size = new Size(60, 19);
            rdioParcial.TabIndex = 1;
            rdioParcial.Text = "Parcial";
            rdioParcial.UseVisualStyleBackColor = true;
            // 
            // rdioTP
            // 
            rdioTP.AutoSize = true;
            rdioTP.Checked = true;
            rdioTP.Location = new Point(15, 34);
            rdioTP.Name = "rdioTP";
            rdioTP.Size = new Size(109, 19);
            rdioTP.TabIndex = 0;
            rdioTP.TabStop = true;
            rdioTP.Text = "Trabajo Practico";
            rdioTP.UseVisualStyleBackColor = true;
            // 
            // mnstrp1
            // 
            mnstrp1.Items.AddRange(new ToolStripItem[] { notasToolStripMenuItem, ayudaToolStripMenuItem, salirToolStripMenuItem });
            mnstrp1.Location = new Point(0, 0);
            mnstrp1.Name = "mnstrp1";
            mnstrp1.Size = new Size(447, 24);
            mnstrp1.TabIndex = 7;
            mnstrp1.Text = "menuStrip1";
            // 
            // notasToolStripMenuItem
            // 
            notasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { planillaToolStripMenuItem });
            notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            notasToolStripMenuItem.Size = new Size(50, 20);
            notasToolStripMenuItem.Text = "Notas";
            // 
            // planillaToolStripMenuItem
            // 
            planillaToolStripMenuItem.AutoToolTip = true;
            planillaToolStripMenuItem.Name = "planillaToolStripMenuItem";
            planillaToolStripMenuItem.Size = new Size(112, 22);
            planillaToolStripMenuItem.Text = "Planilla";
            planillaToolStripMenuItem.ToolTipText = "Vea la planilla con todas las notas subidas";
            planillaToolStripMenuItem.Click += planillaToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(126, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.RightToLeft = RightToLeft.No;
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // btn
            // 
            btn.Location = new Point(325, 352);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 8;
            btn.Text = "Guardar";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // ctxMenu
            // 
            ctxMenu.Items.AddRange(new ToolStripItem[] { limpiarEntradasToolStripMenuItem, salirToolStripMenuItem1 });
            ctxMenu.Name = "ctxMenu";
            ctxMenu.Size = new Size(181, 70);
            // 
            // limpiarEntradasToolStripMenuItem
            // 
            limpiarEntradasToolStripMenuItem.Name = "limpiarEntradasToolStripMenuItem";
            limpiarEntradasToolStripMenuItem.Size = new Size(180, 22);
            limpiarEntradasToolStripMenuItem.Text = "Limpiar entradas";
            limpiarEntradasToolStripMenuItem.Click += limpiarEntradasToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(180, 22);
            salirToolStripMenuItem1.Text = "Salir";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // formNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(447, 450);
            ContextMenuStrip = ctxMenu;
            Controls.Add(btn);
            Controls.Add(gboxTipo);
            Controls.Add(lblNota);
            Controls.Add(txtNota);
            Controls.Add(txtMateria);
            Controls.Add(txtName);
            Controls.Add(lblMateria);
            Controls.Add(lblAlumno);
            Controls.Add(mnstrp1);
            MainMenuStrip = mnstrp1;
            Name = "formNotas";
            Text = "Gestor Notas";
            gboxTipo.ResumeLayout(false);
            gboxTipo.PerformLayout();
            mnstrp1.ResumeLayout(false);
            mnstrp1.PerformLayout();
            ctxMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlumno;
        private Label lblMateria;
        private TextBox txtName;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtMateria;
        private TextBox txtNota;
        private Label lblNota;
        private GroupBox gboxTipo;
        private RadioButton rdioFinal;
        private RadioButton rdioParcial;
        private RadioButton rdioTP;
        private MenuStrip mnstrp1;
        private ToolStripMenuItem notasToolStripMenuItem;
        private ToolStripMenuItem planillaToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Button btn;
        private ContextMenuStrip ctxMenu;
        private ToolStripMenuItem limpiarEntradasToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
    }
}
