using Exercicio03_CSharp;
using System;
using System.Collections.Generic;
using System.Text;

public class Carro : Veiculo
{
	public Carro(string mar, string mod, string pla, string cor, float km, bool ligado, int comb, int vel, double prec, int limit) : base(mar, mod, pla, cor, km, ligado, comb, vel, prec, limit)
	{
	}

	public override void ligar()
	{
		if (isLigado)
		{
			Console.WriteLine("O carro já está ligado!");
		}
		else
		{
			Console.WriteLine("O carro ligou.");
			this.isLigado = true;
		}
	}

		public override void desligar()
	{
		if (!isLigado)
		{
			Console.WriteLine("O carro já está desligado!");
		}
		else
		{
			Console.WriteLine("O carro desligou.");
			isLigado = false;
		}
	}

		public override void acelerar()
	{
		if (!isLigado)
			Console.WriteLine("O carro está desligado.");
			else if (this.litrosCombustivel > 0)
		{
			this.Velocidade += 20;
			this.litrosCombustivel -= 1;
			Console.WriteLine("O carro está em " + this.Velocidade + " KM por hora.");
			Console.WriteLine("O carro tem " + this.litrosCombustivel + " litros de combustível");
		}
		else
		{
			Console.WriteLine("O carro etá sem combustível!");
			this.isLigado = false;
			this.Velocidade = 0;
		}
	}

	public override void frear()
	{
		if (this.isLigado && this.Velocidade > 0)
		{
			if (this.Velocidade < 20)
			{
				this.Velocidade = 0;
				Console.WriteLine("O carro parou.");
			}
			else
			{
				this.Velocidade -= 20;
				Console.WriteLine("A velocidade do carro é de " + this.Velocidade + " KM por hora.");
			}
		}
		else
		{
			Console.WriteLine("O carro está parado.");
		}
	}

		public new void abastecer(int qtdLitros)
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

		public override void pintar(String corNova)
	{
		this.Cor = corNova;
		Console.WriteLine("Você pintou seu carro com a cor " + this.Cor + ".");
	}
}
