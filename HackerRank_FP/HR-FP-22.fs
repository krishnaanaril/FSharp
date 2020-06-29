// Functions and Fractals - Recursive Trees: https://www.hackerrank.com/challenges/fractal-trees/problem?h_r=next-challenge&h_v=zen

module HackerRank

open System

let printDiag diag =
    for r = 0 to Array2D.length1 diag - 1 do
        for c = 0 to Array2D.length2 diag - 1 do
            printf "%c" (if diag.[r, c]=0 then '_' else '1')
        printfn ""


let rec genTriangle (x, y, h) n (diag:int [,]) = 
    match n with
    | 0 -> diag
    | _ -> 
        for r = (x) downto x-h do                    
            diag.[r, y] <- 1        
        for r = (x-h-1) downto x-2*h-1 do     
            let shift = x-h-r
            diag.[r, y-shift] <- 1
            diag.[r, y+shift] <- 1
        diag
        |> genTriangle (x-2*h-2, y-h-1, h/2) (n-1)      
        |> genTriangle (x-2*h-2, y+h+1, h/2) (n-1)      
        

[<EntryPoint>]
let main argv =    
    let n =  Console.ReadLine() |> int
    let width = 100
    let height = 63
    let mid = width/2
    let diag = Array2D.init height width (fun i j -> 0)
    diag
    |> genTriangle (height-1, mid-1, 15) n 
    |> printDiag
    0