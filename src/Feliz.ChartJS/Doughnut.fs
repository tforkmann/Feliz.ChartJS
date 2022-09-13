namespace Feliz.ChartJS

open Feliz
open Fable.Core.JsInterop
open Fable.Core

[<Erase>]
type doughnut =
    static member inline options props : IDoughnutChartProp =
        Interop.mkDoughnutChartProp "options" (createObj !!props)
    static member inline data props : IDoughnutChartProp =
        Interop.mkDoughnutChartProp "data" (createObj !!props)
    static member inline labels props : IDoughnutChartProp = !!(createObj !!props)

[<Erase>]
type doughnutData =
    static member inline labels(labels: string array) : IDoughnutDataSetsProp = !!("labels" ==> labels)
    static member inline datasets(props: IDoughnutDataSetsProp seq) = (!!("datasets" ==> props))
    static member inline dataset props : IDoughnutDataSetsProp = !!(createObj !!props)

[<Erase>]
type doughnutdataset =
    static member inline label(label: string): IDoughnutDataSetsProp =
        Interop.mkDoughnutDataSetsProp "label" label
    static member inline borderColor(borderColor: string): IDoughnutDataSetsProp =
        Interop.mkDoughnutDataSetsProp "borderColor" borderColor
    static member inline backgroundColor(backgroundColor: string): IDoughnutDataSetsProp =
        Interop.mkDoughnutDataSetsProp "backgroundColor" backgroundColor
    static member inline data(data: string []): IDoughnutDataSetsProp =
        Interop.mkDoughnutDataSetsProp "data" data