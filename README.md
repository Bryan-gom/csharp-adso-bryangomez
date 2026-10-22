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
| 6 | **Ciclo repetitivo (Iteración)** | `for item in lista:`<br>&nbsp;&nbsp;&nbsp;&nbsp;`print(item)` | `for (const item of lista) {`<br>&nbsp;&nbsp;`console.log(item);`<br>`}` | `foreach (var item in lista) {`<br>&nbsp;&nbsp;`Console.WriteLine(item);`<br>`}` |

---

## Estructura del Repositorio

- **`Sesion01/`**
  - **`Reto/`**: Proyecto de consola interactivo que solicita datos del aprendiz, aplica estilos de color y genera una tarjeta de presentación con bordes mediante interpolación de cadenas (`$""`).
  - **`Tarea/`**: Proyecto de consola que traduce a C# el programa "Bienvenida" originalmente desarrollado en Python, capturando datos del usuario y mostrando un saludo interactivo en .NET 8.
