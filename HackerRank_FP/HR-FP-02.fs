//Hello World N Times: https://www.hackerrank.com/challenges/fp-hello-world-n-times/problem

module HackerRank

open System

[<EntryPoint>]
let main argv =     
    let num = Console.ReadLine() |> int
    for i = 1 to num do
        printfn "Hello World"
    0 // return an integer exit code

