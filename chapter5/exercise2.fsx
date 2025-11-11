type Person = 
    { 
        NameDetails: string * string
        AgeDetails: int * string 
    }

let buildPerson (forename: string) (surname: string) (age: int) = 
    let ageGroup = if age < 18 then "child" else "adult"
    { 
        NameDetails = (forename, surname)
        AgeDetails = (age, ageGroup)
    }

let p1= buildPerson "John" "Doe" 25

let (foreName1, surName1) = p1.NameDetails
let ageDetails1 = p1.AgeDetails
