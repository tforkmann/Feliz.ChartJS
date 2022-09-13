module Index

open System
open Elmish
open Fable.React
open Feliz
open Feliz.ChartJS
open Browser.Dom
open Fable.Core.JsInterop

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


let datasets =
    [|  lineData.dataset [
            linedataset.label "My First Dataset"
            linedataset.borderColor "rgb(53, 162, 235)"
            linedataset.backgroundColor "rgba(53, 162, 235, 0.5)"
            linedataset.data [|"1"; "2"; "3"; "4"; "5"; "6"|]
            ]
        lineData.dataset [
            linedataset.label "My Second Dataset"
            linedataset.borderColor "yellow"
            linedataset.backgroundColor "rgba(53, 162, 235, 0.5)"
            linedataset.data [|"1"; "2"; "3"; "4"; "4"; "6"|]
            ]
         |]

[<ReactComponent>]
let ChartJSChart () =
    ChartJS.line [
        ChartJS.options [
            option.responsive true
        ]
        ChartJS.lineData [
            lineData.labels [|"Red"; "Blue"; "Yellow"; "Green"; "Purple"; "Orange"|]
            lineData.datasets [|
                linedataset.label "My First Dataset"
                linedataset.borderColor "rgb(53, 162, 235)"
                linedataset.backgroundColor "rgba(53, 162, 235, 0.5)"
                linedataset.data [|"1"; "2"; "3"; "4"; "5"; "6"|]
            |]
            lineData.datasets datasets
        ]
        // line.data [
        //     {|
        //     labels = [|"January"; "February"; "March"; "April"; "May"; "June"; "July" |]
        //     datasets = [|
        //         {||}|]
        //     |}|}
        // line.data  {|
        //     // lables = [|"January"; "February"; "March"; "April"; "May"; "June"; "July" |]
        //     // datasets =[||]
        // |}]
            // Data.labels [ "January"; "February"; "March"; "April"; "May"; "June"; "July" ]
            // Data.datasets [
            //     Dataset.label "My First dataset"
            //     Dataset.backgroundColor "rgba(255,99,132,0.2)"
            //     Dataset.borderColor "rgba(255,99,132,1)"
            //     Dataset.borderWidth 1
            //     Dataset.hoverBackgroundColor "rgba(255,99,132,0.4)"
            //     Dataset.hoverBorderColor "rgba(255,99,132,1)"
            //     Dataset.data [ 65; 59; 80; 81; 56; 55; 40 ]
            // ]
            // ]
                        // ChartJS.layoutElements layouts
            // ChartJS.className "layout"
            // ChartJS.cols 24
            // ChartJS.autoSize false
            // ChartJS.isDraggable true
            // ChartJS.compactType Vertical
            // ChartJS.preventCollision true
            // ChartJS.rowHeight 30
            // ChartJS.onLayoutChange (fun layout ->
            //     console.log layout
            //     for e in layout do
            //         console.log e.x
            //         console.log e.y
            //         console.log e.i
            //         console.log e.w
            //         console.log e.h)
            // ChartJS.width 1200
            // ChartJS.children [
            //     Html.div [
            //         prop.key "a"
            //         prop.text "Texta"
            //     ]
            //     Html.div [
            //         prop.key "b"
            //         prop.text "Textb"
            //     ]
            //     Html.div [
            //         prop.key "c"
            //         prop.text "Textc"
            //     ]
            //     Html.div [
            //         prop.key "d"
            //         prop.text "Textd"
            //     ]
            //     Html.div [
            //         prop.key "e"
            //         prop.text "TextE"
            //     ]

            ]

let view (model: Model) (dispatch: Msg -> unit) =
    div [ Props.Style [ Props.CSSProp.Height 800 ] ] [
        ChartJSChart ()
    ]