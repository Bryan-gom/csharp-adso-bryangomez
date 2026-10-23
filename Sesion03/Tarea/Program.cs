using System.Text;

// ========================================================
// PROYECTO: Tarea - Sesión 03
// REPOSITORIO: csharp-adso-bryangomez
// PROGRAMA: Análisis y Desarrollo de Software (ADSO) - SENA
// DESCRIPCIÓN: Implementación de 2 métodos requeridos:
//              1. Generador de usuarios:
//                 Primera letra del nombre + primer apellido + 2 últimos dígitos
//                 del documento, en minúsculas y sin tildes.
//                 (Ej. Ana María Gómez Pérez, 1034567812 -> agomez12).
//              2. Analizador de frases:
//                 Cuenta las palabras de una frase y muestra las palabras
//                 en orden inverso utilizando StringBuilder.
// ========================================================

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("=================================================");
Console.WriteLine("     TAREA SESIÓN 03: USUARIOS Y FRASES (ADSO)   ");
Console.WriteLine("=================================================\n");
Console.ResetColor();

// --------------------------------------------------------
// MÉTODO 1: GENERADOR DE USUARIOS
// --------------------------------------------------------
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("--- 1. GENERADOR DE USUARIOS INSTITUCIONALES ---");
Console.ResetColor();

Console.Write("Ingresa el nombre completo (ej. Ana María Gómez Pérez): ");
string entradaNombre = Console.ReadLine() ?? "";
if (string.IsNullOrWhiteSpace(entradaNombre))
{
    entradaNombre = "Ana María Gómez Pérez";
    Console.WriteLine($"[Usando valor por defecto de prueba: {entradaNombre}]");
}

Console.Write("Ingresa el número de documento (ej. 1034567812): ");
string entradaDoc = Console.ReadLine() ?? "";
if (string.IsNullOrWhiteSpace(entradaDoc))
{
    entradaDoc = "1034567812";
    Console.WriteLine($"[Usando valor por defecto de prueba: {entradaDoc}]");
}

// Llamada al método 1
string usuarioGenerado = GenerarUsuario(entradaNombre, entradaDoc);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nUsuario institucional generado: {usuarioGenerado}\n");
Console.ResetColor();

// --------------------------------------------------------
// MÉTODO 2: ANALIZADOR DE FRASES
// --------------------------------------------------------
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("--- 2. ANALIZADOR DE FRASES (INVERTIR CON STRINGBUILDER) ---");
Console.ResetColor();

Console.Write("Ingresa una frase para analizar: ");
string entradaFrase = Console.ReadLine() ?? "";
if (string.IsNullOrWhiteSpace(entradaFrase))
{
    entradaFrase = "C# es un lenguaje profesional y moderno";
    Console.WriteLine($"[Usando frase por defecto de prueba: \"{entradaFrase}\"]");
}

// Llamada al método 2
var (totalPalabras, fraseInvertida) = AnalizarFrase(entradaFrase);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nTotal de palabras detectadas: {totalPalabras}");
Console.WriteLine($"Frase con palabras en orden inverso:");
Console.WriteLine($"\"{fraseInvertida}\"\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("¡Ejercicios de la Sesión 03 completados exitosamente!");
Console.ResetColor();

// ========================================================
// MÉTODOS REQUERIDOS DE LA SESIÓN 03
// ========================================================

/// <summary>
/// Genera un nombre de usuario en minúsculas y sin tildes combinando:
/// - Primera letra del primer nombre
/// - Primer apellido
/// - Últimos dos dígitos del documento
/// </summary>
static string GenerarUsuario(string nombreCompleto, string documento)
{
    string[] partes = nombreCompleto.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

    if (partes.Length == 0) return "usuario00";

    // 1. Primera letra del primer nombre
    char primeraLetra = char.ToLower(partes[0][0]);

    // 2. Extracción del primer apellido
    // Si tiene 4 palabras (ej. "Ana María Gómez Pérez"), el primer apellido es la posición 2.
    // Si tiene 2 o 3 palabras (ej. "Bryan Gómez" o "Ana Gómez Pérez"), es la posición 1.
    string primerApellido;
    if (partes.Length >= 4)
    {
        primerApellido = partes[2];
    }
    else if (partes.Length >= 2)
    {
        primerApellido = partes[1];
    }
    else
    {
        primerApellido = partes[0];
    }

    // Limpiar tildes y convertir a minúsculas
    string apellidoLimpio = QuitarTildes(primerApellido).ToLower();

    // 3. Dos últimos dígitos del documento
    string soloDigitos = new string(documento.Where(char.IsDigit).ToArray());
    string ultimosDos = soloDigitos.Length >= 2 ? soloDigitos[^2..] : soloDigitos.PadLeft(2, '0');

    return $"{primeraLetra}{apellidoLimpio}{ultimosDos}";
}

/// <summary>
/// Elimina acentos ortográficos (tildes) y caracteres especiales comunes en español.
/// </summary>
static string QuitarTildes(string texto)
{
    return texto
        .Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u")
        .Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U")
        .Replace("ñ", "n").Replace("Ñ", "N")
        .Replace("ü", "u").Replace("Ü", "U");
}

/// <summary>
/// Cuenta las palabras de una frase y construye una nueva frase con las palabras
/// en orden inverso utilizando la clase StringBuilder.
/// </summary>
static (int TotalPalabras, string FraseInvertida) AnalizarFrase(string frase)
{
    string[] palabras = frase.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int total = palabras.Length;

    if (total == 0) return (0, string.Empty);

    // Construcción de la frase invertida mediante StringBuilder
    var sb = new StringBuilder();

    for (int i = total - 1; i >= 0; i--)
    {
        sb.Append(palabras[i]);
        if (i > 0)
        {
            sb.Append(' ');
        }
    }

    return (total, sb.ToString());
}
