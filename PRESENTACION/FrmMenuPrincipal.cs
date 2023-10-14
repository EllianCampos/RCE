using System.Windows.Forms;
using LOGICA;
using ENTIDADES;

namespace PRESENTACION
{
    public partial class FrmMenuPrincipal : Form
    {
        LogicaMenuPrincipal logicaMenuPrincipal = new LogicaMenuPrincipal();
        //Campos
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activarformulario;
        //Constructor
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        private Color SeleccionarTemaColor()
        {
            int index = random.Next(TemasdeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(TemasdeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = TemasdeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SeleccionarTemaColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panelTitulo.BackColor = color;
                    panelLogo.BackColor = TemasdeColor.ChangeColorBrightness(color, -0.3);
                }

            }
        }
        private void AbrirFormularios(Form childForm, object btnSender)
        {
            if (activarformulario != null)
            {
                activarformulario.Close();
            }
            ActivateButton(btnSender);
            activarformulario = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelformularios.Controls.Add(childForm);
            this.panelformularios.Tag = childForm; ;
            childForm.BringToFront();
            childForm.Show();
            lbltitulo.Text = childForm.Text;
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;

                }
            }
        }

        private void btncursos_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FCursos(),sender);
           
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnestudiantes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnregistrocursos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}