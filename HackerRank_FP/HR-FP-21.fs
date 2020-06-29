// String-o-Permute: https://www.hackerrank.com/challenges/string-o-permute/problem

module HackerRank

open System

// Not working for 5th test case
// let rec swap (a:string) =
//     printf "%c%c" a.[1] a.[0]    
//     match a.Length with 
//     | 2 -> 
//         printfn ""
//     | _ ->         
//         swap a.[2..]

[<EntryPoint>]
let main argv =    
    let t = Console.ReadLine() |> int    
    [1..t] |> List.iter (fun _ -> 
                            let str = Console.ReadLine() 
                            {0 .. 2 .. (str.Length-1)} 
                            |> Seq.iter (fun x  -> printf "%c%c" str.[x+1] str.[x])
                            printfn "")        
    0