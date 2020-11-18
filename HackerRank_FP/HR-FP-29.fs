// Sequence full of colors: https://www.hackerrank.com/challenges/sequence-full-of-colors/problem

module HackerRank

open System

type Info = {
    RedCount: int;
    GreenCount: int;
    YellowCount: int;
    BlueCount: int;
    IsColorful: bool;
}

let isColorful (u: string) =
    let initialState = { 
        RedCount = 0;
        GreenCount = 0;
        YellowCount = 0;
        BlueCount =  0;
        IsColorful = true;
    }
    let finalState = Seq.fold (fun initState x ->               
        if initState.IsColorful then  
            let mutable nextState = match x with 
                                    | 'R' -> { 
                                            RedCount = initState.RedCount + 1;
                                            GreenCount = initState.GreenCount;
                                            YellowCount = initState.YellowCount;
                                            BlueCount =  initState.BlueCount;
                                            IsColorful = initialState.IsColorful;
                                        }
                                    | 'G' -> { 
                                            RedCount = initState.RedCount;
                                            GreenCount = initState.GreenCount + 1;
                                            YellowCount = initState.YellowCount;
                                            BlueCount =  initState.BlueCount;
                                            IsColorful = initialState.IsColorful;
                                        }
                                    | 'B' -> { 
                                            RedCount = initState.RedCount;
                                            GreenCount = initState.GreenCount;
                                            YellowCount = initState.YellowCount;
                                            BlueCount =  initState.BlueCount + 1;
                                            IsColorful = initialState.IsColorful;
                                        }
                                    | 'Y' -> { 
                                            RedCount = initState.RedCount;
                                            GreenCount = initState.GreenCount;
                                            YellowCount = initState.YellowCount + 1;
                                            BlueCount =  initState.BlueCount;
                                            IsColorful = initialState.IsColorful;
                                        }
                                    | _ -> { 
                                            RedCount = initState.RedCount;
                                            GreenCount = initState.GreenCount;
                                            YellowCount = initState.YellowCount;
                                            BlueCount =  initState.BlueCount;
                                            IsColorful = false;
                                        }   
            
            if (((abs (nextState.RedCount - nextState.GreenCount )) > 1) || ((abs (nextState.YellowCount - nextState.BlueCount )) > 1)) then
                nextState <- { 
                                RedCount = nextState.RedCount;
                                GreenCount = nextState.GreenCount;
                                YellowCount = nextState.YellowCount;
                                BlueCount =  nextState.BlueCount;
                                IsColorful = false;
                            } 
                nextState
            else 
                nextState
        else            
            initState) initialState u
    if finalState.IsColorful then
        (finalState.RedCount = finalState.GreenCount && finalState.YellowCount = finalState.BlueCount)
    else
        false

let processTestCases _ = 
    Console.ReadLine() |> isColorful |> (fun x -> match x with
                                                  | true -> printfn "True"
                                                  | false -> printfn "False")  
    
[<EntryPoint>]
let main argv = 
    let t = Console.ReadLine() |> int
    [1..t] |> List.map processTestCases |> ignore
    0