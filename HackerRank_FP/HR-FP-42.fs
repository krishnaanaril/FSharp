// Password Cracker FP: https://www.hackerrank.com/challenges/password-cracker-fp/problem

// solved partially

module HackerRank

open System

let inline sliceString (index:int) (str:string) =
    if index < 0 then
        ("", str)
    elif index >= str.Length then
        ("", str)
    else
        (str.[0..(index-1)], str.[index..])

let rec solve pswdList depth (attempt:string) = 
    match attempt.Length with 
    | 0 -> true
    | _ -> 
        let result = Array.tryFind (fun (x:string) ->         
                                        let pos = attempt.Length - x.Length
                                        let (prefix, suffix) = sliceString pos attempt                               
                                        if suffix = x then                                            
                                            solve pswdList (depth+1) <| prefix
                                        else
                                            false) pswdList
        match result with        
        | None -> 
            false
        | Some (x:string) -> 
            if depth = 0 then
                printf "%s" x
            else
                printf "%s " x
            true

let processCase _ =
    let n = Console.ReadLine() |> int
    let pswdList = Console.ReadLine().Split(' ') |> Array.rev
    let attempt = Console.ReadLine()
    let ans = solve pswdList 0 attempt
    match ans with
    | true -> printfn ""
    | false -> printfn "WRONG PASSWORD"

[<EntryPoint>]
let main argv =        
    let t = Console.ReadLine() |> int
    [1..t] |> List.map processCase |> ignore
    0