// Prefix Compression: https://www.hackerrank.com/challenges/prefix-compression/problem

module HackerRank

open System

// This is just a workaround to calculate the prefix
// length. I tried to have an early exit from the fold function
// but it didn't succeed.
let getPrefix (u:string) (v:string) =       
    Seq.foldBack2 (fun a b pos -> if a=b then pos+1 else 0) u v 0    

[<EntryPoint>]
let main argv =   
    let x = Console.ReadLine();
    let y = Console.ReadLine();
    let prefixLength = getPrefix x y    
    let prefix = x.[..(prefixLength-1)]
    printfn "%d %s" prefixLength prefix    
    printfn "%d %s" (x.Length - prefixLength) x.[prefixLength..]
    printfn "%d %s" (y.Length - prefixLength) y.[prefixLength..]
    0