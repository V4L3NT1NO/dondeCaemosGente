

public class Categoria
{
    public string nombre { get; set; }
    public List<Productos> listaProductos { get; set; }

    public Categoria(string nombre)
    {
        this.nombre = nombre;
        this.listaProductos = new List<Productos>();
    }
}
