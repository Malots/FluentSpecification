# FluentSpecification

- Validation Package build in .NET Core  SDK.

## Nuget:

- This package is hosted on Nuget under the name "Malots.FluentSpecification.Specification".
- Current Version is 1.0.1.

## Installation:

- Package Manager -> Install-Package Malots.FluentSpecification.Specification -Version 1.0.1
- .NET CLI -> dotnet add package Malots.FluentSpecification.Specification --version 1.0.1

## Example:
- Check the units tests project
- Example:  var value = "stringcontent_";
            var lengthSpecification = new StringLengthSpecification<string>();
            var characterSpecification = new StringCharacterSpecification<string>();
            var andSpecification = lengthSpecification.And(characterSpecification);

## Reference:

- This package is based on this article -> https://en.wikipedia.org/wiki/Specification_pattern


