using System;
using System.Collections.Generic;
using System.Text;
using Exercicio03_CSharp;

namespace Exercicio03_CSharp
{
	public class Caminhao : Veiculo
	{
		public Caminhao(String mar, String mod, String pla, String cor, float km, bool ligado, int comb, int vel, double prec, int limit) : base(mar, mod, pla, cor, km, ligado, comb, vel, prec, limit)
		{
		}

		public override void ligar()
		{
			if (isLigado)
			{
				Console.WriteLine("O caminhão já está ligado!");
			}
			else
			{
				Console.WriteLine("O caminhão ligou.");
				this.isLigado = true;
			}
		}

		public override void desligar()
		{
			if (!isLigado)
			{
				Console.WriteLine("O caminhão já está desligado!");
			}
			else
			{
				Console.WriteLine("O caminhão desligou.");
				isLigado = false;
			}
		}

		public override void acelerar()
		{
			if (!isLigado)
				Console.WriteLine("O caminhão está desligado.");
			else if (this.litrosCombustivel > 0)
			{
				this.Velocidade += 10;
				this.litrosCombustivel -= 2;
				Console.WriteLine("O caminhão está em " + this.Velocidade + " KM por hora.");
				Console.WriteLine("O caminhão tem " + this.litrosCombustivel + " litros de combustível");
			}
			else
			{
				Console.WriteLine("O caminhão etá sem combustível!");
				this.isLigado = false;
				this.Velocidade = 0;
			}
		}

		public override void frear()
		{
			if (this.isLigado && this.Velocidade > 0)
			{
				if (this.Velocidade < 10)
				{
					this.Velocidade = 0;
					Console.WriteLine("O caminhão parou.");
				}
				else
				{
					this.Velocidade -= 10;
					Console.WriteLine("A velocidade do caminhão é de " + this.Velocidade + " KM por hora.");
				}
			}
			else
			{
				Console.WriteLine("O caminhão está parado.");
			}
		}

		public void abastecer(float qtdLitros)
		{

			int change;
			int dif = 0;
			change = (int)qtdLitros;

			if (this.litrosCombustivel + change > tanqueLimite)
			{
				dif = tanqueLimite - this.litrosCombustivel;
				this.litrosCombustivel = tanqueLimite;
				Console.WriteLine("Você tentou abastecer " + change + " litros, porém você abasteceu apenas " + dif + " litros,\n pois seu tanque encheu, agora você tem " + this.litrosCombustivel + " litros.");
			}
			else
			{
				litrosCombustivel += change;
				Console.WriteLine("Você abasteceu " + change + " litros, seu tanque agora tem " + litrosCombustivel + " litros.");
			}

		}

		public override void pintar(String corNova)
		{
			this.Cor = corNova;
			Console.WriteLine("Você pintou seu caminhão com a cor " + this.Cor + ".");
		}
	}
}
