// Computing the GCD: https://www.hackerrank.com/challenges/functional-programming-warmups-in-recursion---gcd/problem
module HackerRank

open System

let rec gcd a b =
    if a = 0 then b
    else gcd (b % a) a

[<EntryPoint>]
let main argv =  
    let (a, b) =  Console.ReadLine().Split(' ') |> (fun elem -> (elem.[0] |> int, elem.[1] |> int))    
    gcd a b |> printfn "%d"
    0