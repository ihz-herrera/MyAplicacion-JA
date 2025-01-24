using MyAplicacion.Contratos;
using MyAplicacion.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAplicacion.Fabricas
{
    internal class RepoFactory
    {

        public static IRepository CrearRepository(string tipo)
        {
            switch (tipo)
            {
                case "txt":
                    return new TxtRepository();
                case "sqlite":
                    return new SqliteRepository();
                case "sqlserver":
                    return new SqlServerRepository();
                default:
                    throw new InvalidOperationException("Tipo de repositorio no soportado");
            }
        }   
    }
}
