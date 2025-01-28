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
            if (Buscar(cliente.Id))
                throw new InvalidOperationException("Id Duplicado");

            var contexto = new Contexto();
            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();

        }

        public List<Cliente> Leer()
        {
            var contexto = new Contexto();
            return contexto.Clientes.ToList();
        }

        public bool Buscar(int id)
        {
            var contexto = new Contexto();
            return contexto.Clientes.Any(x => x.Id == id);
        }

    }
}
