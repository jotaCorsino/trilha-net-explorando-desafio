using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models.Excessoes
{
    internal class ExcecaoReserva : ApplicationException
    {
        public ExcecaoReserva(string mensagem) : base(mensagem)
        {

        }
    }
}
