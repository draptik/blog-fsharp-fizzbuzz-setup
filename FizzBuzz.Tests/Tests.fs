module Tests

open System
open Xunit
open FizzBuzz

[<Fact>]
let ``Array with Number 1 returns 'one'`` () =
    let result = FizzBuzz.Generate [1]
    Assert.Equal(result, "one")