open System
open Car

printf "Enter distance to drive: "
let distance = Console.ReadLine() |> int

let carStatus = drive distance 8

if carStatus.IsOutOfGas then
    printfn "You ran out of gas!"
else
    printfn $"You have {carStatus.RemainingGas} gas left."