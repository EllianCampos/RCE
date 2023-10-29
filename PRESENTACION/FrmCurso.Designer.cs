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
            lblNombreCurso = new Label();
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
            // FrmCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNombreCurso);
            Name = "FrmCurso";
            Text = "FrmCurso";
            Load += FrmCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreCurso;
    }
}