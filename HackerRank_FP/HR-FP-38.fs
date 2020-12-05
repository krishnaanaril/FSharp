// Subset Sum: https://www.hackerrank.com/challenges/subset-sum/problem

module HackerRank

open System

let rec lowerBound target (arr:int64 array) beg en =  
  match sign <| compare en beg with
  | -1 -> None  
  | _ -> let mid = (beg+en)/2
         match  sign <| compare target arr.[mid] with         
         | 1  -> lowerBound target arr (mid+1) en
         | _ -> if beg<mid then
                    lowerBound target arr beg mid
                 else
                    Some(mid)

let processCase dat _ =
  let num = Console.ReadLine() |> int64
  let res = lowerBound num dat 0 ((Array.length dat)-1)
  match res with
  | Some x -> printfn "%d" (x+1)
  | None -> printfn "-1"


[<EntryPoint>]
let main argv = 
  let n = Console.ReadLine() |> int  
  let dat = Console.ReadLine().Split(' ') |> Array.map int64 |> Array.sortDescending  
  let prefixSum = match n with
                  | 1 -> dat
                  | _ -> Array.scan (+) dat.[0] dat.[1..]    
  let t = Console.ReadLine() |> int  
  [1..t] |> List.map (processCase prefixSum) |> ignore
  0