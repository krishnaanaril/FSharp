// Super Digit: https://www.hackerrank.com/challenges/super-digit/problem

module HackerRank

open System

let inline charToInt c = 
    int64 c - int64 '0'

let stringSum str = 
    str |> Seq.map charToInt |> Seq.reduce (+)

let digitSum (num:int64) =
    let rec loop (acc:int64)  (n:int64)  =
        if n < 10L then
            n+acc
        else
            let curDig = n%10L
            loop (acc+curDig) (n/10L)
    loop 0L num

let rec getSuperDigit (num:int64) =
    match num/10L with
    | 0L -> num
    | _ -> num |> digitSum |> getSuperDigit 

[<EntryPoint>]
let main argv = 
    let (n, k) = Console.ReadLine().Split(' ') |> (fun x -> (x.[0], x.[1]|>int64))
    let initSum = (stringSum n) * k
    initSum |> getSuperDigit |> printfn "%d" 
    0