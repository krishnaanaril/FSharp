// Functions and Fractals: Sierpinski triangles: https://www.hackerrank.com/challenges/functions-and-fractals-sierpinski-triangles/problem
module HackerRank

open System

let printDiag diag =
    for r = 0 to Array2D.length1 diag - 1 do
        for c = 0 to Array2D.length2 diag - 1 do
            printf "%c" (if diag.[r, c]=0 then '_' else '1')
        printfn ""

let fillTirangle (x, y, h) (diag:int [,]) = 
    for r = x to x+h-1 do        
        for c = y-(r-x) to y+(r-x) do
            diag.[r, c] <- 1
    diag

let rec genTriangle (x, y, h) n (diag:int [,]) = 
    match n with
    | 0 -> diag
    | _ -> 
        for r = (x+h-1) downto x+(h/2) do        
            for c = y-(x+h-1-r) to y+(x+h-1-r) do
                diag.[r, c] <- 0        
        diag
        |> genTriangle (x, y, h/2) (n-1)      
        |> genTriangle ((x+h/2), (y-(h/2)), h/2) (n-1)      
        |> genTriangle ((x+h/2), (y+(h/2)), h/2) (n-1)      

[<EntryPoint>]
let main argv =    
    let n =  Console.ReadLine() |> int
    let width = 63
    let height = 32
    let mid = width/2
    let diag = Array2D.init height width (fun i j -> 0)
    diag
    |> fillTirangle (0, mid, height)
    |> genTriangle (0, mid, height) n 
    |> printDiag 
    0