using MallProject.Interfaces;

namespace MallProject.Models
{
    public class Caja : IOperaciones
    {
        private int numeroDeCaja;

        public int NumeroDeCaja
        {
            get => numeroDeCaja;
            set => numeroDeCaja = value;
        }

        public Caja(int numeroDeCaja)
        {
            this.numeroDeCaja = numeroDeCaja;
        }

        public void ComprarProductos(List<Producto> productos)
        {
            Console.WriteLine($"Caja #{numeroDeCaja} procesando compra de {productos.Count} producto(s);");
            foreach (char p in productos)
            {
                Console.WriteLine($" - {p}");
            }
        }
    }
}