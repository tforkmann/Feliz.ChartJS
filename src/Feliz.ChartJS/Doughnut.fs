namespace Feliz.ChartJS

open Feliz
open Fable.Core.JsInterop
open Fable.Core
open Browser.Types

[<Erase>]
type doughnut =
    static member inline options props : IDoughnutChartProp =
        Interop.mkDoughnutChartProp "options" (createObj !!props)

    static member inline data props : IDoughnutChartProp =
        Interop.mkDoughnutChartProp "data" (createObj !!props)

    static member inline plugins (plugins:IInlinePlugin seq) : IDoughnutChartProp =
        !!("plugins" ==> plugins)

    static member inline ref(ref: IRefValue<Interop.ChartJS option>) : IDoughnutChartProp =
        Interop.mkDoughnutChartProp "ref" ref

    static member inline labels props : IDoughnutChartProp = !!(createObj !!props)

    static member inline onClick(handler: MouseEvent -> unit) : IDoughnutChartProp = !!("onClick" ==> handler)

[<Erase>]
type doughnutData =
    static member inline labels(labels: string array) : IDoughnutDataProp = !!("labels" ==> labels)
    static member inline datasets(props: IDoughnutDataSetsProp seq) = !!("datasets" ==> props)
    static member inline dataset props : IDoughnutDataSetsProp = !!(createObj !!props)

[<Erase>]
type doughnutDataSet =
    static member inline label(label: string) : IDoughnutDataSetsProp =
        Interop.mkDoughnutDataSetsProp "label" label

    static member inline mixedType(mixedType: string) : IDoughnutDataSetsProp =
        Interop.mkDoughnutDataSetsProp "type" mixedType

    static member inline borderAlign(borderAlign: string) : IDoughnutDataSetsProp =
        Interop.mkDoughnutDataSetsProp "borderAlign" borderAlign

    static member inline borderWidth(borderWidth: int) : IDoughnutDataSetsProp =
        Interop.mkDoughnutDataSetsProp "borderWidth" borderWidth

    static member inline borderColor(borderColor: string[]) : IDoughnutDataSetsProp =
        (!!("borderColor" ==> borderColor))

    static member inline cutout(cutout: int) : IDoughnutDataSetsProp =
        Interop.mkDoughnutDataSetsProp "cutout" cutout

    static member inline backgroundColor(backgroundColor: string[]) : IDoughnutDataSetsProp =
        (!!("backgroundColor" ==> backgroundColor))

    static member inline hoverOffset(hoverOffset: int) : IDoughnutDataSetsProp =
        Interop.mkDoughnutDataSetsProp "hoverOffset" hoverOffset

    static member inline weight(weight: int) : IDoughnutDataSetsProp =
        Interop.mkDoughnutDataSetsProp "weight" weight

    static member inline data(data: int[]) : IDoughnutDataSetsProp =
        Interop.mkDoughnutDataSetsProp "data" data

    static member inline dataLabels props : IDoughnutDataSetsProp =
        Interop.mkDoughnutDataSetsProp "datalabels" (createObj !!props)

[<Erase>]
type dataLabel =
    static member inline anchor(anchor: string) : IDataLabelProp = Interop.mkDataLabelProp "anchor" anchor
