using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03_CSharp
{
    class Aviao:Veiculo
    {
		public Aviao(String mar, String mod, String pla, String cor, float km, bool ligado, int comb, int vel, double prec, int limit) : base(mar, mod, pla, cor, km, ligado, comb, vel, prec, limit)
		{ 
		}

	public override void ligar()
		{
			if (isLigado)
			{
				Console.WriteLine("O avião já está ligado!");
			}
			else
			{
				Console.WriteLine("O avião ligou.");
				this.isLigado = true;
			}
		}

	public override void desligar()
		{
			if (!isLigado)
			{
				Console.WriteLine("O avião já está desligado!");
			}
			else
			{
				Console.WriteLine("O avião desligou.");
				isLigado = false;
			}
		}


	public override void acelerar()
		{
			if (!isLigado)
				Console.WriteLine("O avião está desligado.");
		else if (this.litrosCombustivel > 0)
			{
				this.Velocidade += 200;
				this.litrosCombustivel -= 20;
				Console.WriteLine("O avião está em " + this.Velocidade + " KM por hora.");
				Console.WriteLine("O avião tem " + this.litrosCombustivel + " litros de combustível");
			}
			else
			{
				Console.WriteLine("O avião etá sem combustível!");
				this.isLigado = false;
				this.Velocidade = 0;
			}
		}

	public override void frear()
		{
			if (this.isLigado && this.Velocidade > 0)
			{
				if (this.Velocidade < 200)
				{
					this.Velocidade = 0;
					Console.WriteLine("O avião parou.");
				}
				else
				{
					this.Velocidade -= 200;
					Console.WriteLine("A velocidade do avião é de " + this.Velocidade + " KM por hora.");
				}
			}
			else
			{
				Console.WriteLine("O avião está parado.");
			}
		}

		public void abastecer(String qtdLitros)
		{
			int change;
			int dif = 0;
			change = Convert.ToInt32(qtdLitros);

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
			Console.WriteLine("Você pintou seu avião com a cor " + this.Cor + ".");
		}
	}
}
