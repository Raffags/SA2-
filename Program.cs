namespace SA2
{
    class program
    {



        static void Main(string[] args)
        {
            List<pessoaFisica> listaPf = new List<pessoaFisica>();
            List<pessoaJuridica> listapj = new List<pessoaJuridica>();
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
                        //      Endereco endPf1 = new Endereco();
                        //       Console.WriteLine("Informe seu logradouro :");
                        //       endPf1.logradouro = Console.ReadLine();

                        //       Console.WriteLine("Informe o numero da residencia : ");
                        //       endPf1.numero = int.Parse(Console.ReadLine());

                        //       Console.WriteLine("informe seu complemento caso exista,caso não, pressione enter.");
                        //      endPf1.complemento = Console.ReadLine();

                        //       Console.WriteLine("este endereço é comercial ? 'S' para sim , 'N' para não. ");

                        //       string endComercial = Console.ReadLine().ToUpper();
                        //       if (endComercial == "S")
                        //       {
                        //           endPf1.enderecoComercial = true;
                        //       }
                        //        else
                        //        {
                        //  endPf1.enderecoComercial = false;
                        //        }



                        pessoaFisica pf = new pessoaFisica();
                        //     pf.endereco = endPf1;


                        Console.WriteLine("Informe seu nome : ");
                        pf.nome = Console.ReadLine();

                        Console.WriteLine("Informe seu CPF (SOMENTE NUMEROS)");
                        pf.CPF = Console.ReadLine();

                        //    Console.WriteLine("Informe seu salário  : ");
                        //   pf.salario = float.Parse(Console.ReadLine());

                        //    Console.WriteLine("Informe data de nascimento no formato : AA/MM/DD");
                        //     pf.dataNascimento = DateTime.Parse(Console.ReadLine());
                        //     bool idadevalida = pf.ValidarDataNascimento(pf.dataNascimento);
                        //    if (idadevalida == true)
                        //    {


                        //     Console.WriteLine("cadastro aprovado ");
                        //        listaPf.Add(pf);
                        //       Console.WriteLine("imposto a pagar : ");
                        //        Console.WriteLine(pf.PagarImposto(pf.salario));
                        //         ;
                        //   }
                          using (StreamWriter sw = new StreamWriter($"{pf.nome}.txt"))
                        {
                            sw.Write($"O nome do usuario é {pf.nome}, o cpf dele é {pf.CPF} e só!");
                        }
                            

                        break;
                    case "2":
                        foreach (var item in listaPf)
                        {
                            Console.WriteLine($"O indivíduo: {item.nome},de cpf :{item.CPF},recebe :  {item.salario} , e paga de imposto :{item.PagarImposto(item.salario)}");
                        }

                        break;
                    case "3":
                        Console.WriteLine("digite o cpf da pessoa que deseja remover : ");
                        string cpfProcurado = Console.ReadLine();
                        pessoaFisica pessoaEncontrada = listaPf.Find(item => item.CPF == cpfProcurado);
                        if (pessoaEncontrada != null)
                        {
                            listaPf.Remove(pessoaEncontrada);
                            Console.WriteLine("Meliante removido");
                        }
                        else
                        {
                            Console.WriteLine("cpf não encontrado");
                        }
                        break;
                    case "4":
                        Endereco endpj1 = new Endereco();
                        Console.WriteLine("Digite seu logradouro : ");
                        endpj1.logradouro = Console.ReadLine();
                        Console.WriteLine("Digite o número : ");
                        endpj1.numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("digite o complemento, caso não exista, pressione enter. ");
                        endpj1.complemento = Console.ReadLine();

                        Console.WriteLine("este endereço é comercial ? Digite SIM ou NÂO");
                        string endpjcomercial = Console.ReadLine().ToUpper();
                        if (endpjcomercial == "SIM")
                        {
                            endpj1.enderecoComercial = true;
                        }
                        else
                        {
                            endpj1.enderecoComercial = false;
                        }

                        pessoaJuridica pj1 = new pessoaJuridica();

                        pj1.endereco = endpj1;
                        Console.WriteLine("Nome da empresa : ");
                        pj1.nome = Console.ReadLine();






                        Console.WriteLine("digite o faturamento da empresa : ");
                        pj1.Faturamento = float.Parse(Console.ReadLine());

                        Console.WriteLine("digite a razão social : ");
                        pj1.razaoSocial = Console.ReadLine();
                        Console.WriteLine("Digite o CNPJ : ");
                        pj1.CNPJ = Console.ReadLine();
                        bool cnpjvalido = pj1.validaCNPJ(pj1.CNPJ);
                        if (cnpjvalido == true)
                        {
                            Console.WriteLine("cadastro aprovado");
                            listapj.Add(pj1);
                        }
                        else
                        {
                            Console.WriteLine("CNPJ Inválido, cadastro falhou.");
                        }



                        Console.WriteLine("imposto a ser pago : ");
                        Console.WriteLine(pj1.PagarImposto(pj1.Faturamento));




                        break;
                    case "5":
                        foreach (var item in listapj)
                        {
                            Console.WriteLine($" a empresa : {item.endereco.logradouro} {item.nome} de razão social :{item.razaoSocial} {item.CNPJ} {item.Faturamento},  , imposto a pagar : {item.PagarImposto(item.Faturamento)} ");
                        }
                        break;
                    case "6":
                        Console.WriteLine("digite o CNPJ da pessoa jurídica que deseja remover : ");
                        string procurarcnjp = Console.ReadLine();
                        pessoaJuridica cnpjencontrado = listapj.Find(item => item.CNPJ == procurarcnjp);
                        if (cnpjencontrado != null)
                        {
                            listapj.Remove(cnpjencontrado);
                            Console.WriteLine("Empresa removida.");

                        }
                        else
                        {
                            Console.WriteLine("CNPJ não encontrado");
                        }

                        break;
                    case "0":
                        Console.WriteLine("obrigado por usar o programa");

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






