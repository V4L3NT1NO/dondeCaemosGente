

public class Mall
{
    public string nombre { get; set; }
    public List<Local> locales {get; set;}

    public Mall(string nombre)
    {
        this.nombre = nombre;
        this.locales = new List<Local>();
    }


    public void AgregarLocal(Local local)
    {
        this.locales.Add(local);
    }




}