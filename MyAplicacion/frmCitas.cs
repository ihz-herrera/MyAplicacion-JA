using MyAplicacion.Entidades;

namespace MyAplicacion;

public partial class frmCitas : Form
{
    public frmCitas()
    {
        InitializeComponent();
    }

    private void frmCitas_Load(object sender, EventArgs e)
    {

        var db = new TxtDatabase();
        var clientes = db.Leer();
        cmbClientes.DataSource = clientes;
        cmbClientes.DisplayMember = "Nombre";

    }

    private void button1_Click(object sender, EventArgs e)
    {
        if(cmbClientes.SelectedItem == null)
            return;

        var cliente = (Cliente)cmbClientes.SelectedItem;

        lblApellido.Text = cliente.Apellido;
        lblDireccion.Text = cliente.Direccion;
        lblNombre.Text = cliente.Nombre;
    }
}
