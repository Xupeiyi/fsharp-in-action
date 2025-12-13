module Car

type CarStatus = {
    RemainingGas: float
    IsOutOfGas: bool
}

let drive distance gas = 
    let remaingGas = 
        if distance > 50.0 then gas / 2.0
        elif distance > 25.0 then gas - 10.0
        elif distance > 0.0 then gas - 1.0
        else gas
    {
        RemainingGas = remaingGas 
        IsOutOfGas = remaingGas <= 0.0
    }