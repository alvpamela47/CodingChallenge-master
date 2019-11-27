using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class Reporte
    {
        protected List<FormaGeometrica> formas;
        
        public abstract string EscribirEncabezado();
        public abstract string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFormaGeometrica tipo);
        protected abstract string TraducirForma(TipoFormaGeometrica tipo, int cantidad);
        public abstract string EscribirTotales(int total);
        public abstract string EscribirTotalesPerimetro(decimal total);
        public abstract string EscribirTotalesArea(decimal total);

        public string Imprimir()
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(EscribirEncabezado());
                return sb.ToString();
            }

            sb.Append(EscribirEncabezado());

            var numeroCuadrados = 0;
            var numeroCirculos = 0;
            var numeroTriangulos = 0;
            var numerosTrapecios = 0;
            var numerosRectangulos = 0;

            var areaCuadrados = 0m;
            var areaCirculos = 0m;
            var areaTriangulos = 0m;
            var areaTrapecios = 0m;
            var areaRectangulos = 0m;

            var perimetroCuadrados = 0m;
            var perimetroCirculos = 0m;
            var perimetroTriangulos = 0m;
            var perimetroTrapecios = 0m;
            var perimetroRectangulos = 0m;

            foreach (FormaGeometrica forma in formas)
            {
                switch (forma.GetTipo())
                {
                    case TipoFormaGeometrica.CUADRADO:
                        numeroCuadrados++;
                        areaCuadrados += forma.CalcularArea();
                        perimetroCuadrados += forma.CalcularPerimetro();
                        break;
                    case TipoFormaGeometrica.TRIANGULOEQUILATERO:
                        numeroTriangulos++;
                        areaTriangulos += forma.CalcularArea();
                        perimetroTriangulos += forma.CalcularPerimetro();
                        break;
                    case TipoFormaGeometrica.CIRCULO:
                        numeroCirculos++;
                        areaCirculos += forma.CalcularArea();
                        perimetroCirculos += forma.CalcularPerimetro();
                        break;
                    case TipoFormaGeometrica.TRAPECIO:
                        numerosTrapecios++;
                        areaTrapecios += forma.CalcularArea();
                        perimetroTrapecios += forma.CalcularPerimetro();
                        break;
                    case TipoFormaGeometrica.RECTANGULO:
                        numerosRectangulos++;
                        areaRectangulos += forma.CalcularArea();
                        perimetroRectangulos += forma.CalcularPerimetro();
                        break;
                }

            }

            sb.Append(ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, TipoFormaGeometrica.CUADRADO));
            sb.Append(ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, TipoFormaGeometrica.CIRCULO));
            sb.Append(ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, TipoFormaGeometrica.TRIANGULOEQUILATERO));
            sb.Append(ObtenerLinea(numerosTrapecios, areaTrapecios, perimetroTrapecios, TipoFormaGeometrica.TRAPECIO));
            sb.Append(ObtenerLinea(numerosRectangulos, areaRectangulos, perimetroRectangulos, TipoFormaGeometrica.RECTANGULO));

            // FOOTER
            sb.Append(EscribirTotales(numeroCuadrados + numeroCirculos + numeroTriangulos + numerosTrapecios + numerosRectangulos));
            sb.Append(EscribirTotalesPerimetro(perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroTrapecios + perimetroRectangulos));
            sb.Append(EscribirTotalesArea(areaCuadrados + areaCirculos + areaTriangulos + areaTrapecios + areaRectangulos));

            return sb.ToString();
        }
    }
}
