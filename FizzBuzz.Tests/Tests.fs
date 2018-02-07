module Tests

open System
open FsUnit.Xunit
open Xunit
open FizzBuzz

[<Fact>]
let ``Array with Number 1 returns 'one'`` () =
    FizzBuzz.Generate [1] |> should equal "one"