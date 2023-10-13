using System.Windows.Forms;
using LOGICA;
using ENTIDADES;

namespace PRESENTACION
{
    public partial class FrmMenuPrincipal : Form
    {
        LogicaMenuPrincipal logicaMenuPrincipal = new LogicaMenuPrincipal();

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = logicaMenuPrincipal.Test();
        }
    }
}