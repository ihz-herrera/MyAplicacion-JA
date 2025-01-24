namespace MyAplicacion
{
    public partial class FrmConsultorio : Form
    {
        private string baseDatos = "txt";
        public FrmConsultorio()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var frmClientes = new frmClientes(baseDatos);
            frmClientes.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            var frmCitas = new frmCitas(baseDatos);

            frmCitas.Show();
        }
    }
}
