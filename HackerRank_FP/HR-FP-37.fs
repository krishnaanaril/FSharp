// Missing Numbers (FP): https://www.hackerrank.com/challenges/missing-numbers-fp/problem

module HackerRank

open System

let initSeq = seq { for i in 0..105 -> 0 }

let updateSeq key (sq: int seq) =
    sq 
    |> Seq.mapi (fun i x -> if i=key then (x+1) else x)

let countElements sq minVal =
    sq |> Seq.fold (fun state item ->                         
                        let diff = item-minVal                        
                        updateSeq diff state) initSeq


[<EntryPoint>]
let main argv =     
    let n = Console.ReadLine() |> int
    let seqA = Console.ReadLine().Split(' ') |> Seq.map int 
    let minSeqA = Seq.min seqA    
    let m = Console.ReadLine() |> int
    let seqB = Console.ReadLine().Split(' ') |> Seq.map int
    let minSeqB = Seq.min seqB  
    let minVal = Math.Min(minSeqA, minSeqB)
    let finalCountSeqA = countElements seqA minVal     
    let finalCountSeqB = countElements seqB minVal        
    Seq.iteri2 (fun i x y-> 
                    let diff = y-x
                    if diff > 0 then
                        printf "%d " (i+minVal)) finalCountSeqA finalCountSeqB
    0