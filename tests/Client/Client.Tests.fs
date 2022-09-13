module Client.Tests

open Fable.Mocha

open Index

//ToDo
let client = testList "Client" [
    testCase "Test ChartJS" <| fun _ ->
        // let model, _ = init ()
        // let ChartJS =
        //     { Id = "6"
        //       Descr = "AdditionalChartJS" }

        Expect.equal "2" "2" "Works"
]

let all =
    testList "All"
        [
#if FABLE_COMPILER // This preprocessor directive makes editor happy
            Shared.Tests.shared
#endif
            client
        ]

[<EntryPoint>]
let main _ = Mocha.runTests all