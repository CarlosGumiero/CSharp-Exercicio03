using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03_CSharp
{
	public abstract class Veiculo
	{
		protected String Marca { get; set; }
		protected String Modelo { get; set; }
		protected String Placa { get; set; }
		protected String Cor { get; set; }
		protected float Km { get; set; }
		protected bool isLigado { get; set; }
		protected int litrosCombustivel { get; set; }
		protected int Velocidade { get; set; }
		protected double Preco { get; set; }
		protected int tanqueLimite { get; set; }

		public Veiculo(String mar, String mod, String pla, String cor, float km, bool ligado, int comb, int vel, double prec, int limit)
		{
			this.Marca = mar;
			this.Modelo = mod;
			this.Placa = pla;
			this.Cor = cor;
			this.Km = km;
			this.isLigado = ligado;
			this.litrosCombustivel = comb;
			this.Velocidade = vel;
			this.Preco = prec;
			this.tanqueLimite = limit;
		}


		public void status()
		{
			Console.WriteLine("Marca: " + this.Marca);
			Console.WriteLine("Modelo: " + this.Modelo);
			Console.WriteLine("Placa: " + this.Placa);
			Console.WriteLine("Cor: " + this.Cor);
			Console.WriteLine("Km: " + this.Km);
			Console.WriteLine("Está ligado: " + this.isLigado);
			Console.WriteLine("Combustivel (litros): " + this.litrosCombustivel);
			Console.WriteLine("Velocidade: " + this.Velocidade);
			Console.WriteLine("Preço: " + this.Preco);
		}

		public abstract void ligar();
		public abstract void desligar();
		public abstract void pintar(String corNova);
		public abstract void acelerar();
		public abstract void frear();

		public void abastecer(int qtdLitros)
		{
			int dif = 0;
			if (this.litrosCombustivel + qtdLitros > 100)
			{
				dif = 100 - this.litrosCombustivel;
				this.litrosCombustivel = 100;
				Console.WriteLine("Você tentou abastecer " + qtdLitros + " litros, porém você abasteceu apenas " + dif + " litros,\n pois seu tanque encheu, agora você tem " + this.litrosCombustivel + " litros.");
			}
			else
			{
				litrosCombustivel += qtdLitros;
				Console.WriteLine("Você abasteceu " + qtdLitros + " litros, seu tanque agora tem " + litrosCombustivel + " litros.");
			}
		}
	}
}
