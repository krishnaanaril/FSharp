//Evaluating e^x: https://www.hackerrank.com/challenges/eval-ex/problem
module HackerRank

open System

[<EntryPoint>]
let main argv =    
    let limit = Console.ReadLine() |> int
    let inputList  = List.init limit (fun elem -> (Console.ReadLine() |> float) )
    let factorial n = [1..n] |> List.fold (*) 1 |> float
    let exponential num = [1..10] |> List.mapi (fun i x -> ((pown num i)/factorial i)) |> List.fold (+) 0.0
    inputList |> List.map exponential |> List.iter (printfn "%f")
    0 // return an integer exit code