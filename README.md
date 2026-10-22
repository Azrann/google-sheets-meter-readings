**Languages:** [English](README.md) · [Español](README.es.md)

# google-sheets-meter-readings

Meter readings and Google Sheets access.

<!-- BEGIN project-context -->

## Historical dates and evidence

**Reference year for this version: 2021.** This uses the most recent source or configuration file with a recoverable historical date; the exact creation date could not be confirmed.

- Most recent datable file: **2021-04-07**, [`pieces/MeterReading/Program.cs`](pieces/MeterReading/Program.cs); date of the commit modifying the file, recovered from local Git history.
- Earliest record among the original Git repositories included: **2020-05-10**. This may be an import and does not establish when the code was first written.
- Most recently published dependency among those checked: [Google.Apis.Sheets.v4 1.45.0.1930](https://www.nuget.org/packages/Google.Apis.Sheets.v4/1.45.0.1930), published on **2020-04-16** (declared version), in [`pieces/SheetsLibrary/SheetsLibrary.csproj`](pieces/SheetsLibrary/SheetsLibrary.csproj).
- Additional reference: target `netcoreapp3.1` in [`pieces/MeterReading/MeterReading.csproj`](pieces/MeterReading/MeterReading.csproj); its [stable release was published on 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). This indicates the technology generation; earlier preview releases may have existed.

A dependency's publication places the preserved configuration at or after that version, if the reference is valid. Package updates may be much newer than the project's beginnings. Packages were not restored to verify this.

October 2026 copy timestamps and documents generated during this review were excluded. Recoverable dates do not guarantee that there are no later, undated changes.

Reference years by component (most recent datable file):

| Component | Year |
| --- | --- |
| [`pieces/SheetsLibrary`](pieces/SheetsLibrary/) | 2020 |
| [`pieces/SheetsLibrary.Test`](pieces/SheetsLibrary.Test/) | 2020 |
| [`pieces/MeterReading`](pieces/MeterReading/) | 2021 |
| [`pieces/MeterReadings`](pieces/MeterReadings/) | 2021 |

## Why this is worth exploring

Transforms spreadsheets into reports by building and dwelling, including dwellings without readings. It is an administrative automation example with a clear flow from API to output document.

Code entry points:

- [`pieces/SheetsLibrary/Sheets.cs`](pieces/SheetsLibrary/Sheets.cs)
- [`pieces/MeterReadings/Program.cs`](pieces/MeterReadings/Program.cs)

<!-- END project-context -->

## Contents

| Directory | Function |
| --- | --- |
| [`pieces/SheetsLibrary/`](pieces/SheetsLibrary/) | Source code |
| [`pieces/SheetsLibrary.Test/`](pieces/SheetsLibrary.Test/) | Source code |
| [`pieces/MeterReading/`](pieces/MeterReading/) | Source code |
| [`pieces/MeterReadings/`](pieces/MeterReadings/) | Source code |

The service account JSON and meter reading data are not included. Create your own credentials and keep them outside Git.

## Requirements and setup

.NET Core, Google Sheets API, and NuGet.

This is a historical copy. Consult each component's project files and README for versions and dependencies. Restore NuGet/npm from the appropriate folder; internal libraries may need rebuilding. Prepare databases and external services using your own accounts.

## Configuration and security

Original secrets have been removed or replaced with `REPLACE_WITH_YOUR_VALUE`. Search for this marker before running and provide values through local configuration or environment variables. Sessions, private keys, signing certificates, databases, logs, deployment profiles, and binary packages are not published. The `.gitignore` protects these local files.

A fresh history is published: old commits remain only in the original local copy. Example values cannot connect to the original services.

## Validation status

A static review and secret scan were performed before publication. Applications, trading operations, deployments, and tests contacting external services were not run. Building with current tools is not guaranteed. Some projects need historical dependencies and assets that are not included.

## Licenses and provenance

Third-party licenses and attributions present in the code are retained. No blanket license is added to components that lacked one. This import preserves local sources and does not claim to be a current version of the original project.
