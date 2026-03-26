


public class Productos
{
    public string nombre {get; set;}
    public double precio {get; set;}
    public string descripcion {get; set;}

    public int cantidad {get; set;}


    public Productos(string nombre,double precio, string descripcion, int cantidad)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.descripcion = descripcion;
        this.cantidad = cantidad;
    }


}