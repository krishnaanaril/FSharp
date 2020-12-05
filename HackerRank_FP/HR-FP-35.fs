// Huge GCD: https://www.hackerrank.com/challenges/huge-gcd-fp/forum

// Need to solve without BigInteger

module HackerRank

open System
open System.Numerics

let bigint (x:int) = bigint(x);

let modulo = 1000000007 |> bigint

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int
    let numa = Console.ReadLine().Split(' ') |> Seq.map (int >> bigint) |> Seq.reduce (*)
    let m = Console.ReadLine() |> int
    let numb = Console.ReadLine().Split(' ') |> Seq.map (int >> bigint) |> Seq.reduce (*)
    let res = BigInteger.GreatestCommonDivisor(numa, numb)    
    printfn "%A" (res % modulo)
    0