// Lists and GCD: https://www.hackerrank.com/challenges/lists-and-gcd/problem

module HackerRank

open System

let numberAsTuple _ =
    Console.ReadLine().Split(' ') 
    |> Array.map int        
    |> Array.chunkBySize 2 
    |> Array.map (fun x -> (x.[0], x.[1]))

let getGCD state item =
    let res = Array.map (fun (x, y) -> 
                    let matching = Array.tryFind (fun (a, b) -> a=x ) item
                    match matching with
                    | None -> (-1, -1)
                    | Some (a:int, b:int) -> (a, Math.Min(b, y))) state
                |> Array.filter (fun (a, b) -> a<>(-1) && b<>(-1))
    res

let printListInLine lists =    
    Array.iter (fun (a, b) -> printf "%d %d " a b) lists |> ignore

[<EntryPoint>]
let main argv =     
    let t = Console.ReadLine() |> int        
    let lists = [|1..t|] |> Array.map numberAsTuple                                    
    let first = lists.[0]
    let rest = lists.[1..]    
    Array.fold getGCD first rest |> printListInLine    
    0