module Docs.Pages.ScatterChart

open Feliz
open Feliz.Bulma
open Feliz.ChartJS
open Docs.SharedView

[<ReactComponent>]
let ChartJSScatterChart () =
    ChartJS.scatter [
        scatter.options [
            option.responsive true
            option.plugins [
                plugin.legend [
                    legend.position Position.Top
                ]
                plugin.title [
                    title.display true
                    title.text "Scatter Chart Example"
                ]
            ]
            option.scales [
                scale.xWithAxes [
                    axes.title [
                        title.display true
                        title.text "X Axis"
                    ]
                ]
                scale.yWithAxes [
                    axes.title [
                        title.display true
                        title.text "Y Axis"
                    ]
                ]
            ]
        ]
        scatter.data [
            scatterData.labels [||]
            scatterData.datasets [|
                scatterData.dataset [
                    scatterDataSet.label "Dataset A"
                    scatterDataSet.borderColor "rgba(255, 99, 132, 1)"
                    scatterDataSet.backgroundColor "rgba(255, 99, 132, 0.5)"
                    scatterDataSet.pointRadius 8
                    scatterDataSet.dataPoints [|
                        scatterDataPoints.dataPoint [
                            scatterDataPoint.x -10.0
                            scatterDataPoint.y 0.0
                        ]
                        scatterDataPoints.dataPoint [
                            scatterDataPoint.x 0.0
                            scatterDataPoint.y 10.0
                        ]
                        scatterDataPoints.dataPoint [
                            scatterDataPoint.x 10.0
                            scatterDataPoint.y 5.0
                        ]
                        scatterDataPoints.dataPoint [
                            scatterDataPoint.x 5.0
                            scatterDataPoint.y 15.0
                        ]
                        scatterDataPoints.dataPoint [
                            scatterDataPoint.x -5.0
                            scatterDataPoint.y 8.0
                        ]
                    |]
                ]
                scatterData.dataset [
                    scatterDataSet.label "Dataset B"
                    scatterDataSet.borderColor "rgba(54, 162, 235, 1)"
                    scatterDataSet.backgroundColor "rgba(54, 162, 235, 0.5)"
                    scatterDataSet.pointRadius 8
                    scatterDataSet.dataPoints [|
                        scatterDataPoints.dataPoint [
                            scatterDataPoint.x -8.0
                            scatterDataPoint.y 12.0
                        ]
                        scatterDataPoints.dataPoint [
                            scatterDataPoint.x 3.0
                            scatterDataPoint.y -2.0
                        ]
                        scatterDataPoints.dataPoint [
                            scatterDataPoint.x 7.0
                            scatterDataPoint.y 8.0
                        ]
                        scatterDataPoints.dataPoint [
                            scatterDataPoint.x -3.0
                            scatterDataPoint.y -5.0
                        ]
                    |]
                ]
            |]
        ]
    ]

let ChartJSChart =
    Html.div [
        prop.style [ style.height 500 ]
        prop.children [
            ChartJSScatterChart()
        ]
    ]


let code =
    """
ChartJS.scatter [
    scatter.options [
        option.responsive true
        option.plugins [
            plugin.legend [
                legend.position Position.Top
            ]
        ]
    ]
    scatter.data [
        scatterData.labels [||]
        scatterData.datasets [|
            scatterData.dataset [
                scatterDataSet.label "Dataset A"
                scatterDataSet.borderColor "rgba(255, 99, 132, 1)"
                scatterDataSet.backgroundColor "rgba(255, 99, 132, 0.5)"
                scatterDataSet.pointRadius 8
                scatterDataSet.dataPoints [|
                    scatterDataPoints.dataPoint [
                        scatterDataPoint.x -10.0
                        scatterDataPoint.y 0.0
                    ]
                    scatterDataPoints.dataPoint [
                        scatterDataPoint.x 0.0
                        scatterDataPoint.y 10.0
                    ]
                    // ... more points
                |]
            ]
        |]
    ]
]
    """

let title = Html.text "Scatter Chart"

[<ReactComponent>]
let ScatterChartView () =
    Html.div [
        Bulma.content [
            codedView title code ChartJSChart
        ]
        fixDocsView "ScatterChart" false
    ]
