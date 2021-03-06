﻿module Functions

open Tree
open Expression

let reverseList list = 
    let rec recursiveReverse list tempList =
        match list with
        | [] -> tempList
        | h :: t -> recursiveReverse t (h :: tempList)
    recursiveReverse list []

let indexOfMaxSum list =
    let zList = List.zip (reverseList (reverseList list).Tail) list.Tail
    let rec inRec list acc =
        match list with
        | (a, b) :: t -> if a + b > acc then inRec t (acc + 1) else inRec t acc
        | [] -> acc
    inRec zList 0

let evenNumbersCountMap (list : list<'a>) = 
    list |> List.map (fun x -> (x + 1) % 2) |> List.sum

let evenNumbersCountFilter (list : list<'a>) = 
    list |> List.filter (fun x -> x % 2 = 0) |> List.length

let evenNumbersCountFold (list : list<'a>) =
    List.fold (fun acc x -> acc + ((x + 1) % 2)) 0 list

let isPrime (n : int) =
    let rec check i =
        i > int (System.Math.Sqrt (float n)) + 1 || (n % i <> 0 && if i <> 2 then check (i + 2) else check (i + 1))
    check 2

let primeNumbersSeq = 
    let rec loop x = seq {if isPrime x then yield x; yield! loop (x + 1); else yield! loop (x + 1)}
    loop 2

let rec treeHeight tree =
    match tree with 
    | Tree (_, l, r) -> 1 + max (treeHeight r) (treeHeight l)
    | Tip _ -> 1

let rec eval exp = 
    match exp with
    | Number n -> n
    | Addition (x, y) -> eval x + eval y
    | Multiplication (x, y) -> eval x * eval y
    | Division (x, y) -> eval x / eval y
    | Mod (x, y) -> eval x % eval y
    | Subtraction (x, y) -> eval x - eval y