# Repositorio de C# - ADSO (SENA)

**Aprendiz:** Bryan Gómez  
**Programa:** Análisis y Desarrollo de Software (ADSO)  
**Ficha:** 2826901  
**Tecnología:** .NET 8.0 / C#  

---

## Tabla Comparativa de Sintaxis (Python vs. JavaScript vs. C#)

Comparación de 6 instrucciones fundamentales entre los lenguajes abordados durante la formación:

| # | Instrucción / Concepto | Python | JavaScript | C# (.NET) |
|---|------------------------|--------|------------|-----------|
| 1 | **Salida por consola (Imprimir)** | `print("Hola, ADSO")` | `console.log("Hola, ADSO");` | `Console.WriteLine("Hola, ADSO");` |
| 2 | **Entrada por consola (Leer datos)** | `nombre = input("Nombre: ")` | `let nombre = prompt("Nombre:");` | `string? nombre = Console.ReadLine();` |
| 3 | **Declaración de variables** | `edad = 20` *(tipado dinámico)* | `let edad = 20;` *(tipado dinámico)* | `int edad = 20;` *(tipado estático y fuerte)* |
| 4 | **Interpolación de texto** | `f"Hola {nombre}, edad: {edad}"` | `` `Hola ${nombre}, edad: ${edad}` `` | `$"Hola {nombre}, edad: {edad}"` |
| 5 | **Estructura condicional (If / Else)** | `if edad >= 18:`<br>&nbsp;&nbsp;&nbsp;&nbsp;`print("Mayor")`<br>`else:`<br>&nbsp;&nbsp;&nbsp;&nbsp;`print("Menor")` | `if (edad >= 18) {`<br>&nbsp;&nbsp;`console.log("Mayor");`<br>`} else {`<br>&nbsp;&nbsp;`console.log("Menor");`<br>`}` | `if (edad >= 18) {`<br>&nbsp;&nbsp;`Console.WriteLine("Mayor");`<br>`} else {`<br>&nbsp;&nbsp;`Console.WriteLine("Menor");`<br>`}` |
| 6 | **Ciclo repetitivo (Iteración)** | `for item in lista:`<br>&nbsp;&nbsp;&nbsp;&nbsp;`print(item)` | `for (const item of lista) {`<br>&nbsp;&nbsp;`console.log(item);`<br>`}` | `for (int i = 0; i < n; i++)`<br>o `foreach (var item in lista)` |

---

## Estructura del Repositorio

- **`Sesion01/`**: *De Python a C# (Sintaxis, tipos, entrada segura y formatos)*
  - **`Reto/`**: Calculadora de propinas con total de la cuenta, porcentaje de propina, número de personas, formato de moneda (`:C0`), mensajes amables y colores de consola.
  - **`Tarea/`**: Tres ejercicios de consolidación:
    1. Conversor de segundos a formato reloj (`X h Y min Z s`) usando `/` y `%`.
    2. Conversor de temperatura (°C a °F) validado con `TryParse`.
    3. Promedio de 3 notas con formato de un decimal (`:N1`).

- **`Sesion02/`**: *Decisiones, ciclos y depurador*
  - **`Reto/`**: Simulación de cajero automático con saldo de $500.000, PIN de seguridad (1234 con 3 intentos máx.), y menú de operaciones (consultar saldo, depositar montos positivos y retirar múltiplos de $10.000 hasta el límite de saldo).
  - **`Tarea/`**: Juego de consola "Adivina el número secreto" (1 al 100 con 7 intentos máximos y pistas de mayor/menor mediante `Random.Shared.Next(1, 101)`).

- **`Sesion03/`**: *Métodos, arreglos y cadenas*
  - **`Reto/`**: Validador interactivo de contraseñas evaluando 6 reglas de seguridad en un método (longitud, mayúsculas, minúsculas, números, caracteres especiales y sin espacios), mostrando símbolos `✔` o `✘`, clasificación de nivel (Fuerte, Media o Débil) y reintentos automáticos.
  - **`Tarea/`**: Implementación de 2 métodos modulares:
    1. Generador de usuarios institucionales (primera letra del nombre + primer apellido + últimos 2 dígitos del documento, en minúsculas y sin tildes).
    2. Analizador de frases (conteo de palabras e inversión del orden de las palabras mediante `StringBuilder`).

