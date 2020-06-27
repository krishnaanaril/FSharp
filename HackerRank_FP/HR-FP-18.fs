// Pascal's Triangle: https://www.hackerrank.com/challenges/pascals-triangle/problem
module HackerRank

open System

let rec fact n = 
    match n with 
    | 0 | 1 -> 1
    | _ -> n * fact(n-1)

let coeff n r = 
    fact(n)/(fact(r)*fact(n-r))

let printRow n =
    let row = [ for r in 0 .. n ->  coeff n r]
    row |> List.map (printf "%d ") |> ignore
    printfn ""

[<EntryPoint>]
let main argv =  
    let n =  Console.ReadLine() |> int
    [ for row in 0 .. (n-1) -> (printRow row)] |> ignore
    0