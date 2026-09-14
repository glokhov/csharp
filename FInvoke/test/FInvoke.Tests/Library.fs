namespace FInvoke.Tests

open CSharp
open Xunit

module Result =
    open FInvoke.Result

    [<Fact>]
    let ``invoke returns ok result`` () =
        match invoke Ok.Func 'a' with
        | Ok result -> Assert.Equal("a", result)
        | Error _ -> Assert.Fail()

    [<Fact>]
    let ``invoke2 returns ok result`` () =
        match invoke2 Ok.Func 'a' 'b' with
        | Ok result -> Assert.Equal("ab", result)
        | Error _ -> Assert.Fail()

    [<Fact>]
    let ``invoke3 returns ok result`` () =
        match invoke3 Ok.Func 'a' 'b' 'c' with
        | Ok result -> Assert.Equal("abc", result)
        | Error _ -> Assert.Fail()

    [<Fact>]
    let ``invoke4 returns ok result`` () =
        match invoke4 Ok.Func 'a' 'b' 'c' 'd' with
        | Ok result -> Assert.Equal("abcd", result)
        | Error _ -> Assert.Fail()

    [<Fact>]
    let ``invoke5 returns ok result`` () =
        match invoke5 Ok.Func 'a' 'b' 'c' 'd' 'e' with
        | Ok result -> Assert.Equal("abcde", result)
        | Error _ -> Assert.Fail()

    [<Fact>]
    let ``invoke6 returns ok result`` () =
        match invoke6 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' with
        | Ok result -> Assert.Equal("abcdef", result)
        | Error _ -> Assert.Fail()

    [<Fact>]
    let ``invoke7 returns ok result`` () =
        match invoke7 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' with
        | Ok result -> Assert.Equal("abcdefg", result)
        | Error _ -> Assert.Fail()

    [<Fact>]
    let ``invoke8 returns ok result`` () =
        match invoke8 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' with
        | Ok result -> Assert.Equal("abcdefgh", result)
        | Error _ -> Assert.Fail()

    [<Fact>]
    let ``invoke9 returns ok result`` () =
        match invoke9 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' with
        | Ok result -> Assert.Equal("abcdefghi", result)
        | Error _ -> Assert.Fail()

    [<Fact>]
    let ``invoke10 returns ok result`` () =
        match invoke10 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' with
        | Ok result -> Assert.Equal("abcdefghij", result)
        | Error _ -> Assert.Fail()

    [<Fact>]
    let ``invoke11 returns ok result`` () =
        match invoke11 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' with
        | Ok result -> Assert.Equal("abcdefghijk", result)
        | Error _ -> Assert.Fail()

    [<Fact>]
    let ``invoke12 returns ok result`` () =
        match invoke12 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' with
        | Ok result -> Assert.Equal("abcdefghijkl", result)
        | Error _ -> Assert.Fail()

    [<Fact>]
    let ``invoke13 returns ok result`` () =
        match invoke13 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' with
        | Ok result -> Assert.Equal("abcdefghijklm", result)
        | Error _ -> Assert.Fail()

    [<Fact>]
    let ``invoke14 returns ok result`` () =
        match invoke14 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' with
        | Ok result -> Assert.Equal("abcdefghijklmn", result)
        | Error _ -> Assert.Fail()

    [<Fact>]
    let ``invoke15 returns ok result`` () =
        match invoke15 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' 'o' with
        | Ok result -> Assert.Equal("abcdefghijklmno", result)
        | Error _ -> Assert.Fail()

    [<Fact>]
    let ``invoke16 returns ok result`` () =
        match invoke16 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' 'o' 'p' with
        | Ok result -> Assert.Equal("abcdefghijklmnop", result)
        | Error _ -> Assert.Fail()

    [<Fact>]
    let ``invoke returns error`` () =
        match invoke Error.Func 'a' with
        | Ok _ -> Assert.Fail()
        | Error error -> Assert.Equal("a", error.Message)

    [<Fact>]
    let ``invoke2 returns error`` () =
        match invoke2 Error.Func 'a' 'b' with
        | Ok _ -> Assert.Fail()
        | Error error -> Assert.Equal("ab", error.Message)

    [<Fact>]
    let ``invoke3 returns error`` () =
        match invoke3 Error.Func 'a' 'b' 'c' with
        | Ok _ -> Assert.Fail()
        | Error error -> Assert.Equal("abc", error.Message)

    [<Fact>]
    let ``invoke4 returns error`` () =
        match invoke4 Error.Func 'a' 'b' 'c' 'd' with
        | Ok _ -> Assert.Fail()
        | Error error -> Assert.Equal("abcd", error.Message)

    [<Fact>]
    let ``invoke5 returns error`` () =
        match invoke5 Error.Func 'a' 'b' 'c' 'd' 'e' with
        | Ok _ -> Assert.Fail()
        | Error error -> Assert.Equal("abcde", error.Message)

    [<Fact>]
    let ``invoke6 returns error`` () =
        match invoke6 Error.Func 'a' 'b' 'c' 'd' 'e' 'f' with
        | Ok _ -> Assert.Fail()
        | Error error -> Assert.Equal("abcdef", error.Message)

    [<Fact>]
    let ``invoke7 returns error`` () =
        match invoke7 Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' with
        | Ok _ -> Assert.Fail()
        | Error error -> Assert.Equal("abcdefg", error.Message)

    [<Fact>]
    let ``invoke8 returns error`` () =
        match invoke8 Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' with
        | Ok _ -> Assert.Fail()
        | Error error -> Assert.Equal("abcdefgh", error.Message)

    [<Fact>]
    let ``invoke9 returns error`` () =
        match invoke9 Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' with
        | Ok _ -> Assert.Fail()
        | Error error -> Assert.Equal("abcdefghi", error.Message)

    [<Fact>]
    let ``invoke10 returns error`` () =
        match invoke10 Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' with
        | Ok _ -> Assert.Fail()
        | Error error -> Assert.Equal("abcdefghij", error.Message)

    [<Fact>]
    let ``invoke11 returns error`` () =
        match invoke11 Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' with
        | Ok _ -> Assert.Fail()
        | Error error -> Assert.Equal("abcdefghijk", error.Message)

    [<Fact>]
    let ``invoke12 returns error`` () =
        match invoke12 Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' with
        | Ok _ -> Assert.Fail()
        | Error error -> Assert.Equal("abcdefghijkl", error.Message)

    [<Fact>]
    let ``invoke13 returns error`` () =
        match invoke13 Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' with
        | Ok _ -> Assert.Fail()
        | Error error -> Assert.Equal("abcdefghijklm", error.Message)

    [<Fact>]
    let ``invoke14 returns error`` () =
        match invoke14 Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' with
        | Ok _ -> Assert.Fail()
        | Error error -> Assert.Equal("abcdefghijklmn", error.Message)

    [<Fact>]
    let ``invoke15 returns error`` () =
        match invoke15 Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' 'o' with
        | Ok _ -> Assert.Fail()
        | Error error -> Assert.Equal("abcdefghijklmno", error.Message)

    [<Fact>]
    let ``invoke16 returns error`` () =
        match invoke16 Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' 'o' 'p' with
        | Ok _ -> Assert.Fail()
        | Error error -> Assert.Equal("abcdefghijklmnop", error.Message)

