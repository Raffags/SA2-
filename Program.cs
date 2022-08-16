namespace SA2
{
    public class Program
    {
        static void Main(string[] args)
        {/*
         Endereco end = new Endereco();
         end.logradouro = "Rua x ";
         end.numero = 100;
         end.complemento = "YYY";
         end.enderecoComercial= false;
         
         pessoaFisica pf = new pessoaFisica();
         pf.nome= "raffael";
         pf.endereco= end;
         pf.CPF= "2123123";
         pf.dataNascimento= new DateTime(1997, 01, 29);
         Console.WriteLine($"Rua: {pf.endereco.logradouro},{pf.endereco.numero}");
          
          
          bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);
 
        if (idadeValida == true)
        {
            System.Console.WriteLine("tem idade para acessar o sistema");
        }else{
            Console.WriteLine("idade insuficiente para acesso do sistema");
        }*/


          pessoaJuridica pj = new pessoaJuridica();
            
            Endereco end = new Endereco();
            end.logradouro = "Rua X";
            end.numero = 100;
            end.complemento = "YYY";
            end.enderecoComercial = true;

            pj.endereco = end;
            pj.CNPJ = "12345678990001";
            pj.razaoSocial = "Pessoa Juridica";

            if(pj.validaCNPJ(pj.CNPJ)){
                Console.WriteLine("cnpj valido");
            }else{
                Console.WriteLine("cnpj invalido");
            }
        
        }


    }


}



