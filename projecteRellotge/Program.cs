//Array de hores disponibles
string[] hores = { "una", "dos", "tres", "quatre", "cinc", "sis", "set", "vuit", "nou", "deu", "onze", "dotze" };

//Bucle infinit
while (true)
{
    //Obtenir el temps cada vegada que fa el bucle (1 minut)
    string horaActual = DateTime.Now.ToString("HH");
    int horaIntActual = Convert.ToInt32(horaActual);
    string minutActual = DateTime.Now.ToString("mm");
    int minutIntActual = Convert.ToInt32(minutActual);

    //Convertir les hores mes grans que 12 (20 -> 8)
    if (horaIntActual > 12)
        horaIntActual = horaIntActual - 12;

    //Switch, només executa quan minut actual és un multiple de 5, si no mostra la hora en numeros
    switch (minutIntActual)
    {
        case 0:
            Console.WriteLine("La hora és " + hores[horaIntActual - 1]);
            break;

        case 5:
            Console.WriteLine("La hora és: Les " + hores[horaIntActual - 1] + " i cinc");
            break;

        case 10:
            Console.WriteLine("La hora és: Les " + hores[horaIntActual - 1] + " i deu");
            break;

        case 15:
            Console.WriteLine("La hora és: Un quart de " + hores[horaIntActual]);
            break;

        case 20:
            Console.WriteLine("La hora és: Un quart i cinc de " + hores[horaIntActual]);
            break;

        case 25:
            Console.WriteLine("La hora és: Un quart i deu de " + hores[horaIntActual]);
            break;

        case 30:
            Console.WriteLine("La hora és: Dos quarts de " + hores[horaIntActual]);
            break;

        case 35:
            Console.WriteLine("La hora és: Dos quarts i cinc de " + hores[horaIntActual]);
            break;

        case 40:
            Console.WriteLine("La hora és: Dos quarts i deu de " + hores[horaIntActual]);
            break;

        case 45:
            Console.WriteLine("La hora és: Tres quarts de " + hores[horaIntActual]);
            break;

        case 50:
            Console.WriteLine("La hora és: Tres quarts i cinc de " + hores[horaIntActual]);
            break;

        case 55:
            Console.WriteLine("La hora és: Tres quarts i deu de " + hores[horaIntActual]);
            break;

        case 60:
            Console.WriteLine("La hora és: " + hores[horaIntActual]);
            break;

        default:
            Console.WriteLine(DateTime.Now.ToString("HH:mm"));
            break;
    }

    //Espero 1 minut abans de tornar a executar el bucle
    Thread.Sleep(60000);
}
