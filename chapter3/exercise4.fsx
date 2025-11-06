let  explicit = ResizeArray<int>()
let typeHole = ResizeArray<_>()
let omitted = ResizeArray()

typeHole.Add 99
omitted.Add "a"

let combineElements a b c =
    let output = ResizeArray()
    output.Add a
    output.Add b
    output.Add c
    output
 
combineElements 1 2 3

combineElements 1.1 2.2 3.3
