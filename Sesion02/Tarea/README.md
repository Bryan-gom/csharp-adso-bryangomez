# Sesión 02 - Tarea: Juego "Adivina el Número"

Este proyecto corresponde a la **Tarea** oficial de la **Sesión 02** para el programa de formación **Análisis y Desarrollo de Software (ADSO)** del SENA.

---

## Descripción del Juego
1. El programa genera un número secreto aleatorio entre 1 y 100 utilizando:
   ```csharp
   int secreto = Random.Shared.Next(1, 101);
   ```
2. El usuario dispone de **7 intentos** como máximo para adivinar el número.
3. En cada intento:
   - Si el número ingresado no es el secreto, el programa indica con una pista si el número secreto es **mayor** o **menor**.
   - Si el usuario acierta, se muestra un mensaje de felicitaciones indicando en cuántos intentos lo logró.
4. Si se agotan los 7 intentos sin acertar, el programa revela cuál era el número secreto.

---

## Requerimientos y Conceptos Aplicados
- **Ciclo `while`**: Controla el flujo de repetición hasta completar los 7 intentos o adivinar el número.
- **Validación con `int.TryParse`**: Garantiza que no se cuelgue el programa si se digitan letras o números fuera del rango 1 a 100.
- **Uso de depurador**:
  - Punto de interrupción (F9) dentro del ciclo.
  - Ejecución paso a paso (F10) e inspección de la ventana *Variables locales* en Visual Studio / VS Code.

---

## Cómo ejecutar el proyecto

Desde una terminal en esta carpeta:
```bash
dotnet run
```
