namespace MyriadTests.App.Domain

[<Myriad.Plugins.Generator.Lenses("Lens")>]
type User = {
    Name : string
    Age : int
    Email : string option
}