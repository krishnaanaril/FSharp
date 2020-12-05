// Common Divisors: https://www.hackerrank.com/challenges/common-divisors/problem

module HackerRank

open System

let rec getFactor (n:int) (x:int) a = 
    if x = n then
        x::a
    elif n % x = 0 then 
        getFactor (n/x) x (x::a)
    else
        getFactor n (x+1) a
let getPrimeFactors n =
    match n with
    | 1 -> []
    | _ -> getFactor n 2 []

let processCase _ =
    let (m, l) = Console.ReadLine().Split(' ') |> (fun elem -> (elem.[0] |> int, elem.[1] |> int))
    let a = getPrimeFactors m |> Seq.countBy id 
    let b = getPrimeFactors l |> Seq.countBy id 
    let res = Seq.map (fun (x, y) -> 
                            let matching = Seq.tryFind (fun (a, b) -> a=x ) b
                            match matching with
                            | None -> 0
                            | Some (a:int, b:int) -> Math.Min(b, y))  a                        
    let ret = match (Seq.length res) with
              | 0 -> 1
              | _ -> Seq.map (fun x -> x+ 1) res |> Seq.reduce (*)
    printfn "%d" ret

[<EntryPoint>]
let main argv = 
    let t = Console.ReadLine() |> int
    [1..t] |> List.iter processCase
    0