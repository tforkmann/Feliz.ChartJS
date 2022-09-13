namespace Feliz.ChartJS

open Feliz
open Fable.Core.JsInterop
open Fable.Core

[<Erase>]
type line =
    static member inline options props : ILineChartProp =
        Interop.mkLineChartProp "options" (createObj !!props)

    static member inline data props : ILineChartProp =
        Interop.mkLineChartProp "data" (createObj !!props)
    static member inline labels props : ILineDataProp = !!(createObj !!props)

[<Erase>]
type lineData =
    static member inline labels(labels: string array) : ILineDataProp = !!("labels" ==> labels)
    static member inline datasets(props: ILineDataSetsProp seq) = (!!("datasets" ==> props))
    static member inline dataset props : ILineDataSetsProp = !!(createObj !!props)

[<Erase>]
type lineDataSet =
    static member inline label(label: string): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "label" label
    static member inline borderColor(borderColor: string): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "borderColor" borderColor
    static member inline backgroundColor(backgroundColor: string): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "backgroundColor" backgroundColor
    static member inline data(data: string []): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "data" data