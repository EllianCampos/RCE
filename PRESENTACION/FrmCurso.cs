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
        LogicaEvaluaciones logicaEvaluaciones = new LogicaEvaluaciones();
        public int idCurso;

        string nombreEvaluacion;
        int puntosEvaluacion;
        int porcentajeEvaluacion;

        int idEvaluacionSeleccionada;
        string calculoAuto;

        public FrmCurso()
        {
            InitializeComponent();
        }

        public void MostrarEvaluaciones()
        {
            dgvEvaluaciones.DataSource = null;
            dgvEvaluaciones.DataSource = logicaEvaluaciones.ObtenerEvaluacionesPorCurso(idCurso);
            dgvEvaluaciones.Columns[0].Visible = false;
            dgvEvaluaciones.Columns[4].HeaderText = "Cálculo Automático";
            dgvEvaluaciones.Columns[5].Visible = false;
        }

        public bool ValidarCamposEvaluaciones()
        {
            bool errorFlag = false;
            errorProvider1.Clear();

            if (txtNombreEvaluacion.Text.Trim().Equals(""))
            {
                errorFlag = true;
                errorProvider1.SetError(txtNombreEvaluacion, "Campo requerido");
            }
            nombreEvaluacion = txtNombreEvaluacion.Text;

            if (!Int32.TryParse(txtPuntosEvaluacion.Text, out puntosEvaluacion))
            {
                errorFlag = true;
                errorProvider1.SetError(txtPuntosEvaluacion, "Debe ser un número entero");
            }

            if (!Int32.TryParse(txtPorcentajeEvaluacion.Text, out porcentajeEvaluacion))
            {
                errorFlag = true;
                errorProvider1.SetError(txtPorcentajeEvaluacion, "Debe ser un número entero");
            }

            if (errorFlag) return false;
            else return true;
        }

        public void LimpiarCamposEvaluaciones()
        {
            txtNombreEvaluacion.Clear();
            txtPuntosEvaluacion.Clear();
            txtPorcentajeEvaluacion.Clear();
        }

        public void MostrarCamposEvaluaciones()
        {
            txtNombreEvaluacion.Visible = true;
            txtPuntosEvaluacion.Visible = true;
            txtPorcentajeEvaluacion.Visible = true;
            lblNombreEvaluacion.Visible = true;
            lblPuntosEvaluacion.Visible = true;
            lblPorcentajeEvaluacion.Visible = true;
            chkCalcAuto.Visible = true;
            btnHelp.Visible = true;
        }

        public void OcultarCamposEvaluaciones()
        {
            txtNombreEvaluacion.Visible = false;
            txtPuntosEvaluacion.Visible = false;
            txtPorcentajeEvaluacion.Visible = false;
            lblNombreEvaluacion.Visible = false;
            lblPuntosEvaluacion.Visible = false;
            lblPorcentajeEvaluacion.Visible = false;
            chkCalcAuto.Visible = false;
            btnHelp.Visible = false;
            btnAgregarEvaluacion.Visible = true;
            btnEditarEvaluacion.Visible = true;
            btnEliminarEvaluacion.Visible = true;
        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {
            Curso curso = logicaCursos.ObtenerCurso(idCurso);
            lblNombreCurso.Text = $"Curso: {curso.Nombre}";
            MostrarEvaluaciones();
            OcultarCamposEvaluaciones();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Utiliza el cálculo automático para evaluaciones como la asistencia cuya cantidad puede variar, con esta funcionalidad el porcentaje se reparte entre las evaluaciones del mismo tipo. " +
                "\nTambién puedes utilizarlo para las tareas si no sabes cuantas vas a asignar.",
                "Información Cálculo automático",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question
                );
        }

        private void btnAgregarEvaluacion_Click(object sender, EventArgs e)
        {
            if (txtNombreEvaluacion.Visible == false)
            {
                MostrarCamposEvaluaciones();
                txtNombreEvaluacion.Focus();
                btnEditarEvaluacion.Visible = false;
                btnEliminarEvaluacion.Visible = false;
                return;
            }

            if (!ValidarCamposEvaluaciones()) return;

            calculoAuto = "NO";
            if (chkCalcAuto.Checked) calculoAuto = "SI";

            if (!logicaEvaluaciones.CrearEvaluacion(new Evaluacion(nombreEvaluacion, puntosEvaluacion, porcentajeEvaluacion, calculoAuto, idCurso)))
                MessageBox.Show("Ha ocurrido un error al crear la evaluación", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);

            MostrarEvaluaciones();
            LimpiarCamposEvaluaciones();
            OcultarCamposEvaluaciones();
            btnEditarEvaluacion.Visible = true;
            btnEliminarEvaluacion.Visible = true;
        }

        private void btnEditarEvaluacion_Click(object sender, EventArgs e)
        {
            if (txtNombreEvaluacion.Visible == false)
            {
                MostrarCamposEvaluaciones();
                btnAgregarEvaluacion.Visible = false;
                btnEliminarEvaluacion.Visible = false;
                chkCalcAuto.Visible = false;
                btnHelp.Visible = false;

                idEvaluacionSeleccionada = Convert.ToInt32(dgvEvaluaciones.SelectedRows[0].Cells[0].Value);
                txtNombreEvaluacion.Text = dgvEvaluaciones.SelectedRows[0].Cells[1].Value.ToString();
                txtPuntosEvaluacion.Text = dgvEvaluaciones.SelectedRows[0].Cells[2].Value.ToString();
                txtPorcentajeEvaluacion.Text = dgvEvaluaciones.SelectedRows[0].Cells[3].Value.ToString();
                calculoAuto = dgvEvaluaciones.SelectedRows[0].Cells[4].Value.ToString();
                if (calculoAuto == "SI") chkCalcAuto.Checked = true;
                else chkCalcAuto.Checked = false;

                return;
            }

            if (!ValidarCamposEvaluaciones()) return;

            calculoAuto = "NO";
            if (chkCalcAuto.Checked) calculoAuto = "SI";

            if (!logicaEvaluaciones.ActualizarEvaluacion(new Evaluacion(idEvaluacionSeleccionada, nombreEvaluacion, 
                puntosEvaluacion, porcentajeEvaluacion, calculoAuto, idCurso)))
                MessageBox.Show("Ha ocurrido un error al editar la evaluación", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            MostrarEvaluaciones();
            LimpiarCamposEvaluaciones();
            OcultarCamposEvaluaciones();
            btnAgregarEvaluacion.Visible = true;
            btnEliminarEvaluacion.Visible = true;
        }

        private void FrmCurso_Click(object sender, EventArgs e)
        {
            LimpiarCamposEvaluaciones();
            OcultarCamposEvaluaciones();
        }
    }
}
