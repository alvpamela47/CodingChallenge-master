using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        protected TipoFormaGeometrica Tipo;

        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
        public abstract TipoFormaGeometrica GetTipo();

        public static string Imprimir(Reporte reporte)
        {
            return reporte.Imprimir();
        }
    }

    public enum TipoFormaGeometrica
    {
        CUADRADO = 1,
        TRIANGULOEQUILATERO = 2,
        CIRCULO = 3,
        TRAPECIO = 4,
        RECTANGULO = 5,
    }
}

