using MyAplicacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAplicacion.Contratos
{
    internal interface IRepository
    {
        void Guardar(Cliente cliente);
        List<Cliente> Leer();
        bool Buscar(int id);
    }
}
