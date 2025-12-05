module Docs.Pages.PieChart

open Feliz
open Feliz.Bulma
open Feliz.ChartJS
open Docs.SharedView

[<ReactComponent>]
let ChartJSPieChart () =
    ChartJS.pie [
        pie.options [
            option.responsive true
            option.plugins [
                plugin.legend [
                    legend.position Position.Right
                ]
                plugin.title [
                    title.display true
                    title.text "Pie Chart Example"
                ]
            ]
        ]
        pie.data [
            pieData.labels [|
                "Red"
                "Blue"
                "Yellow"
                "Green"
                "Purple"
            |]
            pieData.datasets [|
                pieData.dataset [
                    pieDataSet.label "Votes"
                    pieDataSet.backgroundColor [|
                        "rgba(255, 99, 132, 0.8)"
                        "rgba(54, 162, 235, 0.8)"
                        "rgba(255, 206, 86, 0.8)"
                        "rgba(75, 192, 192, 0.8)"
                        "rgba(153, 102, 255, 0.8)"
                    |]
                    pieDataSet.borderColor [|
                        "rgba(255, 99, 132, 1)"
                        "rgba(54, 162, 235, 1)"
                        "rgba(255, 206, 86, 1)"
                        "rgba(75, 192, 192, 1)"
                        "rgba(153, 102, 255, 1)"
                    |]
                    pieDataSet.borderWidth 2
                    pieDataSet.hoverOffset 10
                    pieDataSet.data [| 12; 19; 3; 5; 2 |]
                ]
            |]
        ]
    ]

let ChartJSChart =
    Html.div [
        prop.style [ style.height 500 ]
        prop.children [
            ChartJSPieChart()
        ]
    ]


let code =
    """
ChartJS.pie [
    pie.options [
        option.responsive true
        option.plugins [
            plugin.legend [
                legend.position Position.Right
            ]
            plugin.title [
                title.display true
                title.text "Pie Chart Example"
            ]
        ]
    ]
    pie.data [
        pieData.labels [|
            "Red"
            "Blue"
            "Yellow"
            "Green"
            "Purple"
        |]
        pieData.datasets [|
            pieData.dataset [
                pieDataSet.label "Votes"
                pieDataSet.backgroundColor [|
                    "rgba(255, 99, 132, 0.8)"
                    "rgba(54, 162, 235, 0.8)"
                    "rgba(255, 206, 86, 0.8)"
                    "rgba(75, 192, 192, 0.8)"
                    "rgba(153, 102, 255, 0.8)"
                |]
                pieDataSet.borderWidth 2
                pieDataSet.hoverOffset 10
                pieDataSet.data [| 12; 19; 3; 5; 2 |]
            ]
        |]
    ]
]
    """

let title = Html.text "Pie Chart"

[<ReactComponent>]
let PieChartView () =
    Html.div [
        Bulma.content [
            codedView title code ChartJSChart
        ]
        fixDocsView "PieChart" false
    ]
