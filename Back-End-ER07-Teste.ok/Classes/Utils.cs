namespace CadastroPessoaBET6.Classes
{
    static class Utils
    {
        public static void BarraCarregamento(string texto, int tempo, int quantidade)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write(texto);

            for (var contador = 0; contador < quantidade; contador++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);
            }

            Console.ResetColor();
        }

        //24 - aqui vamos criar o codigo de verificacao de caminho/path
        // publico, estatico e vazio, vai receber o path como argumento,
        // 25 verificar pasta e caminho se existe, usaremos o metodo split
        public static void VerificarPastaArquivo(string caminho)
        {
            // 26 splitamos pela / sendo posicao 0 será a pasta
            // pegamos atraves do split a pasta do path, aquilo antes da barra.
            string pasta = caminho.Split("/")[0];
            // 27 agora vamos verificar se a apasta existe com o IF
            if (!Directory.Exists(pasta))
            {
                // 28 criar a pasta baseada no mome que chegou dentro do caminho
                Directory.CreateDirectory(pasta);

                // 29 se o arquivo existe nao existe
                if (!File.Exists(caminho))
                {
                    // 30 criando o arquivo no caminho
                    using (File.Create(caminho)) { }
                }
                    // 31 agora vamos voltar a pj para inserir uma pessoa jurica


            }
        }

    }
}