using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class ReporteIngles : Reporte
    {
        public ReporteIngles(List<FormaGeometrica> formas)
        {
            base.formas = formas;
        }

        public override string EscribirEncabezado()
        {
            if (!formas.Any())
                return "<h1>Empty list of shapes!</h1>";
            else
                return "<h1>Shapes report</h1>";
        }

        public override string EscribirTotales(int total)
        {
            return "TOTAL:<br/>" + total + " shapes ";
        }

        public override string EscribirTotalesArea(decimal total)
        {
            return "Area " + total.ToString("#.##");
        }

        public override string EscribirTotalesPerimetro(decimal total)
        {
            return "Perimeter " + total.ToString("#.##") + " ";
        }

        public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFormaGeometrica tipo)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma(tipo, cantidad)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        protected override string TraducirForma(TipoFormaGeometrica tipo, int cantidad)
        {
            string res = String.Empty;
            switch (tipo)
            {
                case TipoFormaGeometrica.CUADRADO:
                    res = cantidad == 1 ? "Square" : "Squares";
                    break;
                case TipoFormaGeometrica.TRIANGULOEQUILATERO:
                    res = cantidad == 1 ? "Triangle" : "Triangles";
                    break;
                case TipoFormaGeometrica.CIRCULO:
                    res = cantidad == 1 ? "Circle" : "Circles";
                    break;
                case TipoFormaGeometrica.TRAPECIO:
                    res = cantidad == 1 ? "Trapeze" : "Trapezes";
                    break;
                case TipoFormaGeometrica.RECTANGULO:
                    res = cantidad == 1 ? "Rectangle" : "Rectangles";
                    break;
                default:
                    res = "Type of unknown form";
                    break;
            }
            return res;
        }
    }
}
