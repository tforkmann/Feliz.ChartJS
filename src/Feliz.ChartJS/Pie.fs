namespace Feliz.ChartJS

open Feliz
open Fable.Core.JsInterop
open Fable.Core
open Browser.Types

[<Erase>]
type pie =
    static member inline options props : IPieChartProp =
        Interop.mkPieChartProp "options" (createObj !!props)

    static member inline data props : IPieChartProp =
        Interop.mkPieChartProp "data" (createObj !!props)

    static member inline plugins (plugins:IInlinePlugin seq) : IPieChartProp =
        !!("plugins" ==> plugins)

    static member inline ref(ref: IRefValue<Interop.ChartJS option>) : IPieChartProp =
        Interop.mkPieChartProp "ref" ref

    static member inline labels props : IPieChartProp = !!(createObj !!props)

    static member inline onClick(handler: MouseEvent -> unit) : IPieChartProp = !!("onClick" ==> handler)

[<Erase>]
type pieData =
    static member inline labels(labels: string array) : IPieDataProp = !!("labels" ==> labels)
    static member inline datasets(props: IPieDataSetsProp seq) = !!("datasets" ==> props)
    static member inline dataset props : IPieDataSetsProp = !!(createObj !!props)

[<Erase>]
type pieDataSet =
    static member inline label(label: string) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "label" label

    static member inline borderAlign(borderAlign: string) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "borderAlign" borderAlign

    static member inline borderWidth(borderWidth: int) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "borderWidth" borderWidth

    static member inline borderColor(borderColor: string) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "borderColor" borderColor

    static member inline borderColor(borderColor: string[]) : IPieDataSetsProp =
        !!("borderColor" ==> borderColor)

    static member inline backgroundColor(backgroundColor: string) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "backgroundColor" backgroundColor

    static member inline backgroundColor(backgroundColor: string[]) : IPieDataSetsProp =
        !!("backgroundColor" ==> backgroundColor)

    static member inline hoverOffset(hoverOffset: int) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "hoverOffset" hoverOffset

    static member inline hoverBackgroundColor(hoverBackgroundColor: string) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "hoverBackgroundColor" hoverBackgroundColor

    static member inline hoverBackgroundColor(hoverBackgroundColor: string[]) : IPieDataSetsProp =
        !!("hoverBackgroundColor" ==> hoverBackgroundColor)

    static member inline hoverBorderColor(hoverBorderColor: string) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "hoverBorderColor" hoverBorderColor

    static member inline hoverBorderColor(hoverBorderColor: string[]) : IPieDataSetsProp =
        !!("hoverBorderColor" ==> hoverBorderColor)

    static member inline hoverBorderWidth(hoverBorderWidth: int) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "hoverBorderWidth" hoverBorderWidth

    static member inline weight(weight: int) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "weight" weight

    static member inline spacing(spacing: int) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "spacing" spacing

    static member inline rotation(rotation: float) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "rotation" rotation

    static member inline circumference(circumference: float) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "circumference" circumference

    static member inline hidden(hidden: bool) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "hidden" hidden

    static member inline order(order: int) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "order" order

    static member inline data(data: int[]) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "data" data
    static member inline data(data: float[]) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "data" data
    static member inline data(data: string[]) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "data" data
    static member inline data(data: decimal[]) : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "data" data

    static member inline dataLabels props : IPieDataSetsProp =
        Interop.mkPieDataSetsProp "datalabels" (createObj !!props)
