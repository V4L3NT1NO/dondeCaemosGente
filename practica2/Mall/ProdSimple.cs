public class SimpleGestion : IGestion
{
    public void agregarCategoria(List<Categoria> categorias, Categoria categoria)
    {
        if (categoria == null)
        {
            Console.WriteLine("No se pudo completar: categoria nula.");
            return;
        }
        if (categoria.listaProductos == null) categoria.listaProductos = new List<Productos>();
        categorias.Add(categoria);
        Console.WriteLine($"Categoria '{categoria.nombre}' agregada.");
    }

    public void eliminarCategoria(List<Categoria> categorias, Categoria categoria)
    {
        if (categoria == null)
        {
            Console.WriteLine("No se pudo completar: categoria nula.");
            return;
        }
        if (categorias.Remove(categoria))
        {
            Console.WriteLine($"Categoria '{categoria.nombre}' eliminada.");
        }
        else
        {
            Console.WriteLine($"Categoria '{categoria.nombre}' no se encontró.");
        }
        Console.WriteLine($"Categoria '{categoria.nombre}' eliminada.");
    }

    public void agregarProducto(Categoria categoria, Productos producto)
    {
        if (categoria == null)
        {
            Console.WriteLine("No se pudo completar: categoria nula.");
            return;
        }
        if (producto == null)
        {
            Console.WriteLine("No se pudo completar: producto nulo.");
            return;
        }

        if (categoria.listaProductos == null) categoria.listaProductos = new List<Productos>();
        categoria.listaProductos.Add(producto);
        Console.WriteLine($"Producto '{producto.nombre}' agregado a la categoria '{categoria.nombre}'.");
    }

    public void eliminarProducto(Categoria categoria, Productos producto)
    {
        if (categoria == null)
        {
            Console.WriteLine("No se pudo completar: categoria nula.");
            return;
        }
        if (producto == null)
        {
            Console.WriteLine("No se pudo completar: producto nulo.");
            return;
        }

        if (categoria.listaProductos != null && categoria.listaProductos.Remove(producto))
        {
            Console.WriteLine($"Producto '{producto.nombre}' eliminado de la categoria '{categoria.nombre}'.");
        }
        else
        {
            Console.WriteLine($"Producto '{producto.nombre}' no se encontró en la categoria '{categoria.nombre}'.");
        }
    }

    public int cantidadProdPorCategoria(Categoria categoria)
    {
        if (categoria == null) throw new ArgumentNullException(nameof(categoria));
        return categoria.listaProductos?.Count ?? 0;
    }

    public void agregarCaja(Local local, Caja caja)
    {
        if (local == null)
        {
            Console.WriteLine("No se pudo completar: local nulo.");
            return;
        }
        if (caja == null)
        {
            Console.WriteLine("No se pudo completar: caja nula.");
            return;
        }

        if (local.cajas == null) local.cajas = new List<Caja>();
        local.cajas.Add(caja);
        Console.WriteLine($"Caja '{caja.numero}' agregada al local '{local.nombre}'.");
    }

    public void eliminarCaja(Local local, Caja caja)
    {
        if (local == null)
        {
            Console.WriteLine("No se pudo completar: local nulo.");
            return;
        }
        if (caja == null)
        {
            Console.WriteLine("No se pudo completar: caja nula.");
            return;
        }

        if (local.cajas != null && local.cajas.Remove(caja))
        {
            Console.WriteLine($"Caja '{caja.numero}' eliminada del local '{local.nombre}'.");
        }
        else
        {
            Console.WriteLine($"Caja '{caja.numero}' no se encontró en el local '{local.nombre}'.");
        }
    }
}