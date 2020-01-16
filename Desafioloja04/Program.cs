using Desafioloja04.br.gft.com.model;
using System;
using System.Collections.Generic;

namespace Desafioloja04
{
    class Program
    {
		

		static void Main(string[] args)
		{
			Livro l1 = new Livro("J.K> Rowling", "Fantasia ", "Harry Potter", 40, 50);
			Livro l2 = new Livro("J.R.R.", "fantasia", "Senhor dos Áneis", 60, 30);
			Livro l3 = new Livro("GFT", "Educativo", "Java Poo", 20, 50);



			VideoGame ps4 = new VideoGame("Sony", " Slim", false, "Ps4", 1800, 100);
			VideoGame ps4Usado = new VideoGame("Sony", "slim", true, "Ps4", 1000, 100);
			VideoGame videoGame = new VideoGame("Microsoft", "One", false, "Xbox", 1500, 500);
			VideoGame xbox = videoGame;


			List<Livro> livros = new List<Livro>();
			livros.Add(l1);
			livros.Add(l2);
			livros.Add(l3);

			List<VideoGame> games = new List<VideoGame>();
			games.Add(ps4);
			games.Add(ps4Usado);
			games.Add(xbox);

			Loja americanas = new Loja("Americanas ", "101021302", livros, games);



			l2.CalculaImpostos();
			l3.CalculaImpostos();

			ps4Usado.CalculaImpostos();
			ps4.CalculaImpostos();

			americanas.listaLivros();
			americanas.listaVideoGames();
			americanas.calculaPatrimonio();


		}

	}
}

