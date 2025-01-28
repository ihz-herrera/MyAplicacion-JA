using Consultorio.Applicacion.Fabricas.Enumeradores;
using MyAplicacion.Entidades;
using MyAplicacion.Fabricas;
using MyAplicacion.Repositorio;
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

        private DbTypeEnum baseDatos = DbTypeEnum.Txt;

        public frmClientes(DbTypeEnum baseDatos)
        {
            InitializeComponent();
            this.baseDatos = baseDatos;
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



                var db = RepoFactory.CrearRepository(baseDatos);

                db.Guardar(cliente);


                //if (baseDatos == "txt")
                //{
                //    var db = new TxtRepository();
                //    db.GuardarClienteTxt(cliente);
                //}
                //else if (baseDatos == "sqlite")
                //{
                //    var dbsqlite = new SqliteRepository();
                //    dbsqlite.GuardarClienteSqlite(cliente);
                //}
                //else if (baseDatos == "sqlserver")
                //    db.GuardarClienteSqlServer(cliente);



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
