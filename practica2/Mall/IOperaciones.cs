public interface IOperaciones
{
    public void agregarProductoAFactura(Categoria categoria,Productos producto, List<Productos> factura);

    public void eliminarProductoDeFactura(Categoria categoria,Productos producto, List<Productos> factura);

    public void comprarProductos(List<Productos> factura);
    
    public void cancelarCompra(List<Productos> factura);


}