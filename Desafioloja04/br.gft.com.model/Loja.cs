using System;
using System.Collections.Generic;
using System.Text;

namespace Desafioloja04.br.gft.com.model
{
    class Loja
    {

        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public List<Livro> Livros { get; set; }
        public List<VideoGame> videoGames { get; set; }

        public Loja( string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            Nome = nome;
            Cnpj = cnpj;
            Livros = livros;
            this.videoGames = videoGames;
        }

        public Loja(string v)
        {

        }

        public void listaLivros()
        {
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Lista de Livros da loja " + Nome);
            if (Livros.Count == 0)
            {
                Console.WriteLine("A loja não tem livros no seu estoque");
            }
            else
            {

                foreach (Livro livro in Livros)
                {
                    Console.WriteLine("Título " + livro.nome + ", preço : " + livro.preco + ", Quantidade  " + livro.qtd + " em estoque ");
                }

            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------\n");
        }



        
        
            


        

        public double calculaPatrimonio()
        {

            double result = 0;

            for(int i = 0; i < Livros.Count; i++)
            {
                result += Livros[i].preco * Livros[i].qtd;
            }
            for (int i =0; i< videoGames.Count;i ++  )
            {
                result += videoGames[i].preco * videoGames[i].qtd;
            }

            Console.WriteLine("O patrimonio da loja:  " + Nome + " é de " + result);
            return result;



        }

        public void listaVideoGames()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------/n");
            Console.WriteLine("Lista de Video Games ");
            if (videoGames.Count == 0)
            {
                Console.WriteLine(" A loja não tem Video Games em seu estoque");
            }
            else
            {
                foreach (VideoGame index in videoGames)
                {
                    Console.WriteLine("modelo : " + index.Modelo + ", preço :" + index.preco + " , marca" + index.Marca + ", quantidade " + ", " + index.qtd + " , em estoque");
                }
            }

        }
    }
}
