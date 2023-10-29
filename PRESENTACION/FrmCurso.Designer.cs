namespace PRESENTACION
{
    partial class FrmCurso
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
            components = new System.ComponentModel.Container();
            lblNombreCurso = new Label();
            label1 = new Label();
            dgvEvaluaciones = new DataGridView();
            btnEditarEvaluacion = new Button();
            txtNombreEvaluacion = new TextBox();
            btnAgregarEvaluacion = new Button();
            btnEliminarEvaluacion = new Button();
            lblNombreEvaluacion = new Label();
            lblPuntosEvaluacion = new Label();
            lblPorcentajeEvaluacion = new Label();
            chkCalcAuto = new CheckBox();
            txtPuntosEvaluacion = new TextBox();
            txtPorcentajeEvaluacion = new TextBox();
            helpProvider1 = new HelpProvider();
            btnHelp = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblNombreCurso
            // 
            lblNombreCurso.AutoSize = true;
            lblNombreCurso.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreCurso.Location = new Point(12, 9);
            lblNombreCurso.Name = "lblNombreCurso";
            lblNombreCurso.Size = new Size(66, 17);
            lblNombreCurso.TabIndex = 0;
            lblNombreCurso.Text = "curso info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(82, 17);
            label1.TabIndex = 2;
            label1.Text = "Evaluaciones";
            // 
            // dgvEvaluaciones
            // 
            dgvEvaluaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvaluaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvaluaciones.Location = new Point(12, 93);
            dgvEvaluaciones.Name = "dgvEvaluaciones";
            dgvEvaluaciones.RowTemplate.Height = 25;
            dgvEvaluaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvaluaciones.Size = new Size(776, 150);
            dgvEvaluaciones.TabIndex = 3;
            // 
            // btnEditarEvaluacion
            // 
            btnEditarEvaluacion.Anchor = AnchorStyles.Top;
            btnEditarEvaluacion.Image = Properties.Resources.edit;
            btnEditarEvaluacion.Location = new Point(134, 53);
            btnEditarEvaluacion.Name = "btnEditarEvaluacion";
            btnEditarEvaluacion.Size = new Size(28, 28);
            btnEditarEvaluacion.TabIndex = 16;
            btnEditarEvaluacion.UseVisualStyleBackColor = true;
            btnEditarEvaluacion.Click += btnEditarEvaluacion_Click;
            // 
            // txtNombreEvaluacion
            // 
            txtNombreEvaluacion.Anchor = AnchorStyles.Top;
            txtNombreEvaluacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreEvaluacion.Location = new Point(209, 56);
            txtNombreEvaluacion.Name = "txtNombreEvaluacion";
            txtNombreEvaluacion.Size = new Size(159, 25);
            txtNombreEvaluacion.TabIndex = 15;
            // 
            // btnAgregarEvaluacion
            // 
            btnAgregarEvaluacion.Anchor = AnchorStyles.Top;
            btnAgregarEvaluacion.Image = Properties.Resources.add_circle;
            btnAgregarEvaluacion.Location = new Point(100, 53);
            btnAgregarEvaluacion.Name = "btnAgregarEvaluacion";
            btnAgregarEvaluacion.Size = new Size(28, 28);
            btnAgregarEvaluacion.TabIndex = 14;
            btnAgregarEvaluacion.UseVisualStyleBackColor = true;
            btnAgregarEvaluacion.Click += btnAgregarEvaluacion_Click;
            // 
            // btnEliminarEvaluacion
            // 
            btnEliminarEvaluacion.Anchor = AnchorStyles.Top;
            btnEliminarEvaluacion.Image = Properties.Resources.trash;
            btnEliminarEvaluacion.Location = new Point(168, 53);
            btnEliminarEvaluacion.Name = "btnEliminarEvaluacion";
            btnEliminarEvaluacion.Size = new Size(28, 28);
            btnEliminarEvaluacion.TabIndex = 13;
            btnEliminarEvaluacion.UseVisualStyleBackColor = true;
            // 
            // lblNombreEvaluacion
            // 
            lblNombreEvaluacion.AutoSize = true;
            lblNombreEvaluacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreEvaluacion.Location = new Point(209, 36);
            lblNombreEvaluacion.Name = "lblNombreEvaluacion";
            lblNombreEvaluacion.Size = new Size(57, 17);
            lblNombreEvaluacion.TabIndex = 17;
            lblNombreEvaluacion.Text = "Nombre";
            // 
            // lblPuntosEvaluacion
            // 
            lblPuntosEvaluacion.AutoSize = true;
            lblPuntosEvaluacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPuntosEvaluacion.Location = new Point(398, 36);
            lblPuntosEvaluacion.Name = "lblPuntosEvaluacion";
            lblPuntosEvaluacion.Size = new Size(47, 17);
            lblPuntosEvaluacion.TabIndex = 18;
            lblPuntosEvaluacion.Text = "Puntos";
            // 
            // lblPorcentajeEvaluacion
            // 
            lblPorcentajeEvaluacion.AutoSize = true;
            lblPorcentajeEvaluacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPorcentajeEvaluacion.Location = new Point(499, 35);
            lblPorcentajeEvaluacion.Name = "lblPorcentajeEvaluacion";
            lblPorcentajeEvaluacion.Size = new Size(69, 17);
            lblPorcentajeEvaluacion.TabIndex = 19;
            lblPorcentajeEvaluacion.Text = "Porcentaje";
            // 
            // chkCalcAuto
            // 
            chkCalcAuto.AutoSize = true;
            chkCalcAuto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chkCalcAuto.Location = new Point(622, 56);
            chkCalcAuto.Name = "chkCalcAuto";
            chkCalcAuto.Size = new Size(138, 21);
            chkCalcAuto.TabIndex = 20;
            chkCalcAuto.Text = "Calculo automatico";
            chkCalcAuto.UseVisualStyleBackColor = true;
            // 
            // txtPuntosEvaluacion
            // 
            txtPuntosEvaluacion.Anchor = AnchorStyles.Top;
            txtPuntosEvaluacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPuntosEvaluacion.Location = new Point(398, 55);
            txtPuntosEvaluacion.Name = "txtPuntosEvaluacion";
            txtPuntosEvaluacion.Size = new Size(69, 25);
            txtPuntosEvaluacion.TabIndex = 21;
            // 
            // txtPorcentajeEvaluacion
            // 
            txtPorcentajeEvaluacion.Anchor = AnchorStyles.Top;
            txtPorcentajeEvaluacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPorcentajeEvaluacion.Location = new Point(499, 55);
            txtPorcentajeEvaluacion.Name = "txtPorcentajeEvaluacion";
            txtPorcentajeEvaluacion.Size = new Size(69, 25);
            txtPorcentajeEvaluacion.TabIndex = 22;
            // 
            // btnHelp
            // 
            btnHelp.Anchor = AnchorStyles.Top;
            btnHelp.Image = Properties.Resources.help24;
            btnHelp.Location = new Point(757, 54);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(28, 28);
            btnHelp.TabIndex = 24;
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHelp);
            Controls.Add(txtPorcentajeEvaluacion);
            Controls.Add(txtPuntosEvaluacion);
            Controls.Add(chkCalcAuto);
            Controls.Add(lblPorcentajeEvaluacion);
            Controls.Add(lblPuntosEvaluacion);
            Controls.Add(lblNombreEvaluacion);
            Controls.Add(btnEditarEvaluacion);
            Controls.Add(txtNombreEvaluacion);
            Controls.Add(btnAgregarEvaluacion);
            Controls.Add(btnEliminarEvaluacion);
            Controls.Add(dgvEvaluaciones);
            Controls.Add(label1);
            Controls.Add(lblNombreCurso);
            Name = "FrmCurso";
            Text = "FrmCurso";
            Load += FrmCurso_Load;
            Click += FrmCurso_Click;
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreCurso;
        private Label label1;
        private DataGridView dgvEvaluaciones;
        private Button btnEditarEvaluacion;
        private TextBox txtNombreEvaluacion;
        private Button btnAgregarEvaluacion;
        private Button btnEliminarEvaluacion;
        private Label lblNombreEvaluacion;
        private Label lblPuntosEvaluacion;
        private Label lblPorcentajeEvaluacion;
        private CheckBox chkCalcAuto;
        private TextBox txtPuntosEvaluacion;
        private TextBox txtPorcentajeEvaluacion;
        private HelpProvider helpProvider1;
        private Button btnHelp;
        private ErrorProvider errorProvider1;
    }
}