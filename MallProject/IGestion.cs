namespace MallProject.Interfaces
{
    public interface IGestion
    {
        void AgregarProducto(Producto producto, string nombreCategoria);
        void EliminarProducto(Producto producto);
        int CantidadProdByCategoria(string nombreCategoria);
    }
}