// String Mingling: https://www.hackerrank.com/challenges/string-mingling/problem

module HackerRank

open System

// Not working for 9 & 10 test cases
// let rec shuffle (a:string) (b:string) =
//     printf "%c%c" a.[0] b.[0]
//     match a.Length with 
//     | 1 -> ()
//     | _ -> 
//         shuffle a.[1..] b.[1..] 

// Not working for 9 & 10 test cases
// let shuffleLists list1 list2 = 
//     Seq.fold2 (fun acc elem1 elem2 -> acc + string elem1 +  string elem2) "" list1 list2

[<EntryPoint>]
let main argv = 
    let p = Console.ReadLine()
    let q = Console.ReadLine()   
    Seq.iter2 (fun elem1 elem2 -> printf "%c%c" elem1 elem2) p q           
    printfn ""
    0