namespace SA2
{
    class program
    {



        static void Main(string[] args)
        {
            List<pessoaFisica> listaPf = new List<pessoaFisica>();
            static void BarraCarregamento(string texto)
            {

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(texto);
                Thread.Sleep(500);
                for (var contador = 0; contador < 10; contador++)
                {
                    Console.Write("#");
                    Thread.Sleep(500);
                }
            }

            Console.WriteLine(@$"
            =================================================================
            =                     seja bem vindo ao nosso cadastro          =   
            =                                                               =
            =                                                               =
            =================================================================                   
");
            BarraCarregamento("iniciando");

            string? opção;
            do
            {
                Console.WriteLine(@$"
=================================================== 
!          Escolha uma das opcoes abaixo          !          
=================================================== 
!                                                 !
!                 PESSOA FISICA                   !
!           1 - Cadastrar Pessoa Física           !
!           2 - Listar Pessoa Física              !
!           3 - Remover Pessoa Física             !
!                                                 !
!                 PESSOA JURIDICA                 !
!           4 - Cadastrar Pessoa Juridica         !
!           5 - Listar Pessoa Juridica            !
!           6 - Remover Pessoa Juridica           !
===================================================
!              0 - Sair                           !
=================================================== 
            ");
                opção = Console.ReadLine();
                switch (opção)
                {
                    case "1":
                        Endereco endPf1 = new Endereco();
                        Console.WriteLine("Informe seu logradouro :");
                        endPf1.logradouro = Console.ReadLine();

                        Console.WriteLine("Informe o numero da residencia : ");
                        endPf1.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("informe seu complemento caso exista,caso não, pressione enter.");
                        endPf1.complemento = Console.ReadLine();

                        Console.WriteLine("este endereço é comercial ? 'S' para sim , 'N' para não. ");
                        
                        string endComercial = Console.ReadLine().ToUpper();
                        if (endComercial == "S")
                        {
                            endPf1.enderecoComercial = true;
                        }
                        else
                        {
                            endPf1.enderecoComercial = false;
                        }



                        pessoaFisica pf = new pessoaFisica();
                        pf.endereco = endPf1;


                        Console.WriteLine("Informe seu nome : ");
                        pf.nome = Console.ReadLine();

                        Console.WriteLine("Informe seu CPF (SOMENTE NUMEROS)");
                        pf.CPF = Console.ReadLine();

                        Console.WriteLine("Informe seu salário  : ");
                        pf.salario = float.Parse(Console.ReadLine());

                        Console.WriteLine("Informe data de nascimento no formato : AA/MM/DD");
                        pf.dataNascimento = DateTime.Parse(Console.ReadLine());
                        bool idadevalida = pf.ValidarDataNascimento(pf.dataNascimento);
                        if (idadevalida == true)
                        {


                            Console.WriteLine("cadastro aprovado ");
                            listaPf.Add(pf);
                            Console.WriteLine(pf.PagarImposto(pf.salario));
                            ;
                        }


                        break;
                    case "2": 
                    foreach (var item in listaPf){
                    Console.WriteLine($"{item.nome}, {item.CPF},");
                    }

                        break;
                    case "3": Console.WriteLine("digite o cpf da pessoa que deseja remover : ");
                    string cpfProcurado = Console.ReadLine();
                      pessoaFisica pessoaEncontrada = listaPf.Find(item => item.CPF == cpfProcurado);
                    if (pessoaEncontrada != null){
                        listaPf.Remove(pessoaEncontrada);
                        Console.WriteLine("Meliante removido");
                    }else{
                        Console.WriteLine("cpf não encontrado");
                    }
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "0":
                        Console.WriteLine("obrigado por usar o programa");
                        BarraCarregamento("finalizando");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opção != "0");
            Console.ResetColor();



        }



    }
}






