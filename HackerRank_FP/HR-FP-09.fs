//List Length: https://www.hackerrank.com/challenges/fp-list-length/problem
module HackerRank

open System

[<EntryPoint>]
let main argv =    
    let read _ = Console.ReadLine()
    let isValid = function null -> false | _ -> true
    let inputList = Seq.initInfinite read |> Seq.takeWhile isValid |> Seq.toList |> List.map int
    let result = inputList |> List.fold (fun acc elem -> acc + 1) 0 
    printf "%d\n" result
    0 // return an integer exit code

