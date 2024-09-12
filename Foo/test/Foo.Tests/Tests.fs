module Tests

open Foo;
open Xunit

[<Fact>]
let ``My test`` () =
    let text = Say.hello "Test"
    Assert.Equal("Hello Test", text)
