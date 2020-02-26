open System

type Operation =
    | Sum
    | Subtraction
    | Multiplication
    | Division
    | Power
    | NotCorrect

let matchOperation (input: string) =
    match input with
    | "+" -> Operation.Sum
    | "-" -> Operation.Subtraction
    | "*" -> Operation.Multiplication
    | "/" -> Operation.Division
    | "**" -> Operation.Power
    | _ -> Operation.NotCorrect

let executeOperation (firstNumber: float, secondNumber: float, operation: Operation) =
    match operation with
    | Operation.Sum -> printfn ">> %g + %g = %g" firstNumber secondNumber (firstNumber + secondNumber)
    | Operation.Subtraction -> printfn ">> %g - %g = %g" firstNumber secondNumber (firstNumber - secondNumber)
    | Operation.Multiplication -> printfn ">> %g * %g = %g" firstNumber secondNumber (firstNumber * secondNumber)
    | Operation.Division -> printfn ">> %g / %g = %g" firstNumber secondNumber (firstNumber / secondNumber)
    | Operation.Power -> printfn ">> %g ** %g = %g" firstNumber secondNumber (pown firstNumber (int secondNumber))
    | Operation.NotCorrect -> printfn "Invalid operation."
                            
[<EntryPoint>]
let main argv =

    printfn "Welcome to the demo calculator written in F#"
    printfn "--------------------------------------------\n"
    printfn "Syntax: [number] [symbol] [number]"

    while true do
        printf ">> "
        let userInput = Console.ReadLine().Split ' '
        let chosenOperation = matchOperation userInput.[1]
        if userInput.[1] = "/" then
            if int userInput.[2] = 0 then
                printfn "Attempt to divide by 0."
        else
            executeOperation ( float userInput.[0], float userInput.[2], chosenOperation)    

    0 // return an integer exit code