module Docs.Pages.PolarAreaChart

open Feliz
open Feliz.Bulma
open Feliz.ChartJS
open Docs.SharedView

[<ReactComponent>]
let ChartJSPolarAreaChart () =
    ChartJS.polarArea [
        polarArea.options [
            option.responsive true
            option.plugins [
                plugin.legend [
                    legend.position Position.Right
                ]
                plugin.title [
                    title.display true
                    title.text "Polar Area Chart Example"
                ]
            ]
        ]
        polarArea.data [
            polarAreaData.labels [|
                "Red"
                "Green"
                "Yellow"
                "Grey"
                "Blue"
            |]
            polarAreaData.datasets [|
                polarAreaData.dataset [
                    polarAreaDataSet.label "My Dataset"
                    polarAreaDataSet.backgroundColor [|
                        "rgba(255, 99, 132, 0.5)"
                        "rgba(75, 192, 192, 0.5)"
                        "rgba(255, 205, 86, 0.5)"
                        "rgba(201, 203, 207, 0.5)"
                        "rgba(54, 162, 235, 0.5)"
                    |]
                    polarAreaDataSet.borderColor [|
                        "rgb(255, 99, 132)"
                        "rgb(75, 192, 192)"
                        "rgb(255, 205, 86)"
                        "rgb(201, 203, 207)"
                        "rgb(54, 162, 235)"
                    |]
                    polarAreaDataSet.borderWidth 1
                    polarAreaDataSet.data [| 11; 16; 7; 3; 14 |]
                ]
            |]
        ]
    ]

let ChartJSChart =
    Html.div [
        prop.style [ style.height 500 ]
        prop.children [
            ChartJSPolarAreaChart()
        ]
    ]


let code =
    """
ChartJS.polarArea [
    polarArea.options [
        option.responsive true
        option.plugins [
            plugin.legend [
                legend.position Position.Right
            ]
            plugin.title [
                title.display true
                title.text "Polar Area Chart Example"
            ]
        ]
    ]
    polarArea.data [
        polarAreaData.labels [|
            "Red"
            "Green"
            "Yellow"
            "Grey"
            "Blue"
        |]
        polarAreaData.datasets [|
            polarAreaData.dataset [
                polarAreaDataSet.label "My Dataset"
                polarAreaDataSet.backgroundColor [|
                    "rgba(255, 99, 132, 0.5)"
                    "rgba(75, 192, 192, 0.5)"
                    "rgba(255, 205, 86, 0.5)"
                    "rgba(201, 203, 207, 0.5)"
                    "rgba(54, 162, 235, 0.5)"
                |]
                polarAreaDataSet.borderWidth 1
                polarAreaDataSet.data [| 11; 16; 7; 3; 14 |]
            ]
        |]
    ]
]
    """

let title = Html.text "Polar Area Chart"

[<ReactComponent>]
let PolarAreaChartView () =
    Html.div [
        Bulma.content [
            codedView title code ChartJSChart
        ]
        fixDocsView "PolarAreaChart" false
    ]
