// ========================================================
// PROYECTO: Reto - Sesión 02
// REPOSITORIO: csharp-adso-bryangomez
// PROGRAMA: Análisis y Desarrollo de Software (ADSO) - SENA
// DESCRIPCIÓN: Simulación de un Cajero Automático.
//              - Saldo inicial de $500.000.
//              - Validación de PIN (1234) con máximo 3 intentos ("Tarjeta bloqueada").
//              - Menú repetitivo: Consultar, Depositar, Retirar, Salir.
//              - Depositar no acepta negativos ni letras.
//              - Retirar solo múltiplos de $10.000 y nunca más del saldo.
// ========================================================

const string PinCorrecto = "1234";
const int MaxIntentos = 3;
int intentos = 0;
bool autenticado = false;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("========================================");
Console.WriteLine("       CAJERO AUTOMÁTICO ADSO SENA      ");
Console.WriteLine("========================================");
Console.ResetColor();

// 1. CONTROL DE ACCESO MEDIANTE PIN (Máximo 3 intentos)
while (intentos < MaxIntentos && !autenticado)
{
    Console.Write($"\nIngresa tu clave PIN ({intentos + 1} de {MaxIntentos}): ");
    string pin = Console.ReadLine() ?? "";

    if (pin == PinCorrecto)
    {
        autenticado = true;
    }
    else
    {
        intentos++;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("PIN incorrecto.");
        Console.ResetColor();
    }
}

// Si agotó los 3 intentos sin acertar
if (!autenticado)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nTarjeta bloqueada. Has superado el límite de intentos permitidos.");
    Console.ResetColor();
    return;
}

// 2. MENÚ PRINCIPAL Y OPERACIONES DEL CAJERO
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\n¡PIN correcto! Bienvenido a tu cuenta bancaria.");
Console.ResetColor();

double saldo = 500000;
bool salir = false;

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n--- MENÚ DE OPERACIONES ---");
    Console.ResetColor();
    Console.WriteLine("1. Consultar saldo");
    Console.WriteLine("2. Depositar");
    Console.WriteLine("3. Retirar");
    Console.WriteLine("4. Salir");
    Console.Write("Selecciona una opción (1-4): ");

    string opcion = Console.ReadLine() ?? "";

    switch (opcion)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nTu saldo disponible es: {saldo:C0}");
            Console.ResetColor();
            break;

        case "2":
            Console.Write("\nIngresa el valor a depositar: ");
            // Validación: No acepta letras ni valores menores o iguales a cero
            if (double.TryParse(Console.ReadLine(), out double deposito) && deposito > 0)
            {
                saldo += deposito;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Depósito exitoso por {deposito:C0}.");
                Console.WriteLine($"Nuevo saldo disponible: {saldo:C0}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Monto inválido. No se permiten valores negativos, cero ni letras.");
                Console.ResetColor();
            }
            break;

        case "3":
            Console.Write("\nIngresa el valor a retirar: ");
            // Validación de número
            if (!int.TryParse(Console.ReadLine(), out int retiro) || retiro <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Monto no válido. Debe ingresar un valor numérico positivo.");
                Console.ResetColor();
            }
            // Validación: Solo múltiplos de $10.000
            else if (retiro % 10000 != 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Solo puedes retirar valores en múltiplos de $10.000 (ej. $10.000, $20.000, $50.000).");
                Console.ResetColor();
            }
            // Validación: No retirar más que el saldo disponible
            else if (retiro > saldo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Fondos insuficientes. Tu saldo actual es {saldo:C0}.");
                Console.ResetColor();
            }
            else
            {
                saldo -= retiro;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Retiro exitoso de {retiro:C0}. Por favor retira tu dinero.");
                Console.WriteLine($"Nuevo saldo disponible: {saldo:C0}");
                Console.ResetColor();
            }
            break;

        case "4":
            salir = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nGracias por utilizar el Cajero Automático. ¡Hasta pronto!");
            Console.ResetColor();
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opción no válida. Por favor ingresa un número del 1 al 4.");
            Console.ResetColor();
            break;
    }

} while (!salir);
