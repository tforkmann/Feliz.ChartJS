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
    static member inline labels(labels: string array) : IBarDataSetsProp = !!("labels" ==> labels)
    static member inline datasets(props: IBarDataSetsProp seq) = (!!("datasets" ==> props))
    static member inline dataset props : IBarDataSetsProp = !!(createObj !!props)

[<Erase>]
type bardataset =
    static member inline label(label: string): IBarDataSetsProp =
        Interop.mkBarDataSetsProp "label" label
    static member inline borderColor(borderColor: string): IBarDataSetsProp =
        Interop.mkBarDataSetsProp "borderColor" borderColor
    static member inline backgroundColor(backgroundColor: string): IBarDataSetsProp =
        Interop.mkBarDataSetsProp "backgroundColor" backgroundColor
    static member inline data(data: string []): IBarDataSetsProp =
        Interop.mkBarDataSetsProp "data" data