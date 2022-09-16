namespace Feliz.ChartJS

open Fable.Core
open Fable.Core.JsInterop

[<Erase; RequireQualifiedAccess>]
module Interop =
    let inline mkChartJSProp (key: string) (value: obj) : IChartJSProp = unbox (key, value)
    let inline mkLineChartProp (key: string) (value: obj) : ILineChartProp = unbox (key, value)
    let inline mkBarChartProp (key: string) (value: obj) : IBarChartProp = unbox (key, value)
    let inline mkDoughnutChartProp (key: string) (value: obj) : IDoughnutChartProp = unbox (key, value)
    let inline mkOptionsProp (key: string) (value: obj) : IOptionsProp = unbox (key, value)
    let inline mkPluginsProp (key: string) (value: obj) : IPluginsProp = unbox (key, value)
    let inline mkScalesProp (key: string) (value: obj) : IScalesProp = unbox (key, value)
    let inline mkTitleProp (key: string) (value: obj) : ITitleProp = unbox (key, value)
    let inline mkAxesProp (key: string) (value: obj) : IAxesProp = unbox (key, value)
    let inline mkLegendProp (key: string) (value: obj) : ILegendProp = unbox (key, value)
    let inline mkDataLabelsProp (key: string) (value: obj) : IDataLabelsProp = unbox (key, value)
    let inline mkDataLabelProp (key: string) (value: obj) : IDataLabelProp = unbox (key, value)
    let inline mkLabelsProp (key: string) (value: obj) : ILabelsProp = unbox (key, value)
    let inline mkFontProp (key: string) (value: obj) : IFontProp = unbox (key, value)
    let inline mkLineDataProp (key: string) (value: obj) : ILineDataProp = unbox (key, value)
    let inline mkLineDataSetsProp (key: string) (value: obj) : ILineDataSetsProp = unbox (key, value)
    let inline mkBarDataProp (key: string) (value: obj) : IBarDataProp = unbox (key, value)
    let inline mkBarDataSetsProp (key: string) (value: obj) : IBarDataSetsProp = unbox (key, value)
    let inline mkDoughnutDataProp (key: string) (value: obj) : IDoughnutDataProp = unbox (key, value)
    let inline mkDoughnutDataSetsProp (key: string) (value: obj) : IDoughnutDataSetsProp = unbox (key, value)

    let ChartJS : obj = import "Chart" "chart.js"
    let CategoryScale : obj = import "CategoryScale" "chart.js"
    let LinearScale : obj = import "LinearScale" "chart.js"
    let LineElement : obj = import "LineElement" "chart.js"
    let PointElement : obj = import "PointElement" "chart.js"
    let BarElement : obj = import "BarElement" "chart.js"
    let ArcElement : obj = import "ArcElement" "chart.js"
    let Legend : obj = import "Legend" "chart.js"
    let Title: obj = import "Title" "chart.js"
    let Tooltip : obj = import "Tooltip" "chart.js"

    let ChartDataLabels : obj = importAll "chartjs-plugin-datalabels"

    let chart : obj = import "Chart" "react-chartjs-2"
    let line : obj = import "Line" "react-chartjs-2"
    let doughnut : obj = import "Doughnut" "react-chartjs-2"
    let bar : obj = import "Bar" "react-chartjs-2"
