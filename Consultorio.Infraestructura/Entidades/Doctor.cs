using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Infraestructura.Entidades
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Doctor(int id, string nombre, string direccion, string telefono, string email)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;

            Validar(this);
        }

        private void Validar(Doctor doctor)
        {
            if (string.IsNullOrEmpty(doctor.Nombre))
                throw new InvalidOperationException("El nombre del proveedor es requerido");

            if (string.IsNullOrEmpty(doctor.Direccion))
                throw new InvalidOperationException("La dirección del proveedor es requerida");

            if (string.IsNullOrEmpty(Email))
                throw new InvalidOperationException("El email del proveedor es requerido");

            if(doctor.Id <= 0)
                throw new InvalidOperationException("El id del proveedor es requerido");

        }
    }
}
