namespace EjNotaEscolares
{
    partial class Form2
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
            lblTitle = new Label();
            lblAlumno = new Label();
            lblMateria = new Label();
            lblNota = new Label();
            lblTipo = new Label();
            lblAlumnoinfo = new Label();
            lblMateriaInfo = new Label();
            lblNotaInfo = new Label();
            lblTipoInfo = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.Control;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(89, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(453, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "INFORMACION ULTIMO ALUMNO CARGADO";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Segoe UI", 12F);
            lblAlumno.Location = new Point(66, 158);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(0, 21);
            lblAlumno.TabIndex = 1;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 12F);
            lblMateria.Location = new Point(199, 158);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(0, 21);
            lblMateria.TabIndex = 2;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Segoe UI", 12F);
            lblNota.Location = new Point(343, 158);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(0, 21);
            lblNota.TabIndex = 3;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 12F);
            lblTipo.Location = new Point(490, 158);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(0, 21);
            lblTipo.TabIndex = 4;
            // 
            // lblAlumnoinfo
            // 
            lblAlumnoinfo.AutoSize = true;
            lblAlumnoinfo.BackColor = SystemColors.Control;
            lblAlumnoinfo.Font = new Font("Segoe UI", 12F);
            lblAlumnoinfo.Location = new Point(66, 104);
            lblAlumnoinfo.Name = "lblAlumnoinfo";
            lblAlumnoinfo.Size = new Size(65, 21);
            lblAlumnoinfo.TabIndex = 5;
            lblAlumnoinfo.Text = "Alumno";
            // 
            // lblMateriaInfo
            // 
            lblMateriaInfo.AutoSize = true;
            lblMateriaInfo.BackColor = SystemColors.Control;
            lblMateriaInfo.Font = new Font("Segoe UI", 12F);
            lblMateriaInfo.Location = new Point(199, 104);
            lblMateriaInfo.Name = "lblMateriaInfo";
            lblMateriaInfo.Size = new Size(63, 21);
            lblMateriaInfo.TabIndex = 6;
            lblMateriaInfo.Text = "Materia";
            // 
            // lblNotaInfo
            // 
            lblNotaInfo.AutoSize = true;
            lblNotaInfo.BackColor = SystemColors.Control;
            lblNotaInfo.Font = new Font("Segoe UI", 12F);
            lblNotaInfo.Location = new Point(343, 104);
            lblNotaInfo.Name = "lblNotaInfo";
            lblNotaInfo.Size = new Size(44, 21);
            lblNotaInfo.TabIndex = 7;
            lblNotaInfo.Text = "Nota";
            // 
            // lblTipoInfo
            // 
            lblTipoInfo.AutoSize = true;
            lblTipoInfo.BackColor = SystemColors.Control;
            lblTipoInfo.Font = new Font("Segoe UI", 12F);
            lblTipoInfo.Location = new Point(490, 104);
            lblTipoInfo.Name = "lblTipoInfo";
            lblTipoInfo.Size = new Size(40, 21);
            lblTipoInfo.TabIndex = 8;
            lblTipoInfo.Text = "Tipo";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(627, 284);
            Controls.Add(lblTipoInfo);
            Controls.Add(lblNotaInfo);
            Controls.Add(lblMateriaInfo);
            Controls.Add(lblAlumnoinfo);
            Controls.Add(lblTipo);
            Controls.Add(lblNota);
            Controls.Add(lblMateria);
            Controls.Add(lblAlumno);
            Controls.Add(lblTitle);
            Name = "Form2";
            Text = "PLANILLA";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAlumno;
        private Label lblMateria;
        private Label lblNota;
        private Label lblTipo;
        private Label lblAlumnoinfo;
        private Label lblMateriaInfo;
        private Label lblNotaInfo;
        private Label lblTipoInfo;
    }
}