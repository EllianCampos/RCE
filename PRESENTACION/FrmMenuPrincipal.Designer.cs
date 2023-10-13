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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            panelMenu = new Panel();
            btnregistrocursos = new Button();
            btnestudiantes = new Button();
            btnProfesores = new Button();
            btncursos = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
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
            // btnregistrocursos
            // 
            btnregistrocursos.Dock = DockStyle.Top;
            btnregistrocursos.FlatAppearance.BorderSize = 0;
            btnregistrocursos.FlatStyle = FlatStyle.Flat;
            btnregistrocursos.ForeColor = Color.Gainsboro;
            btnregistrocursos.Image = (Image)resources.GetObject("btnregistrocursos.Image");
            btnregistrocursos.ImageAlign = ContentAlignment.MiddleLeft;
            btnregistrocursos.Location = new Point(0, 279);
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
            btnestudiantes.Location = new Point(0, 219);
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
            btnProfesores.Location = new Point(0, 159);
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
            btncursos.Location = new Point(0, 99);
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
            panelLogo.Size = new Size(220, 99);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(panelMenu);
            Name = "FrmMenuPrincipal";
            Text = "Form1";
            Load += FrmMenuPrincipal_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}