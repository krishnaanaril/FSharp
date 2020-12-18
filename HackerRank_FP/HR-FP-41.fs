// Kundu And Bubble Wrap: https://www.hackerrank.com/challenges/kundu-and-bubble-wrap/problem

(*
    Refer:
    1. https://en.wikipedia.org/wiki/Coupon_collector%27s_problem
*)

module HackerRank

open System

[<EntryPoint>]
let main argv =
    let prod = Console.ReadLine().Split(' ') 
                |> Array.map int 
                |> (fun x -> x.[0]*x.[1])
    [1..prod] 
    |> List.fold (fun acc x -> acc + ((prod |> double)/(x |> double))) 0.0 
    |> printfn "%f"    
    0