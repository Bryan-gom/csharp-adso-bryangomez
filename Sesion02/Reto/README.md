# Sesión 02 - Reto: Menú de Cajero Automático

Este proyecto corresponde al reto práctico oficial de la **Sesión 02** para el programa de formación **Análisis y Desarrollo de Software (ADSO)** del SENA.

---

## Descripción del Reto
El programa simula un cajero automático bancario con las siguientes reglas de negocio:
1. **Autenticación con PIN**:
   - PIN predeterminado: `1234`.
   - Máximo 3 intentos de ingreso. Si el usuario falla los 3 intentos, se muestra el mensaje `"Tarjeta bloqueada"` y el programa finaliza.
2. **Saldo Inicial**:
   - Inicia con un saldo base de **$500.000**.
3. **Menú interactivo repetitivo**:
   - Se repite mediante un ciclo `do-while` hasta que el usuario elija la opción **4. Salir**.
   - Opciones:
     1. **Consultar saldo**: Muestra el saldo actual formateado como moneda (`:C0`).
     2. **Depositar**: Valida con `double.TryParse` que no se ingresen negativos, cero ni letras.
     3. **Retirar**: Valida que el monto sea un número entero positivo, múltiplo de `$10.000` (utilizando el operador residuo `% 10000 == 0`) y que no supere el saldo disponible en la cuenta.
     4. **Salir**: Despide al usuario y finaliza la sesión.

---

## Conceptos Aplicados de la Sesión
- **Condicionales**: `if`, `else if`, `else`, comparadores lógicos (`&&`, `||`).
- **Estructura de selección**: `switch` para el control de opciones del menú.
- **Ciclos de control**: `while` para los intentos del PIN y `do-while` para el menú interactivo.
- **Validación robusta con `TryParse`**: Prevención de fallos ante entradas no numéricas.
- **Operador módulo (`%`)**: Verificación de múltiplos de $10.000.
- **Formato de moneda**: `{saldo:C0}` para pesos colombianos.
- **Experiencia de usuario**: Colores en consola (`Cyan`, `Green`, `Yellow`, `Red`).

---

## Cómo ejecutar el proyecto

Desde una terminal en esta carpeta:
```bash
dotnet run
```
