using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGESTOR_CSHARP
{
    public class CredenciaisOperador
    {
        public string operador { get; set; }
        public string senha { get; set; }

        public CredenciaisOperador(string NomeOperador, string SenhaOperador) {
            operador = NomeOperador;

            senha = SenhaOperador;

        
        
        }
    }
}
