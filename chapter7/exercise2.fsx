type Result = 
    {
        HomeTeam: string
        HomeGoals: int
        AwayTeam: string
        AwayGoals: int
    }

let create homeTeam homeGoals awayTeam awayGoals = 
    {
        HomeTeam = homeTeam
        HomeGoals = homeGoals
        AwayTeam = awayTeam
        AwayGoals = awayGoals
    }

let results = [
    create "Messiville" 1 "Ronaldo City" 2
    create "Messiville" 1 "Bale Town" 3
    create "Ronaldo City" 2 "Bale Town" 3
    create "Bale Town" 2 "Messiville" 1
]

let isAwayWin result = result.AwayGoals > result.HomeGoals
let wonAwayTheMost = 
    results
    |> List.filter isAwayWin
    |> List.countBy (fun result -> result.AwayTeam)
    |> List.maxBy (fun (team, count) -> count)

let isRonaldoCityGame result = 
    result.HomeTeam = "Ronaldo City" || result.AwayTeam = "Ronaldo City"

let nRonaldoCityGames = 
    results
    |> List.filter isRonaldoCityGame
    |> List.length