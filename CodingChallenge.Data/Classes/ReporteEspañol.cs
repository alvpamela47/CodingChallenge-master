using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class ReporteEspañol : Reporte
    {
        public ReporteEspañol(List<FormaGeometrica> formas)
        {
            base.formas = formas;
        }

        public override string EscribirEncabezado()
        {
            if (!formas.Any())
                return "<h1>Lista vacía de formas!</h1>";
            else
                return "<h1>Reporte de Formas</h1>";
        }

        public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFormaGeometrica tipo)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma(tipo, cantidad)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        //método solo visto por la clase hija
        protected override string TraducirForma(TipoFormaGeometrica tipo, int cantidad)
        {
            string res = String.Empty;
            switch (tipo)
            {
                case TipoFormaGeometrica.CUADRADO:
                    res = cantidad == 1 ? "Cuadrado" : "Cuadrados";
                    break;
                case TipoFormaGeometrica.TRIANGULOEQUILATERO:
                    res = cantidad == 1 ? "Triángulo" : "Triángulos";
                    break;
                case TipoFormaGeometrica.CIRCULO:
                    res = cantidad == 1 ? "Círculo" : "Círculos";
                    break;
                case TipoFormaGeometrica.TRAPECIO:
                    res = cantidad == 1 ? "Trapecio" : "Trapecios";
                    break;
                case TipoFormaGeometrica.RECTANGULO:
                    res = cantidad == 1 ? "Rectangulo" : "Rectangulos";
                    break;
                default:
                    res = "Tipo de forma desconocida";
                    break;
            }
            return res;
        }

        public override string EscribirTotales(int total)
        {
            return "TOTAL:<br/>" + total + " formas ";
        }

        public override string EscribirTotalesPerimetro(decimal total)
        {
            return "Perimetro " + total.ToString("#.##") + " ";
        }

        public override string EscribirTotalesArea(decimal total)
        {
            return "Area " + total.ToString("#.##");
        }
    }
}
