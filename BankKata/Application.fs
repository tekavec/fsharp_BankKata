module Application

type IAccount = 
    abstract member Deposit: float -> unit 
    abstract member Withdraw: float -> unit 
    abstract member PrintStatement: unit -> unit