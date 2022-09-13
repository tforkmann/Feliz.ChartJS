module Index

open System
open Elmish
open Fable.React
open Feliz
open Feliz.ChartJS
open Browser.Dom

type Model =
    { Txt: string }

type Msg =
    | UpdateTxt of string

let init () =
    { Txt = "" },
    Cmd.none

let update msg (model: Model) =
    match msg with
    | UpdateTxt txt ->
        { model with Txt = txt }, Cmd.none

let layouts =
    [|  ReactJS.layout [
                layout.i "a"
                layout.x 0
                layout.y 0
                layout.w 1
                layout.h 2
                layout.``static`` true
            ]
        ReactJS.layout [
            layout.i "b"
            layout.x 1
            layout.y 0
            layout.w 3
            layout.h 2
            layout.minW 2
            layout.maxW 4
        ] |]

[<ReactComponent>]
let ReactJSChart () =
    ReactJS.gridChart [
            ReactJS.layoutElements layouts
            ReactJS.className "layout"
            ReactJS.cols 24
            ReactJS.autoSize false
            ReactJS.isDraggable true
            ReactJS.compactType Vertical
            ReactJS.preventCollision true
            ReactJS.rowHeight 30
            ReactJS.onLayoutChange (fun layout ->
                console.log layout
                for e in layout do
                    console.log e.x
                    console.log e.y
                    console.log e.i
                    console.log e.w
                    console.log e.h)
            ReactJS.width 1200
            ReactJS.children [
                Html.div [
                    prop.key "a"
                    prop.text "Texta"
                ]
                Html.div [
                    prop.key "b"
                    prop.text "Textb"
                ]
                Html.div [
                    prop.key "c"
                    prop.text "Textc"
                ]
                Html.div [
                    prop.key "d"
                    prop.text "Textd"
                ]
                Html.div [
                    prop.key "e"
                    prop.text "TextE"
                ]

            ]
        ]
let view (model: Model) (dispatch: Msg -> unit) =
    div [ Props.Style [ Props.CSSProp.Height 800 ] ] [
        ReactJSChart ()
    ]