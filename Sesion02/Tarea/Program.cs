using System;

// PROYECTO: Tarea - Sesión 02
// REPOSITORIO: csharp-adso-bryangomez
// PROGRAMA: Análisis y Desarrollo de Software (ADSO) - SENA
// DESCRIPCIÓN: Juego de consola en C# (.NET 8) para adivinar un número secreto
//              entre 1 y 100 en un máximo de 7 intentos, con pistas de mayor/menor.

// 1. Configuración inicial del juego
const int maxIntentos = 7;
int numeroSecreto = Random.Shared.Next(1, 101);
int intentoActual = 1;
int intentoUsuario = 0;
bool acerto = false;
string? entrada = null;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("JUEGO DE ADIVINANZA - NÚMERO SECRETO");
Console.WriteLine("Adivina el número entre 1 y 100. Tienes 7 intentos.\n");
Console.ResetColor();

// 2. Ciclo principal de intentos
while (intentoActual <= maxIntentos && !acerto)
{
    Console.Write($"Intento {intentoActual} de {maxIntentos}: Ingresa tu número (1-100): ");
    entrada = Console.ReadLine();

    // Control de cierre de consola o EOF
    if (entrada == null)
    {
        Console.WriteLine("\nJuego finalizado.");
        break;
    }

    // Validación de entrada numérica
    if (!int.TryParse(entrada, out intentoUsuario) || intentoUsuario < 1 || intentoUsuario > 100)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no válida. Por favor, escribe un número entero entre 1 y 100.\n");
        Console.ResetColor();
        continue;
    }

    // Evaluación del intento
    if (intentoUsuario == numeroSecreto)
    {
        acerto = true;
        Console.ForegroundColor = ConsoleColor.Green;
        string sufijo = intentoActual == 1 ? "intento" : "intentos";
        Console.WriteLine($"\n¡Felicidades! Acertaste el número secreto ({numeroSecreto}) en {intentoActual} {sufijo}.\n");
        Console.ResetColor();
    }
    else if (intentoUsuario < numeroSecreto)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"El número secreto es MAYOR que {intentoUsuario}.\n");
        Console.ResetColor();
        intentoActual++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"El número secreto es MENOR que {intentoUsuario}.\n");
        Console.ResetColor();
        intentoActual++;
    }
}

// 3. Resultado si agotó todos los intentos sin acertar
if (!acerto && entrada != null)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\nHas agotado tus {maxIntentos} intentos. El número secreto era: {numeroSecreto}.\n");
    Console.ResetColor();
}
