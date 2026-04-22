static int demanar(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


//Exercici 1
int numeroEscollit;
int sumaDeNumeros = 0;
int n1 = 13;

//Exercici 2
int n2;
int nParells = 0;
int nSenars = 0;

string queTriarText = "Exercici a provar?";
int queTriar;
queTriar = demanar(queTriarText);
switch (queTriar)
{
	case 1:
		string EX1Text = "Introdueix un numero enter";
		numeroEscollit = demanar(EX1Text);

		while (n1 <= numeroEscollit)
		{
			sumaDeNumeros += n1;
			n1++;
		}

		Console.WriteLine(sumaDeNumeros);
		break;

	case 2:
		string EX2Text = "Introdueix un numero enter";
		n2 = demanar(EX2Text);

		for (int i = 1; i <= n2; i++)
		{
			if (i % 2 == 0)
			{
				nParells += 1;
			}
			else
			{
				nSenars += 1;
			}
		}
		
		Console.WriteLine(nParells);
		Console.WriteLine(nSenars);
		break;

	case 3:
		Random rnd = new Random();
		int nRival = rnd.Next(0, 3);
		string EX3Text = "posa un numero per jugar al pedra paper tisora";
		int nJugador = demanar(EX3Text);
		switch (nRival)
		{
			case 0: // PEDRA
				if (nJugador == nRival)
				{
					Console.WriteLine("Empat");
				}
				else if (nJugador == 1)
				{
					Console.WriteLine("Has guanyat amb paper!");
				}
				else
				{
					Console.WriteLine("Has perdut");
				}
					break;

			case 1: //PAPER
                if (nJugador == nRival)
                {
                    Console.WriteLine("Empat");
                }
                else if (nJugador == 2)
                {
                    Console.WriteLine("Has guanyat amb tisora!");
                }
                else
                {
                    Console.WriteLine("Has perdut");
                }
                break;

			case 2: //TISORA
                if (nJugador == nRival)
                {
                    Console.WriteLine("Empat");
                }
                else if (nJugador == 0)
                {
                    Console.WriteLine("Has guanyat amb pedra!");
                }
                else
                {
                    Console.WriteLine("Has perdut");
                }
                break;
		}
		break;

	case 4:
		int saldo = 500;
		int efectiu = 0;
		string EX4Text = "0 per veure saldo | 1 per treure | 2 per ingresar";
		string treureText = "quant vols treure/ingresar";
		int quantitatATreure = 0;
		int choice = demanar(EX4Text);
        switch (choice)
        {
            case 0:
                Console.WriteLine(saldo);
                break;

            case 1:
                quantitatATreure = demanar(treureText);
                if (quantitatATreure > saldo)
                {
                    Console.WriteLine("No tens saldo suficient");
                    break;
                }

                efectiu += quantitatATreure;
                saldo -= quantitatATreure;

                Console.WriteLine($"tens {efectiu}€ efectiu i {saldo}€ saldo");
                break;

            case 2:
                quantitatATreure = demanar(treureText);
                if (quantitatATreure > efectiu)
                {
                    Console.WriteLine("No tens efectiu suficient");
                    break;
                }

                efectiu -= quantitatATreure;
                saldo += quantitatATreure;

                Console.WriteLine($"tens {efectiu}€ efectiu i {saldo}€ saldo");
                break;
        }

        break;
}