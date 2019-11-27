using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Data.Classes;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReporteFrances reporte = new ReporteFrances();

            //var formas = new List<FormaGeometricaNew>
            //{
            //    new Cuadrado(2),
            //    new Triangulo(3),
            //};
            var formas =  new List<FormaGeometricaNew> { new Trapecio(5, 2, 3, 3, 6) };
            var resumen = FormaGeometricaNew.Imprimir(new ReporteFrances(formas));

            Console.Write(resumen);
        }
    }
}
