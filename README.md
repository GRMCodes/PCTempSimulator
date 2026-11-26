# PC Temp Simulator

Simulación de un sistema de enfriamiento inteligente para una computadora, hecha en C# con Windows Forms.

**Universidad Interamericana de Puerto Rico · Departamento de Informática**
**COMP 3300 · Proyecto Final** · Profesor: Dr. Rafael Nieves Rivera

**Integrantes:** _(Evan Tellado, Gian Rivera, Keven Paulino)_

---

## Descripción

El programa simula un sensor que mide la temperatura de un procesador y un controlador que decide la velocidad de un ventilador según esa temperatura. Representa el flujo:

**Sensor → Controlador → Programa → Decisión → Dispositivo de salida**

| Componente | En el programa |
|---|---|
| Sensor (entrada) | Caja numérica de temperatura o botón **Random** |
| Controlador (procesamiento) | Clase `Controlador`, método `Evaluar` |
| Ventilador (salida) | Barra de progreso y texto de velocidad |
| Indicador de estado (salida adicional) | Mensaje con color y popup de alerta |

## Reglas del sistema

Valores usados únicamente como criterios académicos de la simulación.

| Temperatura | Estado | Ventilador |
|---|---|---|
| Menor de 40 °C | Normal | 0% |
| 40 a 59 °C | Moderada | 40% |
| 60 a 74 °C | Alta | 70% |
| 75 a 89 °C | Muy Alta | 100% |
| 90 °C o más | Crítica | 100% + alerta |

## Cómo usarlo

1. Escribe una temperatura (0 a 150 °C) en el cuadro numérico y presiona **Evaluar**, o presiona **Random** para generar una temperatura aleatoria (20 a 110 °C) y evaluarla.
2. El programa muestra:
   - El mensaje de estado, con color según la gravedad.
   - La velocidad del ventilador en texto y en la barra de progreso.
   - Una nueva fila en la tabla de registros.
3. Si la temperatura es crítica, aparece un popup de **ALERTA**.

### Tabla de registros

Columnas: `#`, `Temp.`, `Estado`, `Vel.`, `Duracion`, `Alerta`, `Fecha`.

> La columna **Duracion** es un número aleatorio que representa cuánto tiempo pudo haber estado el sistema a esa temperatura. Es simulado.

### Archivo de log

- Cuando la tabla llega a **10 filas**, estas se guardan en `log_temperaturas.txt` y la tabla se limpia.
- El contador **no se reinicia**, así la numeración del archivo es continua (11, 12, 13...).
- El archivo se encuentra junto al ejecutable (carpeta `bin`) y se **borra cada vez que se inicia el programa**.
- Formato de cada línea: `1 | 45 °C | Moderada | 40% | 37 min | No | 16:05:12`
- Las filas que aún estén en la tabla al cerrar el programa no se guardan en el archivo.

## Requisitos

- Windows
- Visual Studio Community con la carga de trabajo **.NET desktop development**
- Proyecto de tipo **Windows Forms App** (.NET)

## Cómo ejecutarlo

1. Abre la solución (`.sln`) en Visual Studio.
2. Presiona **F5** (o el botón verde **Iniciar**).

## Estructura del proyecto

| Archivo | Contenido |
|---|---|
| `Program.cs` | Punto de entrada; abre la ventana `Form1` |
| `Form1.cs` | Lógica de la interfaz: botones, tabla, popup y log |
| `Form1.Designer.cs` | Controles de la ventana (generado por Visual Studio) |
| `Controlador.cs` | Lógica de decisión: temperatura → estado, velocidad y alerta |

## Variables principales

| Variable | Tipo | Propósito |
|---|---|---|
| `Temperatura` | `decimal` | Temperatura simulada |
| `Velocidad` | `int` | Velocidad del ventilador (%) |
| `Estado` | `string` | Estado del sistema (Normal, Moderada, Alta, Muy Alta, Critica) |
| `Alerta` | `bool` | Indica situación crítica |
| `Mensaje` | `string` | Texto del indicador de estado |
| `Contador` | `int` | Indica la fila en la tabla de evaluaciones |
| `Random` | `random` | Utilizado para pruebas aleatorias y la duracion |
| `FilePath` | `string` | Almacena el path del archivo de logs |


## Pruebas

| # | Entrada | Resultado esperado |
|---|---|---|
| 1 | 30 °C | Normal |
| 2 | 45 °C | Moderada |
| 3 | 65 °C | Alta |
| 4 | 80 °C | Muy Alta |
| 5 | 95 °C | Crítica |
