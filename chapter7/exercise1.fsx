let calculate operator a b = 
    printfn $"inputs: {a} {b}"
    operator a b

let add x y = x + y

let resultAdd = calculate add 5 10
printfn "The addition result is %d" resultAdd

let multiply x y = x * y
let resultMul = calculate multiply 6 10
printfn "The multiplication result is %d" resultMul