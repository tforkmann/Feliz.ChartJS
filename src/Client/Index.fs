module Index

open System
open Elmish
open Fable.React
open Feliz
open Feliz.ChartJS
open Browser.Dom
open Fable.Core.JsInterop

type Model = { Txt: string }

type Msg = UpdateTxt of string

let init () = { Txt = "" }, Cmd.none

let update msg (model: Model) =
    match msg with
    | UpdateTxt txt -> { model with Txt = txt }, Cmd.none

[<ReactComponent>]
let ChartJSLineChart () =
    ChartJS.line [
        line.options [ option.responsive true ]
        line.data [
            lineData.labels [|
                "Red"
                "Blue"
                "Yellow"
                "Green"
                "Purple"
                "Orange"
            |]
            lineData.datasets [|
                lineData.dataset [
                    lineDataSet.label "My First Dataset"
                    lineDataSet.borderColor "rgb(53, 162, 235)"
                    lineDataSet.backgroundColor "rgba(53, 162, 235, 0.5)"
                    lineDataSet.data [|
                        "1"
                        "2"
                        "3"
                        "4"
                        "5"
                        "6"
                    |]
                ]
                lineData.dataset [
                    lineDataSet.label "My Second Dataset"
                    lineDataSet.borderColor "yellow"
                    lineDataSet.backgroundColor "rgba(53, 162, 235, 0.5)"
                    lineDataSet.data [|
                        "1"
                        "2"
                        "3"
                        "4"
                        "4"
                        "6"
                    |]
                ]
            |]
        ]
    ]

[<ReactComponent>]
let ChartJSBarChart () =
    ChartJS.bar [
        bar.options [
            option.responsive true
            option.scales [
                scale.x [
                    axes.stacked true
                ]
                scale.y [
                    axes.stacked true
                ]
            ]
            option.plugins [
                plugin.legend [
                    legend.position LegendPosition.Top
                ]
                plugin.title [
                    title.display true
                    title.text "Chart.js Bar Chart"
                ]
            ]
        ]
        bar.data [
            barData.labels [| "January"; "Feburary"|]
            barData.datasets [|
                barData.dataset [
                    barDataSet.label "My First Dataset"
                    barDataSet.borderColor "blue"
                    barDataSet.backgroundColor "rgba(53, 162, 235, 0.5)"
                    barDataSet.borderSkipped false
                    barDataSet.borderWidth 2
                    barDataSet.borderRadius 50
                    barDataSet.data [|"1";"2" |]
                ]
                barData.dataset [
                    barDataSet.label "My Second Dataset"
                    barDataSet.borderColor "green"
                    barDataSet.backgroundColor "rgba(53, 162, 235, 0.5)"
                    barDataSet.borderSkipped false
                    barDataSet.borderWidth 2
                    barDataSet.borderRadius 50
                    barDataSet.data [|"1";"2" |]
                ]
            |]
        ]
    ]

[<ReactComponent>]
let ChartJSDoughnutChart () =
    ChartJS.doughnut [
        doughnut.options [
            option.responsive true
        ]
        doughnut.data [
            doughnutData.labels [|
                "Red"
                "Blue"
                "Yellow"
                "Green"
                "Purple"
                "Orange"
            |]
            doughnutData.datasets [|
                doughnutData.dataset [
                    doughnutDataSet.label "My First Dataset"
                    doughnutDataSet.borderColor "rgb(53, 162, 235)"
                    doughnutDataSet.backgroundColor "rgba(53, 162, 235, 0.5)"
                    doughnutDataSet.data [|
                        "1"
                        "2"
                        "3"
                        "4"
                        "5"
                        "6"
                    |]
                ]
                doughnutData.dataset [
                    doughnutDataSet.label "My Second Dataset"
                    doughnutDataSet.borderColor "yellow"
                    doughnutDataSet.backgroundColor "rgba(53, 162, 235, 0.5)"
                    doughnutDataSet.data [|
                        "1"
                        "2"
                        "3"
                        "4"
                        "4"
                        "6"
                    |]
                ]
            |]
        ]
    ]

let view (model: Model) (dispatch: Msg -> unit) =
    div [ Props.Style [ Props.CSSProp.Height 800 ] ] [
        // ChartJSLineChart()
        ChartJSBarChart()
        // ChartJSDoughnutChart()

    ]