// Mangoes: https://www.hackerrank.com/challenges/mango/
module HackerRank

open System


let kmax (k: int64) (a:seq<int64>) (h:seq<int64>) =
    let inter = Seq.map2 (fun a1 h1 -> a1 + ((k-1L)*h1)) a h |> Seq.sort |> Seq.take (k|>int) |> Seq.sum
    inter

[<EntryPoint>]
let main argv =  
    let (n, m) = Console.ReadLine().Split() |> fun elem -> (elem.[0] |> int64, elem.[1] |> int64)
    let app = Console.ReadLine().Split() |> Seq.map int64
    let happ = Console.ReadLine().Split() |> Seq.map int64    
    
    let rec binarySearch (beg:int64) (en:int64) =  
      match sign <| compare en beg with
      | -1 -> None  
      | _ -> let mid = (beg+en)/2L
             let target = kmax mid app happ                         
             match  sign <| compare m target with         
             | -1  ->  if (beg<mid) then
                            binarySearch beg (mid-1L)
                       else 
                            Some(beg)
             | _ -> if (mid< en) then
                        binarySearch (mid+1L) en
                     else
                        Some(mid)

    let result = binarySearch 1L n        
    match result with
      | Some x -> 
                    let target = kmax x app happ                                   
                    match sign <| compare m target with                     
                    | -1 -> printf "%d" (x-1L)          
                    | _ -> printfn "%d" x              
      | None -> printfn "0"
    0