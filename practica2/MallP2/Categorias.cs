namespace MallProject.Models
{
    public class Categorias
    {
        private string nombre;
        private List<Producto> listaProductos;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public List<Producto> ListaProductos => listaProductos;

        public Categorias(string nombre)
        {
            this.nombre = nombre;
            this.listaProductos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            listaProductos.Add(producto);
        }

        public void EliminarProducto(Producto producto)
        {
            listaProductos.Remove(producto);
        }

        public int CantidadProductos()
        {
            return listaProductos.Count;
        }
    }
}