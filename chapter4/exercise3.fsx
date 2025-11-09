let drive gas distance = 
    if distance > 50.0 then gas / 2.0
    elif distance > 25.0 then gas - 10.0
    elif distance > 0.0 then gas - 1.0
    else gas


let gas = 100.0
let firstState = drive gas 70
let secondState = drive firstState 30
let finalState = drive secondState 10
