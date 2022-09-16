module Docs.Pages.LineChart

open Fable.React
open Feliz
open Feliz.Bulma
open Feliz.ChartJS
open Docs.SharedView

[<ReactComponent>]
let ChartJSLineChart () =
    ChartJS.line [ line.options [ option.responsive true
                                  option.plugins[plugin.datalabels [ datalabels.display true
                                                                     datalabels.allign Bottom
                                                                     datalabels.borderRadius 3
                                                                     datalabels.color "red"
                                                                     datalabels.backgroundColor "green"
                                                                     // datalabels.labels [
                                                                     //     labels.value {|color="blue"|}
                                                                     // ]
                                                                     // datalabels.formatter renderCustomLabel
                                                                      ]] ]
                   line.data [ lineData.labels [| "Red"
                                                  "Blue"
                                                  "Yellow"
                                                  "Green"
                                                  "Purple"
                                                  "Orange" |]
                               lineData.datasets [| lineData.dataset [ lineDataSet.label "My First Dataset"
                                                                       lineDataSet.borderColor "rgb(53, 162, 235)"
                                                                       lineDataSet.backgroundColor
                                                                           "rgba(53, 162, 235, 0.5)"
                                                                       lineDataSet.data [| "1"
                                                                                           "2"
                                                                                           "3"
                                                                                           "4"
                                                                                           "5"
                                                                                           "6" |] ]
                                                    lineData.dataset [ lineDataSet.label "My Second Dataset"
                                                                       lineDataSet.borderColor "yellow"
                                                                       lineDataSet.backgroundColor
                                                                           "rgba(53, 162, 235, 0.5)"
                                                                       lineDataSet.data [| "1"
                                                                                           "2"
                                                                                           "3"
                                                                                           "4"
                                                                                           "4"
                                                                                           "6" |] ] |] ] ]

let ChartJSChart =
    div [ Props.Style [ Props.CSSProp.Height 800 ] ] [
        ChartJSLineChart()
    ]

let title = Html.text "Line Chart"

let code =
    """
    ChartJS.line [
        line.options [
            option.responsive true
            option.plugins[plugin.datalabels [
                               datalabels.display true
                               datalabels.allign Bottom
                               datalabels.borderRadius 3
                               datalabels.color "red"
                               datalabels.backgroundColor "green"
                               ]]
        ]
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
    """

[<ReactComponent>]
let LineChartView () =
    Html.div [ Bulma.title.h1 [ Html.text "Feliz.ChartJS Example" ]
               Bulma.content [ Html.p "Here is an example how to use ChartJS"
                               codedView title code ChartJSChart ]
               fixDocsView "LineChart" false ]