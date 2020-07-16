// Fibonacci: https://www.hackerrank.com/challenges/fibonacci-fp/problem, https://www.geeksforgeeks.org/program-for-nth-fibonacci-number/

module HackerRank

open System

let multiply (f: int64 [,]) (m: int64 [,]) = 
    let _mod:int64 = 100000007L  
    let x = ((((f.[0,0] * m.[0, 0])%_mod) + ((f.[0, 1] * m.[1, 0])%_mod))%_mod)
    let y = ((f.[0,0] * m.[0, 1])%_mod + (f.[0, 1] * m.[1, 1])%_mod)%_mod
    let z = ((f.[1,0] * m.[0, 0])%_mod + (f.[1, 1] * m.[1, 0])%_mod)%_mod
    let w = ((f.[1,0] * m.[0, 1])%_mod + (f.[1, 1] * m.[1, 1])%_mod)%_mod    
    array2D [[x; y]; [z; w]]

let rec power (f: int64 [,]) (n:int64) = 
    match n with
    | 0L | 1L -> f
    | _ -> 
        let m = array2D [[1L; 1L]; [1L; 0L]]
        let newf = power f (n/2L)
        let res = multiply newf newf        
        if (n%2L)=0L then res else (multiply res m)

let fib (n:int64) = 
    let f = array2D [[1L; 1L]; [1L; 0L]]
    match n with
    | 0L -> 0L
    | _ -> 
        let res = power f (n-1L)
        res.[0, 0]

[<EntryPoint>]
let main argv = 
    let t = Console.ReadLine() |> int 
    [1..t]
    |> List.iter (fun _ -> 
        let n = Console.ReadLine() |> int64
        fib n |> printfn "%d" )       
    0