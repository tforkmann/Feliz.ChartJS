namespace Feliz.ChartJS

open Feliz
open Fable.Core.JsInterop
open Fable.Core
open Browser.Types

[<Erase>]
type bar =
    static member inline options props : IBarChartProp =
        Interop.mkBarChartProp "options" (createObj !!props)

    static member inline data props : IBarChartProp =
        Interop.mkBarChartProp "data" (createObj !!props)

    static member inline plugins (plugins:IInlinePlugin seq) : IBarChartProp =
        !!("plugins" ==> plugins)

    static member inline labels props : IBarChartProp = !!(createObj !!props)

    static member inline ref(ref: IRefValue<Interop.ChartJS option>) : IBarChartProp =
        Interop.mkBarChartProp "ref" ref

    static member inline onClick(handler: MouseEvent -> unit) : IBarChartProp = !!("onClick" ==> handler)

[<Erase>]
type barData =
    static member inline labels(labels: string array) : IBarDataProp = !!("labels" ==> labels)
    static member inline datasets(props: IBarDataSetsProp seq) = !!("datasets" ==> props)
    static member inline dataset props : IBarDataSetsProp = !!(createObj !!props)

[<Erase>]
type barDataSet =
    static member inline mixedType(mixedType: string) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "type" mixedType

    static member inline label(label: string) : IBarDataSetsProp = Interop.mkBarDataSetsProp "label" label

    static member inline borderColor(borderColor: string) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "borderColor" borderColor

    static member inline borderColor(borderColor: string[]) : IBarDataSetsProp =
        !!("borderColor" ==> borderColor)

    static member inline barThickness(barThickness: int) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "barThickness" barThickness

    static member inline maxBarThickness (maxBarThickness: int) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "maxBarThickness" maxBarThickness

    static member inline minBarLength (minBarLength: int) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "minBarLength" minBarLength

    static member inline categoryPercentage(categoryPercentage: float) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "categoryPercentage" categoryPercentage

    static member inline barPercentage(barPercentage: float) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "barPercentage" barPercentage

    static member inline backgroundColor(backgroundColor: string) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "backgroundColor" backgroundColor

    static member inline backgroundColor(backgroundColor: string []) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "backgroundColor" backgroundColor

    static member inline borderWidth(borderWidth: int) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "borderWidth" borderWidth

    static member inline borderSkipped(borderSkipped: bool) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "borderSkipped" borderSkipped

    static member inline borderSkipped(borderSkipped: string) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "borderSkipped" borderSkipped

    static member inline borderRadius(borderRadius: int) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "borderRadius" borderRadius

    static member inline xAxisID(xAxisID: string) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "xAxisID" xAxisID

    static member inline yAxisID(yAxisID: string) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "yAxisID" yAxisID

    static member inline stack(stack: string) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "stack" stack

    static member inline grouped(grouped: bool) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "grouped" grouped

    static member inline hidden(hidden: bool) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "hidden" hidden

    static member inline order(order: int) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "order" order

    static member inline hoverBackgroundColor(hoverBackgroundColor: string) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "hoverBackgroundColor" hoverBackgroundColor

    static member inline hoverBackgroundColor(hoverBackgroundColor: string[]) : IBarDataSetsProp =
        !!("hoverBackgroundColor" ==> hoverBackgroundColor)

    static member inline hoverBorderColor(hoverBorderColor: string) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "hoverBorderColor" hoverBorderColor

    static member inline hoverBorderColor(hoverBorderColor: string[]) : IBarDataSetsProp =
        !!("hoverBorderColor" ==> hoverBorderColor)

    static member inline hoverBorderWidth(hoverBorderWidth: int) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "hoverBorderWidth" hoverBorderWidth

    static member inline hoverBorderRadius(hoverBorderRadius: int) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "hoverBorderRadius" hoverBorderRadius

    static member inline inflateAmount(inflateAmount: int) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "inflateAmount" inflateAmount

    static member inline pointStyle(pointStyle: PointStyle) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "pointStyle" pointStyle

    static member inline data(data: string []) : IBarDataSetsProp = Interop.mkBarDataSetsProp "data" data
    static member inline data(data: int []) : IBarDataSetsProp = Interop.mkBarDataSetsProp "data" data
    static member inline data(data: float []) : IBarDataSetsProp = Interop.mkBarDataSetsProp "data" data
    static member inline data(data: decimal []) : IBarDataSetsProp = Interop.mkBarDataSetsProp "data" data

    static member inline dataLabels props : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "datalabels" (createObj !!props)
