// ========================================================
// PROYECTO: Tarea - Sesión 01
// REPOSITORIO: csharp-adso-bryangomez
// PROGRAMA: Análisis y Desarrollo de Software (ADSO) - SENA
// DESCRIPCIÓN: 3 ejercicios prácticos de consolidación:
//              1. Conversión de segundos a formato de reloj (h, min, s).
//              2. Conversión de temperatura (°C a °F) con validación.
//              3. Cálculo de promedio de 3 notas con formato de 1 decimal.
// ========================================================

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("=== TAREA SESIÓN 01: EJERCICIOS PRÁCTICOS ===");
Console.ResetColor();

// --------------------------------------------------------
// EJERCICIO 1: Segundos a reloj (usa / y %)
// Ejemplo: 3725 segundos -> 1 h 2 min 5 s
// --------------------------------------------------------
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n--- 1. Conversor de Segundos a Reloj ---");
Console.ResetColor();

Console.Write("Ingresa la cantidad total de segundos: ");
if (int.TryParse(Console.ReadLine(), out int totalSegundos) && totalSegundos >= 0)
{
    int horas = totalSegundos / 3600;
    int minutos = (totalSegundos % 3600) / 60;
    int segundos = totalSegundos % 60;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Resultado: {totalSegundos} segundos equivalen a {horas} h {minutos} min {segundos} s");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Por favor, ingresa un número entero positivo para los segundos.");
    Console.ResetColor();
}

// --------------------------------------------------------
// EJERCICIO 2: Temperatura (°C a °F)
// Fórmula: F = C * 9 / 5 + 32, validando la entrada
// --------------------------------------------------------
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n--- 2. Conversor de Temperatura (°C a °F) ---");
Console.ResetColor();

Console.Write("Ingresa la temperatura en grados Celsius (°C): ");
if (double.TryParse(Console.ReadLine(), out double celsius))
{
    double fahrenheit = (celsius * 9.0 / 5.0) + 32;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Resultado: {celsius}°C = {fahrenheit:N1}°F");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Entrada no válida. Asegúrate de ingresar un número.");
    Console.ResetColor();
}

// --------------------------------------------------------
// EJERCICIO 3: Promedio de 3 notas con un decimal ({promedio:N1})
// Pide 3 notas (0,0 a 5,0) con double.TryParse y muestra el promedio
// --------------------------------------------------------
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n--- 3. Promedio de 3 Notas ---");
Console.ResetColor();

Console.Write("Ingresa la Nota 1 (0,0 a 5,0): ");
bool esNota1Valida = double.TryParse(Console.ReadLine(), out double nota1);

Console.Write("Ingresa la Nota 2 (0,0 a 5,0): ");
bool esNota2Valida = double.TryParse(Console.ReadLine(), out double nota2);

Console.Write("Ingresa la Nota 3 (0,0 a 5,0): ");
bool esNota3Valida = double.TryParse(Console.ReadLine(), out double nota3);

if (esNota1Valida && esNota2Valida && esNota3Valida)
{
    double promedio = (nota1 + nota2 + nota3) / 3.0;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nEl promedio final es: {promedio:N1}");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nUna o más notas no fueron válidas. Recuerda usar coma para decimales (ej. 3,5).");
    Console.ResetColor();
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n¡Ejercicios completados exitosamente!");
Console.ResetColor();
