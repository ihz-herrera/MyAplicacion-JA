namespace MyAplicacion
{
    public partial class FrmConsultorio : Form
    {
        public FrmConsultorio()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var frmClientes = new frmClientes();
            frmClientes.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            var frmCitas = new frmCitas();

            frmCitas.Show();
        }
    }
}
