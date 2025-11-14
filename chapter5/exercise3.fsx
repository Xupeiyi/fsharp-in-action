type Name = 
    {
        FirstName: string
        LastName: string
    }

type Address = 
    {
        Street: string
        Country: string
    }

type Customer = 
    { 
        Name: Name
        Address: Address 
        CreditRating: int
    }

type Supplier = 
    {
        Name: Name
        Address: Address
        Balance: decimal
        NextDueDate: System.DateTime
    }

