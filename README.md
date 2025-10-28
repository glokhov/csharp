# C# function wrapper [![Nuget Version](https://img.shields.io/nuget/v/FInvoke)](https://www.nuget.org/packages/FInvoke)
Simple F# wrapper for C# methods.
## Wrapping methods which can throw an Exception.
Import ```FInvoke.Result``` module.
```fsharp
open FInvoke.Result
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

## Wrapping methods which don't throw an Exception, or you don't care.
Import ```FInvoke.Object``` module.
```fsharp
open FInvoke.Object
```
Wrapping methods with ```void``` as a return type:
```fsharp
let deleteFile: string -> unit = invoke File.Delete

let result = deleteFile "file.ext"

Debug.Assert(() = result)
```
Wrapping methods without arguments:
```fsharp
let getRandomFileName: unit -> string = invoke Path.GetRandomFileName

let name = getRandomFileName ()

Debug.Assert(name.Contains("."))
```
Wrapping methods with one argument:
```fsharp
let getFileName: string -> string = invoke Path.GetFileName

let name = getFileName @"root\file.ext"

Debug.Assert("file.ext" = name)
```
Wrapping methods with two arguments:
```fsharp
let combine2: string -> string -> string = invoke2 Path.Combine

let name = combine2 "root" "file.ext"

Debug.Assert(@"root\file.ext" = name)
```
Wrapping methods with three arguments:
```fsharp
let combine3: string -> string -> string -> string = invoke3 Path.Combine

let name = combine3 "root" "folder" "file.ext"

Debug.Assert(@"root\folder\file.ext" = name)
```
And so on...