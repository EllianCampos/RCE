using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGICA;
using ENTIDADES;

namespace PRESENTACION
{
    public partial class FrmCursos : Form
    {
        LogicaCursos logicaCursos = new LogicaCursos();

        public FrmCursos()
        {
            InitializeComponent();
        }

        private void AjustarAnchoBotones()
        {
            int maxButtonWidth = flpCursos.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;

            foreach (Control control in flpCursos.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Width = maxButtonWidth - (button.Margin.Horizontal);
                }
            }
        }


        public void MostrarCursos()
        {
            List<Curso> listaCursos = logicaCursos.ObtenerCursos();
            foreach (Curso curso in listaCursos)
            {
                Button button = new Button();
                button.Text = curso.Nombre;
                button.Padding = new Padding(15);
                button.AutoSize = true;
                button.Margin = new Padding(10);
                button.Size = new Size(flpCursos.ClientSize.Width - (button.Margin.Horizontal), button.Height);

                button.Click += (sender, e) =>
                {
                    if (sender is Button clickedButton)
                    {
                        FrmCurso frmCurso = new FrmCurso();
                        frmCurso.idCurso = curso.IdCurso;
                        frmCurso.ShowDialog();
                    }
                };

                flpCursos.Controls.Add(button);
            }
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            MostrarCursos();
            AjustarAnchoBotones();
        }

        private void flpCursos_SizeChanged(object sender, EventArgs e)
        {
            AjustarAnchoBotones();
        }
    }
}
