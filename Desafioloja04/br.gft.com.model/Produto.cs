using System;
using System.Collections.Generic;
using System.Text;

namespace Desafioloja04.br.gft.com.model
{
    abstract class Produto { 
    
        public string nome { get; set; }
        public double preco { get; set; }
        public int qtd { get;  set; }

        public Produto(string nome, double preco, int qtd)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }

        public Produto()
        {


        }
    }
}
