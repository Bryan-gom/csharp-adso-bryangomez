// ========================================================
// PROYECTO: Reto - Sesión 03
// REPOSITORIO: csharp-adso-bryangomez
// PROGRAMA: Análisis y Desarrollo de Software (ADSO) - SENA
// DESCRIPCIÓN: Validador interactivo de contraseñas.
//              Evalúa 6 reglas de seguridad en un método:
//              1. Mínimo 8 caracteres.
//              2. Al menos una letra mayúscula.
//              3. Al menos una letra minúscula.
//              4. Al menos un número.
//              5. Al menos un carácter especial.
//              6. Sin espacios.
//              Muestra ✔ o ✘ por regla y clasifica el nivel:
//              - Débil (3 o menos)
//              - Media (4 o 5)
//              - Fuerte (6)
//              Si la contraseña no es fuerte, se vuelve a solicitar.
// ========================================================

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("========================================");
Console.WriteLine("   VALIDADOR DE CONTRASEÑAS - ADSO SENA ");
Console.WriteLine("========================================\n");
Console.ResetColor();

bool contrasenaAceptada = false;

do
{
    Console.Write("Contraseña: ");
    string contrasena = Console.ReadLine() ?? "";

    // Evaluación encapsulada en un método
    var evaluacion = EvaluarContrasena(contrasena);

    Console.WriteLine();
    MostrarResultadoRegla(evaluacion.Reglas[0], "Mínimo 8 caracteres");
    MostrarResultadoRegla(evaluacion.Reglas[1], "Una mayúscula");
    MostrarResultadoRegla(evaluacion.Reglas[2], "Una minúscula");
    MostrarResultadoRegla(evaluacion.Reglas[3], "Un número");
    MostrarResultadoRegla(evaluacion.Reglas[4], "Un carácter especial");
    MostrarResultadoRegla(evaluacion.Reglas[5], "Sin espacios");

    // Clasificación del nivel
    string nivelTexto;
    ConsoleColor nivelColor;

    if (evaluacion.Cumplidas == 6)
    {
        nivelTexto = "Fuerte";
        nivelColor = ConsoleColor.Green;
        contrasenaAceptada = true;
    }
    else if (evaluacion.Cumplidas >= 4)
    {
        nivelTexto = "Media";
        nivelColor = ConsoleColor.Yellow;
    }
    else
    {
        nivelTexto = "Débil";
        nivelColor = ConsoleColor.Red;
    }

    Console.ForegroundColor = nivelColor;
    Console.WriteLine($"Nivel: {nivelTexto} ({evaluacion.Cumplidas}/6)");
    Console.ResetColor();

    if (contrasenaAceptada)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n¡Felicidades! Tu contraseña cumple con todos los estándares de seguridad.");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nLa contraseña no es fuerte. Por favor, ingresa una nueva contraseña cumpliendo todas las reglas.\n");
        Console.ResetColor();
    }

} while (!contrasenaAceptada);

// ========================================================
// MÉTODOS DE LA SESIÓN 03
// ========================================================

/// <summary>
/// Evalúa una contraseña contra 6 reglas de seguridad y retorna los resultados individuales y el total cumplido.
/// </summary>
static (bool EsFuerte, int Cumplidas, bool[] Reglas) EvaluarContrasena(string password)
{
    bool[] reglas = new bool[6];

    // Regla 1: Mínimo 8 caracteres
    reglas[0] = password.Length >= 8;

    // Regla 2: Una mayúscula
    reglas[1] = password.Any(char.IsUpper);

    // Regla 3: Una minúscula
    reglas[2] = password.Any(char.IsLower);

    // Regla 4: Un número
    reglas[3] = password.Any(char.IsDigit);

    // Regla 5: Un carácter especial (no letra, no dígito, no espacio)
    reglas[4] = password.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c));

    // Regla 6: Sin espacios
    reglas[5] = !password.Any(char.IsWhiteSpace);

    int totalCumplidas = reglas.Count(r => r);
    bool esFuerte = totalCumplidas == 6;

    return (esFuerte, totalCumplidas, reglas);
}

/// <summary>
/// Muestra en consola el estado de una regla con símbolo ✔ (verde) o ✘ (rojo).
/// </summary>
static void MostrarResultadoRegla(bool cumple, string descripcion)
{
    if (cumple)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("✔ ");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("✘ ");
    }

    Console.ResetColor();
    Console.WriteLine(descripcion);
}
