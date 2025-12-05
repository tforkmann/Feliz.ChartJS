namespace Feliz.ChartJS

open Feliz
open Fable.Core.JsInterop
open Fable.Core
open Browser.Types
open ScriptableOptions

[<Erase>]
type line =
    static member inline options props : ILineChartProp =
        Interop.mkLineChartProp "options" (createObj !!props)

    static member inline data props : ILineChartProp =
        Interop.mkLineChartProp "data" (createObj !!props)

    static member inline plugins (plugins:IInlinePlugin seq) : ILineChartProp =
        !!("plugins" ==> plugins)

    static member inline labels props : ILineDataProp = !!(createObj !!props)

    static member inline ref(ref: IRefValue<Interop.ChartJS option>) : ILineChartProp =
        Interop.mkLineChartProp "ref" ref

    static member inline onClick(handler: MouseEvent -> unit) : ILineChartProp = !!("onClick" ==> handler)

[<Erase>]
type lineData =
    static member inline labels(labels: string array) : ILineDataProp = !!("labels" ==> labels)
    static member inline datasets(props: ILineDataSetsProp seq) = !!("datasets" ==> props)
    static member inline dataset props : ILineDataSetsProp = !!(createObj !!props)

[<Erase>]
type lineDataSet =
    static member inline label(label: string): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "label" label

    static member inline stepped(stepped: bool): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "stepped" stepped

    static member inline mixedType(mixedType: string) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "type" mixedType

    static member inline borderColor(borderColor: string): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "borderColor" borderColor

    static member inline borderColors(borderColors: string []): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "borderColor" borderColors

    static member inline backgroundColor(backgroundColor: string): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "backgroundColor" backgroundColor

    static member inline borderWidth(borderWidth: int): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "borderWidth" borderWidth

    static member inline colors(colors: string []): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "color" colors

    static member inline backgroundColors(backgroundColors: string []): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "backgroundColor" backgroundColors

    static member inline data(data: string []): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "data" data

    static member inline data(data: int []): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "data" data

    static member inline data(data: float []): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "data" data

    static member inline data(data: decimal []): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "data" data

    static member inline yAxisID(yAxisID: string): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "yAxisID" yAxisID

    static member inline xAxisID(xAxisID: string): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "xAxisID" xAxisID

    static member inline borderColor(iColor: IColor -> string) : ILineDataSetsProp =
        !!("borderColor" ==> iColor)

    static member inline color(iColor: IColor -> string) : ILineDataSetsProp =
        !!("color" ==> iColor)

    static member inline lineSegment props : ILineDataSetsProp = !!("segment" ==> props)

    // New properties for fill, tension, points
    static member inline fill(fill: bool) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "fill" fill

    static member inline fill(fill: string) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "fill" fill

    static member inline fill(fill: FillTarget) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "fill" fill

    static member inline fill(fill: int) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "fill" fill

    static member inline tension(tension: float) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "tension" tension

    static member inline cubicInterpolationMode(mode: string) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "cubicInterpolationMode" mode

    static member inline pointBackgroundColor(pointBackgroundColor: string) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "pointBackgroundColor" pointBackgroundColor

    static member inline pointBackgroundColor(pointBackgroundColor: string[]) : ILineDataSetsProp =
        !!("pointBackgroundColor" ==> pointBackgroundColor)

    static member inline pointBorderColor(pointBorderColor: string) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "pointBorderColor" pointBorderColor

    static member inline pointBorderColor(pointBorderColor: string[]) : ILineDataSetsProp =
        !!("pointBorderColor" ==> pointBorderColor)

    static member inline pointBorderWidth(pointBorderWidth: int) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "pointBorderWidth" pointBorderWidth

    static member inline pointBorderWidth(pointBorderWidth: int[]) : ILineDataSetsProp =
        !!("pointBorderWidth" ==> pointBorderWidth)

    static member inline pointRadius(pointRadius: int) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "pointRadius" pointRadius

    static member inline pointRadius(pointRadius: int[]) : ILineDataSetsProp =
        !!("pointRadius" ==> pointRadius)

    static member inline pointRadius(pointRadius: float) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "pointRadius" pointRadius

    static member inline pointHoverRadius(pointHoverRadius: int) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "pointHoverRadius" pointHoverRadius

    static member inline pointHoverRadius(pointHoverRadius: int[]) : ILineDataSetsProp =
        !!("pointHoverRadius" ==> pointHoverRadius)

    static member inline pointHoverBackgroundColor(pointHoverBackgroundColor: string) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "pointHoverBackgroundColor" pointHoverBackgroundColor

    static member inline pointHoverBackgroundColor(pointHoverBackgroundColor: string[]) : ILineDataSetsProp =
        !!("pointHoverBackgroundColor" ==> pointHoverBackgroundColor)

    static member inline pointHoverBorderColor(pointHoverBorderColor: string) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "pointHoverBorderColor" pointHoverBorderColor

    static member inline pointHoverBorderColor(pointHoverBorderColor: string[]) : ILineDataSetsProp =
        !!("pointHoverBorderColor" ==> pointHoverBorderColor)

    static member inline pointHoverBorderWidth(pointHoverBorderWidth: int) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "pointHoverBorderWidth" pointHoverBorderWidth

    static member inline pointHoverBorderWidth(pointHoverBorderWidth: int[]) : ILineDataSetsProp =
        !!("pointHoverBorderWidth" ==> pointHoverBorderWidth)

    static member inline pointStyle(pointStyle: PointStyle) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "pointStyle" pointStyle

    static member inline pointStyle(pointStyle: string) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "pointStyle" pointStyle

    static member inline pointHitRadius(pointHitRadius: int) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "pointHitRadius" pointHitRadius

    static member inline pointHitRadius(pointHitRadius: int[]) : ILineDataSetsProp =
        !!("pointHitRadius" ==> pointHitRadius)

    static member inline spanGaps(spanGaps: bool) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "spanGaps" spanGaps

    static member inline spanGaps(spanGaps: int) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "spanGaps" spanGaps

    static member inline showLine(showLine: bool) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "showLine" showLine

    static member inline borderDash(borderDash: int[]) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "borderDash" borderDash

    static member inline borderDashOffset(borderDashOffset: float) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "borderDashOffset" borderDashOffset

    static member inline borderCapStyle(borderCapStyle: BorderCapStyle) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "borderCapStyle" borderCapStyle

    static member inline borderJoinStyle(borderJoinStyle: BorderJoinStyle) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "borderJoinStyle" borderJoinStyle

    static member inline hidden(hidden: bool) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "hidden" hidden

    static member inline order(order: int) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "order" order

    static member inline hoverBackgroundColor(hoverBackgroundColor: string) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "hoverBackgroundColor" hoverBackgroundColor

    static member inline hoverBorderColor(hoverBorderColor: string) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "hoverBorderColor" hoverBorderColor

    static member inline hoverBorderWidth(hoverBorderWidth: int) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "hoverBorderWidth" hoverBorderWidth

    static member inline clip(clip: bool) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "clip" clip

    static member inline clip(clip: int) : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "clip" clip

    static member inline dataLabels props : ILineDataSetsProp =
        Interop.mkLineDataSetsProp "datalabels" (createObj !!props)

[<Erase>]
type lineSegment =
    static member inline borderColor(context: IColor -> string) : ILineSegmentProp =
        !!("borderColor" ==> context)

    static member inline borderDash(borderDash: int[]) : ILineSegmentProp =
        !!("borderDash" ==> borderDash)

    static member inline borderWidth(borderWidth: int) : ILineSegmentProp =
        !!("borderWidth" ==> borderWidth)

