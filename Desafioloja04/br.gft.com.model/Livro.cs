using System;
using System.Collections.Generic;
using System.Text;

namespace Desafioloja04.br.gft.com.model
{
    class Livro : Produto
    {

        public string autor { get; set; }
        public string tema { get; set; }
        public int qtdpag { get; set; }

        public Livro(string autor, string tema,  string nome, double preço, int qtd) : base(nome, preço, qtd)
        {
            this.autor = autor;
            this.tema = tema;
           
        }

        public Livro()
        {

        }
        public double CalculaImpostos()
        {
            double imp;
            if (tema.Equals("Educativo"))
            {
                imp = 0;
                Console.WriteLine("Livro educativo não tem impostos" + this.nome);
            }
            else
            {
                imp = this.preco * 0.10;
                Console.WriteLine("R$: " + this.preco + " imposostos sobre o livro " + this.nome);
            }
            return imp;




        }

        

     
       
       
    }
}


