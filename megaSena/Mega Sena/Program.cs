
		bool repetir = false; // Repetição falsa
		Console.Write("Quantos jogos vc deseja fazer? "); // Impressao na tela
		int jogadas = int.Parse(Console.ReadLine()); // são usados para converter uma representação de string de um número em um inteiro
		do
		{
			Console.Write("Quantas dezenas vc deseja fazer? "); // Impressao na tela
			int dezenas = int.Parse(Console.ReadLine()); // são usados para converter uma representação de string de um número em um inteiro
			if (dezenas >= 6) // Significa para tomar decisões 
			{
				repetir = false; // repetição falsa
				for (int n = 1; n <= jogadas; n++) // Toma decisões
				{
					Console.WriteLine($"\nJogo {n}:"); // Grava apresentações de textos
					for (int contador = 1; contador <= dezenas; contador++)
					{
						Random na = new Random(); // Gerador de numero aleatorios
						int valores = na.Next(01, 60); // armazena valores inteiros, sem casas decimais
						if (contador == dezenas) // Toma decisões 
						{
							Console.Write(valores.ToString("00")); // Impressao na tela
						}
						else
						{
							Console.Write(valores.ToString("00")); // impressao na tela
						}
					}
				}
			}
			else 
			{
				repetir = true; // repetição verdadeira
				Console.WriteLine("O minimo de dezenas e 6!"); // impressao de Tela
			}
		}
		while (repetir == true); // repetição verdadeira

