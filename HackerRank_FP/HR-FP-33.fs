// Different Ways: https://www.hackerrank.com/challenges/different-ways-fp/problem

module HackerRank

open System
open System.Numerics

let modulo = 100000007L

let getFact (n:int64) = 
    match n with
    | 0L -> 1L
    | _ -> Seq.reduce (fun (a:int64) (b:int64) -> (a*b)%modulo) { 1L .. n}

let rec modPow (n:int64) (p:int64) (q:int64) =
    if n=0L || p=0L then  
        1L
    else
        let ret = match p with
                    | _ when p%2L=0L -> 
                        let a = modPow n (p/2L) q
                        (a*a)%q
                    | _ -> 
                        let b = n % q
                        (b * (modPow n (p-1L) q)) % q
        (ret + q)%q

let processCases _ =
    let (n, k) = Console.ReadLine().Split(' ') 
                    |> Array.map int64 
                    |> (fun x -> (x.[0], x.[1]))
    let a = getFact n 
    let b = getFact (n-k) 
    let c = getFact k     
    let e = modPow b (modulo-2L) modulo    
    let f = modPow c (modulo-2L) modulo    
    let res1 = (a * e) % modulo
    let res = (res1 * f) % modulo    
    printfn "%d" res
    

[<EntryPoint>]
let main argv =       
    let t = Console.ReadLine() |> int    
    [1 .. t] |> List.map processCases |> ignore
    0