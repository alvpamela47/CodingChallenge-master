using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Circulo: FormaGeometrica
    {
        private decimal diametro;

        public Circulo(decimal diametro)
        {
            this.diametro = diametro;
            base.Tipo = TipoFormaGeometrica.CIRCULO;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (diametro / 2) * (diametro / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return(decimal)Math.PI* diametro;
        }

        public override TipoFormaGeometrica GetTipo()
        {
            return base.Tipo;
        }
    }
}
