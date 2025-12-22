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
                    title.text "Radar Chart Example - Player Stats Comparison"
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
                    radarDataSet.label "Player 1 (Warrior)"
                    radarDataSet.borderColor "rgba(255, 99, 132, 1)"
                    radarDataSet.backgroundColor "rgba(255, 99, 132, 0.2)"
                    radarDataSet.borderWidth 2
                    radarDataSet.pointBackgroundColor "rgba(255, 99, 132, 1)"
                    radarDataSet.pointBorderColor "#fff"
                    radarDataSet.pointBorderWidth 2
                    radarDataSet.pointRadius 5
                    radarDataSet.pointHoverRadius 7
                    radarDataSet.pointHoverBackgroundColor "#fff"
                    radarDataSet.pointHoverBorderColor "rgba(255, 99, 132, 1)"
                    radarDataSet.pointHoverBorderWidth 3
                    radarDataSet.fill true
                    radarDataSet.tension 0.2
                    radarDataSet.data [| 65; 90; 85; 40; 56; 70 |]
                ]
                radarData.dataset [
                    radarDataSet.label "Player 2 (Mage)"
                    radarDataSet.borderColor "rgba(54, 162, 235, 1)"
                    radarDataSet.backgroundColor "rgba(54, 162, 235, 0.2)"
                    radarDataSet.borderWidth 2
                    radarDataSet.pointBackgroundColor "rgba(54, 162, 235, 1)"
                    radarDataSet.pointBorderColor "#fff"
                    radarDataSet.pointBorderWidth 2
                    radarDataSet.pointRadius 5
                    radarDataSet.pointHoverRadius 7
                    radarDataSet.pointHoverBackgroundColor "#fff"
                    radarDataSet.pointHoverBorderColor "rgba(54, 162, 235, 1)"
                    radarDataSet.pointHoverBorderWidth 3
                    radarDataSet.fill true
                    radarDataSet.tension 0.2
                    radarDataSet.data [| 45; 35; 30; 95; 82; 55 |]
                ]
                radarData.dataset [
                    radarDataSet.label "Player 3 (Rogue)"
                    radarDataSet.borderColor "rgba(75, 192, 192, 1)"
                    radarDataSet.backgroundColor "rgba(75, 192, 192, 0.2)"
                    radarDataSet.borderWidth 2
                    radarDataSet.pointBackgroundColor "rgba(75, 192, 192, 1)"
                    radarDataSet.pointBorderColor "#fff"
                    radarDataSet.pointBorderWidth 2
                    radarDataSet.pointRadius 5
                    radarDataSet.pointHoverRadius 7
                    radarDataSet.pointHoverBackgroundColor "#fff"
                    radarDataSet.pointHoverBorderColor "rgba(75, 192, 192, 1)"
                    radarDataSet.pointHoverBorderWidth 3
                    radarDataSet.fill true
                    radarDataSet.tension 0.2
                    radarDataSet.data [| 95; 45; 50; 55; 92; 90 |]
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
                radarDataSet.label "Player 1 (Warrior)"
                radarDataSet.borderColor "rgba(255, 99, 132, 1)"
                radarDataSet.backgroundColor "rgba(255, 99, 132, 0.2)"
                radarDataSet.borderWidth 2
                radarDataSet.pointBackgroundColor "rgba(255, 99, 132, 1)"
                radarDataSet.pointBorderColor "#fff"
                radarDataSet.pointBorderWidth 2
                radarDataSet.pointRadius 5
                radarDataSet.pointHoverRadius 7
                radarDataSet.fill true
                radarDataSet.tension 0.2
                radarDataSet.data [| 65; 90; 85; 40; 56; 70 |]
            ]
            radarData.dataset [
                radarDataSet.label "Player 2 (Mage)"
                radarDataSet.borderColor "rgba(54, 162, 235, 1)"
                radarDataSet.backgroundColor "rgba(54, 162, 235, 0.2)"
                radarDataSet.borderWidth 2
                radarDataSet.pointBackgroundColor "rgba(54, 162, 235, 1)"
                radarDataSet.fill true
                radarDataSet.tension 0.2
                radarDataSet.data [| 45; 35; 30; 95; 82; 55 |]
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
