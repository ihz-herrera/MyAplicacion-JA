using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAplicacion.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }



        public Cliente(int id, string nombre, string apellido, int edad, string direccion)
        {

           

            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Direccion = direccion; 
            
            ValidarCliente(this);


        }

        private bool ValidarCliente(Cliente cliente)
        {
            if (cliente.Id <= 0 || string.IsNullOrEmpty(cliente.Nombre) || cliente.Edad < 18 || string.IsNullOrEmpty(cliente.Apellido) ||
                string.IsNullOrEmpty(cliente.Direccion))
            {
                throw new InvalidOperationException("Datos invalidos");
            }
            return true;
        }



        public override string ToString()
        {
            return $"{Id},{Nombre},{Apellido},{Edad},{Direccion}";
        }
    }
}
