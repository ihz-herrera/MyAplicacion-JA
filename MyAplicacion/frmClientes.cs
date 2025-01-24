using MyAplicacion.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAplicacion
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                var cliente = new Cliente(
                int.Parse(txtId.Text),
                txtNombre.Text,
                txtApellido.Text,
                int.Parse(txtEdad.Text),
                txtDireccion.Text
                );

                var db = new TxtDatabase();
                db.Guardar(cliente);
                MessageBox.Show("Cliente guardado");

                InicializarControles();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Error inesperado. Comuniquese con su departamento de soporte");

            }

        }

        private void InicializarControles()
        {
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }
    }
}
