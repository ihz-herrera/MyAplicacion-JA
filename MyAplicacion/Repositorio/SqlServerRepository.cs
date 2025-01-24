using MyAplicacion.Contratos;
using MyAplicacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAplicacion.Repositorio
{
    public class SqlServerRepository:IRepository
    {

        public void Guardar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Leer()
        {
            throw new NotImplementedException();
        }

        public bool Buscar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
