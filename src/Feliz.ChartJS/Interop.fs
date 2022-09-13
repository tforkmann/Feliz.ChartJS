namespace Feliz.ChartJS

open Fable.Core
open Fable.Core.JsInterop

[<Erase; RequireQualifiedAccess>]
module Interop =
    // let inline mkStyleProp (key: string) (value: obj) : IStyleProp = unbox (key, value)
    let inline mkChartJSProp (key: string) (value: obj) : IChartJSProp = unbox (key, value)
    let inline mkLineChartProp (key: string) (value: obj) : ILineChartProp = unbox (key, value)
    let inline mkBarChartProp (key: string) (value: obj) : IBarChartProp = unbox (key, value)
    let inline mkOptionsProp (key: string) (value: obj) : IOptionsProp = unbox (key, value)
    let inline mkLineDataProp (key: string) (value: obj) : ILineDataProp = unbox (key, value)
    let inline mkLineDataSetsProp (key: string) (value: obj) : ILineDataSetsProp = unbox (key, value)
    let inline mkBarDataProp (key: string) (value: obj) : IBarDataProp = unbox (key, value)
    let inline mkBarDataSetsProp (key: string) (value: obj) : IBarDataSetsProp = unbox (key, value)

    let ChartJS : obj = import "Chart" "chart.js"
    let CategoryScale : obj = import "CategoryScale" "chart.js"
    let LinearScale : obj = import "LinearScale" "chart.js"
    let LineElement : obj = import "LineElement" "chart.js"
    let PointElement : obj = import "PointElement" "chart.js"
    let BarElement : obj = import "BarElement" "chart.js"
    let chart : obj = import "Chart" "react-chartjs-2"
    let line : obj = import "Line" "react-chartjs-2"
    let doughnut : obj = import "Doughnut" "react-chartjs-2"
    let bar : obj = import "Bar" "react-chartjs-2"

    ChartJS?register(CategoryScale)
    ChartJS?register(LinearScale)
    ChartJS?register(PointElement)
    ChartJS?register(LineElement)
    ChartJS?register(BarElement)