module Object =
    open FInvoke.Object

    [<Fact>]
    let ``invoke returns ok result`` () =
        let result = invoke Ok.Func 'a'
        Assert.Equal("a", result)

    [<Fact>]
    let ``invoke2 returns ok result`` () =
        let result = invoke2 Ok.Func 'a' 'b'
        Assert.Equal("ab", result)

    [<Fact>]
    let ``invoke3 returns ok result`` () =
        let result = invoke3 Ok.Func 'a' 'b' 'c'
        Assert.Equal("abc", result)

    [<Fact>]
    let ``invoke4 returns ok result`` () =
        let result = invoke4 Ok.Func 'a' 'b' 'c' 'd'
        Assert.Equal("abcd", result)

    [<Fact>]
    let ``invoke5 returns ok result`` () =
        let result = invoke5 Ok.Func 'a' 'b' 'c' 'd' 'e'
        Assert.Equal("abcde", result)

    [<Fact>]
    let ``invoke6 returns ok result`` () =
        let result = invoke6 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f'
        Assert.Equal("abcdef", result)

    [<Fact>]
    let ``invoke7 returns ok result`` () =
        let result = invoke7 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g'
        Assert.Equal("abcdefg", result)

    [<Fact>]
    let ``invoke8 returns ok result`` () =
        let result = invoke8 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h'
        Assert.Equal("abcdefgh", result)

    [<Fact>]
    let ``invoke9 returns ok result`` () =
        let result = invoke9 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i'
        Assert.Equal("abcdefghi", result)

    [<Fact>]
    let ``invoke10 returns ok result`` () =
        let result = invoke10 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j'
        Assert.Equal("abcdefghij", result)

    [<Fact>]
    let ``invoke11 returns ok result`` () =
        let result = invoke11 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k'
        Assert.Equal("abcdefghijk", result)

    [<Fact>]
    let ``invoke12 returns ok result`` () =
        let result = invoke12 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l'
        Assert.Equal("abcdefghijkl", result)

    [<Fact>]
    let ``invoke13 returns ok result`` () =
        let result = invoke13 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm'
        Assert.Equal("abcdefghijklm", result)

    [<Fact>]
    let ``invoke14 returns ok result`` () =
        let result = invoke14 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n'
        Assert.Equal("abcdefghijklmn", result)

    [<Fact>]
    let ``invoke15 returns ok result`` () =
        let result = invoke15 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' 'o'
        Assert.Equal("abcdefghijklmno", result)

    [<Fact>]
    let ``invoke16 returns ok result`` () =
        let result = invoke16 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' 'o' 'p'
        Assert.Equal("abcdefghijklmnop", result)
