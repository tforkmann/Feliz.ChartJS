namespace Feliz.ChartJS

open Feliz
open Fable.Core.JsInterop
open Fable.Core
open Browser.Types

[<Erase>]
type radar =
    static member inline options props : IRadarChartProp =
        Interop.mkRadarChartProp "options" (createObj !!props)

    static member inline data props : IRadarChartProp =
        Interop.mkRadarChartProp "data" (createObj !!props)

    static member inline plugins (plugins:IInlinePlugin seq) : IRadarChartProp =
        !!("plugins" ==> plugins)

    static member inline ref(ref: IRefValue<Interop.ChartJS option>) : IRadarChartProp =
        Interop.mkRadarChartProp "ref" ref

    static member inline labels props : IRadarChartProp = !!(createObj !!props)

    static member inline onClick(handler: MouseEvent -> unit) : IRadarChartProp = !!("onClick" ==> handler)

[<Erase>]
type radarData =
    static member inline labels(labels: string array) : IRadarDataProp = !!("labels" ==> labels)
    static member inline datasets(props: IRadarDataSetsProp seq) = !!("datasets" ==> props)
    static member inline dataset props : IRadarDataSetsProp = !!(createObj !!props)

[<Erase>]
type radarDataSet =
    static member inline label(label: string) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "label" label

    static member inline borderColor(borderColor: string) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "borderColor" borderColor

    static member inline backgroundColor(backgroundColor: string) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "backgroundColor" backgroundColor

    static member inline backgroundColor(backgroundColor: string[]) : IRadarDataSetsProp =
        !!("backgroundColor" ==> backgroundColor)

    static member inline borderColor(borderColor: string[]) : IRadarDataSetsProp =
        !!("borderColor" ==> borderColor)

    static member inline borderWidth(borderWidth: int) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "borderWidth" borderWidth

    static member inline borderWidth(borderWidth: int[]) : IRadarDataSetsProp =
        !!("borderWidth" ==> borderWidth)

    static member inline borderDash(borderDash: int[]) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "borderDash" borderDash

    static member inline borderDashOffset(borderDashOffset: float) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "borderDashOffset" borderDashOffset

    static member inline borderCapStyle(borderCapStyle: BorderCapStyle) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "borderCapStyle" borderCapStyle

    static member inline borderJoinStyle(borderJoinStyle: BorderJoinStyle) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "borderJoinStyle" borderJoinStyle

    static member inline fill(fill: bool) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "fill" fill

    static member inline fill(fill: string) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "fill" fill

    static member inline fill(fill: FillTarget) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "fill" fill

    static member inline tension(tension: float) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "tension" tension

    static member inline pointBackgroundColor(pointBackgroundColor: string) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "pointBackgroundColor" pointBackgroundColor

    static member inline pointBackgroundColor(pointBackgroundColor: string[]) : IRadarDataSetsProp =
        !!("pointBackgroundColor" ==> pointBackgroundColor)

    static member inline pointBorderColor(pointBorderColor: string) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "pointBorderColor" pointBorderColor

    static member inline pointBorderColor(pointBorderColor: string[]) : IRadarDataSetsProp =
        !!("pointBorderColor" ==> pointBorderColor)

    static member inline pointBorderWidth(pointBorderWidth: int) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "pointBorderWidth" pointBorderWidth

    static member inline pointBorderWidth(pointBorderWidth: int[]) : IRadarDataSetsProp =
        !!("pointBorderWidth" ==> pointBorderWidth)

    static member inline pointRadius(pointRadius: int) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "pointRadius" pointRadius

    static member inline pointRadius(pointRadius: int[]) : IRadarDataSetsProp =
        !!("pointRadius" ==> pointRadius)

    static member inline pointRadius(pointRadius: float) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "pointRadius" pointRadius

    static member inline pointHoverRadius(pointHoverRadius: int) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "pointHoverRadius" pointHoverRadius

    static member inline pointHoverRadius(pointHoverRadius: int[]) : IRadarDataSetsProp =
        !!("pointHoverRadius" ==> pointHoverRadius)

    static member inline pointHoverBackgroundColor(pointHoverBackgroundColor: string) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "pointHoverBackgroundColor" pointHoverBackgroundColor

    static member inline pointHoverBackgroundColor(pointHoverBackgroundColor: string[]) : IRadarDataSetsProp =
        !!("pointHoverBackgroundColor" ==> pointHoverBackgroundColor)

    static member inline pointHoverBorderColor(pointHoverBorderColor: string) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "pointHoverBorderColor" pointHoverBorderColor

    static member inline pointHoverBorderColor(pointHoverBorderColor: string[]) : IRadarDataSetsProp =
        !!("pointHoverBorderColor" ==> pointHoverBorderColor)

    static member inline pointHoverBorderWidth(pointHoverBorderWidth: int) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "pointHoverBorderWidth" pointHoverBorderWidth

    static member inline pointHoverBorderWidth(pointHoverBorderWidth: int[]) : IRadarDataSetsProp =
        !!("pointHoverBorderWidth" ==> pointHoverBorderWidth)

    static member inline pointStyle(pointStyle: PointStyle) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "pointStyle" pointStyle

    static member inline pointStyle(pointStyle: string) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "pointStyle" pointStyle

    static member inline pointHitRadius(pointHitRadius: int) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "pointHitRadius" pointHitRadius

    static member inline pointHitRadius(pointHitRadius: int[]) : IRadarDataSetsProp =
        !!("pointHitRadius" ==> pointHitRadius)

    static member inline hidden(hidden: bool) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "hidden" hidden

    static member inline order(order: int) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "order" order

    static member inline data(data: int[]) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "data" data
    static member inline data(data: float[]) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "data" data
    static member inline data(data: string[]) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "data" data
    static member inline data(data: decimal[]) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "data" data

    static member inline dataLabels props : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "datalabels" (createObj !!props)

    static member inline spanGaps(spanGaps: bool) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "spanGaps" spanGaps

    static member inline spanGaps(spanGaps: int) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "spanGaps" spanGaps

    static member inline clip(clip: bool) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "clip" clip

    static member inline clip(clip: int) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "clip" clip

    static member inline hoverBackgroundColor(hoverBackgroundColor: string) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "hoverBackgroundColor" hoverBackgroundColor

    static member inline hoverBorderColor(hoverBorderColor: string) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "hoverBorderColor" hoverBorderColor

    static member inline hoverBorderWidth(hoverBorderWidth: int) : IRadarDataSetsProp =
        Interop.mkRadarDataSetsProp "hoverBorderWidth" hoverBorderWidth
