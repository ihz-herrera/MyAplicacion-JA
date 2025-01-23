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
            //guardar cliente en un archivo de texto
            var id = txtId.Text;
            var nombre = txtNombre.Text;
            var apellido = txtApellido.Text;
            var direccion = txtDireccion.Text;

            if(!(int.Parse(id) <= 0 || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(direccion)))
            {


                //leer el archivo
                using (var sw = new StreamReader(@"c:\BaseDatos\clientes.txt"))
                {
                    // validar que el id no exista en la lista de clientes en el archivo

                    while(  !sw.EndOfStream)
                    {
                        var linea = sw.ReadLine();

                        var campos = linea.Split(",");

                        if (campos[0]== id)
                        {
                            MessageBox.Show("Id Duplicado");
                            return;
                        }
                    }
                }


                using (var sw = new System.IO.StreamWriter(@"c:\BaseDatos\clientes.txt", true))
                {
                    sw.WriteLine($"{id},{nombre},{apellido},{direccion}");
                }

            }
            else
            {
                MessageBox.Show("Valores ingresados incorrectos.");
            }




        }
    }
}
