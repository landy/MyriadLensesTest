//------------------------------------------------------------------------------
//        This code was generated by myriad.
//        Changes to this file will be lost when the code is regenerated.
//------------------------------------------------------------------------------
namespace rec MyriadTest.App

module UserLenses =
    open MyriadTests.App.Domain

    let Name =
        (fun (x: User) -> x.Name), (fun (value: string) (x: User) -> { x with Name = value })

    let Age =
        (fun (x: User) -> x.Age), (fun (value: int) (x: User) -> { x with Age = value })

    let Email =
        (fun (x: User) -> x.Email), (fun (value: string option) (x: User) -> { x with Email = value })



