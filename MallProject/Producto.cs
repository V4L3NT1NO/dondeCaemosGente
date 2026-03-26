namespace MallProject.Models
{
    public class Producto
    {
        private int precio;
        private string descripcion;
        private int cantidad;

        public int Precio
        {
            get => precio;
            set => precio = value;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }

        public string Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }

        public Producto(int precio, string descripcion, int cantidad)
        {
            this.precio = precio;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
        }

        //Formato de como se mostrarán los productos
        public override string ToString()
        {
            return $"[{descripcion} | Precio: {precio} | Cantidad: {cantidad}]";
        }
    }
}