using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
     class FuncionarioTercerizado : Funcionario
    {
        public double DepesaAdicional { get; set; }

        public FuncionarioTercerizado()
        { 
        }
        public FuncionarioTercerizado(string nome, int hora, double valorHoraTrabalhada, double despesaAdicional)
            : base(nome, hora, valorHoraTrabalhada)
        {
            DepesaAdicional = despesaAdicional;
        }


        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DepesaAdicional;
        }
    }
}
