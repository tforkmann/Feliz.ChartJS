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
    static member inline labels props : ILineDataProp = !!(createObj !!props)

    static member inline ref(ref: IRefValue<Interop.ChartJS option>) : ILineChartProp =
        Interop.mkLineChartProp "ref" ref

    static member inline onClick(handler: MouseEvent -> unit) : ILineDataProp = !!("onClick" ==> handler)

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
    static member inline yAxisID(yAxisID: string): ILineDataSetsProp =
        Interop.mkLineDataSetsProp "yAxisID" yAxisID
    static member inline borderColor(iColor: IColor -> string) : ILineDataSetsProp =
        !!("borderColor" ==> iColor)
    static member inline color(iColor: IColor -> string) : ILineDataSetsProp =
        !!("color" ==> iColor)
    static member inline lineSegment props : ILineDataSetsProp = (!!("segment" ==> props))

[<Erase>]
type lineSegment =
    static member inline borderColor(context: IColor -> string) : ILineSegmentProp =
        !!("borderColor" ==> context)

