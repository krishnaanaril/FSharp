// Jumping Bunnies: https://www.hackerrank.com/challenges/jumping-bunnies/problem

module HackerRank

open System

let rec gcd (a:int64) (b:int64) =    
    if a = 0L then b
    else gcd (b % a) a

let lcm a b =
    (a/(gcd a b)*b)

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int64
    let dat = Console.ReadLine().Split(' ') 
                |> Seq.map int64                 
    Seq.reduce lcm dat |> printfn "%d" 
    0