type CustomerDetailsRecord = {
    YearsOfHistory: int;
    HasOverdraft: bool;
    Overdraft: int;
}

let calcMaxOverdraft (years) = 
    250 * years

let canTakeOutALoanNoGuard (recordWithOverdraft: CustomerDetailsRecord) = 
    match recordWithOverdraft with
    | { YearsOfHistory = 0 } -> false
    | { YearsOfHistory = 1; HasOverdraft = true } when recordWithOverdraft.Overdraft > calcMaxOverdraft recordWithOverdraft.YearsOfHistory -> false
    | { YearsOfHistory = 2; HasOverdraft = true } when recordWithOverdraft.Overdraft > calcMaxOverdraft recordWithOverdraft.YearsOfHistory -> false
    | _-> true

let record1 = {
    YearsOfHistory = 1;
    HasOverdraft = true;
    Overdraft = 600;
}

let result1 = canTakeOutALoanNoGuard record1

let record2 = {
    YearsOfHistory = 1;
    HasOverdraft = true;
    Overdraft = 100;
}

let result2 = canTakeOutALoanNoGuard record2

