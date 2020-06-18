// Fibonacci Numbers:https://www.hackerrank.com/challenges/functional-programming-warmups-in-recursion---fibonacci-numbers/problem
module HackerRank

open System

let rec fib n =
   match n with 
   | 1 -> 0
   | 2 -> 1
   | _ -> fib (n - 1) + fib (n - 2)

[<EntryPoint>]
let main argv =  
    let n =  Console.ReadLine() |> int
    fib n |> printfn "%d"
    0