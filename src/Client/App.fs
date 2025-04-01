module App

open Elmish
open Elmish.React
open Fable.Core.JsInterop

#if DEBUG
open Elmish.Debug
#endif

importSideEffects "./index.css"

Program.mkProgram Index.init Index.update Index.view
#if DEBUG
|> Program.withConsoleTrace
#endif
|> Program.withReactSynchronous "elmish-app"
#if DEBUG
|> Program.withDebugger
#endif
|> Program.run
