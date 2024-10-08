module CSharpOkTests

open Assets
open Xunit

[<Fact>]
let ``invoke returns ok result`` () =
    match CSharp.invoke Ok.Func 'a' with
    | Ok result -> Assert.Equal("a", result)
    | Error _ -> Assert.Fail()

[<Fact>]
let ``invoke2 returns ok result`` () =
    match CSharp.invoke2 Ok.Func 'a' 'b' with
    | Ok result -> Assert.Equal("ab", result)
    | Error _ -> Assert.Fail()

[<Fact>]
let ``invoke3 returns ok result`` () =
    match CSharp.invoke3 Ok.Func 'a' 'b' 'c' with
    | Ok result -> Assert.Equal("abc", result)
    | Error _ -> Assert.Fail()

[<Fact>]
let ``invoke4 returns ok result`` () =
    match CSharp.invoke4 Ok.Func 'a' 'b' 'c' 'd' with
    | Ok result -> Assert.Equal("abcd", result)
    | Error _ -> Assert.Fail()

[<Fact>]
let ``invoke5 returns ok result`` () =
    match CSharp.invoke5 Ok.Func 'a' 'b' 'c' 'd' 'e' with
    | Ok result -> Assert.Equal("abcde", result)
    | Error _ -> Assert.Fail()

[<Fact>]
let ``invoke6 returns ok result`` () =
    match CSharp.invoke6 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' with
    | Ok result -> Assert.Equal("abcdef", result)
    | Error _ -> Assert.Fail()

[<Fact>]
let ``invoke7 returns ok result`` () =
    match CSharp.invoke7 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' with
    | Ok result -> Assert.Equal("abcdefg", result)
    | Error _ -> Assert.Fail()

[<Fact>]
let ``invoke8 returns ok result`` () =
    match CSharp.invoke8 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' with
    | Ok result -> Assert.Equal("abcdefgh", result)
    | Error _ -> Assert.Fail()

[<Fact>]
let ``invoke9 returns ok result`` () =
    match CSharp.invoke9 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' with
    | Ok result -> Assert.Equal("abcdefghi", result)
    | Error _ -> Assert.Fail()

[<Fact>]
let ``invoke10 returns ok result`` () =
    match CSharp.invoke10 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' with
    | Ok result -> Assert.Equal("abcdefghij", result)
    | Error _ -> Assert.Fail()

[<Fact>]
let ``invoke11 returns ok result`` () =
    match CSharp.invoke11 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' with
    | Ok result -> Assert.Equal("abcdefghijk", result)
    | Error _ -> Assert.Fail()

[<Fact>]
let ``invoke12 returns ok result`` () =
    match CSharp.invoke12 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' with
    | Ok result -> Assert.Equal("abcdefghijkl", result)
    | Error _ -> Assert.Fail()

[<Fact>]
let ``invoke13 returns ok result`` () =
    match CSharp.invoke13 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' with
    | Ok result -> Assert.Equal("abcdefghijklm", result)
    | Error _ -> Assert.Fail()

[<Fact>]
let ``invoke14 returns ok result`` () =
    match CSharp.invoke14 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' with
    | Ok result -> Assert.Equal("abcdefghijklmn", result)
    | Error _ -> Assert.Fail()

[<Fact>]
let ``invoke15 returns ok result`` () =
    match CSharp.invoke15 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' 'o' with
    | Ok result -> Assert.Equal("abcdefghijklmno", result)
    | Error _ -> Assert.Fail()

[<Fact>]
let ``invoke16 returns ok result`` () =
    match CSharp.invoke16 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' 'o' 'p' with
    | Ok result -> Assert.Equal("abcdefghijklmnop", result)
    | Error _ -> Assert.Fail()
