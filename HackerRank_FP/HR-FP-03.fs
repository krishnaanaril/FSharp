//List Replication: https://www.hackerrank.com/challenges/fp-list-replication/problem

module HackerRank

open System

[<EntryPoint>]
let main argv =    
    let n = Console.ReadLine() |> int
    let read _ = Console.ReadLine() 
    let isValid = function null -> false | _ -> true
    let inputList = Seq.initInfinite read |> Seq.takeWhile isValid |> Seq.toList 
    let result = inputList |> List.collect (fun x -> List.replicate n x) |> List.map int
    result |> List.iter (printf "%A\n")
    0 // return an integer exit code



