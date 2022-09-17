module Docs.Pages.BarChart

open Fable.React
open Feliz
open Feliz.Bulma
open Feliz.ChartJS
open Docs.SharedView

[<ReactComponent>]
let ChartJSBarChart () =
    ChartJS.bar [
        bar.options [
            option.responsive true
            option.scales [
                scale.x [ axes.stacked true ]
                scale.y [ axes.stacked true ]
            ]
            option.plugins [
                plugin.legend [ legend.position Top ]
                plugin.title [
                    title.display true
                    title.text "Chart.js Bar Chart"
                ]
                plugin.datalabels [
                    datalabels.display true
                    datalabels.allign Bottom
                    datalabels.borderRadius 3
                    datalabels.color "red"
                    datalabels.backgroundColor "green"
                    // datalabels.labels [
                    //     labels.value {|color="blue"|}
                    // ]
                    // datalabels.formatter renderCustomLabel
                    ]
            ]
        ]
        bar.data [
            barData.labels [|
                "January"
                "Feburary"
            |]
            barData.datasets [|
                barData.dataset [
                    barDataSet.label "My First Dataset"
                    barDataSet.borderColor "blue"
                    barDataSet.backgroundColor "rgba(53, 162, 235, 0.5)"
                    barDataSet.borderSkipped false
                    barDataSet.borderWidth 2
                    barDataSet.borderRadius 50
                    barDataSet.data [| "1"; "2" |]
                ]
                barData.dataset [
                    barDataSet.label "My Second Dataset"
                    barDataSet.borderColor "green"
                    barDataSet.backgroundColor "rgba(53, 162, 235, 0.5)"
                    barDataSet.borderSkipped false
                    barDataSet.borderWidth 2
                    barDataSet.borderRadius 50
                    barDataSet.data [| "1"; "2" |]
                ]
            |]
        ]
    ]

let ChartJSChart =
    div [ Props.Style [ Props.CSSProp.Height 800 ] ] [
        ChartJSBarChart()
    ]

let title = Html.text "Line Chart"

let code =
    """
    ChartJS.bar [
        bar.options [
            option.responsive true
            option.scales [
                scale.x [ axes.stacked true ]
                scale.y [ axes.stacked true ]
            ]
            option.plugins [
                plugin.legend [ legend.position Top ]
                plugin.title [
                    title.display true
                    title.text "Chart.js Bar Chart"
                ]
                plugin.datalabels [
                    datalabels.display true
                    datalabels.allign Bottom
                    datalabels.borderRadius 3
                    datalabels.color "red"
                    datalabels.backgroundColor "green"
                    // datalabels.labels [
                    //     labels.value {|color="blue"|}
                    // ]
                    // datalabels.formatter renderCustomLabel
                    ]
            ]
        ]
        bar.data [
            barData.labels [|
                "January"
                "Feburary"
            |]
            barData.datasets [|
                barData.dataset [
                    barDataSet.label "My First Dataset"
                    barDataSet.borderColor "blue"
                    barDataSet.backgroundColor "rgba(53, 162, 235, 0.5)"
                    barDataSet.borderSkipped false
                    barDataSet.borderWidth 2
                    barDataSet.borderRadius 50
                    barDataSet.data [| "1"; "2" |]
                ]
                barData.dataset [
                    barDataSet.label "My Second Dataset"
                    barDataSet.borderColor "green"
                    barDataSet.backgroundColor "rgba(53, 162, 235, 0.5)"
                    barDataSet.borderSkipped false
                    barDataSet.borderWidth 2
                    barDataSet.borderRadius 50
                    barDataSet.data [| "1"; "2" |]
                ]
            |]
        ]
    ]
    """

[<ReactComponent>]
let BarChartView () =
    Html.div [ Bulma.title.h1 [ Html.text "Feliz.ChartJS Example" ]
               Bulma.content [ Html.p "Here is an example how to use ChartJS"
                               codedView title code ChartJSChart ]
               fixDocsView "LineChart" false ]