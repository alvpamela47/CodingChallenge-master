using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class ReporteFrances : Reporte
    {
        public ReporteFrances(List<FormaGeometrica> formas)
        {
            base.formas = formas;
        }

        public override string EscribirEncabezado()
        {
            if (!formas.Any())
                return "<h1>Liste vide de formes!</h1>";
            else
                return "<h1>Rapport de formulaires</h1>";
        }

        public override string EscribirTotales(int total)
        {
            return "TOTAL:<br/>" + total + " formes ";
        }

        public override string EscribirTotalesArea(decimal total)
        {
            return "Zone " + total.ToString("#.##");
        }

        public override string EscribirTotalesPerimetro(decimal total)
        {
            return "Périmètre " + total.ToString("#.##") + " ";
        }

        public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFormaGeometrica tipo)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma(tipo, cantidad)} | Zone {area:#.##} | Périmètre { perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        protected override string TraducirForma(TipoFormaGeometrica tipo, int cantidad)
        {
            string res = String.Empty;
            switch (tipo)
            {
                case TipoFormaGeometrica.CUADRADO:
                    res = cantidad == 1 ? "Carré" : "Carrés";
                    break;
                case TipoFormaGeometrica.TRIANGULOEQUILATERO:
                    res = cantidad == 1 ? "Triangle" : "Triangles";
                    break;
                case TipoFormaGeometrica.CIRCULO:
                    res = cantidad == 1 ? "Cercle" : "Cercles";
                    break;
                case TipoFormaGeometrica.TRAPECIO:
                    res = cantidad == 1 ? "Trapèze" : "Trapèzes";
                    break;
                case TipoFormaGeometrica.RECTANGULO:
                    res = cantidad == 1 ? "Rectangle" : "Rectangles";
                    break;
                default:
                    res = "Type de forme inconnue";
                    break;
            }
            return res;
        }
    }
}
