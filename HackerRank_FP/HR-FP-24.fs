// Rotate String: https://www.hackerrank.com/challenges/rotate-string/problem

module HackerRank

open System

let rec rotateAndPrint pos str =
    let n = String.length str    
    match pos with
    | var1 when var1 >= n -> printfn ""
    | _ -> 
        let nxt = str.[1..] + string str.[0]
        printf "%s " nxt
        rotateAndPrint (pos + 1) nxt
    

[<EntryPoint>]
let main argv =
    let t = Console.ReadLine() |> int 
    [1..t]
    |> List.iter (fun _ -> 
        rotateAndPrint 0 <| Console.ReadLine())
    0