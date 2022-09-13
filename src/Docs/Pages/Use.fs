module Docs.Pages.Use

open Feliz
open Elmish
open Feliz.UseElmish
open Feliz.DaisyUI
open Feliz.DaisyUI.Operators
open Docs.SharedView

[<ReactComponent>]
let UseView () =
    React.fragment [ Html.divClassed "description" [ Html.text "After installation just open proper namespace:" ]
                     Html.divClassed "max-w-xl" [ linedMockupCode "open Clapper" ]
                     Html.divClassed
                         "description"
                         [ Html.text "Now you can start using library. Everything important starts with "
                           Html.code [ prop.className "code"
                                       prop.text "PlcProgram.*" ]
                           Html.text " module." ]
                     Html.divClassed
                         "max-w-xl"
                         [ linedMockupCode
                               """@"TIAProgramPath"
|> PlcProgram.projectPath""" ]
                     Html.divClassed
                         "description"
                         [ Html.text
                               "After starting your console app you have to grant Openness access to the TIA Portal." ]
                     Html.divClassed "grid flex-1" [ Html.img [ prop.src "./opennessaccess.png" ] ] ]