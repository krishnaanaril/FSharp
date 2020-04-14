//Reverse a list: https://www.hackerrank.com/challenges/fp-reverse-a-list/problem

module HackerRank

open System

[<EntryPoint>]
let main argv =    
    let read _ = Console.ReadLine()
    let isValid = function null -> false | _ -> true
    let inputList = Seq.initInfinite read |> Seq.takeWhile isValid |> Seq.toList |> List.map int
    let result = inputList |> List.rev
    result |> List.iter (printf "%d\n")
    0 // return an integer exit code