using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Triangulo : FormaGeometrica
    {
        private decimal lado;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <param name=""></param>
        public Triangulo(decimal lado)
        {
            this.lado = lado;
            base.Tipo = TipoFormaGeometrica.TRIANGULOEQUILATERO;
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * this.lado * this.lado;
        }

        public override decimal CalcularPerimetro()
        {
            return this.lado*3;
        }

        public override TipoFormaGeometrica GetTipo()
        {
            return base.Tipo;
        }
    }
}
