using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA2
{
    public abstract class Pessoa
    {
        public string nome {get; set;}
        public string endereco { get; set; }
        public bool enderecoComercial{ get; set; }
        public void PagarImposto(){}
        
        
        
    }
}