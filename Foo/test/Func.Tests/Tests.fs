module Tests

open Foo
open Xunit

let invoke a = a
let invoke2 (a, b) = a + b
let invoke3 (a, b, c) = a + b + c
let invoke4 (a, b, c, d) = a + b + c + d
let invoke5 (a, b, c, d, e) = a + b + c + d + e
let invoke6 (a, b, c, d, e, f) = a + b + c + d + e + f
let invoke7 (a, b, c, d, e, f, g) = a + b + c + d + e + f + g
let invoke8 (a, b, c, d, e, f, g, h) = a + b + c + d + e + f + g + h
let invoke9 (a, b, c, d, e, f, g, h, i) = a + b + c + d + e + f + g + h + i
let invoke10 (a, b, c, d, e, f, g, h, i, j) = a + b + c + d + e + f + g + h + i + j
let invoke11 (a, b, c, d, e, f, g, h, i, j, k) = a + b + c + d + e + f + g + h + i + j + k
let invoke12 (a, b, c, d, e, f, g, h, i, j, k, l) = a + b + c + d + e + f + g + h + i + j + k + l
let invoke13 (a, b, c, d, e, f, g, h, i, j, k, l, m) = a + b + c + d + e + f + g + h + i + j + k + l + m
let invoke14 (a, b, c, d, e, f, g, h, i, j, k, l, m, n) = a + b + c + d + e + f + g + h + i + j + k + l + m + n
let invoke15 (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) = a + b + c + d + e + f + g + h + i + j + k + l + m + n + o
let invoke16 (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) = a + b + c + d + e + f + g + h + i + j + k + l + m + n + o + p

[<Fact>]
let ``invoke returns ok result`` () =
    match Func.invoke invoke 42 with
    | Ok result -> Assert.Equal(42, result)
    | Error error -> Assert.Fail(error.Message)

[<Fact>]
let ``invoke2 returns ok result`` () =
    match Func.invoke2 invoke2 21 21 with
    | Ok result -> Assert.Equal(42, result)
    | Error error -> Assert.Fail(error.Message)

[<Fact>]
let ``invoke3 returns ok result`` () =
    match Func.invoke3 invoke3 14 14 14 with
    | Ok result -> Assert.Equal(42, result)
    | Error error -> Assert.Fail(error.Message)

[<Fact>]
let ``invoke4 returns ok result`` () =
    match Func.invoke4 invoke4 10 10 11 11 with
    | Ok result -> Assert.Equal(42, result)
    | Error error -> Assert.Fail(error.Message)

[<Fact>]
let ``invoke5 returns ok result`` () =
    match Func.invoke5 invoke5 8 8 8 9 9 with
    | Ok result -> Assert.Equal(42, result)
    | Error error -> Assert.Fail(error.Message)

[<Fact>]
let ``invoke6 returns ok result`` () =
    match Func.invoke6 invoke6 7 7 7 7 7 7 with
    | Ok result -> Assert.Equal(42, result)
    | Error error -> Assert.Fail(error.Message)

[<Fact>]
let ``invoke7 returns ok result`` () =
    match Func.invoke7 invoke7 6 6 6 6 6 6 6 with
    | Ok result -> Assert.Equal(42, result)
    | Error error -> Assert.Fail(error.Message)

[<Fact>]
let ``invoke8 returns ok result`` () =
    match Func.invoke8 invoke8 5 5 5 5 5 5 6 6 with
    | Ok result -> Assert.Equal(42, result)
    | Error error -> Assert.Fail(error.Message)

[<Fact>]
let ``invoke9 returns ok result`` () =
    match Func.invoke9 invoke9 4 4 4 5 5 5 5 5 5 with
    | Ok result -> Assert.Equal(42, result)
    | Error error -> Assert.Fail(error.Message)

[<Fact>]
let ``invoke10 returns ok result`` () =
    match Func.invoke10 invoke10 4 4 4 4 4 4 4 4 5 5 with
    | Ok result -> Assert.Equal(42, result)
    | Error error -> Assert.Fail(error.Message)

[<Fact>]
let ``invoke11 returns ok result`` () =
    match Func.invoke11 invoke11 3 3 4 4 4 4 4 4 4 4 4 with
    | Ok result -> Assert.Equal(42, result)
    | Error error -> Assert.Fail(error.Message)

[<Fact>]
let ``invoke12 returns ok result`` () =
    match Func.invoke12 invoke12 3 3 3 3 3 3 4 4 4 4 4 4 with
    | Ok result -> Assert.Equal(42, result)
    | Error error -> Assert.Fail(error.Message)

[<Fact>]
let ``invoke13 returns ok result`` () =
    match Func.invoke13 invoke13 3 3 3 3 3 3 3 3 3 3 4 4 4 with
    | Ok result -> Assert.Equal(42, result)
    | Error error -> Assert.Fail(error.Message)

[<Fact>]
let ``invoke14 returns ok result`` () =
    match Func.invoke14 invoke14 3 3 3 3 3 3 3 3 3 3 3 3 3 3 with
    | Ok result -> Assert.Equal(42, result)
    | Error error -> Assert.Fail(error.Message)

[<Fact>]
let ``invoke15 returns ok result`` () =
    match Func.invoke15 invoke15 2 2 2 3 3 3 3 3 3 3 3 3 3 3 3 with
    | Ok result -> Assert.Equal(42, result)
    | Error error -> Assert.Fail(error.Message)

[<Fact>]
let ``invoke16 returns ok result`` () =
    match Func.invoke16 invoke16 2 2 2 2 2 2 3 3 3 3 3 3 3 3 3 3 with
    | Ok result -> Assert.Equal(42, result)
    | Error error -> Assert.Fail(error.Message)
