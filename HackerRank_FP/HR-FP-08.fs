//Sum of Odd Elements: https://www.hackerrank.com/challenges/fp-sum-of-odd-elements/problem
module HackerRank

open System

[<EntryPoint>]
let main argv =    
    let read _ = Console.ReadLine()
    let isValid = function null -> false | _ -> true
    let inputList = Seq.initInfinite read |> Seq.takeWhile isValid |> Seq.toList |> List.map int
    let result = inputList |> List.sumBy (fun elem -> if abs (elem%2)=1 then elem else 0)
    printf "%d\n" result
    0 // return an integer exit code
