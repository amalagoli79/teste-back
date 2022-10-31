﻿using CadastroPessoaBET6.Classes;

List<PessoaFisica> listaPf = new List<PessoaFisica>();

Console.Clear();
Console.WriteLine(@$"
=============================================
|    Bem vindo ao sistema de cadastro de    |
|        Pessoas Físicas e Juridícas        |
=============================================
");


Utils.BarraCarregamento("Iniciando", 100, 40);


string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
=============================================
|        Escolha uma das opções abaixo      |
|-------------------------------------------|
|           1 - Pessoa Física               |
|           2 - Pessoa Juridíca             |
|                                           |
|           0 - Sair                        |
=============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            string? opcaoPf;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
=============================================
|        Escolha uma das opções abaixo      |
|-------------------------------------------|
|           1 - Cadastrar Pessoa Física     |
|           2 - Listar Pessoa Física        |
|                                           |
|           0 - Voltar ao menu anterior     |
=============================================
");
                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPf)
                {
                    case "1":
                        Console.Clear();

                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa fisica, tecle Enter ao final");
                        novaPf.Nome = Console.ReadLine();

                        // bool dataValida;
                        // do
                        // {
                        //     Console.WriteLine($"Digite a data de nascimento Ex: DD/MM/AAAA");
                        //     string? dataNascimento = Console.ReadLine();

                        //     dataValida = novaPf.ValidarDataNasc(dataNascimento);

                        //     if (dataValida)
                        //     {
                        //         DateTime.TryParse(dataNascimento, out DateTime dataConvertida);
                        //         novaPf.dataNasc = dataConvertida;
                        //     }
                        //     else
                        //     {
                        //         Console.ForegroundColor = ConsoleColor.DarkRed;
                        //         Console.WriteLine($"Erro: Data inválida, digite um valor válido, Ex: DD/MM/AAAA");
                        //         Console.ResetColor();
                        //         Thread.Sleep(3000);
                        //     }

                        // } while (dataValida == false); //repeir laço 

                        // Console.WriteLine($"Digite o numero do CPF");
                        // novaPf.Cpf = Console.ReadLine();

                        // Console.WriteLine($"Digite o valor do rendimento mensal (somente numeros)");
                        // novaPf.Rendimento = float.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o logradouro");
                        // novoEndPf.logradouro = Console.ReadLine();

                        // Console.WriteLine($"Digite o numero");
                        // novoEndPf.numero = int.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o complemento");
                        // novoEndPf.complemento = Console.ReadLine();

                        // Console.WriteLine($"Este endereço é comercial? S ou N");
                        // String endCom = Console.ReadLine().ToUpper();

                        // if (endCom == "S")
                        // {
                        //     novoEndPf.endComercial = true;
                        // }
                        // else
                        // {
                        //     novoEndPf.endComercial = false;
                        // }
                        //  ======= tudo acima será comentado.

                        // novaPf.Endereco = novoEndPf;

                        //1 desativar o >> listaPf.Add(novaPf);
                        // 2 Daqui em diante teremos novo metodo
                        // 3 Criando o arquivo com  o nome da pessoa
                        //StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt");
                        // 4 agora que o arquivo já existe, vamos escrever dentro dele
                        // 5 comentar todos os imputs anteriores, para agilzar
                        //sw.WriteLine(novaPf.Nome);
                        // 6 Agora vamos fechar o arquivo que ficou aberto
                        //sw.Close();

                        // 7. tudo feito acima, pode ser feito de forma mais automatica com o using
                        // 8 depois que o SW para, o using fecha automaticamente.
                        // 9 deligar o codigo acima, para o using funcionar
                        using (StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt"))
                        {
                            sw.WriteLine(novaPf.Nome);
                        }
                        // 10. agora vamos ler o aquivo, usar o streamreader
                        // 11. vamos fazer isso no case 2 abaixo:




                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Cadastro gravado");
                        Console.ResetColor();
                        Thread.Sleep(2000);



                        break;

                    case "2":

                        //12. comentar todo o case 2 antigo.
                        //                         Console.Clear();

                        //                         if (listaPf.Count > 0)
                        //                         {
                        //                             foreach (PessoaFisica cadaPessoa in listaPf)
                        //                             {
                        //                                 Console.Clear();
                        //                                 Console.WriteLine(@$"
                        // Nome: {cadaPessoa.Nome}
                        // Endereço: {cadaPessoa.Endereco.logradouro}, {cadaPessoa.Endereco.numero} - Compl.: {cadaPessoa.Endereco.complemento}
                        // Rend. Mensal: {cadaPessoa.Rendimento.ToString("C")}
                        // Imposto a ser pago: {metodosPf.PagarImposto(cadaPessoa.Rendimento).ToString("C")}
                        // Data Nasc.: {cadaPessoa.dataNasc.ToString("d")}
                        // ");
                        //                             Console.WriteLine($"Aperte ENTER para continuar");
                        //                             Console.ReadLine();
                        //                             }

                        //                         }
                        //                         else
                        //                         {
                        //                             Console.Clear();
                        //                             Console.ForegroundColor = ConsoleColor.Green;
                        //                             Console.WriteLine($"Lista vazia, cadastre uma nova P.F.");
                        //                             Console.ResetColor();
                        //                             Thread.Sleep(2000); 
                        //                         }
                        // 13 vamos ler o aquivo criado.
                        using (StreamReader sr = new StreamReader("Adriano.txt"))
                        {
                            // 13.1 criando a variavel linha
                            string linha;
                            // 14 estamos lendo a linha do sr, que é o arquivo carregado, 
                            // e vamos ler até ser vazio (no caso nulo)
                            while ((linha = sr.ReadLine()) != null)
                            {
                                // 15 imprime a info. da linha
                                Console.WriteLine($"{linha}");

                            }
                            // 16 para o proc. para poder ser ver a info. na tela.
                            Console.WriteLine($"Aperte Enter para Continuar");
                            Console.ReadLine();
                            // 17 poderiamos inserir mais dados para serem lidos pelo 
                            // streamreader/readline.
                            // ===== Agora vamos para a 2 parte, Será em P.Juridica
                            // Fazendo a grav. e leit. no arq. csv.

                            // 18 - O que é um arq csv ???
                            // 19 - Agora vamos definir onde vai ficar o banco de dados csv
                            // 20 - Vamos para a Classe PJ e fazer o path por lá
                            //============ vai para PJ



                        }
                        {

                        }

                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine($"Voltando ao menu anterior");
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Inválida, por favor digite uma opção válida");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;
                }


            } while (opcaoPf != "0");


            //             PessoaFisica novaPf = new PessoaFisica();
            //             PessoaFisica metodosPf = new PessoaFisica();
            //             Endereco novoEndPf = new Endereco();




            //             novaPf.Nome = "Fernando";
            //             novaPf.dataNasc = new DateTime(2000, 01, 01);
            //             novaPf.Cpf = "1234567890";
            //             novaPf.Rendimento = 3500.5f;

            //             novoEndPf.logradouro = "Alameda barao de limeira";
            //             novoEndPf.numero = 539;
            //             novoEndPf.complemento = "SENAI Informatica";
            //             novoEndPf.endComercial = true;

            //             novaPf.Endereco = novoEndPf;

            //             Console.Clear();
            //             Console.WriteLine(@$"
            // Nome: {novaPf.Nome}
            // Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
            // Maior de idade: {(metodosPf.ValidarDataNasc(novaPf.dataNasc) ? "Sim" : "Não")}
            // Imposto a ser pago: {metodosPf.PagarImposto(novaPf.Rendimento).ToString("C")}
            // ");
            //             // condicao ? "Sim" : "Não"

            //             // Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");
            //             // Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome);


            break;

        case "2":

            //39 - Criar a instancia da pessoa PJ
            PessoaJuridica metodosPj = new PessoaJuridica();

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.Nome = "Nome Pj2";
            novaPj.RazaoSocial = "Razão Social Pj2";
            novaPj.Cnpj = "00000000000122";
            novaPj.Rendimento = 10000.5f;

            novoEndPj.logradouro = "Alameda Barão de Limeira";
            novoEndPj.numero = 539;
            novoEndPj.complemento = "SENAI Informatica";
            novoEndPj.endComercial = true;

            novaPj.Endereco = novoEndPj;
            //51 comenado para poder imprimir apenas os itens do arquivo lido mais abaixo:
            //             Console.Clear();
            //             Console.WriteLine(@$"
            // Nome: {novaPj.Nome}
            // Razão Social: {novaPj.RazaoSocial}
            // CNPJ: {novaPj.Cnpj}, Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
            // Endereço: {novaPj.Endereco.logradouro}, Nº: {novaPj.Endereco.numero}
            // Complemento: {novaPj.Endereco.complemento}
            // ");

            // 40 - aqui, apos carregar e listar os dados acima, inserimos ele no arquivo
            // com o comando abaixo
            // 41 agora esta ok o processo de inserir no aquivo.
            metodosPj.Inserir(novaPj);
            // 42 agora vamos ler as pessoas juridicas, criar uma lista
            // e depois gerar o writeline para mostrar
            // vamos para pessoa juridica.
            //==========

            // 49 agora vamos listar, criar uma lista  
            List<PessoaJuridica> listaExibicaoPj = metodosPj.LerArquivo();

            // 50 agora vamos ler cada linha e carregar em cadaItem
            foreach (PessoaJuridica cadaItem in listaExibicaoPj)
            {
                //51 copiamos o writeline acima para cá em comentamos o original acima
                //colamos e ajustamos o writeline usando o cadaItem
                Console.Clear();
                Console.WriteLine(@$"
Nome: {cadaItem.Nome}
Razão Social: {cadaItem.RazaoSocial}
CNPJ: {cadaItem.Cnpj}
");
            // 52 subimos o Aperte Enter e Readline para dentro do foreach, 
            // assim listamos item por item 
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();
            //53 testar e fim.
            }
            
            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");
            Thread.Sleep(3000);

            Utils.BarraCarregamento("Finalizando", 500, 6);

            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção Inválida, por favor digite uma opção válida");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }

} while (opcao != "0");


// static void BarraCarregamento(string texto, int tempo, int quantidade)
// {
//     Console.BackgroundColor = ConsoleColor.Green;
//     Console.ForegroundColor = ConsoleColor.Yellow;

//     Console.Write(texto);

//     for (var contador = 0; contador < quantidade; contador++)
//     {
//         Console.Write(".");
//         Thread.Sleep(tempo);
//     }

//     Console.ResetColor();
// }