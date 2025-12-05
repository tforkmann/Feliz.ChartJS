namespace Feliz.ChartJS

open Feliz
open Fable.Core.JsInterop
open Fable.Core
open Browser.Types

[<Erase>]
type polarArea =
    static member inline options props : IPolarAreaChartProp =
        Interop.mkPolarAreaChartProp "options" (createObj !!props)

    static member inline data props : IPolarAreaChartProp =
        Interop.mkPolarAreaChartProp "data" (createObj !!props)

    static member inline plugins (plugins:IInlinePlugin seq) : IPolarAreaChartProp =
        !!("plugins" ==> plugins)

    static member inline ref(ref: IRefValue<Interop.ChartJS option>) : IPolarAreaChartProp =
        Interop.mkPolarAreaChartProp "ref" ref

    static member inline labels props : IPolarAreaChartProp = !!(createObj !!props)

    static member inline onClick(handler: MouseEvent -> unit) : IPolarAreaChartProp = !!("onClick" ==> handler)

[<Erase>]
type polarAreaData =
    static member inline labels(labels: string array) : IPolarAreaDataProp = !!("labels" ==> labels)
    static member inline datasets(props: IPolarAreaDataSetsProp seq) = !!("datasets" ==> props)
    static member inline dataset props : IPolarAreaDataSetsProp = !!(createObj !!props)

[<Erase>]
type polarAreaDataSet =
    static member inline label(label: string) : IPolarAreaDataSetsProp =
        Interop.mkPolarAreaDataSetsProp "label" label

    static member inline borderColor(borderColor: string) : IPolarAreaDataSetsProp =
        Interop.mkPolarAreaDataSetsProp "borderColor" borderColor

    static member inline borderColor(borderColor: string[]) : IPolarAreaDataSetsProp =
        !!("borderColor" ==> borderColor)

    static member inline backgroundColor(backgroundColor: string) : IPolarAreaDataSetsProp =
        Interop.mkPolarAreaDataSetsProp "backgroundColor" backgroundColor

    static member inline backgroundColor(backgroundColor: string[]) : IPolarAreaDataSetsProp =
        !!("backgroundColor" ==> backgroundColor)

    static member inline borderWidth(borderWidth: int) : IPolarAreaDataSetsProp =
        Interop.mkPolarAreaDataSetsProp "borderWidth" borderWidth

    static member inline borderAlign(borderAlign: string) : IPolarAreaDataSetsProp =
        Interop.mkPolarAreaDataSetsProp "borderAlign" borderAlign

    static member inline hoverBackgroundColor(hoverBackgroundColor: string) : IPolarAreaDataSetsProp =
        Interop.mkPolarAreaDataSetsProp "hoverBackgroundColor" hoverBackgroundColor

    static member inline hoverBackgroundColor(hoverBackgroundColor: string[]) : IPolarAreaDataSetsProp =
        !!("hoverBackgroundColor" ==> hoverBackgroundColor)

    static member inline hoverBorderColor(hoverBorderColor: string) : IPolarAreaDataSetsProp =
        Interop.mkPolarAreaDataSetsProp "hoverBorderColor" hoverBorderColor

    static member inline hoverBorderColor(hoverBorderColor: string[]) : IPolarAreaDataSetsProp =
        !!("hoverBorderColor" ==> hoverBorderColor)

    static member inline hoverBorderWidth(hoverBorderWidth: int) : IPolarAreaDataSetsProp =
        Interop.mkPolarAreaDataSetsProp "hoverBorderWidth" hoverBorderWidth

    static member inline circular(circular: bool) : IPolarAreaDataSetsProp =
        Interop.mkPolarAreaDataSetsProp "circular" circular

    static member inline hidden(hidden: bool) : IPolarAreaDataSetsProp =
        Interop.mkPolarAreaDataSetsProp "hidden" hidden

    static member inline order(order: int) : IPolarAreaDataSetsProp =
        Interop.mkPolarAreaDataSetsProp "order" order

    static member inline data(data: int[]) : IPolarAreaDataSetsProp =
        Interop.mkPolarAreaDataSetsProp "data" data
    static member inline data(data: float[]) : IPolarAreaDataSetsProp =
        Interop.mkPolarAreaDataSetsProp "data" data
    static member inline data(data: string[]) : IPolarAreaDataSetsProp =
        Interop.mkPolarAreaDataSetsProp "data" data
    static member inline data(data: decimal[]) : IPolarAreaDataSetsProp =
        Interop.mkPolarAreaDataSetsProp "data" data

    static member inline dataLabels props : IPolarAreaDataSetsProp =
        Interop.mkPolarAreaDataSetsProp "datalabels" (createObj !!props)
