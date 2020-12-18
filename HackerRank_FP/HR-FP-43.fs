//Captain Prime: https://www.hackerrank.com/challenges/captain-prime/problem

module HackerRank

open System

let hasZero (num:string) = 
    let ret = num |> Seq.fold (fun acc x -> 
                                    let res = x='0' 
                                    (res || acc)) false
    ret


let isPrime num = 

    let checkDivisible acc x =        
        let res = ((num%x)=0)        
        acc || res

    match num with 
    | 1 -> false
    | 2 -> true
    | _ -> 
        if (num%2)=0 then   
            false
        else
            let sq = Math.Sqrt(num |> float) |> int
            let lt = [3..2..sq]            
            lt |> List.fold checkDivisible false |> not



let isLeftTrimPrime (num:string) =
    let ans = [1..(num.Length-1)] |> List.fold (fun acc x -> 
                                            let n = num.[x..] |> int
                                            let ret = isPrime n
                                            (acc && ret)) true
    ans

let isRightTrimPrime (num:string) =
    let ans = [(num.Length-1)..(-1)..0] |> List.fold (fun acc x -> 
                                            let n = num.[..x] |> int
                                            let ret = isPrime n
                                            (acc && ret)) true
    ans


let (|Center|Left|Right|Dead|) (input:string) =
    let a = input |> int |> isPrime 
    let b = hasZero input |> not
    let c = isRightTrimPrime input
    let d = isLeftTrimPrime input
    if (a && b && c && d) then
        Center
    elif (a && b && c) then
        Right
    elif (a && b && d) then
        Left
    else
        Dead

let solve _ =
    let num = Console.ReadLine()
    match num with
    | Center -> printfn "CENTRAL"
    | Right -> printfn "RIGHT"
    | Left -> printfn "LEFT"
    | Dead -> printfn "DEAD"

[<EntryPoint>]
let main argv =  
    let t = Console.ReadLine() |> int
    [1..t] |> List.map solve |> ignore   
    0