using Consultorio.Applicacion.Fabricas.Enumeradores;
using MyAplicacion.Entidades;
using MyAplicacion.Fabricas;

namespace MyAplicacion;

public partial class frmCitas : Form
{
    private DbTypeEnum _dbType;

    public frmCitas(DbTypeEnum dbType)
    {
        InitializeComponent();
        _dbType = dbType;
    }

    private void frmCitas_Load(object sender, EventArgs e)
    {

        var db = RepoFactory.CrearRepository(_dbType);
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
