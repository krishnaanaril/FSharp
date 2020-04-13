//Filter Positions in a List: https://www.hackerrank.com/challenges/fp-filter-positions-in-a-list/problem

module HackerRank

open System

[<EntryPoint>]
let main argv =    
    let read _ = Console.ReadLine()
    let isValid = function null -> false | _ -> true
    let inputList = Seq.initInfinite read |> Seq.takeWhile isValid |> Seq.toList |> List.map int
    let result = inputList |> List.mapi (fun i x -> x, i) |> List.choose (fun (x, i) -> if i%2 = 1 then Some(x) else None)
    result |> List.iter (printf "%d\n")
    0 // return an integer exit code


