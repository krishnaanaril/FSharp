// The Sums of Powers: https://www.hackerrank.com/challenges/functional-programming-the-sums-of-powers

module HackerRank

open System

let getPow x y =
    let result = (x |> double) ** (y |> double )
    result |> int

let rec countWays x n num = 
    let rem = (x - getPow num n)    
    if rem = 0 then
        1
    elif rem < 0 then
        0
    else
        (countWays rem n (num+1)) + (countWays x n (num+1))
        

[<EntryPoint>]
let main argv = 
    let x = Console.ReadLine() |> int;
    let n = Console.ReadLine() |> int;
    printfn "%d" (countWays x n 1)
    0