// Compute the Area of a Polygon: https://www.hackerrank.com/challenges/lambda-march-compute-the-area-of-a-polygon/problem
module HackerRank

open System

let readxy _ =
    let xy = Console.ReadLine().Split(' ') |> (fun elem -> 
        let x = elem.[0] |> float
        let y = elem.[1] |> float
        (x, y))
    xy

let getArea list shiftedlist = 
    let interRes = 
        List.fold2 (fun acc (x1, y1) (x2, y2) -> 
        let a = x1 * y2
        let b = x2 * y1
        let diff = (a - b)
        acc + diff) 0.0 list shiftedlist    
    (abs interRes)/2.0

[<EntryPoint>]
let main argv =  
    let n = Console.ReadLine() |> int    
    let values = 
        [1..n] 
        |> List.map readxy    
    let shiftedValues = List.append values.[1..] values.[..0]      
    getArea values shiftedValues |> printfn "%A" 
    0