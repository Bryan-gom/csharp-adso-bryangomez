# Sesión 03 - Tarea: Usuarios y Frases

Este proyecto corresponde a la **Tarea** oficial de la **Sesión 03** para el programa de formación **Análisis y Desarrollo de Software (ADSO)** del SENA.

---

## Métodos Desarrollados

### 1. Generador de Usuarios Institucionales (`GenerarUsuario`)
- **Descripción:** Genera un nombre de usuario combinando:
  - La **primera letra** del primer nombre (en minúscula).
  - El **primer apellido** en minúsculas y sin tildes (normalización ortográfica).
  - Los **2 últimos dígitos** del documento de identidad.
- **Caso de prueba oficial:**
  - Entrada: `"Ana María Gómez Pérez"`, Documento: `1034567812`
  - Salida esperada: `agomez12`
- **Técnicas aplicadas:**
  - Partición de cadenas con `Split`.
  - Tratamiento de tildes y caracteres diacríticos (`QuitarTildes`).
  - Indexación de cadenas y extracción de subcadenas con operadores de rango (`[^2..]`).

### 2. Analizador de Frases (`AnalizarFrase`)
- **Descripción:**
  1. Cuenta cuántas palabras componen una frase ingresada.
  2. Invierte el orden de las palabras construyendo la nueva frase con la clase `StringBuilder` (para manipulación eficiente de memoria).
- **Ejemplo:**
  - Entrada: `"C# es un lenguaje profesional y moderno"`
  - Total de palabras: `7`
  - Salida invertida: `"moderno y profesional lenguaje un es C#"`

---

## Requerimientos y Buenas Prácticas Aplicadas
- **Métodos estáticos modulares:** Separación de responsabilidades con firmas claras, parámetros tipados y valores de retorno con tuplas `(int, string)`.
- **Uso de `StringBuilder`:** Uso del espacio de nombres `System.Text` para operaciones sobre texto sin generar basura innecesaria en memoria.
- **Experiencia de usuario interactiva:** Menú con colores (`Cyan`, `Yellow`, `Green`) y soporte para entradas directas o valores de prueba guiados.

---

## Cómo ejecutar el proyecto

Desde una terminal en esta carpeta:
```bash
dotnet run
```
