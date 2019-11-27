using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        private decimal base_mayor;
        private decimal base_menor;
        private decimal lado_izq;
        private decimal lado_derecho;
        private decimal altura;

        public Trapecio(decimal base_mayor, decimal base_menor, decimal lado_izq, decimal lado_derecho, decimal altura)
        {
            this.base_mayor = base_mayor;
            this.base_menor = base_menor;
            this.lado_izq = lado_izq;
            this.lado_derecho = lado_derecho;
            this.altura = altura;
            base.Tipo = TipoFormaGeometrica.TRAPECIO;
        }

        public override decimal CalcularArea()
        {
            return ((this.base_mayor + this.base_menor) * this.altura) / 2;
        }

        public override decimal CalcularPerimetro()
        {
            return this.base_mayor + this.base_menor + this.lado_derecho + this.lado_izq;
        }

        public override TipoFormaGeometrica GetTipo()
        {
            return base.Tipo;
        }
    }
}
