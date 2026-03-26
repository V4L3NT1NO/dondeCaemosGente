using MallProject.Models;

class Program
{
    static void Main(string[] args)
    {
        //Crear el Mall
        Mall mall = new Mall("InviziMall");

        //Agregar los locales (por composición, los locales pertenecen al Mall)
        Local localRopa = mall.AgregarLocal("H&M", 1);
        localRopa localTech = mall.AgregarLocal("Corsair Store", 2);

        //Crear las categorías (por agregación, pueden existir sin el local)
        Categorias catCamisas = new Categorias("Camisas");
        Categorias catPantalones = new Categorias("Pantalones");
        Categorias catAuricularesG = new Categorias("Auriculares gamer");

        localRopa.AgregarCategoria(catCamisas);
        localRopa.AgregarCategoria(catPantalones);
        localTech.AgregarCategoria(catAuricularesG);

        //Crear productos
        Producto camisa = new Producto(150, "Caminsa Celeste", 30);
        Producto pantalon = new Producto(120, "Pantalon Beige", 25);
        Producto auricularG = new Producto(560, "Corsair Void V2", 10);

        //Agregar productos a sus categorías por IGestion 
        Console.WriteLine("\n--- Agregando productos ---");
        localRopa.AgregarProducto(camisa, "Camisas");
        localRopa.AgregarProducto(pantalon, "Pantalones");
        localTech.AgregarProducto(auricularG, "Auriculares gamer");

        //Consultar cantidad por categoría 
        Console.WriteLine("\n--- Cantidad por categoría ---");
        Console.WriteLine($"Productos en 'Camisas': {localRopa.CantidadProdByCategoria("Camisas")}");
        Console.WriteLine($"Productos en 'Auriculares gamer': {localTech.CantidadProdByCategoria("Auriculares gamer")}");

        //Comprar productos por Ioperaciones en Caja (cada local tiene su propia caja)
        Console.WriteLine("\n--- Procesando compra ---");
        List<Producto> carritoRopa = new List<Producto> { camisa, pantalon };
        List<Producto> carritoTech = new List<Producto> { auricularG };
        localRopa.Caja.ComprarProductos(carritoRopa);
        localTech.Caja.ComprarProductos(carritoTech);

        //Eliminar producto
        Console.WriteLine("\n--- Elimnando producto ---");
        localRopa.EliminarProducto(camisa);
        Console.WriteLine($"Productos en 'Camisas' tras eliminar: {localRopa.CantidadProdByCategoria("Camisas")}");

    }
}