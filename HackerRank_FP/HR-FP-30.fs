// Pentagonal Numbers: https://www.hackerrank.com/challenges/pentagonal-numbers/problem

module HackerRank

open System

let processTestCase _ =
    let n = Console.ReadLine() |> int64
    let sum = n * ( 2L + (n-1L)*3L) / 2L
    printfn "%d" sum

[<EntryPoint>]
let main argv = 
    let t = Console.ReadLine() |> int
    [1..t] |> List.map processTestCase |> ignore
    0