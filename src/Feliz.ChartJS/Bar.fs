namespace Feliz.ChartJS

open Feliz
open Fable.Core.JsInterop
open Fable.Core

[<Erase>]
type bar =
    static member inline options props : IBarChartProp =
        Interop.mkBarChartProp "options" (createObj !!props)

    static member inline data props : IBarChartProp =
        Interop.mkBarChartProp "data" (createObj !!props)

    static member inline labels props : IBarChartProp = !!(createObj !!props)

[<Erase>]
type barData =
    static member inline labels(labels: string array) : IBarDataProp = !!("labels" ==> labels)
    static member inline datasets(props: IBarDataSetsProp seq) = (!!("datasets" ==> props))
    static member inline dataset props : IBarDataSetsProp = !!(createObj !!props)

[<Erase>]
type barDataSet =
    static member inline label(label: string) : IBarDataSetsProp = Interop.mkBarDataSetsProp "label" label

    static member inline borderColor(borderColor: string) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "borderColor" borderColor

    static member inline backgroundColor(backgroundColor: string) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "backgroundColor" backgroundColor

    static member inline borderWidth(borderWidth: int) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "borderWidth" borderWidth

    static member inline borderSkipped(borderSkipped: bool) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "borderSkipped" borderSkipped

    static member inline borderRadius(borderRadius: int) : IBarDataSetsProp =
        Interop.mkBarDataSetsProp "borderRadius" borderRadius

    static member inline data(data: string []) : IBarDataSetsProp = Interop.mkBarDataSetsProp "data" data