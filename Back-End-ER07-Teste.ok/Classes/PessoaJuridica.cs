using System.Text.RegularExpressions;
using CadastroPessoaBET6.Interfaces;

namespace CadastroPessoaBET6.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string? Cnpj { get; set; }

        public string? RazaoSocial { get; set; }

        // 21 - vamos definir o path/caminho do bando de dados csv
        // abaixo, private serve para travar a alt. do caminho fora desse codigo:
        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";
        // 22 - O utils serve para fazer codigos utilitarios,
        // que podem ser usados em varios lugadore do projeto.
        // vamos para lá entao fazer um codigo de verificacao de caminho.
        // 23 - vamos para Util entao.

        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * .03f;

            }
            else if (rendimento <= 6000)
            {
                return rendimento * .05f;

            }
            else if (rendimento <= 10000)
            {
                return rendimento * .07f;

            }
            else
            {
                return rendimento * .09f;
            }
        }


        //XX.XXX.XXX/0001-XX ----- XXXXXXXX0001XX
        public bool ValidarCnpj(string cnpj)
        {

            // = Atribução
            // == Comparação
            // === Comparação exata 
            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)");

            // if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            if (retornoCnpjValido == true)
            {
                if (cnpj.Length == 18)
                {
                    string subStringCnpj = cnpj.Substring(11, 4);

                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }


                }
                else if (cnpj.Length == 14)
                {
                    string subStringCnpj = cnpj.Substring(8, 4);

                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        // 32 agora fazer... inserir pj
        // metodo que inseri uma nova PJ criado abaixo
        public void Inserir(PessoaJuridica pj)
        {
            // 33 antes de inserir, vamos checar o caminho usando a Utils
            // 34 usamos o metodo generico e no argumento mandomos o path/caminho
            Utils.VerificarPastaArquivo(caminho);
            // 35 carregando valores pj em um array 
            string[] pjValores = { $"{pj.Nome},{pj.Cnpj},{pj.RazaoSocial}" };
            // 36 agora usamos o metodo que insere os dados dentro do arquivo inf. no caminho.
            File.AppendAllLines(caminho, pjValores);
            // 37 metodo de inserir finalizo
            // 38 ainda nao esta ok, falta chamar esse metodo no pragram.cs
            // vamos lá então
            //==============
        }

        // 43 - agora vamos ler o arquivo csv
        // criar uma lista para carregar o aquivo csv
        public List<PessoaJuridica> LerArquivo()
        {
            // 44 instanciar a lista
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            // 45 varredura todas as linhas
            string[] linhas = File.ReadAllLines(caminho);

            // 46 foreach = para cada linha vamos ler e separar os atributos, campos
            // Nome Pj,00000000000100,Razão Social Pj
            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");
                // 47 instanciar uma nova pj para poder guardar os dados do array
                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.Nome = atributos[0];
                cadaPj.Cnpj = atributos[1];
                cadaPj.RazaoSocial = atributos[2];
                
                // 48 agora é preciso associar a cadaPj a listaPj (que está sem os dados)
                listaPj.Add(cadaPj);
            }
            // retornar a listaPj no metodo
            return listaPj;
            // agora vamos para a program fazer a lista ser exibida/49
        }
    }
}
