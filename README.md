# BitHelp.Core.Extend

[![Licensed under the MIT License](https://img.shields.io/badge/License-MIT-blue.svg)](./LICENSE)
[![Integration Tests](https://github.com/RenatoPacheco/BitHelp.Core.Extend/workflows/Integration%20Tests/badge.svg?branch=master)](https://github.com/RenatoPacheco/BitHelp.Core.Extend/actions/workflows/integration-tests.yml)
[![NuGet](https://img.shields.io/nuget/v/BitHelp.Core.Extend.svg)](https://nuget.org/packages/BitHelp.Core.Extend)
[![Nuget](https://img.shields.io/nuget/dt/BitHelp.Core.Extend.svg)](https://nuget.org/packages/BitHelp.Core.Extend)

This project is a collection of extensions that I use constantly, so put them all in this package.

# Getting Started

## Software dependencies

[.NET Standard 2.0](https://docs.microsoft.com/pt-br/dotnet/standard/net-standard)

[System.ComponentModel.Annotations (>= 4.7.0)](https://www.nuget.org/packages/System.ComponentModel.Annotations/)

## Installation process

This package is available through Nuget Packages: https://www.nuget.org/packages/BitHelp.Core.Extend

**Nuget**
```
Install-Package BitHelp.Core.Extend
```

**.NET CLI**
```
dotnet add package BitHelp.Core.Extend
```

## Latest releases

#### Release 0.5.0

**Features:**

- Adding PropertyPath and depreciating PropertyTrail

**Others:**

- Ignoring CS0618: Type or member is obsolete
- Update project test to .net 5.0
- Adding github action Integration Tests
- Adding github action Build & Publish to NuGet
- Adding README.md and RELEASES.md

To read about others releases access [RELEASES.md](./RELEASES.md)

# Build and Test

Using Visual Studio Code, you can build and test the project from the terminal.

Build and restore the project:

```
dotnet restore
dotnet build --no-restore
```

Tests:

```
dotnet test --no-build --verbosity normal
```