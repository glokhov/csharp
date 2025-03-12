# CSharp function wrapper [![Nuget Version](https://img.shields.io/nuget/v/CSharp.FSharp)](https://www.nuget.org/packages/CSharp.FSharp)
Simple FSharp wrapper for CSharp methods which can throw an Exception.
## Getting started
Import ```CSharp``` module:
```fsharp
open CSharp
```
Wrapping methods with ```void``` as a return type:
```fsharp
let deleteFile: string -> Result<unit, Exception> = invoke File.Delete

let test () =
    match deleteFile "file.ext" with
    | Ok result -> result
    | Error error -> Debug.Fail(error.Message)
```
Wrapping methods without arguments:
```fsharp
let getRandomFileName: unit -> Result<string, Exception> = invoke Path.GetRandomFileName

let test () =
    match getRandomFileName () with
    | Ok name -> Debug.Assert(name.Contains("."))
    | Error error -> Debug.Fail(error.Message)
```
Wrapping methods with one argument:
```fsharp
let getFileName: string -> Result<string, Exception> = invoke Path.GetFileName

let test () =
    match getFileName @"root\file.ext" with
    | Ok name -> Debug.Assert("file.ext" = name)
    | Error error -> Debug.Fail(error.Message)
```
Wrapping methods with two arguments:
```fsharp
let combine2: string -> string -> Result<string, Exception> = invoke2 Path.Combine

let test () =
    match combine2 "root" "file.ext" with
    | Ok name -> Debug.Assert(@"root\file.ext" = name)
    | Error error -> Debug.Fail(error.Message)
```
Wrapping methods with three arguments:
```fsharp
let combine3: string -> string -> string -> Result<string, Exception> = invoke3 Path.Combine

let test () =
    match combine3 "root" "folder" "file.ext" with
    | Ok name -> Debug.Assert(@"root\folder\file.ext" = name)
    | Error error -> Debug.Fail(error.Message)
```
And so on...