using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA2
{
    public class pessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
        public string razaoSocial { get; set; }
        public override void PagarImposto(float rendimento) { }
        public bool validaCNPJ(string CNPJ)
        {
            if (CNPJ.Length >= 14 && (CNPJ.Substring(CNPJ.Length - 4)) == "0001")
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}