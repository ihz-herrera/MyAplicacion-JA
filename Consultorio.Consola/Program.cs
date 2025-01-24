// See https://aka.ms/new-console-template for more information
using MyAplicacion.Entidades;
using MyAplicacion.Fabricas;

Console.WriteLine("Hello, World!");


var db = RepoFactory.CrearRepository("txt");

var cliente =  new Cliente(5, "Juan", "Perez", 30, "Calle 123");

db.Guardar(cliente);


var clientes = db.Leer();

foreach (var item in clientes)
{
    Console.WriteLine(item.Nombre);
}
