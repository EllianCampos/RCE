namespace PRESENTACION
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            panelMenu = new Panel();
            label1 = new Label();
            btnregistrocursos = new Button();
            btnestudiantes = new Button();
            btnProfesores = new Button();
            btncursos = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelTitulo = new Panel();
            lbltitulo = new Label();
            panelformularios = new Panel();
            horayfecha = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(btnregistrocursos);
            panelMenu.Controls.Add(btnestudiantes);
            panelMenu.Controls.Add(btnProfesores);
            panelMenu.Controls.Add(btncursos);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 497);
            panelMenu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 365);
            label1.Name = "label1";
            label1.Size = new Size(72, 22);
            label1.TabIndex = 5;
            label1.Text = "lblhora";
            // 
            // btnregistrocursos
            // 
            btnregistrocursos.Dock = DockStyle.Top;
            btnregistrocursos.FlatAppearance.BorderSize = 0;
            btnregistrocursos.FlatStyle = FlatStyle.Flat;
            btnregistrocursos.ForeColor = Color.Gainsboro;
            btnregistrocursos.Image = (Image)resources.GetObject("btnregistrocursos.Image");
            btnregistrocursos.ImageAlign = ContentAlignment.MiddleLeft;
            btnregistrocursos.Location = new Point(0, 260);
            btnregistrocursos.Name = "btnregistrocursos";
            btnregistrocursos.Padding = new Padding(12, 0, 0, 0);
            btnregistrocursos.Size = new Size(220, 60);
            btnregistrocursos.TabIndex = 4;
            btnregistrocursos.Text = "  Registro Cursos";
            btnregistrocursos.TextAlign = ContentAlignment.MiddleLeft;
            btnregistrocursos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnregistrocursos.UseVisualStyleBackColor = true;
            btnregistrocursos.Click += btnregistrocursos_Click;
            // 
            // btnestudiantes
            // 
            btnestudiantes.Dock = DockStyle.Top;
            btnestudiantes.FlatAppearance.BorderSize = 0;
            btnestudiantes.FlatStyle = FlatStyle.Flat;
            btnestudiantes.ForeColor = Color.Gainsboro;
            btnestudiantes.Image = (Image)resources.GetObject("btnestudiantes.Image");
            btnestudiantes.ImageAlign = ContentAlignment.MiddleLeft;
            btnestudiantes.Location = new Point(0, 200);
            btnestudiantes.Name = "btnestudiantes";
            btnestudiantes.Padding = new Padding(12, 0, 0, 0);
            btnestudiantes.Size = new Size(220, 60);
            btnestudiantes.TabIndex = 3;
            btnestudiantes.Text = "  Estudiantes";
            btnestudiantes.TextAlign = ContentAlignment.MiddleLeft;
            btnestudiantes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnestudiantes.UseVisualStyleBackColor = true;
            btnestudiantes.Click += btnestudiantes_Click;
            // 
            // btnProfesores
            // 
            btnProfesores.Dock = DockStyle.Top;
            btnProfesores.FlatAppearance.BorderSize = 0;
            btnProfesores.FlatStyle = FlatStyle.Flat;
            btnProfesores.ForeColor = Color.Gainsboro;
            btnProfesores.Image = (Image)resources.GetObject("btnProfesores.Image");
            btnProfesores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfesores.Location = new Point(0, 140);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Padding = new Padding(12, 0, 0, 0);
            btnProfesores.Size = new Size(220, 60);
            btnProfesores.TabIndex = 2;
            btnProfesores.Text = "  Profesores";
            btnProfesores.TextAlign = ContentAlignment.MiddleLeft;
            btnProfesores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfesores.UseVisualStyleBackColor = true;
            btnProfesores.Click += btnProfesores_Click;
            // 
            // btncursos
            // 
            btncursos.Dock = DockStyle.Top;
            btncursos.FlatAppearance.BorderSize = 0;
            btncursos.FlatStyle = FlatStyle.Flat;
            btncursos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btncursos.ForeColor = Color.Gainsboro;
            btncursos.Image = (Image)resources.GetObject("btncursos.Image");
            btncursos.ImageAlign = ContentAlignment.MiddleLeft;
            btncursos.Location = new Point(0, 80);
            btncursos.Name = "btncursos";
            btncursos.Padding = new Padding(12, 0, 0, 0);
            btncursos.Size = new Size(220, 60);
            btncursos.TabIndex = 1;
            btncursos.Text = "  Cursos";
            btncursos.TextAlign = ContentAlignment.MiddleLeft;
            btncursos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncursos.UseVisualStyleBackColor = true;
            btncursos.Click += btncursos_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(51, 51, 76);
            panelTitulo.Controls.Add(lbltitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(220, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(880, 80);
            panelTitulo.TabIndex = 1;
            // 
            // lbltitulo
            // 
            lbltitulo.Anchor = AnchorStyles.None;
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitulo.ForeColor = Color.White;
            lbltitulo.Location = new Point(152, 22);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(569, 36);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Laboratorio de Innovación Comunitaria";
            // 
            // panelformularios
            // 
            panelformularios.Dock = DockStyle.Fill;
            panelformularios.Location = new Point(220, 80);
            panelformularios.Name = "panelformularios";
            panelformularios.Size = new Size(880, 417);
            panelformularios.TabIndex = 2;
            // 
            // horayfecha
            // 
            horayfecha.Enabled = true;
            horayfecha.Tick += horayfecha_Tick;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 497);
            Controls.Add(panelformularios);
            Controls.Add(panelTitulo);
            Controls.Add(panelMenu);
            Name = "FrmMenuPrincipal";
            Text = "RCE";
            Load += FrmMenuPrincipal_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btncursos;
        private Button btnestudiantes;
        private Button btnProfesores;
        private Button btnregistrocursos;
        private PictureBox pictureBox1;
        private Panel panelTitulo;
        private Label lbltitulo;
        private Panel panelformularios;
        private System.Windows.Forms.Timer horayfecha;
        private Label label1;
    }
}