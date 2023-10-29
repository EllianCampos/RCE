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
    public partial class FrmCurso : Form
    {
        LogicaCursos logicaCursos = new LogicaCursos();
        public int idCurso;

        public FrmCurso()
        {
            InitializeComponent();
        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {
            Curso curso = logicaCursos.ObtenerCurso(idCurso);
            lblNombreCurso.Text = $"Curso: {curso.Nombre}";
        }
    }
}
