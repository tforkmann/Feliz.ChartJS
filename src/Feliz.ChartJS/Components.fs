namespace Feliz.ChartJS

open Fable.Core
open Fable.Core.JsInterop
open Feliz

module KeyHelper =
    let keyHelper str =
        ".$" + str

[<Erase>]
type line =
    static member inline data props: ILineChartProp =
        Interop.mkLineChartProp "data" (createObj !!props)

[<Erase>]
type option =
    static member inline responsive (resp: bool): IOptionsProp =
        Interop.mkOptionsProp "responsive" resp
[<Erase>]
type lineData =
    static member inline labels (labels: string array): ILineDataProp =
        printfn "labels %A" labels
        // Interop.mkLineDataProp "labels" (createObj !!labels)
        !!("labels" ==> labels)
    static member inline datasets (props: ILineDataSetsProp seq) =
        // Interop.reactApi.createElement (Interop.miniMap, createObj !!props)
        // Interop.mkLineDataProp "datasets"
        (!!("datasets" ==> props))
    static member inline dataset props : ILineDataSetsProp = !!(createObj !!props)

    // static member inline datasets props =
    //     // Interop.reactApi.createElement (Interop.miniMap, createObj !!props)
    //     Interop.mkLineDataProp "datasets" (!!("datasets" ==> props))
        // !!(createObj !!props)

[<Erase>]
type linedataset =
    static member inline label(label: string): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "label" label
    static member inline borderColor(borderColor: string): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "borderColor" borderColor
    static member inline backgroundColor(backgroundColor: string): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "backgroundColor" backgroundColor
    static member inline data(data: string []): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "data" data