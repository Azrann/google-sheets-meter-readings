# SheetsLibrary

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2020.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2020-06-01**, [`pieces/SheetsLibrary/Sheets.cs`](Sheets.cs); fecha del commit que modificó el archivo, recuperada del Git local.
- Primer registro del repositorio Git original que contiene este código: **2020-05-10**. Puede corresponder a una importación; no prueba cuándo se escribió por primera vez.
- Dependencia fechada más reciente entre las comprobadas: [Google.Apis.Sheets.v4 1.45.0.1930](https://www.nuget.org/packages/Google.Apis.Sheets.v4/1.45.0.1930), publicada el **2020-04-16** (versión declarada), en [`pieces/SheetsLibrary/SheetsLibrary.csproj`](SheetsLibrary.csproj).
- Referencia adicional: destino `netcoreapp3.1` en [`pieces/SheetsLibrary/SheetsLibrary.csproj`](SheetsLibrary.csproj); su [versión estable se publicó el 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

La publicación de una dependencia sitúa la configuración conservada a partir de esa versión, si la referencia es válida. Una actualización de paquetes puede ser mucho más reciente que el inicio del proyecto. No se restauraron paquetes para comprobarlo.

Se descartaron las marcas de tiempo de la copia de octubre de 2026 y los documentos generados durante esta revisión. Las fechas recuperables no garantizan que no existan cambios posteriores sin datar.

## Por qué merece la pena mirarlo

GetRow, Get2Rows y GetRows adaptan las celdas de Google Sheets a listas y diccionarios de C#. Esa capa pequeña resulta útil para entender cómo una hoja termina convertida en datos consumibles por otras herramientas.

Puntos de entrada al código:

- [`Sheets.cs`](Sheets.cs)

<!-- END project-context -->

