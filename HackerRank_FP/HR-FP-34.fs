// Remove Duplicates: https://www.hackerrank.com/challenges/remove-duplicates/problem

module HackerRank

open System

let stringFromCharSeq (cl : char seq) =
    String.concat "" <| Seq.map string cl

[<EntryPoint>]
let main argv = 
    let str = Console.ReadLine()
    printfn "%s" (str |> Seq.distinct |> stringFromCharSeq)    
    0