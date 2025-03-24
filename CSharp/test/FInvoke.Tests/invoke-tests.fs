module Invoke.Tests

open FInvoke.Object
open CSharp
open Xunit

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
    let result =
        invoke14 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n'

    Assert.Equal("abcdefghijklmn", result)

[<Fact>]
let ``invoke15 returns ok result`` () =
    let result = invoke15 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' 'o'
    Assert.Equal("abcdefghijklmno", result)

[<Fact>]
let ``invoke16 returns ok result`` () =
    let result = invoke16 Ok.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' 'o' 'p'
    Assert.Equal("abcdefghijklmnop", result)
