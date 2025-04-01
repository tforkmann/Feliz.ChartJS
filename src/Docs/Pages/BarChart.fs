module Docs.Pages.BarChart

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
                scale.xWithAxes [ axes.stacked true ]
                scale.yWithAxes [ axes.stacked true ]
            ]
            option.plugins [
                plugin.legend [ legend.position Position.Top ]
                plugin.title [
                    title.display true
                    title.text "Chart.js Bar Chart"
                ]
                plugin.dataLabels [
                    dataLabels.display true
                    dataLabels.align Position.Bottom
                    dataLabels.borderRadius 3
                    dataLabels.color "red"
                    dataLabels.backgroundColor "green"
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
    Html.div [
        prop.style [ style.height 800 ]
        prop.children [
            ChartJSBarChart()
        ]
    ]

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
                plugin.dataLabels [
                    dataLabels.display true
                    dataLabels.align Bottom
                    dataLabels.borderRadius 3
                    dataLabels.color "red"
                    dataLabels.backgroundColor "green"
                    // dataLabels.labels [
                    //     labels.value {|color="blue"|}
                    // ]
                    // dataLabels.formatter renderCustomLabel
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

let title = Html.text "Bar Chart"

[<ReactComponent>]
let BarChartView () =
    Html.div [
        Bulma.content [
            codedView title code ChartJSChart
        ]
        fixDocsView "BarChart" false
    ]
