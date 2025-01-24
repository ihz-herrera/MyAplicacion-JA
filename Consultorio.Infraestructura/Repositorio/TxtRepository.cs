using MyAplicacion.Contratos;
using MyAplicacion.Entidades;

namespace MyAplicacion.Repositorio;

public class TxtRepository:IRepository
{
    private const string _path = @"c:\BaseDatos\consultorio\clientes.txt";

    public void Guardar(Cliente cliente)
    {
        //validar que el archivo existe
        if (Buscar(cliente.Id))
            throw new InvalidOperationException("Id Duplicado");

        using (var sw = new StreamWriter(_path, true))
        {
            sw.WriteLine(cliente.ToString());
        }
    }

    public List<Cliente> Leer()
    {

        var list = new List<Cliente>();

        //validar que el archivo existe
        if (!File.Exists(_path))
        {
            Console.WriteLine("No existe el archivo de clientes");
            return null;
        }
        //leer el archivo
        using (var sw = new StreamReader(_path))
        {
            // validar que el id no exista en la lista de clientes en el archivo
            while (!sw.EndOfStream)
            {
                var linea = sw.ReadLine();
                var campos = linea.Split(",");

                var cliente = new Cliente(
                    int.Parse(campos[0]),
                    campos[1],
                    campos[2],
                    int.Parse(campos[3]),
                    campos[4]
                )
                ;

                list.Add(cliente);
            }
        }
        return list;
    }

    public bool Buscar(int id)
    {
        var clientes = Leer();

        if (clientes.Any(x => x.Id == id))
            return true;

        return false;

        //foreach (var cliente in clientes)
        //{
        //    if (cliente.Id == id)
        //    {
        //        return true;
        //    }
        //}


    }

}
