let fizzbuzz i =
    match i % 15 with
    | 0 -> -7
    | _ -> i
let fizz i =
    match i % 3 with
    | 0 -> -3
    | _ -> i
let buzz i =
    match i % 5 with
    | 0 -> -5
    | _ -> i
let tostring i =
    match i with
    | -3 -> "Fizz"
    | -5 -> "Buzz"
    | -7 -> "FizzBuzz"
    | _ -> string i
[<EntryPoint>]
let main argv =
    [ 1 .. 100 ]
    |> List.map fizzbuzz
    |> List.map fizz
    |> List.map buzz
    |> List.map tostring
    |> printfn "%A"
    0
