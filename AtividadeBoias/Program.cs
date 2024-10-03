int escolha;
Console.WriteLine("Escolha entre manual ou aleatório:");
Console.WriteLine("1) Manual");
Console.WriteLine("2) Aleatório:");
escolha = int.Parse(Console.ReadLine());
switch(escolha)
{
case 1:
bool boiaA, boiaB, boiaC, continuar;
do
{
	Console.WriteLine("A boia A (primeiro nível) está cheia? (0 para não, 1 para sim)");
	boiaA = Console.ReadLine() == "1";
	Console.WriteLine("\nA boia B (segundo nível) está cheia? (0 para não, 1 para sim)");
	boiaB = Console.ReadLine() == "1";
	Console.WriteLine("\nA boia C (caixa d'água) está cheia? (0 para não, 1 para sim)");
	boiaC = Console.ReadLine() == "1";
		
	if (!boiaA && !boiaB && !boiaC)
		{
			Console.WriteLine("\nLigue a válvula.");
			Console.WriteLine("\nNão ligue a bomba.");
		}
	else if (!boiaA && !boiaB && boiaC)
		{
			Console.WriteLine("\nLigue a válvula.");
			Console.WriteLine("\nNão ligue a bomba.");
		}
	else if (!boiaA && boiaB && !boiaC)
		{
			Console.WriteLine("\nErro, tente novamente");
		}
	else if (!boiaA && boiaB && boiaC)
		{
			Console.WriteLine("\nErro, tente novamente");
		}
	else if (boiaA && !boiaB && !boiaC)
		{
			Console.WriteLine("\nLigue a válvula.");
			Console.WriteLine("\nLigue a bomba.");
		}
	else if (boiaA && !boiaB && boiaC)
		{
			Console.WriteLine("\nLigue a válvula.");
			Console.WriteLine("\nNão ligue a bomba.");
		}
	else if (boiaA && boiaB && !boiaC)
		{
			Console.WriteLine("\nNão ligue a válvula.");
			Console.WriteLine("\nLigue a bomba.");
    	}
	else if (!boiaA && !boiaB && boiaC)
		{
			Console.WriteLine("\nNão ligue a válvula.");
			Console.WriteLine("\nLigue a bomba.");
		}
	else
		{
			Console.WriteLine("\nDesligue a válvula.");
			Console.WriteLine("\nNão ligue a bomba.");
		}

			Console.WriteLine("\nDeseja continuar?");
			continuar = Console.ReadLine() == "1";
		}
        while (continuar);
		break;

		case 2:
        bool boiaA, boiaB, boiaC, continuar;
        Random random = new Random();

        do
        {
            boiaA = random.Next(2) == 1;
            boiaB = random.Next(2) == 1;
            boiaC = random.Next(2) == 1;

            Console.WriteLine($"A boia A (primeiro nível) está cheia? {(boiaA ? "Sim" : "Não")}");
            Console.WriteLine($"A boia B (segundo nível) está cheia? {(boiaB ? "Sim" : "Não")}");
            Console.WriteLine($"A boia C (caixa d'água) está cheia? {(boiaC ? "Sim" : "Não")}");

            if (!boiaA && !boiaB && !boiaC)
            {
                Console.WriteLine("\nLigue a válvula.");
                Console.WriteLine("Não ligue a bomba.");
            }
            else if (!boiaA && !boiaB && boiaC)
            {
                Console.WriteLine("\nLigue a válvula.");
                Console.WriteLine("Não ligue a bomba.");
            }
            else if (!boiaA && boiaB && !boiaC)
            {
                Console.WriteLine("\nErro, tente novamente");
            }
            else if (!boiaA && boiaB && boiaC)
            {
                Console.WriteLine("\nErro, tente novamente");
            }
            else if (boiaA && !boiaB && !boiaC)
            {
                Console.WriteLine("\nLigue a válvula.");
                Console.WriteLine("Ligue a bomba.");
            }
            else if (boiaA && !boiaB && boiaC)
            {
                Console.WriteLine("\nLigue a válvula.");
                Console.WriteLine("Não ligue a bomba.");
            }
            else if (boiaA && boiaB && !boiaC)
            {
                Console.WriteLine("\nNão ligue a válvula.");
                Console.WriteLine("Ligue a bomba.");
            }
            else if (!boiaA && !boiaB && boiaC)
            {
                Console.WriteLine("\nNão ligue a válvula.");
                Console.WriteLine("Ligue a bomba.");
            }
            else
            {
                Console.WriteLine("\nDesligue a válvula.");
                Console.WriteLine("Não ligue a bomba.");
            }

            Console.WriteLine("\nDeseja continuar? (1 para sim, 0 para não)");
            continuar = Console.ReadLine() == "1";
        }
        while (continuar);

		default: 
        Console.WriteLine("Opção inválida!"); 
        break;
}
    

