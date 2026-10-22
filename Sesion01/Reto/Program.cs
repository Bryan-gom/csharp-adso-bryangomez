using System;

// PROYECTO: Reto - Sesión 01
// REPOSITORIO: csharp-adso-bryangomez
// PROGRAMA: Análisis y Desarrollo de Software (ADSO) - SENA
// DESCRIPCIÓN: Programa de consola interactivo que solicita datos del aprendiz,
//              aplica estilos de color y muestra una tarjeta personal con bordes
//              usando interpolación de cadenas ($"...").

// 1. CONFIGURACIÓN INICIAL Y BIENVENIDA CON COLORES
// Limpiamos la pantalla para una presentación ordenada
Console.Clear();

// Color de consola 1 (DarkCyan): Para el encabezado institucional
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("CENTRO DE SERVICIOS Y GESTIÓN EMPRESARIAL - SENA (ADSO)");
Console.WriteLine("FICHA DE IDENTIFICACIÓN DEL APRENDIZ");
Console.ResetColor(); // Restauramos color por defecto

Console.WriteLine("\nPor favor, ingresa la información solicitada a continuación:\n");

// 2. CAPTURA DE DATOS POR CONSOLA (MÍNIMO 4 DATOS)

// Dato 1: Nombre completo
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("1. Nombre completo: ");
Console.ResetColor();
string nombre = Console.ReadLine()?.Trim() ?? string.Empty;
if (string.IsNullOrWhiteSpace(nombre)) nombre = "Bryan Gómez";

// Dato 2: Programa de formación
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("2. Programa de formación: ");
Console.ResetColor();
string programa = Console.ReadLine()?.Trim() ?? string.Empty;
if (string.IsNullOrWhiteSpace(programa)) programa = "Análisis y Desarrollo de Software (ADSO)";

// Dato 3: Número de ficha
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("3. Número de ficha: ");
Console.ResetColor();
string ficha = Console.ReadLine()?.Trim() ?? string.Empty;
if (string.IsNullOrWhiteSpace(ficha)) ficha = "2826901";

// Dato 4: Frase representativa
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("4. Frase que te represente: ");
Console.ResetColor();
string frase = Console.ReadLine()?.Trim() ?? string.Empty;
if (string.IsNullOrWhiteSpace(frase)) frase = "La constancia en el código construye soluciones que trascienden.";

// 3. RENDERIZADO DE LA TARJETA CON BORDES E INTERPOLACIÓN ($"...")
Console.WriteLine("\nGenerando tarjeta personalizada...\n");

// Ancho interior fijo para asegurar bordes perfectamente alineados
int ancho = 70;
string bordeHorizontal = new string('═', ancho);
string separadorHorizontal = new string('─', ancho);

// Color de consola 2 (Green): Bordes de la tarjeta
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"╔{bordeHorizontal}╗");

// Color de consola 3 (Cyan): Título de la tarjeta
Console.ForegroundColor = ConsoleColor.Cyan;
string titulo = "TARJETA DE PRESENTACIÓN DEL APRENDIZ";
int espacioIzquierda = (ancho - titulo.Length) / 2;
int espacioDerecha = ancho - titulo.Length - espacioIzquierda;
Console.WriteLine($"║{new string(' ', espacioIzquierda)}{titulo}{new string(' ', espacioDerecha)}║");

// Separador interior
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"╠{bordeHorizontal}╣");

// Color de consola 4 (White): Datos personales formateados con interpolación ($"...")
Console.ForegroundColor = ConsoleColor.White;

// Imprimimos cada campo asegurando que el borde derecho siempre encaje con exactitud
ImprimirFila($"  Nombre:    {nombre}", ancho);
ImprimirFila($"  Programa:  {programa}", ancho);
ImprimirFila($"  Ficha:     {ficha}", ancho);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"╟{separadorHorizontal}╢");

Console.ForegroundColor = ConsoleColor.White;
ImprimirFila("  Lema personal:", ancho);

// Imprimimos la frase ajustándola automáticamente si es extensa
ImprimirTextoLargo($"\"{frase}\"", 6, ancho);

// Borde inferior final de la tarjeta
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"╚{bordeHorizontal}╝");

// 4. CIERRE Y RESTABLECIMIENTO DE COLORES
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nTarjeta procesada con éxito mediante C# (.NET 8).\n");
Console.ResetColor();

// Función auxiliar para imprimir filas con bordes y relleno uniforme
static void ImprimirFila(string contenido, int anchoMaximo)
{
    string textoAjustado = contenido.PadRight(anchoMaximo);
    if (textoAjustado.Length > anchoMaximo)
    {
        textoAjustado = textoAjustado.Substring(0, anchoMaximo);
    }
    Console.WriteLine($"║{textoAjustado}║");
}

// Función auxiliar para dividir textos largos en renglones respetando las palabras
static void ImprimirTextoLargo(string texto, int sangria, int anchoMaximo)
{
    int anchoUtil = anchoMaximo - sangria - 2;
    string[] palabras = texto.Split(' ');
    string lineaActual = string.Empty;

    foreach (string palabra in palabras)
    {
        if (lineaActual.Length + palabra.Length + (lineaActual.Length == 0 ? 0 : 1) <= anchoUtil)
        {
            lineaActual += (lineaActual.Length == 0 ? "" : " ") + palabra;
        }
        else
        {
            ImprimirFila(new string(' ', sangria) + lineaActual, anchoMaximo);
            lineaActual = palabra;
        }
    }

    if (!string.IsNullOrEmpty(lineaActual))
    {
        ImprimirFila(new string(' ', sangria) + lineaActual, anchoMaximo);
    }
}
