module CSharpErrorTests

open Func
open Xunit

[<Fact>]
let ``invoke returns error`` () =
    match CSharp.invoke CSharp.Error.Func 'a' with
    | Ok _ -> Assert.Fail()
    | Error error -> Assert.Equal("a", error.Message)

[<Fact>]
let ``invoke2 returns error`` () =
    match CSharp.invoke2 CSharp.Error.Func 'a' 'b' with
    | Ok _ -> Assert.Fail()
    | Error error -> Assert.Equal("ab", error.Message)

[<Fact>]
let ``invoke3 returns error`` () =
    match CSharp.invoke3 CSharp.Error.Func 'a' 'b' 'c' with
    | Ok _ -> Assert.Fail()
    | Error error -> Assert.Equal("abc", error.Message)

[<Fact>]
let ``invoke4 returns error`` () =
    match CSharp.invoke4 CSharp.Error.Func 'a' 'b' 'c' 'd' with
    | Ok _ -> Assert.Fail()
    | Error error -> Assert.Equal("abcd", error.Message)

[<Fact>]
let ``invoke5 returns error`` () =
    match CSharp.invoke5 CSharp.Error.Func 'a' 'b' 'c' 'd' 'e' with
    | Ok _ -> Assert.Fail()
    | Error error -> Assert.Equal("abcde", error.Message)

[<Fact>]
let ``invoke6 returns error`` () =
    match CSharp.invoke6 CSharp.Error.Func 'a' 'b' 'c' 'd' 'e' 'f' with
    | Ok _ -> Assert.Fail()
    | Error error -> Assert.Equal("abcdef", error.Message)

[<Fact>]
let ``invoke7 returns error`` () =
    match CSharp.invoke7 CSharp.Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' with
    | Ok _ -> Assert.Fail()
    | Error error -> Assert.Equal("abcdefg", error.Message)

[<Fact>]
let ``invoke8 returns error`` () =
    match CSharp.invoke8 CSharp.Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' with
    | Ok _ -> Assert.Fail()
    | Error error -> Assert.Equal("abcdefgh", error.Message)

[<Fact>]
let ``invoke9 returns error`` () =
    match CSharp.invoke9 CSharp.Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' with
    | Ok _ -> Assert.Fail()
    | Error error -> Assert.Equal("abcdefghi", error.Message)

[<Fact>]
let ``invoke10 returns error`` () =
    match CSharp.invoke10 CSharp.Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' with
    | Ok _ -> Assert.Fail()
    | Error error -> Assert.Equal("abcdefghij", error.Message)

[<Fact>]
let ``invoke11 returns error`` () =
    match CSharp.invoke11 CSharp.Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' with
    | Ok _ -> Assert.Fail()
    | Error error -> Assert.Equal("abcdefghijk", error.Message)

[<Fact>]
let ``invoke12 returns error`` () =
    match CSharp.invoke12 CSharp.Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' with
    | Ok _ -> Assert.Fail()
    | Error error -> Assert.Equal("abcdefghijkl", error.Message)

[<Fact>]
let ``invoke13 returns error`` () =
    match CSharp.invoke13 CSharp.Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' with
    | Ok _ -> Assert.Fail()
    | Error error -> Assert.Equal("abcdefghijklm", error.Message)

[<Fact>]
let ``invoke14 returns error`` () =
    match CSharp.invoke14 CSharp.Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' with
    | Ok _ -> Assert.Fail()
    | Error error -> Assert.Equal("abcdefghijklmn", error.Message)

[<Fact>]
let ``invoke15 returns error`` () =
    match CSharp.invoke15 CSharp.Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' 'o' with
    | Ok _ -> Assert.Fail()
    | Error error -> Assert.Equal("abcdefghijklmno", error.Message)

[<Fact>]
let ``invoke16 returns error`` () =
    match CSharp.invoke16 CSharp.Error.Func 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' 'o' 'p' with
    | Ok _ -> Assert.Fail()
    | Error error -> Assert.Equal("abcdefghijklmnop", error.Message)
