
public class Local
{
    public string nombre {get; set;}

    public IGestion gestorDeProductos {get; set;} 

    public List<Categoria> categorias {get; set;}

    public List<Caja> cajas {get; set;}

    public Local(string nombre, IGestion gestorDeProductos)
    {
        this.nombre = nombre;
        this.gestorDeProductos = gestorDeProductos;
        this.categorias = new List<Categoria>();
        this.cajas = new List<Caja>();
    }

    
}