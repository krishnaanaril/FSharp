//Array Of N Elements: https://www.hackerrank.com/challenges/fp-array-of-n-elements/problem
module HackerRank

open System

let f n = //Complete this function
    [1 .. n]

[<EntryPoint>]
let main argv =
    let input = Console.ReadLine()
    let n = int input
    printfn "%A" (f n)
    0

