**Languages:** [English](Readme.md) · [Español](README.es.md)

# SheetsLibrary

<!-- BEGIN project-context -->

## Historical dates and evidence

**Reference year for this version: 2020.** This uses the most recent source or configuration file with a recoverable historical date; the exact creation date could not be confirmed.

- Most recent datable file: **2020-06-01**, [`pieces/SheetsLibrary/Sheets.cs`](Sheets.cs); date of the commit modifying the file, recovered from local Git history.
- First record in the original Git repository containing this code: **2020-05-10**. This may be an import and does not establish when the code was first written.
- Most recently published dependency among those checked: [Google.Apis.Sheets.v4 1.45.0.1930](https://www.nuget.org/packages/Google.Apis.Sheets.v4/1.45.0.1930), published on **2020-04-16** (declared version), in [`pieces/SheetsLibrary/SheetsLibrary.csproj`](SheetsLibrary.csproj).
- Additional reference: target `netcoreapp3.1` in [`pieces/SheetsLibrary/SheetsLibrary.csproj`](SheetsLibrary.csproj); its [stable release was published on 2019-12-03](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). This indicates the technology generation; earlier preview releases may have existed.

A dependency's publication places the preserved configuration at or after that version, if the reference is valid. Package updates may be much newer than the project's beginnings. Packages were not restored to verify this.

October 2026 copy timestamps and documents generated during this review were excluded. Recoverable dates do not guarantee that there are no later, undated changes.

## Why this is worth exploring

GetRow, Get2Rows, and GetRows adapt Google Sheets cells to C# lists and dictionaries. This small layer shows how a spreadsheet becomes data consumable by other tools.

Code entry points:

- [`Sheets.cs`](Sheets.cs)

<!-- END project-context -->

