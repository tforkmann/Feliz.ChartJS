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
    let inline mkPieChartProp (key: string) (value: obj) : IPieChartProp = unbox (key, value)
    let inline mkPieDataProp (key: string) (value: obj) : IPieDataProp = unbox (key, value)
    let inline mkPieDataSetsProp (key: string) (value: obj) : IPieDataSetsProp = unbox (key, value)
    let inline mkRadarChartProp (key: string) (value: obj) : IRadarChartProp = unbox (key, value)
    let inline mkRadarDataProp (key: string) (value: obj) : IRadarDataProp = unbox (key, value)
    let inline mkRadarDataSetsProp (key: string) (value: obj) : IRadarDataSetsProp = unbox (key, value)
    let inline mkPolarAreaChartProp (key: string) (value: obj) : IPolarAreaChartProp = unbox (key, value)
    let inline mkPolarAreaDataProp (key: string) (value: obj) : IPolarAreaDataProp = unbox (key, value)
    let inline mkPolarAreaDataSetsProp (key: string) (value: obj) : IPolarAreaDataSetsProp = unbox (key, value)
    let inline mkScatterChartProp (key: string) (value: obj) : IScatterChartProp = unbox (key, value)
    let inline mkScatterDataProp (key: string) (value: obj) : IScatterDataProp = unbox (key, value)
    let inline mkScatterDataSetsProp (key: string) (value: obj) : IScatterDataSetsProp = unbox (key, value)
    let inline mkScatterDataPointProp (key: string) (value: obj) : IScatterDataPointProp = unbox (key, value)
    let inline mkAnimationProp (key: string) (value: obj) : IAnimationProp = unbox (key, value)
    let inline mkAnimationsProp (key: string) (value: obj) : IAnimationsProp = unbox (key, value)
    let inline mkTransitionProp (key: string) (value: obj) : ITransitionProp = unbox (key, value)
    let inline mkInteractionProp (key: string) (value: obj) : IInteractionProp = unbox (key, value)
    let inline mkElementsProp (key: string) (value: obj) : IElementsProp = unbox (key, value)
    let inline mkPointElementProp (key: string) (value: obj) : IPointElementProp = unbox (key, value)
    let inline mkLineElementProp (key: string) (value: obj) : ILineElementProp = unbox (key, value)
    let inline mkBarElementProp (key: string) (value: obj) : IBarElementProp = unbox (key, value)
    let inline mkArcElementProp (key: string) (value: obj) : IArcElementProp = unbox (key, value)
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
    let RadialLinearScale: obj = import "RadialLinearScale" "chart.js"
    let Filler: obj = import "Filler" "chart.js"
    let Legend: obj = import "Legend" "chart.js"
    let Title: obj = import "Title" "chart.js"
    let Tooltip: obj = import "Tooltip" "chart.js"

    let ChartDataLabels: obj = importAll "chartjs-plugin-datalabels"
    let MomentAdapter: obj = importAll "chartjs-adapter-moment"
    // let hammerJS: obj = importAll "hammerjs"
    // let ZoomPlugin: obj = importAll "chartjs-plugin-zoom"

    let chart: Feliz.ReactElement = import "Chart" "react-chartjs-2"
    let line: Feliz.ReactElement = import "Line" "react-chartjs-2"
    let doughnut: Feliz.ReactElement = import "Doughnut" "react-chartjs-2"
    let bubble: Feliz.ReactElement = import "Bubble" "react-chartjs-2"
    let bar: Feliz.ReactElement = import "Bar" "react-chartjs-2"
    let pie: Feliz.ReactElement = import "Pie" "react-chartjs-2"
    let radar: Feliz.ReactElement = import "Radar" "react-chartjs-2"
    let polarArea: Feliz.ReactElement = import "PolarArea" "react-chartjs-2"
    let scatter: Feliz.ReactElement = import "Scatter" "react-chartjs-2"
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
    ChartJS?register RadialLinearScale
    ChartJS?register Filler
    ChartJS?register Tooltip
    ChartJS?register Legend
    ChartJS?register Title
    ChartJS?register ChartDataLabels
    ChartJS?register MomentAdapter
