module Docs.Pages.RadarChart

open Feliz
open Feliz.Bulma
open Feliz.ChartJS
open Docs.SharedView

[<ReactComponent>]
let ChartJSRadarChart () =
    ChartJS.radar [
        radar.options [
            option.responsive true
            option.plugins [
                plugin.legend [
                    legend.position Position.Top
                ]
                plugin.title [
                    title.display true
                    title.text "Radar Chart Example"
                ]
            ]
        ]
        radar.data [
            radarData.labels [|
                "Speed"
                "Strength"
                "Defense"
                "Magic"
                "Luck"
                "Agility"
            |]
            radarData.datasets [|
                radarData.dataset [
                    radarDataSet.label "Player 1"
                    radarDataSet.borderColor "rgba(255, 99, 132, 1)"
                    radarDataSet.backgroundColor "rgba(255, 99, 132, 0.2)"
                    radarDataSet.pointBackgroundColor "rgba(255, 99, 132, 1)"
                    radarDataSet.pointBorderColor "#fff"
                    radarDataSet.pointHoverBackgroundColor "#fff"
                    radarDataSet.pointHoverBorderColor "rgba(255, 99, 132, 1)"
                    radarDataSet.data [| 65; 59; 90; 81; 56; 55 |]
                ]
                radarData.dataset [
                    radarDataSet.label "Player 2"
                    radarDataSet.borderColor "rgba(54, 162, 235, 1)"
                    radarDataSet.backgroundColor "rgba(54, 162, 235, 0.2)"
                    radarDataSet.pointBackgroundColor "rgba(54, 162, 235, 1)"
                    radarDataSet.pointBorderColor "#fff"
                    radarDataSet.pointHoverBackgroundColor "#fff"
                    radarDataSet.pointHoverBorderColor "rgba(54, 162, 235, 1)"
                    radarDataSet.data [| 28; 48; 40; 19; 96; 27 |]
                ]
            |]
        ]
    ]

let ChartJSChart =
    Html.div [
        prop.style [ style.height 500 ]
        prop.children [
            ChartJSRadarChart()
        ]
    ]


let code =
    """
ChartJS.radar [
    radar.options [
        option.responsive true
        option.plugins [
            plugin.legend [
                legend.position Position.Top
            ]
        ]
    ]
    radar.data [
        radarData.labels [|
            "Speed"
            "Strength"
            "Defense"
            "Magic"
            "Luck"
            "Agility"
        |]
        radarData.datasets [|
            radarData.dataset [
                radarDataSet.label "Player 1"
                radarDataSet.borderColor "rgba(255, 99, 132, 1)"
                radarDataSet.backgroundColor "rgba(255, 99, 132, 0.2)"
                radarDataSet.pointBackgroundColor "rgba(255, 99, 132, 1)"
                radarDataSet.data [| 65; 59; 90; 81; 56; 55 |]
            ]
            radarData.dataset [
                radarDataSet.label "Player 2"
                radarDataSet.borderColor "rgba(54, 162, 235, 1)"
                radarDataSet.backgroundColor "rgba(54, 162, 235, 0.2)"
                radarDataSet.pointBackgroundColor "rgba(54, 162, 235, 1)"
                radarDataSet.data [| 28; 48; 40; 19; 96; 27 |]
            ]
        |]
    ]
]
    """

let title = Html.text "Radar Chart"

[<ReactComponent>]
let RadarChartView () =
    Html.div [
        Bulma.content [
            codedView title code ChartJSChart
        ]
        fixDocsView "RadarChart" false
    ]
