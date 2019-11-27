using CodingChallenge.Data.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    class DataTest
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new ReporteEspañol(new List<FormaGeometrica>())));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new ReporteIngles(new List<FormaGeometrica>())));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5)};

            var resumen = FormaGeometrica.Imprimir(new ReporteEspañol(cuadrados));

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometrica.Imprimir(new ReporteIngles(cuadrados));

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new Triangulo(4),
                new Cuadrado(2),
                new Triangulo(9),
                new Circulo(2.75m),
                new Triangulo(4.2m),
            };

            var resumen = FormaGeometrica.Imprimir(new ReporteIngles(formas));

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {

                new Cuadrado(5),
                new Circulo(3),
                new Triangulo(4),
                new Cuadrado(2),
                new Triangulo(9),
                new Circulo(2.75m),
                new Triangulo(4.2m),

            };

            var resumen = FormaGeometrica.Imprimir(new ReporteEspañol(formas));

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnFrances()
        {
            var formas = new List<FormaGeometrica>
            {

                new Cuadrado(5),
                new Circulo(3),
                new Triangulo(4),
                new Cuadrado(2),
                new Triangulo(9),
                new Circulo(2.75m),
                new Triangulo(4.2m),
                new Rectangulo(5,3)

            };

            var resumen = FormaGeometrica.Imprimir(new ReporteFrances(formas));

            Assert.AreEqual(
                "<h1>Rapport de formulaires</h1>2 Carrés | Zone 29 | Périmètre 28 <br/>2 Cercles | Zone 13,01 | Périmètre 18,06 <br/>3 Triangles | Zone 49,64 | Périmètre 51,6 <br/>TOTAL:<br/>7 formes Périmètre 97,66 Zone 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioEnFrances()
        {
            var trapecios = new List<FormaGeometrica> { new Trapecio(5,2, 3,3, 6)};

            var resumen = FormaGeometrica.Imprimir(new ReporteFrances(trapecios));

            Assert.AreEqual("<h1>Rapport de formulaires</h1>1 Trapèze | Zone 21 | Périmètre 13 <br/>TOTAL:<br/>1 formes Périmètre 13 Zone 21", resumen);
        }
    }
}
