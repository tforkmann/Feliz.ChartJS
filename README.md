# Feliz Binding for [ChartJS](https://github.com/reactchartjs/react-chartjs-2)

[![Feliz.ChartJS on Nuget](https://buildstats.info/nuget/Feliz.ChartJS)](https://www.nuget.org/packages/Feliz.ChartJS/)
[![Docs](https://github.com/tforkmann/Feliz.ChartJS/actions/workflows/Docs.yml/badge.svg)](https://github.com/tforkmann/Feliz.ChartJS/actions/workflows/Docs.yml)

## Installation
Install the nuget package
```
dotnet paket add Feliz.ChartJS
```

and install the npm package

```
npm install --save react-chartjs-2 chart.js
```

or use Femto:
```
femto install Feliz.ChartJS
```

## Start test app

- Start your test app by cloning this repository and then execute:
```
dotnet run
```

## Supported Chart Types

| Chart Type | Component | Description |
|------------|-----------|-------------|
| Line | `ChartJS.line` | Line charts for trends over time |
| Bar | `ChartJS.bar` | Bar charts for categorical comparisons |
| Pie | `ChartJS.pie` | Pie charts for proportional data |
| Doughnut | `ChartJS.doughnut` | Doughnut charts (pie with hole) |
| Radar | `ChartJS.radar` | Radar/spider charts for multivariate data |
| PolarArea | `ChartJS.polarArea` | Polar area charts |
| Scatter | `ChartJS.scatter` | Scatter plots for x/y data points |
| Bubble | `ChartJS.bubble` | Bubble charts with x, y, and radius |

## Example Line Chart
```fs
ChartJS.line [
    line.options [
        option.responsive true
        option.plugins [
            plugin.legend [
                legend.position Position.Top
            ]
        ]
    ]
    line.data [
        lineData.labels [| "Jan"; "Feb"; "Mar"; "Apr"; "May"; "Jun" |]
        lineData.datasets [|
            lineData.dataset [
                lineDataSet.label "Sales 2024"
                lineDataSet.borderColor "rgb(53, 162, 235)"
                lineDataSet.backgroundColor "rgba(53, 162, 235, 0.5)"
                lineDataSet.tension 0.4
                lineDataSet.fill true
                lineDataSet.data [| 10; 20; 15; 25; 22; 30 |]
            ]
        |]
    ]
]
```

## Example Radar Chart
```fs
ChartJS.radar [
    radar.options [
        option.responsive true
    ]
    radar.data [
        radarData.labels [| "Speed"; "Strength"; "Defense"; "Magic"; "Luck" |]
        radarData.datasets [|
            radarData.dataset [
                radarDataSet.label "Player Stats"
                radarDataSet.borderColor "rgb(255, 99, 132)"
                radarDataSet.backgroundColor "rgba(255, 99, 132, 0.2)"
                radarDataSet.pointBackgroundColor "rgb(255, 99, 132)"
                radarDataSet.data [| 80; 90; 70; 85; 65 |]
            ]
        |]
    ]
]
```

## Example Pie Chart
```fs
ChartJS.pie [
    pie.options [
        option.responsive true
    ]
    pie.data [
        pieData.labels [| "Red"; "Blue"; "Yellow" |]
        pieData.datasets [|
            pieData.dataset [
                pieDataSet.label "Votes"
                pieDataSet.backgroundColor [| "#FF6384"; "#36A2EB"; "#FFCE56" |]
                pieDataSet.data [| 12; 19; 3 |]
            ]
        |]
    ]
]
```

## Features

### Animation
```fs
option.animation [
    animation.duration 1000
    animation.easing Easing.EaseOutQuart
    animation.onComplete (fun _ -> printfn "Animation complete!")
]
```

### Interaction
```fs
option.interaction [
    interaction.mode InteractionMode.Nearest
    interaction.intersect false
    interaction.axis InteractionAxis.X
]
```

### Legend Events
```fs
plugin.legend [
    legend.position Position.Top
    legend.onClick (fun e item chart -> printfn "Clicked: %A" item)
    legend.onHover (fun e item -> printfn "Hovering: %A" item)
]
```

### Chart Methods
```fs
open Feliz.ChartJS

// Get chart reference
let chartRef = React.useRef<Interop.ChartJS option>(None)

// Use chart methods
match chartRef.current with
| Some chart ->
    ChartMethods.update chart (Some "none")  // Update without animation
    ChartMethods.reset chart                  // Reset to initial state
    let imageData = ChartMethods.toBase64ImagePng chart  // Export as PNG
| None -> ()
```

## Documentation

You can find more examples and documentation at [https://tforkmann.github.io/Feliz.ChartJS/](https://tforkmann.github.io/Feliz.ChartJS/)
