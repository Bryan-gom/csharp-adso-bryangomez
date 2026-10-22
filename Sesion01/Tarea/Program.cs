using System;

// PROYECTO: Tarea - Sesión 01
// REPOSITORIO: csharp-adso-bryangomez
// PROGRAMA: Análisis y Desarrollo de Software (ADSO) - SENA
// DESCRIPCIÓN: Traducción a C# (.NET 8) del programa "Bienvenida" de Python.

// Equivalente a: print("=== SISTEMA DE BIENVENIDA - ADSO SENA ===")
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("SISTEMA DE BIENVENIDA - ADSO SENA");
Console.ResetColor();

// Equivalente en Python a: nombre = input("Ingresa tu nombre completo: ")
Console.Write("\nPor favor, ingresa tu nombre completo: ");
string? entradaNombre = Console.ReadLine();
string nombre = string.IsNullOrWhiteSpace(entradaNombre) ? "Bryan Gómez" : entradaNombre.Trim();

// Equivalente en Python a: programa = input("Ingresa tu programa de formación: ")
Console.Write("Ingresa tu programa de formación: ");
string? entradaPrograma = Console.ReadLine();
string programa = string.IsNullOrWhiteSpace(entradaPrograma) ? "Análisis y Desarrollo de Software (ADSO)" : entradaPrograma.Trim();

// Equivalente en Python a: ficha = input("Ingresa tu número de ficha: ")
Console.Write("Ingresa tu número de ficha: ");
string? entradaFicha = Console.ReadLine();
string ficha = string.IsNullOrWhiteSpace(entradaFicha) ? "2826901" : entradaFicha.Trim();

// Equivalente en Python a: print(f"\n¡Bienvenido/a {nombre}! ...")
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\n¡Bienvenido/a, {nombre}!");
Console.ResetColor();

Console.WriteLine($"Has ingresado satisfactoriamente al programa {programa} (Ficha: {ficha}).");
Console.WriteLine("Este programa fue traducido desde Python a C# utilizando .NET 8.\n");
