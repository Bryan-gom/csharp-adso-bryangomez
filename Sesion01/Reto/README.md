# Sesión 01 - Reto: Calculadora de Propinas

Este proyecto corresponde al reto práctico oficial de la **Sesión 01** para el programa de formación **Análisis y Desarrollo de Software (ADSO)** del SENA.

---

## Descripción del Reto
El programa solicita al usuario:
1. El **total de la cuenta**.
2. El **porcentaje de propina** deseado (por ejemplo, 10%).
3. El **número de personas** entre las cuales se dividirá la cuenta.

Calcula y presenta en consola:
- El valor de la propina calculada.
- El valor total a pagar (cuenta + propina).
- El valor que le corresponde pagar a cada persona.

---

## Requerimientos y Buenas Prácticas Aplicadas
- **Lectura segura con `TryParse`**: Valida que las entradas numéricas sean válidas evitando que el programa se caiga si se escriben letras o valores inválidos.
- **Formato de moneda (`:C0`)**: Muestra los valores numéricos formateados en pesos colombianos.
- **Mensajes claros y amables**: Informa al usuario si ingresa un valor no válido.
- **Estilos con color**: Utiliza `ConsoleColor` (`Cyan`, `Green`, `Red`) para mejorar la experiencia visual en la consola.
- **Instrucciones de nivel superior**: Código limpio y directo acorde a las pautas de C# y .NET 8.

---

## Cómo ejecutar el proyecto

Desde una terminal en esta carpeta:
```bash
dotnet run
```
