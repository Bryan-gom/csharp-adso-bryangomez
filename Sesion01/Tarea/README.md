# Sesión 01 - Tarea: Ejercicios Prácticos de Consolidación

Este proyecto corresponde a la **Tarea** oficial de la **Sesión 01** para el programa de formación **Análisis y Desarrollo de Software (ADSO)** del SENA.

---

## Ejercicios Desarrollados

### 1. Segundos a Reloj (Uso de operadores `/` y `%`)
- **Descripción**: Solicita una cantidad total de segundos y la convierte al formato `X h Y min Z s`.
- **Ejemplo**: `3725` segundos equivalen a `1 h 2 min 5 s`.
- **Lógica aplicada**:
  - Horas: `totalSegundos / 3600`
  - Minutos: `(totalSegundos % 3600) / 60`
  - Segundos restantes: `totalSegundos % 60`

### 2. Conversor de Temperatura (°C a °F)
- **Descripción**: Solicita la temperatura en grados Celsius y la convierte a grados Fahrenheit.
- **Fórmula**: `F = C * 9 / 5 + 32`
- **Validación**: Uso de `double.TryParse` para asegurar una entrada numérica válida.
- **Formato**: Salida con 1 decimal (`:N1`).

### 3. Promedio de 3 Notas
- **Descripción**: Solicita tres notas en rango de 0,0 a 5,0 mediante `double.TryParse`.
- **Resultado**: Calcula la media aritmética y la muestra formateada con un decimal (`{promedio:N1}`).

---

## Requerimientos y Buenas Prácticas Aplicadas
- **Lectura segura con `TryParse`**: Evita excepciones de formato si el usuario escribe letras o formatos incorrectos.
- **Tipos de datos adecuados**: Uso de `int` para tiempo/segundos y `double` para temperaturas y calificaciones.
- **Estilos de consola**: Colores `Cyan`, `Yellow`, `Green` y `Red` para diferenciar secciones, entradas, resultados y mensajes de error.
- **Instrucciones de nivel superior**: Código limpio y legible en C# / .NET 8.

---

## Cómo ejecutar el proyecto

Desde una terminal en esta carpeta:
```bash
dotnet run
```
