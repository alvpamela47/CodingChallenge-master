using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        private decimal lado;

        /// <summary>
        /// Contructor de un cuadrado
        /// </summary>
        /// <param name="lado">Lado del cuadrado</param>
        public Cuadrado(decimal lado)
        {
            this.lado = lado;
            base.Tipo = TipoFormaGeometrica.CUADRADO;
        }

        public override decimal CalcularArea()
        {
            return lado * lado;
        }

        public override decimal CalcularPerimetro()
        {
            return lado * 4;
        }

        public override TipoFormaGeometrica GetTipo()
        {
            return base.Tipo;
        }
    }
}
