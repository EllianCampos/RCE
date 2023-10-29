namespace PRESENTACION
{
    partial class FrmCursos
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
            flpCursos = new FlowLayoutPanel();
            btnCrearCurso = new Button();
            SuspendLayout();
            // 
            // flpCursos
            // 
            flpCursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpCursos.AutoScroll = true;
            flpCursos.AutoScrollMargin = new Size(10, 0);
            flpCursos.FlowDirection = FlowDirection.TopDown;
            flpCursos.Location = new Point(196, 49);
            flpCursos.Name = "flpCursos";
            flpCursos.Size = new Size(408, 389);
            flpCursos.TabIndex = 0;
            flpCursos.WrapContents = false;
            flpCursos.SizeChanged += flpCursos_SizeChanged;
            // 
            // btnCrearCurso
            // 
            btnCrearCurso.BackColor = Color.Green;
            btnCrearCurso.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearCurso.ForeColor = SystemColors.ControlLight;
            btnCrearCurso.Location = new Point(196, 12);
            btnCrearCurso.Name = "btnCrearCurso";
            btnCrearCurso.Size = new Size(129, 31);
            btnCrearCurso.TabIndex = 1;
            btnCrearCurso.Text = "Crear curso";
            btnCrearCurso.UseVisualStyleBackColor = false;
            // 
            // Cursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrearCurso);
            Controls.Add(flpCursos);
            Name = "Cursos";
            Text = "Cursos";
            Load += Cursos_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpCursos;
        private Button btnCrearCurso;
    }
}