using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        private decimal _base;
        private decimal altura;

        public Rectangulo(decimal _base, decimal altura)
        {
            this._base = _base;
            this.altura = altura;
        }

        public override decimal CalcularArea()
        {
            return _base * altura;
        }

        public override decimal CalcularPerimetro()
        {
            return _base * 2 + altura * 2;
        }

        public override TipoFormaGeometrica GetTipo()
        {
            return base.Tipo;
        }
    }
}
