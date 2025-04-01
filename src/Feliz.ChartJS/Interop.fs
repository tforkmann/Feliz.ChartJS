namespace Feliz.ChartJS

open Fable.Core
open Fable.Core.JsInterop
open Browser.Types

[<Erase; RequireQualifiedAccess>]
module Interop =
    let inline mkChartJSProp (key: string) (value: obj) : IChartJSProp = unbox (key, value)
    let inline mkLineChartProp (key: string) (value: obj) : ILineChartProp = unbox (key, value)
    let inline mkBarChartProp (key: string) (value: obj) : IBarChartProp = unbox (key, value)
    let inline mkBubbleChartProp (key: string) (value: obj) : IBubbleChartProp = unbox (key, value)
    let inline mkDoughnutChartProp (key: string) (value: obj) : IDoughnutChartProp = unbox (key, value)
    let inline mkOptionsProp (key: string) (value: obj) : IOptionsProp = unbox (key, value)
    let inline mkPluginProp (key: string) (value: obj) : IPluginProp = unbox (key, value)
    let inline mkInlinePlugin (key: string) (value: obj) : IInlinePlugin = unbox (key, value)
    let inline mkInlinePluginProp (key: string) (value: obj) : IInlinePluginProp = unbox (key, value)
    let inline mkScalesProp (key: string) (value: obj) : IScalesProp = unbox (key, value)
    let inline mkTitleProp (key: string) (value: obj) : ITitleProp = unbox (key, value)
    let inline mkAxesProp (key: string) (value: obj) : IAxesProp = unbox (key, value)
    let inline mkTicksProp (key: string) (value: obj) : ITicksProp = unbox (key, value)
    let inline mkTimeProp (key: string) (value: obj) : ITimeProp = unbox (key, value)
    let inline mkYProp (key: string) (value: obj) : IYProp = unbox (key, value)
    let inline mkXProp (key: string) (value: obj) : IXProp = unbox (key, value)
    let inline mkLegendProp (key: string) (value: obj) : ILegendProp = unbox (key, value)
    let inline mkDataLabelsProp (key: string) (value: obj) : IDataLabelsProp = unbox (key, value)
    let inline mkToolTipsProp (key: string) (value: obj) : IToolTipsProp = unbox (key, value)
    let inline mkToolTipCallback (key: string) (value: obj) : IToolTipCallbackProp = unbox (key, value)
    let inline mkZoomProp (key: string) (value: obj) : IZoomProp = unbox (key, value)
    let inline mkDataLabelProp (key: string) (value: obj) : IDataLabelProp = unbox (key, value)
    let inline mkLabelsProp (key: string) (value: obj) : ILabelsProp = unbox (key, value)
    let inline mkFontProp (key: string) (value: obj) : IFontProp = unbox (key, value)
    let inline mkWheelProp (key: string) (value: obj) : IWheelProp = unbox (key, value)
    let inline mkDefaultsProp (key: string) (value: obj) : IDefaultsProp = unbox (key, value)
    let inline mkLineDataProp (key: string) (value: obj) : ILineDataProp = unbox (key, value)
    let inline mkLineDataSetsProp (key: string) (value: obj) : ILineDataSetsProp = unbox (key, value)
    let inline mkBarDataProp (key: string) (value: obj) : IBarDataProp = unbox (key, value)
    let inline mkBarDataSetsProp (key: string) (value: obj) : IBarDataSetsProp = unbox (key, value)
    let inline mkBubbleDataProp (key: string) (value: obj) : IBubbleDataProp = unbox (key, value)
    let inline mkBubbleDataSetsProp (key: string) (value: obj) : IBubbleDataSetsProp = unbox (key, value)
    let inline mkBubbleDataPointProp (key: string) (value: obj) : IBubbleDataPointProp = unbox (key, value)
    let inline mkDoughnutDataProp (key: string) (value: obj) : IDoughnutDataProp = unbox (key, value)
    let inline mkDoughnutDataSetsProp (key: string) (value: obj) : IDoughnutDataSetsProp = unbox (key, value)
    let inline mkLayoutProp (key: string) (value: obj) : ILayoutProp = unbox (key, value)
    let inline mkPaddingProp (key: string) (value: obj) : IPaddingProp = unbox (key, value)
    let inline convertToInteractionItems (value: obj) : InteractionItem [] = unbox value

    type ChartJS = obj

    let ChartJS: ChartJS = import "Chart" "chart.js"
    let CategoryScale: obj = import "CategoryScale" "chart.js"
    let LinearScale: obj = import "LinearScale" "chart.js"
    let TimeScale: obj = import "TimeScale" "chart.js"
    let LineElement: obj = import "LineElement" "chart.js"
    let PointElement: obj = import "PointElement" "chart.js"
    let BarElement: obj = import "BarElement" "chart.js"
    // let Point: obj = import "Point" "chart.js"
    let ArcElement: obj = import "ArcElement" "chart.js"
    let Legend: obj = import "Legend" "chart.js"
    let Title: obj = import "Title" "chart.js"
    let Tooltip: obj = import "Tooltip" "chart.js"

    let ChartDataLabels: obj = importAll "chartjs-plugin-datalabels"
    let MomentAdapter: obj = importAll "chartjs-adapter-moment"
    // let hammerJS: obj = importAll "hammerjs"
    // let ZoomPlugin: obj = importAll "chartjs-plugin-zoom"

    let chart: obj = import "Chart" "react-chartjs-2"
    let line: obj = import "Line" "react-chartjs-2"
    let doughnut: obj = import "Doughnut" "react-chartjs-2"
    let bubble: obj = import "Bubble" "react-chartjs-2"
    let bar: obj = import "Bar" "react-chartjs-2"
    type IEventOperations =
        abstract getDatasetAtEvent: ChartJS * MouseEvent -> InteractionItem []
        abstract getElementAtEvent: ChartJS * MouseEvent -> InteractionItem []
        abstract getElementsAtEvent: ChartJS * MouseEvent -> InteractionItem []
    type IEventChartJSOperations =

        abstract getElementsAtEventForMode: ChartJS * MouseEvent * Mode * obj * bool -> InteractionItem []

    let eventOperations: IEventOperations = importAll "react-chartjs-2"
    let eventChartJSOperations: IEventChartJSOperations = importAll "chart.js"

    // ChartJS?register (ZoomPlugin)
    ChartJS?register CategoryScale
    ChartJS?register LinearScale
    ChartJS?register TimeScale
    ChartJS?register PointElement
    ChartJS?register LineElement
    ChartJS?register BarElement
    // ChartJS?register Point
    ChartJS?register ArcElement
    ChartJS?register Tooltip
    ChartJS?register Legend
    ChartJS?register Title
    ChartJS?register ChartDataLabels
    ChartJS?register MomentAdapter
