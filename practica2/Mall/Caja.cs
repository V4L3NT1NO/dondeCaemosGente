public class Caja
{
    public int numero {get;set;}
    public List<Productos> factura {get;set;}

    public IOperaciones ControladorOperaciones {get;set;}

    public Caja(int numero, IOperaciones operaciones)
    {
        this.numero = numero;
        this.factura = new List<Productos>();
        this.ControladorOperaciones = operaciones;
    }
}