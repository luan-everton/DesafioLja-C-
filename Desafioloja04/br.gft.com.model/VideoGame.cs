using System;
using System.Collections.Generic;
using System.Text;

namespace Desafioloja04.br.gft.com.model
{
    class VideoGame:Produto
    {

        public string Marca { get; set; }
        public string  Modelo { get; set; }
        public bool isusado { get; set; }

        public VideoGame(string marca, string modelo, bool isusado, string nome, double preço, int qtd) :base(nome,  preço, qtd)
        {
            Marca = marca;
            Modelo = modelo;
            this.isusado = isusado;
        }

        public VideoGame()
        {

        }

        public double CalculaImpostos()
        {
            double imp;
            if (isusado == true)
            {
                imp = this.preco + 0.25;
                Console.WriteLine("imposto "+ this.Marca +" "+ this.Modelo);
            }else
            {
                imp = this.preco * 0.45;
                Console.WriteLine("imposto " + this.Marca +" "+ this.Modelo);
            }
            return imp;
        }

       
       
        
    }
}
