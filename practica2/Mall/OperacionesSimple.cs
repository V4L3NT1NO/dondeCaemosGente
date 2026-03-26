public class OperacionesSimple : IOperaciones
{
    public void agregarProductoAFactura(Categoria categoria, Productos producto, List<Productos> factura)
    {
        if (categoria == null || producto == null || factura == null)
        {
            Console.WriteLine("Error: datos invalidos para agregar a factura.");
            return;
        }
        if(producto.cantidad == 0){
            Console.WriteLine($"Producto '{producto.nombre}' agotado, no se puede agregar a factura.");
            return;
        }
        factura.Add(producto);
        Console.WriteLine($"Producto '{producto.nombre}' agregado a factura.");
    }

    public void eliminarProductoDeFactura(Categoria categoria, Productos producto, List<Productos> factura)
    {
        if (categoria == null || producto == null || factura == null)
        {
            Console.WriteLine("Error: datos invalidos para eliminar de factura.");
            return;
        }
        if (factura.Remove(producto))
        {
            Console.WriteLine($"Producto '{producto.nombre}' eliminado de factura.");
        }
        else
        {
            Console.WriteLine("Producto no encontrado en factura.");
        }
    }

    public void comprarProductos(List<Productos> factura)
    {
        if (factura == null)
        {
            Console.WriteLine("Error: factura nula.");
            return;
        }
        Console.WriteLine("Se compró:");
        foreach (var producto in factura)
        {
            Console.WriteLine($" - {producto.nombre}");
        }
        Console.WriteLine("Gracias por su compra.");
        factura.Clear();
    }

    public void cancelarCompra(List<Productos> factura)
    {
        if (factura == null)
        {
            Console.WriteLine("Error: factura nula.");
            return;
        }
        factura.Clear();
        Console.WriteLine("Compra cancelada, factura limpiada.");
    }
}