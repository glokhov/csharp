# FInvoke

[![NuGet Version](https://img.shields.io/nuget/v/FInvoke)](https://www.nuget.org/packages/FInvoke)
[![GitHub License](https://img.shields.io/github/license/glokhov/csharp)](LICENSE)

A tiny F# helper library for invoking .NET and C# methods with a simple, idiomatic API.

FInvoke helps you wrap method calls as functions and optionally capture exceptions as `Result<T, exn>` without writing repetitive `try/with` boilerplate.

## Why use FInvoke?

- Call .NET/C# methods with the same functional style as other F# functions
- Safely handle exceptions with `Result`
- Keep direct invocation for cases where exceptions are not important
- Support methods with up to 16 arguments

## Install

```bash
dotnet add package FInvoke
```

## Usage

### Safe invocation with exceptions captured

```fsharp
open System.IO
open FInvoke.Result

let deleteFile =
    match invoke File.Delete "file.ext" with
    | Ok () -> printfn "Deleted %s" "file.ext"
    | Error ex -> printfn "Delete failed: %s" ex.Message

let tempFile =
    match invoke Path.GetTempFileName with
    | Ok path -> path
    | Error ex -> failwith ex.Message

let fullPath =
    match invoke Path.GetFullPath "file.ext" with
    | Ok path -> path
    | Error ex -> failwith ex.Message

let combined =
    match invoke2 Path.Combine "folder" "file.ext" with
    | Ok path -> path
    | Error ex -> failwith ex.Message
```

### Direct invocation when exceptions are not a concern

```fsharp
open System.IO
open FInvoke.Object

let tempFile = invoke Path.GetTempFileName
let fullPath = invoke Path.GetFullPath "file.ext"
let combined = invoke2 Path.Combine "folder" "file.ext"

let result: unit = invoke File.Delete "file.ext"
```

## Supported helpers

The library exposes `invoke` and `invokeN` functions for a range of arities:

- `invoke`
- `invoke2` ... `invoke16`

For example:

```fsharp
open FInvoke.Result

let r1 = invoke Console.WriteLine "hello"
let r2 = invoke2 Path.Combine "folder" "file.txt"
let r3 = invoke3 Path.Combine "root" "folder" "file.txt"
```

## License

This project is licensed under the [MIT License](LICENSE).
