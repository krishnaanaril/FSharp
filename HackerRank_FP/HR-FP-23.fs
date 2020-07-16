// String Reductions: https://www.hackerrank.com/challenges/string-reductions/problem

module HackerRank

open System

let contains x 
    = Seq.exists ((=) x)

[<EntryPoint>]
let main argv =
    Console.ReadLine()
    |> Seq.fold (fun acc elem -> 
        if (contains elem acc) 
        then acc 
        else acc + string elem) "" 
    |> printfn "%s"
    0