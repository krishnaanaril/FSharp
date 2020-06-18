//Functions or Not?: https://www.hackerrank.com/challenges/functions-or-not/problem
module HackerRank

open System

let readxy _ =
    let xy = Console.ReadLine().Split(' ') |> (fun elem -> (elem.[0] , elem.[1]))
    xy

let evaluateCase x =        
    let n = Console.ReadLine() |> int
    let fnMap = Map.empty
    let values = 
        [1..n] 
        |> List.map readxy            
    let fnMap =  Map.ofList values        
    let mismatch = List.exists (fun (a, b) -> b <> fnMap.[a]) values        
    if mismatch then 
        "NO"
    else
        "YES"

[<EntryPoint>]
let main argv =  
    let t = Console.ReadLine() |> int                
    [1..t] |> List.map (evaluateCase >> (printfn "%s")) |> ignore    
    0