
//Variables
int queTriar;

//Exercici 1
int valor1;
double valor2;
double resultat;

//Exercici 2
int catet1;
int catet2;
double hipotenusa;

//Exercici 3
double A;
double B;
double C;
double resultatEquacio;
double arrel;
double x1;
double x2;

Console.WriteLine("Exercici a provar? ");
queTriar = Convert.ToInt32(Console.ReadLine());
switch (queTriar)
{
	case 1:
		Console.WriteLine("introdueix un numero enter ");
		valor1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("introdueix un numero decimal ");
		valor2 = Convert.ToDouble(Console.ReadLine());

		resultat = valor1 + valor2;

		Console.WriteLine("el resultat és " + resultat);
		break;

	case 2:
		Console.WriteLine("Càlculadora de pitàgoras, introdueix el valor del primer catet: ");
		catet1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introdueix el valor del segon catet: ");
		catet2 = Convert.ToInt32(Console.ReadLine());

		//Càlcul de pitàgoras
		hipotenusa = Math.Sqrt(Math.Pow(catet1, 2) + (Math.Pow(catet2, 2)));

		Console.WriteLine("La resposta és " + hipotenusa.ToString("0.00"));
		break;

	/*case 3:
		Console.WriteLine("Introdueix el primer valor ");
		A = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Introdueix el segon valor ");
		B = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Introdueix el tercer valor ");
		C = Convert.ToDouble(Console.ReadLine());

		arrel = Math.Pow(B, 2) - 4 * A * C;

		if (arrel > 0)
		{
			x1 = (-B + math.Sqrt(arrel));
		}
        else if (arrel == 0)
        {
             
        }
		else
		{
			Console.WriteLine("no es posible, arrel negativa");
		}

        break;

	*/
}
