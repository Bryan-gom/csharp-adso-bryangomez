# Sesión 03 - Reto: Validador de Contraseñas

Este proyecto corresponde al reto práctico oficial de la **Sesión 03** para el programa de formación **Análisis y Desarrollo de Software (ADSO)** del SENA.

---

## Descripción del Reto
El programa solicita al usuario el ingreso de una contraseña y valida el cumplimiento de **6 reglas de seguridad esenciales**:
1. **Mínimo 8 caracteres:** La longitud de la clave debe ser de al menos 8 símbolos.
2. **Una letra mayúscula:** Contiene al menos un carácter evaluado con `char.IsUpper`.
3. **Una letra minúscula:** Contiene al menos un carácter evaluado con `char.IsLower`.
4. **Un número:** Contiene al menos un dígito evaluado con `char.IsDigit`.
5. **Un carácter especial:** Contiene al menos un símbolo que no sea letra, dígito ni espacio.
6. **Sin espacios:** No debe contener caracteres de espaciado o saltos (`!char.IsWhiteSpace`).

---

## Criterios de Evaluación y Niveles
- **Fuerte:** Cumple las **6 reglas** (6/6). La contraseña es aprobada.
- **Media:** Cumple **4 o 5 reglas**.
- **Débil:** Cumple **3 o menos reglas**.

Si la contraseña no es de nivel **Fuerte**, el programa informa al usuario mediante un ciclo interactivo y vuelve a solicitarla hasta que cumpla todos los criterios.

---

## Conceptos Aplicados de la Sesión
- **Métodos modulares:** Lógica de validación encapsulada en `EvaluarContrasena(string password)`.
- **Métodos auxiliares:** `MostrarResultadoRegla(bool cumple, string descripcion)` para la salida visual con símbolos `✔` y `✘`.
- **Manejo de caracteres y cadenas:** Inspección carácter por carácter con métodos `char.Is*`.
- **Colecciones / Arreglos (`bool[]`):** Almacenamiento de los resultados de cada una de las 6 reglas.
- **Control de flujo:** Ciclo repetitivo `do-while` para reintentos hasta alcanzar seguridad óptima.
- **Formato y experiencia:** Diferenciación visual con `ConsoleColor` (`Cyan`, `Green`, `Yellow`, `Red`).

---

## Cómo ejecutar el proyecto

Desde una terminal en esta carpeta:
```bash
dotnet run
```
