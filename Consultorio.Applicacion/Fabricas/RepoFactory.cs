using Consultorio.Applicacion.Fabricas.Enumeradores;
using MyAplicacion.Contratos;
using MyAplicacion.Repositorio;

namespace MyAplicacion.Fabricas
{
    public class RepoFactory
    {

        public static IRepository CrearRepository(DbTypeEnum tipo)
        {
            switch (tipo)
            {
                case  DbTypeEnum.Txt:
                    return new TxtRepository();
                case DbTypeEnum.Sqlite :
                    return new SqliteRepository();
                case DbTypeEnum.SqlServer:
                    return new SqlServerRepository();
                default:
                    throw new InvalidOperationException("Tipo de repositorio no soportado");
            }
        }   
    }
}
