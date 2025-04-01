module Docs.Pages.BubbleChart

open Feliz
open Feliz.Bulma
open Feliz.ChartJS
open Docs.SharedView
open Browser

[<ReactComponent>]
let ChartJSBubbleChart () =
    let chartRef: IRefValue<Interop.ChartJS option> = React.useRef (None)

    let receiveChartRef () =
        match chartRef.current with
        | None -> failwithf "should be some"
        | Some e -> e

    ChartJS.bubble [
        bubble.ref chartRef
        bubble.onClick (fun (e) ->
            let ref = receiveChartRef ()
            console.log ref
            console.log e
            let dataSet = Interop.eventOperations.getDatasetAtEvent (ref, e)
            console.log dataSet)
        bubble.options [
            option.responsive true
            option.layout [ layout.padding [ padding.bottom 10 ] ]
            option.scales [ scale.y [ y.beginAtZero true ] ]
            option.plugins [
                plugin.legend [ legend.position Position.Top ]
                plugin.title [ title.display true; title.text "Chart.js Bubble Chart" ]
                plugin.dataLabels [
                    dataLabels.display true
                    dataLabels.align Position.Bottom
                    dataLabels.borderRadius 3
                    dataLabels.color "red"
                    dataLabels.backgroundColor "green"
                ]
            ]
        ]
        bubble.data [
            bubbleData.datasets [|
                bubbleData.dataset [
                    bubbleDataSet.label "Red bubbles"
                    bubbleDataSet.backgroundColor "rgba(255, 99, 132)"
                    bubbleDataSet.dataPoints [|
                        bubbleDataPoints.dataPoint [
                            bubbleDataPoint.x 10
                            bubbleDataPoint.y 10
                            bubbleDataPoint.r 15
                        ]
                        bubbleDataPoints.dataPoint [
                            bubbleDataPoint.x 20
                            bubbleDataPoint.y 15
                            bubbleDataPoint.r 10
                        ]
                        bubbleDataPoints.dataPoint [
                            bubbleDataPoint.x 10
                            bubbleDataPoint.y 30
                            bubbleDataPoint.r 5
                        ]
                        bubbleDataPoints.dataPoint [
                            bubbleDataPoint.x 50
                            bubbleDataPoint.y 40
                            bubbleDataPoint.r 20
                        ]
                    |]
                    bubbleDataSet.dataLabels [| dataLabel.anchor "end" |]
                ]
                bubbleData.dataset [
                    bubbleDataSet.label "Blue bubbles"
                    bubbleDataSet.backgroundColor "rgba(54, 162, 235)"
                    bubbleDataSet.dataPoints [|
                        bubbleDataPoints.dataPoint [
                            bubbleDataPoint.x 10
                            bubbleDataPoint.y 20
                            bubbleDataPoint.r 15
                        ]
                        bubbleDataPoints.dataPoint [
                            bubbleDataPoint.x 20
                            bubbleDataPoint.y 10
                            bubbleDataPoint.r 10
                        ]
                        bubbleDataPoints.dataPoint [
                            bubbleDataPoint.x 30
                            bubbleDataPoint.y 30
                            bubbleDataPoint.r 5
                        ]
                        bubbleDataPoints.dataPoint [
                            bubbleDataPoint.x 40
                            bubbleDataPoint.y 40
                            bubbleDataPoint.r 20
                        ]
                    |]
                    bubbleDataSet.dataLabels [| dataLabel.anchor "end" |]
                ]
            |]
        ]
    ]

let ChartJSChart =
    Html.div [
        prop.style [ style.height 800 ]
        prop.children [
            ChartJSBubbleChart()
        ]
    ]

let code =
    """
    ChartJS.doughnut [
        doughnut.options [
            option.responsive true
            option.plugins [
                plugin.legend [ legend.position Top ]
                plugin.title [
                    title.display true
                    title.text "Chart.js Doughnut Chart"
                ]
                plugin.dataLabels [
                    dataLabels.display true
                    dataLabels.align Bottom
                    dataLabels.borderRadius 3
                    dataLabels.color "red"
                    dataLabels.backgroundColor "green"
                    ]
            ]
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
                    doughnutDataSet.label "# of Votes"
                    doughnutDataSet.borderColor [|
                        "rgba(255, 99, 132, 1)"
                        "rgba(54, 162, 235, 1)"
                        "rgba(255, 206, 86, 1)"
                        "rgba(75, 192, 192, 1)"
                        "rgba(153, 102, 255, 1)"
                        "rgba(255, 159, 64, 1)"
                    |]
                    doughnutDataSet.borderWidth 1
                    doughnutDataSet.backgroundColor [|
                        "rgba(255, 99, 132, 0.2)"
                        "rgba(54, 162, 235, 0.2)"
                        "rgba(255, 206, 86, 0.2)"
                        "rgba(75, 192, 192, 0.2)"
                        "rgba(153, 102, 255, 0.2)"
                        "rgba(255, 159, 64, 0.2)"
                    |]
                    doughnutDataSet.data [|
                        12
                        19
                        3
                        5
                        2
                        3
                    |]
                    doughnutDataSet.datalabels [|
                        datalabel.anchor "end"
                    |]
                ]
            |]
        ]
    ]
    """

let title = Html.text "Bubble Chart"

[<ReactComponent>]
let BubbleChartView () =
    Html.div [
        Bulma.content [
            codedView title code ChartJSChart
        ]
        fixDocsView "BubbleChart" false
    ]
