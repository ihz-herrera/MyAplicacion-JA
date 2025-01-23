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
    public partial class frmCitas : Form
    {
        public frmCitas()
        {
            InitializeComponent();
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            //leer el archivo
            using (var sw = new StreamReader(@"c:\BaseDatos\clientes.txt"))
            {
                // validar que el id no exista en la lista de clientes en el archivo

                while (!sw.EndOfStream)
                {
                    var linea = sw.ReadLine();

                    var campos = linea.Split(",");

                    //llenar combo de clientes
                    cmbClientes.Items.Add(campos[1]);


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //leer el archivo
            using (var sw = new StreamReader(@"c:\BaseDatos\clientes.txt"))
            {
                // validar que el id no exista en la lista de clientes en el archivo

                while (!sw.EndOfStream)
                {
                    var linea = sw.ReadLine();

                    var campos = linea.Split(",");

                    if (cmbClientes.Text == campos[1])
                    {
                        lblNombre.Text = campos[1];
                        lblApellido.Text = campos[2];
                        lblDireccion.Text = campos[3];
                        return;
                    }
                }
            }
        }
    }
}
