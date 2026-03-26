using System.Collections;

Mall miMall = new Mall("Huper");
Local local1 = new Local("Totto", new SimpleGestion());

miMall.AgregarLocal(local1);

//Gestión del local
Categoria catMochilas = new Categoria("Mochilas");
Categoria catAccesorios = new Categoria("Accesorios");

local1.gestorDeProductos.agregarCategoria(local1.categorias,catMochilas);
local1.gestorDeProductos.agregarCategoria(local1.categorias,catAccesorios);

local1.gestorDeProductos.agregarProducto(local1.categorias[0], new Productos("Mochila 1", 100, "Bolso escuela", 10));
local1.gestorDeProductos.agregarProducto(local1.categorias[0], new Productos("Mochila 2", 150, "Bolso viaje", 5));
local1.gestorDeProductos.agregarProducto(local1.categorias[0], new Productos("Mochila 3", 200, "Bolso trekking", 3));

local1.gestorDeProductos.agregarProducto(local1.categorias[1], new Productos("Lapicera", 20, "Azul", 50));
local1.gestorDeProductos.agregarProducto(local1.categorias[1], new Productos("Cuaderno", 30, "100 hojas", 40));
local1.gestorDeProductos.agregarProducto(local1.categorias[1], new Productos("Etiqueta", 5, "Identificadora", 100));

Console.WriteLine($"Cantidad en Mochilas: {local1.gestorDeProductos.cantidadProdPorCategoria(catMochilas)}");
Console.WriteLine($"Cantidad en Accesorios: {local1.gestorDeProductos.cantidadProdPorCategoria(catAccesorios)}");

local1.gestorDeProductos.eliminarProducto(local1.categorias[0], catMochilas.listaProductos[0]);
Console.WriteLine($"Cantidad en Mochilas tras eliminar: {local1.gestorDeProductos.cantidadProdPorCategoria(catMochilas)}");

// Caja del local

Caja caja1 = new Caja(1,new OperacionesSimple());

// Agregar 3 productos de diferentes categorías a la factura
caja1.ControladorOperaciones.agregarProductoAFactura(catMochilas, catMochilas.listaProductos[0], caja1.factura); 
caja1.ControladorOperaciones.agregarProductoAFactura(catAccesorios, catAccesorios.listaProductos[0], caja1.factura); 
caja1.ControladorOperaciones.agregarProductoAFactura(catAccesorios, catAccesorios.listaProductos[1], caja1.factura); 

// Comprar
caja1.ControladorOperaciones.comprarProductos(caja1.factura);






