using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA2
{
    public class pessoaJuridica : Pessoa
    {
        public float Faturamento {get; set ;}
        public string? CNPJ { get; set; }
        public string? razaoSocial { get; set; }
        public override float PagarImposto(float rendimento)
        {
            float imposto = 0;
            if (rendimento <= 5000)
            {

                imposto = rendimento * 6 / 100;
            }
            else if (rendimento > 5000 && rendimento <= 10000)
            {
                imposto = rendimento * 8 / 100;
            }
            else if (rendimento > 10000)
            {
                imposto = rendimento * 10 / 100;
            }
            return imposto;
        }
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