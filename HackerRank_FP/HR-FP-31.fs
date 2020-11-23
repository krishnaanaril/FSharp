// Filter Elements: https://www.hackerrank.com/challenges/filter-elements/problem

module HackerRank

open System

let processList list k =    
    let results = list |> Seq.countBy id |> Seq.filter (fun (a, b) -> b>=k) |> Seq.map (fun (a, b) -> a) |> Seq.toList    
    match results.Length with
    | 0 -> printf "-1"
    | _ -> List.iter (printf "%d ") results 
    printfn ""

[<EntryPoint>]
let main argv = 
    let t = Console.ReadLine() |> int
    [1..t] |> List.iter (fun _ -> 
                            let (n, k) = Console.ReadLine().Split(' ') |> fun elem -> (elem.[0] |> int, elem.[1] |> int)
                            (Console.ReadLine().Split(' ') |> Seq.map int |> processList) <| k    
                        )
    0