# FileFusion-Integration for C#

C# utilities to simplify retrieving data into a file in .NET applications.

## System Requirements
- .NET 7.0 or later

## Installation
To add the package to your .NET project dependencies, use the following command:

dotnet add package FileFusion


## Example Usage
To use the package, specify the path and the name of the file with the extension.

## Sample Code


using FileFusion;
using FileFusionClass = FileFusion.FileFusion;

static void Sample()
{
    List<string> escapeChar = new List<string> { "/", "(", ")", ".", " " };

    string path = System.AppContext.BaseDirectory;
    string file = "Test.csv";

    List<object>? result = FileFusionClass.Extract<SimpleData>(file, path, escapeChar, 3);

    List<SimpleData> ahList = result.OfType<SimpleData>().ToList();
}



## Release Notes
All releases and release notes are available on GitHub or the NuGet repository.

## Enjoy and Install
Marc Nomena Anjaratiana Randriamahaleo
