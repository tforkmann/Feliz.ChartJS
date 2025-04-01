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

## Example ChartJS
Here is an example ChartJS
```fs
ChartJS.line [
        line.options [
            option.responsive true
            option.plugins[plugin.dataLabels [
                               dataLabels.display true
                               dataLabels.align Bottom
                               dataLabels.borderRadius 3
                               dataLabels.color "red"
                               dataLabels.backgroundColor "green"
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
```

You can find more examples [here](https://tforkmann.github.io/Feliz.ChartJS/)
