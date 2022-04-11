namespace RecordMemberReturnBug
open System
type MyType () =
    member this.NotWorking(value: obj) : obj =
        sprintf "test: %.2f" 1.1

    member this.Working(value: obj) : obj =
        let a = sprintf "test: %.2f" 1.1
        a
