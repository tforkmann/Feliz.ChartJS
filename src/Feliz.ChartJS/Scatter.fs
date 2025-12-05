namespace Feliz.ChartJS

open Feliz
open Fable.Core.JsInterop
open Fable.Core
open Browser.Types

[<Erase>]
type scatter =
    static member inline options props : IScatterChartProp =
        Interop.mkScatterChartProp "options" (createObj !!props)

    static member inline data props : IScatterChartProp =
        Interop.mkScatterChartProp "data" (createObj !!props)

    static member inline plugins (plugins:IInlinePlugin seq) : IScatterChartProp =
        !!("plugins" ==> plugins)

    static member inline ref(ref: IRefValue<Interop.ChartJS option>) : IScatterChartProp =
        Interop.mkScatterChartProp "ref" ref

    static member inline labels props : IScatterChartProp = !!(createObj !!props)

    static member inline onClick(handler: MouseEvent -> unit) : IScatterChartProp = !!("onClick" ==> handler)

[<Erase>]
type scatterData =
    static member inline labels(labels: string array) : IScatterDataProp = !!("labels" ==> labels)
    static member inline datasets(props: IScatterDataSetsProp seq) = !!("datasets" ==> props)
    static member inline dataset props : IScatterDataSetsProp = !!(createObj !!props)

[<Erase>]
type scatterDataSet =
    static member inline label(label: string) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "label" label

    static member inline borderColor(borderColor: string) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "borderColor" borderColor

    static member inline backgroundColor(backgroundColor: string) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "backgroundColor" backgroundColor

    static member inline borderWidth(borderWidth: int) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "borderWidth" borderWidth

    static member inline pointBackgroundColor(pointBackgroundColor: string) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "pointBackgroundColor" pointBackgroundColor

    static member inline pointBackgroundColor(pointBackgroundColor: string[]) : IScatterDataSetsProp =
        !!("pointBackgroundColor" ==> pointBackgroundColor)

    static member inline pointBorderColor(pointBorderColor: string) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "pointBorderColor" pointBorderColor

    static member inline pointBorderColor(pointBorderColor: string[]) : IScatterDataSetsProp =
        !!("pointBorderColor" ==> pointBorderColor)

    static member inline pointBorderWidth(pointBorderWidth: int) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "pointBorderWidth" pointBorderWidth

    static member inline pointRadius(pointRadius: int) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "pointRadius" pointRadius

    static member inline pointRadius(pointRadius: int[]) : IScatterDataSetsProp =
        !!("pointRadius" ==> pointRadius)

    static member inline pointHoverRadius(pointHoverRadius: int) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "pointHoverRadius" pointHoverRadius

    static member inline pointHoverBackgroundColor(pointHoverBackgroundColor: string) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "pointHoverBackgroundColor" pointHoverBackgroundColor

    static member inline pointHoverBorderColor(pointHoverBorderColor: string) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "pointHoverBorderColor" pointHoverBorderColor

    static member inline pointHoverBorderWidth(pointHoverBorderWidth: int) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "pointHoverBorderWidth" pointHoverBorderWidth

    static member inline pointStyle(pointStyle: PointStyle) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "pointStyle" pointStyle

    static member inline pointHitRadius(pointHitRadius: int) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "pointHitRadius" pointHitRadius

    static member inline showLine(showLine: bool) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "showLine" showLine

    static member inline hidden(hidden: bool) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "hidden" hidden

    static member inline order(order: int) : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "order" order

    static member inline dataPoints (props: IScatterDataPointsProp seq) : IScatterDataSetsProp = !!("data" ==> props)

    static member inline dataLabels props : IScatterDataSetsProp =
        Interop.mkScatterDataSetsProp "datalabels" (createObj !!props)

[<Erase>]
type scatterDataPoints =
    static member inline dataPoint (props: IScatterDataPointProp seq) : IScatterDataPointsProp = !!(createObj !!props)

[<Erase>]
type scatterDataPoint =
    static member inline x(x: float) : IScatterDataPointProp = Interop.mkScatterDataPointProp "x" x
    static member inline x(x: int) : IScatterDataPointProp = Interop.mkScatterDataPointProp "x" x
    static member inline y(y: float) : IScatterDataPointProp = Interop.mkScatterDataPointProp "y" y
    static member inline y(y: int) : IScatterDataPointProp = Interop.mkScatterDataPointProp "y" y
