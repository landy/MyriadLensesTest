module MyriadTest.App.Entry

open MyriadTests.App.Domain
open Aether

let user = {
    Name = "Jiří"
    Age = 37
    Email = None
}

let age  = Optic.get UserLenses.Age user
let updated = Optic.set UserLenses.Age 38 user

printfn $"users age: {age}"
printfn $"updated users age: {updated.Age}"

