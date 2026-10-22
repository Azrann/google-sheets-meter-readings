**Languages:** [English](README.md) · [Español](README.es.md)

# google-sheets-meter-readings

Lecturas de contadores y acceso a Google Sheets.

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2021.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2021-04-07**, [`pieces/MeterReading/Program.cs`](pieces/MeterReading/Program.cs); fecha del commit que modificó el archivo, recuperada del Git local.
- Primer registro entre los repositorios Git originales incluidos: **2020-05-10**. Puede corresponder a una importación; no prueba cuándo se escribió por primera vez.
- Dependencia fechada más reciente entre las comprobadas: [Google.Apis.Sheets.v4 1.45.0.1930](https://www.nuget.org/packages/Google.Apis.Sheets.v4/1.45.0.1930), publicada el **2020-04-16** (versión declarada), en [`pieces/SheetsLibrary/SheetsLibrary.csproj`](pieces/SheetsLibrary/SheetsLibrary.csproj).
- Referencia adicional: destino `netcoreapp3.1` en [`pieces/MeterReading/MeterReading.csproj`](pieces/MeterReading/MeterReading.csproj); su [versión estable se publicó el 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

La publicación de una dependencia sitúa la configuración conservada a partir de esa versión, si la referencia es válida. Una actualización de paquetes puede ser mucho más reciente que el inicio del proyecto. No se restauraron paquetes para comprobarlo.

Se descartaron las marcas de tiempo de la copia de octubre de 2026 y los documentos generados durante esta revisión. Las fechas recuperables no garantizan que no existan cambios posteriores sin datar.

Años de referencia por componente (archivo más reciente datable):

| Componente | Año |
| --- | --- |
| [`pieces/SheetsLibrary`](pieces/SheetsLibrary/) | 2020 |
| [`pieces/SheetsLibrary.Test`](pieces/SheetsLibrary.Test/) | 2020 |
| [`pieces/MeterReading`](pieces/MeterReading/) | 2021 |
| [`pieces/MeterReadings`](pieces/MeterReadings/) | 2021 |

## Por qué merece la pena mirarlo

Transforma hojas de cálculo en informes por bloque y vivienda, incluyendo viviendas sin lectura. Es un ejemplo de automatización administrativa con un flujo claro desde la API hasta el documento de salida.

Puntos de entrada al código:

- [`pieces/SheetsLibrary/Sheets.cs`](pieces/SheetsLibrary/Sheets.cs)
- [`pieces/MeterReadings/Program.cs`](pieces/MeterReadings/Program.cs)

<!-- END project-context -->

## Contenido

| Directorio | Función |
| --- | --- |
| [`pieces/SheetsLibrary/`](pieces/SheetsLibrary/) | Código fuente |
| [`pieces/SheetsLibrary.Test/`](pieces/SheetsLibrary.Test/) | Código fuente |
| [`pieces/MeterReading/`](pieces/MeterReading/) | Código fuente |
| [`pieces/MeterReadings/`](pieces/MeterReadings/) | Código fuente |

El JSON de la cuenta de servicio y los datos de lecturas no se incluyen. Crear credenciales propias y guardarlas fuera de Git.

## Requisitos y preparación

.NET Core, Google Sheets API y NuGet.

Esta es una copia histórica. Consultar los archivos de proyecto y los README de cada componente para sus versiones y dependencias. Restaurar NuGet/npm desde la carpeta correspondiente; las bibliotecas internas pueden necesitar reconstrucción. Preparar las bases de datos y los servicios externos con cuentas propias.

## Configuración y seguridad

Los secretos originales se han eliminado o sustituido por `REPLACE_WITH_YOUR_VALUE`. Buscar este marcador antes de ejecutar y aportar los valores mediante configuración local o variables de entorno. Las sesiones, claves privadas, certificados de firma, bases de datos, registros, perfiles de despliegue y paquetes binarios no se publican. El `.gitignore` protege estos archivos locales.

Se publica un historial nuevo: los commits antiguos permanecen únicamente en la copia local original. Los valores de ejemplo no permiten conectarse a los servicios originales.

## Estado de validación

Se realizó una revisión estática y un escaneo de secretos antes de publicar. No se ejecutaron aplicaciones, operaciones de trading, despliegues ni pruebas que contacten servicios externos. No se garantiza la compilación con herramientas actuales. Algunos proyectos necesitan dependencias históricas y activos que no están incluidos.

## Licencias y procedencia

Se conservan las licencias y atribuciones de terceros presentes en el código. No se añade una licencia global a los componentes que no la tenían. Esta importación conserva fuentes locales y no afirma ser una versión actual del proyecto original.
