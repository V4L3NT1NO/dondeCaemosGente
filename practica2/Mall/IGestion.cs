public interface IGestion
{
    public void agregarCategoria(List<Categoria> categorias, Categoria categoria);
    public void eliminarCategoria(List<Categoria> categorias,Categoria categoria);

    public void agregarProducto(Categoria categoria, Productos producto);
    public void eliminarProducto(Categoria categoria, Productos producto);

    public int cantidadProdPorCategoria(Categoria categoria);

    public void agregarCaja(Local local, Caja caja);
    public void eliminarCaja(Local local, Caja caja);

   
}