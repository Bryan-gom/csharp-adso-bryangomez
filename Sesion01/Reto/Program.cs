// ========================================================
// PROYECTO: Reto - Sesión 01
// REPOSITORIO: csharp-adso-bryangomez
// PROGRAMA: Análisis y Desarrollo de Software (ADSO) - SENA
// DESCRIPCIÓN: Calculadora de propinas interactiva.
//              Solicita total de la cuenta, porcentaje de propina
//              y número de personas, mostrando los resultados en
//              formato de moneda con validación de entradas.
// ========================================================

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("=== CALCULADORA DE PROPINAS ===");
Console.ResetColor();

// 1. Lectura y validación del total de la cuenta
Console.Write("Total de la cuenta: ");
if (!double.TryParse(Console.ReadLine(), out double total) || total <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Por favor, ingresa un valor válido para la cuenta (mayor a 0).");
    Console.ResetColor();
    return;
}

// 2. Lectura y validación del porcentaje de propina
Console.Write("Porcentaje de propina: ");
if (!double.TryParse(Console.ReadLine(), out double porcentaje) || porcentaje < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Por favor, ingresa un porcentaje de propina válido (0 o mayor).");
    Console.ResetColor();
    return;
}

// 3. Lectura y validación del número de personas
Console.Write("Número de personas: ");
if (!int.TryParse(Console.ReadLine(), out int personas) || personas <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("El número de personas debe ser al menos 1.");
    Console.ResetColor();
    return;
}

// 4. Cálculos matemáticos
double propina = total * (porcentaje / 100.0);
double totalPagar = total + propina;
double porPersona = totalPagar / personas;

// 5. Presentación de resultados con formato de moneda y color
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine($"Propina:           {propina:C0}");
Console.WriteLine($"Total:             {totalPagar:C0}");
Console.WriteLine($"Cada persona paga: {porPersona:C0}");
Console.ResetColor();
