Console.WriteLine("quin exercici vols");
int queTriar = Convert.ToInt32(Console.ReadLine());
switch (queTriar)
{
	case 1:
        Random rnd = new Random();
        int[] numeros = new int[55];

        // Generar els 55 números aleatoris
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = rnd.Next(22, 1560); // genera entre 22 i 1559 inclosos
        }

        // Buscar el més petit i el més gran amb una cerca manual
        int min = numeros[0];
        int max = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] < min)
                min = numeros[i];

            if (numeros[i] > max)
                max = numeros[i];
        }

        // Mostrar resultats
        Console.WriteLine("El valor més petit és: " + min);
        Console.WriteLine("El valor més gran és: " + max);
        break;

    case 2:
        Random rng = new Random();
        int[] numeros2 = new int[333];

        for (int i = 0; i < numeros2.Length; i++)
        {
            numeros2[i] = rng.Next(100);
        }

        
        break;

    case 3:

        break;
    case 4:

        break;
}