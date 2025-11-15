let add (firstNumber: int) (secondNumber: int) = 
    firstNumber + secondNumber

let multiply (firstNumber: int) (secondNumber: int) = 
    firstNumber * secondNumber

let addTen = add 10

let timesTwo = multiply 2

let result1 = addTen 5

let addTenAndDouble number = 
    let numberPlusTen = addTen number
    timesTwo numberPlusTen

let result2 = addTenAndDouble 5

