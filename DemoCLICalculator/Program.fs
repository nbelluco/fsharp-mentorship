open System

type Operation =
    | Sum
    | Subtraction
    | Multiplication
    | Division
    | NotCorrect

let matchOperation (input: string) =
    match input with
    | "s" -> Operation.Sum
    | "sb" -> Operation.Subtraction
    | "m" -> Operation.Multiplication
    | "d" -> Operation.Division
    | _ -> Operation.NotCorrect

let executeOperation (firstNumber: int, secondNumber: int, operation: Operation) =
    match operation with
    | Operation.Sum -> printfn "%i + %i = %i" firstNumber secondNumber (firstNumber + secondNumber)
    | Operation.Subtraction -> printfn "%i - %i = %i" firstNumber secondNumber (firstNumber - secondNumber)
    | Operation.Multiplication -> printfn "%i * %i = %i" firstNumber secondNumber (firstNumber * secondNumber)
    | Operation.Division -> printfn "%i / %i = %i" firstNumber secondNumber (firstNumber / secondNumber)
    | Operation.NotCorrect -> printfn "Invalid operation. Exiting ..."
                            
[<EntryPoint>]
let main argv =

    printfn "Welcome to the demo calculator written in F#"
    printfn "--------------------------------------------\n"

    while true do
    
        printfn "Which is the first number ?"
        let firstNumber = Console.ReadLine() |> int
    

        printfn "Which is the second number ?"
        let secondNumber = Console.ReadLine() |> int
 
        printfn "Which operation do you want to perform ?"
        printfn "Type 's' for sum, 'sb' for subtraction, 'm' for multipliation, 'd' for division"
        let chosenOperation = Console.ReadLine() |> matchOperation

        executeOperation (firstNumber, secondNumber, chosenOperation)
        

    0 // return an integer exit code