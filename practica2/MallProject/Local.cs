using MallProject.Interfaces;

namespace MallProject.Models
{
    public class Local : IGestion
    {
        private string nombre;
        private List<Categorias> listaCategorias;
        private Caja caja; // Composición: la Caja se crea y destruye con el Local

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public List<Categorias> ListaCategorias => listaCategorias;
        public Caja Caja => caja;

        public Local(string nombre, int numeroDeCaja)
        {
            this.nombre = nombre;
            this.listaCategorias = new List<Categorias>();
            this.caja = new Caja(numeroDeCaja);
        }

        // ---- IGestion ----

        public void AgregarProducto(Producto producto, string nombreCategoria)
        {
            Categorias cat = listaCategorias.Find(c => c.Nombre == nombreCategoria);
            if (cat != null)
            {
                cat.AgregarProducto(producto);
                Console.WriteLine($"Producto '{producto.Descripcion}' agregado en categoría '{nombreCategoria}'.");
            }
            else
            {
                Console.WriteLine($"Categoría '{nombreCategoria}' no encontrada.");
            }
        }

        public void EliminarProducto(Producto producto)
        {
            foreach (var cat in listaCategorias)
            {
                if (cat.ListaProductos.Contains(producto))
                {
                    cat.EliminarProducto(producto);
                    Console.WriteLine($"Producto '{producto.Descripcion}' eliminado de '{nombre}'.");
                    return;
                }
            }
            Console.WriteLine("Producto no encontrado en este local.");
        }

        public int CantidadProdByCategoria(string nombreCategoria)
        {
            Categorias cat = listaCategorias.Find(c => c.Nombre == nombreCategoria);
            if (cat != null)
                return cat.CantidadProductos();

            Console.WriteLine($"Categoría '{nombreCategoria}' no encontrada.");
            return 0;
        }

        // ---- Gestión de categorías ----

        public void AgregarCategoria(Categorias categoria)
        {
            listaCategorias.Add(categoria);
        }
    }
}