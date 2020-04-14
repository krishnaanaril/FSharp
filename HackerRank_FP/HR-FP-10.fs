//Update List: https://www.hackerrank.com/challenges/fp-update-list/problem
module HackerRank

open System

[<EntryPoint>]
let main argv =    
    let read _ = Console.ReadLine()
    let isValid = function null -> false | _ -> true
    let inputList = Seq.initInfinite read |> Seq.takeWhile isValid |> Seq.toList |> List.map int
    let result = inputList |> List.map (fun elem -> abs elem ) 
    result |> List.iter (printfn "%d")
    0 // return an integer exit code

