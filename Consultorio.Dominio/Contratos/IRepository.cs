using MyAplicacion.Entidades;
using System.Collections.Generic;

namespace MyAplicacion.Contratos
{
    public interface IRepository
    {
        void Guardar(Cliente cliente);
        List<Cliente> Leer();
        bool Buscar(int id);
    }
}
