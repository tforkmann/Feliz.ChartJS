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

[<ReactComponent>]
let ChartJSLineChart () =
    ChartJS.line [
        line.options [
            option.responsive true
        ]
        line.data [
            lineData.labels [|"Red"; "Blue"; "Yellow"; "Green"; "Purple"; "Orange"|]
            lineData.datasets [|
                lineData.dataset [
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
        ]
            ]
[<ReactComponent>]
let ChartJSBarChart () =
    ChartJS.bar [
        bar.options [
            option.responsive true
        ]
        bar.data [
            barData.labels [|"Red"; "Blue"; "Yellow"; "Green"; "Purple"; "Orange"|]
            barData.datasets [|
                barData.dataset [
                                bardataset.label "My First Dataset"
                                bardataset.borderColor "rgb(53, 162, 235)"
                                bardataset.backgroundColor "rgba(53, 162, 235, 0.5)"
                                bardataset.data [|"1"; "2"; "3"; "4"; "5"; "6"|]
                                ]
                barData.dataset [
                                bardataset.label "My Second Dataset"
                                bardataset.borderColor "yellow"
                                bardataset.backgroundColor "rgba(53, 162, 235, 0.5)"
                                bardataset.data [|"1"; "2"; "3"; "4"; "4"; "6"|]
                                ]
                            |]
        ]
            ]

let view (model: Model) (dispatch: Msg -> unit) =
    div [ Props.Style [ Props.CSSProp.Height 800 ] ] [
        ChartJSLineChart ()
        ChartJSBarChart ()

    ]