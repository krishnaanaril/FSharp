//Area Under Curves and Volume of Revolving a Curve: https://www.hackerrank.com/challenges/area-under-curves-and-volume-of-revolving-a-curv/problem
module HackerRank

open System

[<EntryPoint>]
let main argv =    
    let dataA = Console.ReadLine().Split(' ') |> Seq.map double
    let dataB = Console.ReadLine().Split(' ') |> Seq.map double    
    let limits = Console.ReadLine().Split(' ') |> Seq.map double |> Seq.toList
    let steppers = seq { limits.Item(0) .. 0.001 .. limits.Item(1) }    
    let fn dat = 
        Seq.map2 (fun x y -> x * (dat ** y)) dataA dataB 
        |> Seq.reduce (+)
    let (area, volume) = 
        steppers 
        |> Seq.map (fun elem -> (fn elem) * 0.001, Math.PI * ((fn elem) ** 2.0) * 0.001) 
        |> Seq.reduce (fun (a, b) (c, d) -> c+a, b+d)
    printfn "%f" area
    printfn "%f" volume
    0 // return an integer exit code