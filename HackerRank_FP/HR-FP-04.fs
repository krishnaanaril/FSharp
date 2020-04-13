//Filter Array: https://www.hackerrank.com/challenges/fp-filter-array/problem

module HackerRank

open System

[<EntryPoint>]
let main argv =    
    let delimiter = Console.ReadLine() |> int
    let read _ = Console.ReadLine()
    let isValid = function null -> false | _ -> true
    let inputList = Seq.initInfinite read |> Seq.takeWhile isValid |> Seq.toList |> List.map int
    let result = List.filter (fun x -> x < delimiter) inputList
    result |> List.iter (printf "%d\n")
    0 // return an integer exit code



