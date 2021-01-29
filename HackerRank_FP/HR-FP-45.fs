// Sherlock and the Maze: https://www.hackerrank.com/challenges/sherlock-and-the-maze/problem
module HackerRank

open System

let mx = 105
let modulo = 1000000007L

let memoize f = 
    let memo = Array4D.init mx mx 5 mx (fun i j k l -> -1L)    
    (fun (n, m, k, d) ->
        if n<0 || m<0 then 
            0L
        elif n=0 && m=0 then
            1L
        elif d=0 then   
            if k=0 && n=0 then 
                1L
            elif k=1 && m=0 then 
                1L
            else 
                0L
        else
            let v = memo.[n, m, k, d]
            if v = -1L then
                let v = f(n, m, k, d)
                memo.[n, m, k, d] <- v
                v
            else
                v)

let rec countPathUtil = memoize (fun (n, m, k, d) ->                                     
                                    if k=0 then
                                        (countPathUtil(n, m-1, 0, d) + countPathUtil(n-1, m, 1, d-1)) % modulo
                                    else
                                        (countPathUtil(n-1, m, 1, d) + countPathUtil(n, m-1, 0, d-1)) % modulo )

let countPaths (n, m, d) =                                 
    if n=0 && m=0 then
        1L
    else
        (countPathUtil (n-1, m, 1, d) + countPathUtil (n, m-1, 0, d)) % modulo

let processCases _ =
    let (n, m, k) = Console.ReadLine().Split(' ') |> Array.map int |>(fun x -> (x.[0], x.[1], x.[2]))    
    countPaths (n-1, m-1, k) |> printfn "%d"


[<EntryPoint>]
let main argv =    
    let t = Console.ReadLine() |> int    
    [1 .. t] |> List.map processCases |> ignore      
    0
