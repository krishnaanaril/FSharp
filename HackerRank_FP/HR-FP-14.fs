// Compute the Perimeter of a Polygon: https://www.hackerrank.com/challenges/lambda-march-compute-the-perimeter-of-a-polygon/problem
module HackerRank

open System

let readxy _ =
    let xy = Console.ReadLine().Split(' ') |> (fun elem -> 
        let x = elem.[0] |> float
        let y = elem.[1] |> float
        (x, y))
    xy

let getPerimeter list shiftedlist = 
    List.fold2 (fun acc (x1, y1) (x2, y2) -> 
        let squaredx = pown (x2-x1) 2
        let squaredy = pown (y2-y1) 2
        let edgeLength = sqrt (squaredx+squaredy)
        acc + edgeLength) 0.0 list shiftedlist

[<EntryPoint>]
let main argv =  
    let n = Console.ReadLine() |> int    
    let values = 
        [1..n] 
        |> List.map readxy    
    let shiftedValues = List.append values.[1..] values.[..0]      
    getPerimeter values shiftedValues |> printfn "%A" 
    0