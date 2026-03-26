namespace MallProject.Models
{
    public class Mall
    {
        private string nombre;
        private List<Local> locales;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public List<Local> Locales => locales;

        public Mall(string nombre)
        {
            this.nombre = nombre;
            this.locales = new List<Local>();
        }

        public Local AgregarLocal(string nombreLocal, int numeroDeCaja)
        {
            Local nuevoLocal = new Local(nombreLocal, numeroDeCaja);
            locales.Add(nuevoLocal);
            Console.WriteLine($"Local '{nombreLocal}' agregado al mall '{nombre}'.");
            return nuevoLocal;
        }
    }
}