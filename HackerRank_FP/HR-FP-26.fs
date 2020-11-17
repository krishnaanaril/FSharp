// String Compression: https://www.hackerrank.com/challenges/string-compression/problem

module HackerRank

open System

[<EntryPoint>]
let main argv =     
    let (lst, cnt) = Seq.fold (fun (prev, count) elem ->
                        match elem with
                        | var1 when var1<>prev && count > 1 -> printf "%c%d" prev count; (elem, 1)
                        | var2 when var2<>prev && count = 1 && prev<>' ' -> printf "%c" prev; (elem, 1)
                        | var3 when var3=prev -> (elem, count+1)
                        | _ -> (elem, 1)) (' ', 1) <| Console.ReadLine()
    match cnt with
    | 1 -> printfn "%c" lst
    | _ -> printfn "%c%d" lst cnt
    0