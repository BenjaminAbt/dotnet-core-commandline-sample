# Sample of commandline usage with .NET Core

## General

This sample shows the usage of the NuGet package [Microsoft.Extensions.CommandLineUtils ](https://www.nuget.org/packages/Microsoft.Extensions.CommandLineUtils/)

## Environment

Made with..

- .NET Core 1.1
- Visual Studio 2017 RC 
- .NET CLI Version 1.0.0-rc3-004535
- Windows 10

.. should run on all .NET Core platforms.

## usage

```bash
dotnet .\src\dotnet-core-commandline-sample\bin\Debug\netcoreapp1.1\dotnet-core-commandline-sample.dll
```

or with parameters

```bash
dotnet .\src\dotnet-core-commandline-sample\bin\Debug\netcoreapp1.1\dotnet-core-commandline-sample.dll --name YourName 
dotnet .\src\dotnet-core-commandline-sample\bin\Debug\netcoreapp1.1\dotnet-core-commandline-sample.dll -n YourName -o Option1 -o Option2 -o Option3
dotnet .\src\dotnet-core-commandline-sample\bin\Debug\netcoreapp1.1\dotnet-core-commandline-sample.dll --force
```

## publish

Run `dotnet publish -c Release`

This sample produces a dll file for x-plat usage `src\dotnet-core-commandline-sample\bin\Release\netcoreapp1.1\dotnet-core-commandline-sample.dll` and a executable file for Win7 x64 `src\dotnet-core-commandline-sample\bin\Release\netcoreapp1.1\win7-x64\publish\dotnet-core-commandline-sample.exe`

## LICENSE


> Copyright (c) 2017 Benjamin Abt
> 
> Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
> The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
> THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.