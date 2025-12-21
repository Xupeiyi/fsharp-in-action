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

type TeamGoals = 
    {
        Team: string
        Goals: int
    }

let getTeamGoals result = 
    [
        { Team = result.HomeTeam; Goals = result.HomeGoals }
        { Team = result.AwayTeam; Goals = result.AwayGoals }
    ]

let wonTheMost = 
    results
    |> List.collect getTeamGoals
    |> List.groupBy (fun tg -> tg.Team)
    |> List.map (
        fun (team, teamGoals) -> 
            (
                team,
                teamGoals |> List.sumBy (fun tg -> tg.Goals) 
            )
    )
    |> List.maxBy (fun (team, goals) -> goals)