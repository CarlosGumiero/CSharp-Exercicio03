using System;

namespace Exercicio03_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
			Carro carro1 = new Carro("Toyota", "Etios", "RGB1100", "Vermelho", 1000f, false, 50, 0, 50000, 100);


			carro1.abastecer(200);
			carro1.pintar("verde");
			carro1.desligar();
			carro1.ligar();
			carro1.acelerar();
			carro1.frear();

			carro1.status();

			Console.WriteLine("");
			Console.WriteLine("");

			Aviao aviao1 = new Aviao("747 Duplo", "Grande", "999GG", "Cinza", 99900f, false, 200, 0, 500000, 10000);

			aviao1.abastecer("5000");
			aviao1.pintar("Rosa");
			aviao1.desligar();
			aviao1.ligar();
			aviao1.acelerar();
			aviao1.frear();

			aviao1.status();

			Console.WriteLine("");
			Console.WriteLine("");

			Caminhao caminhao1 = new Caminhao("Truckla", "Cargueiro", "GGPQ100", "Azul", 20000f, false, 400, 0, 100000, 1000);

			caminhao1.abastecer(1000f);
			caminhao1.pintar("Roxo");
			caminhao1.desligar();
			caminhao1.ligar();
			caminhao1.acelerar();
			caminhao1.frear();

			caminhao1.status();

		}
	}
}
