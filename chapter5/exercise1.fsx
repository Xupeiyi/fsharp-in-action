let buildPerson (forename: string) (surname: string) (age: int) = 
    let ageGroup = if age < 18 then "child" else "adult"
    (forename, surname), (age, ageGroup)

let (forename, surename), (age1, ageGroup1) = buildPerson "John" "Doe" 25

let nameDetails, ageDetails = buildPerson "Jane" "Dow" 10
