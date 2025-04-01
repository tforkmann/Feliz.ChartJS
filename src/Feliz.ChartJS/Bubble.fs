namespace Feliz.ChartJS

open Feliz
open Fable.Core.JsInterop
open Fable.Core
open Browser.Types

[<Erase>]
type bubble =
    static member inline options props : IBubbleChartProp =
        Interop.mkBubbleChartProp "options" (createObj !!props)

    static member inline data props : IBubbleChartProp =
        Interop.mkBubbleChartProp "data" (createObj !!props)
    static member inline plugins (plugins:IInlinePlugin seq) : IBubbleChartProp =
        !!("plugins" ==> plugins)
    static member inline labels props : IBubbleChartProp = !!(createObj !!props)

    static member inline ref(ref: IRefValue<Interop.ChartJS option>) : IBubbleChartProp =
        Interop.mkBubbleChartProp "ref" ref

    static member inline onClick(handler: MouseEvent -> unit) : IBubbleChartProp = !!("onClick" ==> handler)

[<Erase>]
type bubbleData =
    static member inline labels(labels: string array) : IBubbleDataProp = !!("labels" ==> labels)
    static member inline datasets(props: IBubbleDataProp seq) = !!("datasets" ==> props)
    static member inline dataset props : IBubbleDataProp = !!(createObj !!props)

[<Erase>]
type bubbleDataSet =
    static member inline mixedType(mixedType: string) : IBubbleDataSetsProp =
        Interop.mkBubbleDataSetsProp "type" mixedType

    static member inline label(label: string) : IBubbleDataSetsProp = Interop.mkBubbleDataSetsProp "label" label

    static member inline borderColor(borderColor: string) : IBubbleDataSetsProp =
        Interop.mkBubbleDataSetsProp "borderColor" borderColor

    static member inline barThickness(barThickness: int) : IBubbleDataSetsProp =
        Interop.mkBubbleDataSetsProp "barThickness" barThickness

    static member inline maxBarThickness (maxBarThickness: int) : IBubbleDataSetsProp =
        Interop.mkBubbleDataSetsProp "maxBarThickness" maxBarThickness

    static member inline minBarLength (minBarLength: int) : IBubbleDataSetsProp =
        Interop.mkBubbleDataSetsProp "minBarLength" minBarLength

    static member inline categoryPercentage(categoryPercentage: float) : IBubbleDataSetsProp =
        Interop.mkBubbleDataSetsProp "categoryPercentage" categoryPercentage

    static member inline barPercentage(barPercentage: float) : IBubbleDataSetsProp =
        Interop.mkBubbleDataSetsProp "barPercentage" barPercentage
    static member inline backgroundColor(backgroundColor: string) : IBubbleDataSetsProp =
        Interop.mkBubbleDataSetsProp "backgroundColor" backgroundColor

    static member inline borderWidth(borderWidth: int) : IBubbleDataSetsProp =
        Interop.mkBubbleDataSetsProp "borderWidth" borderWidth

    static member inline borderSkipped(borderSkipped: bool) : IBubbleDataSetsProp =
        Interop.mkBubbleDataSetsProp "borderSkipped" borderSkipped

    static member inline borderRadius(borderRadius: int) : IBubbleDataSetsProp =
        Interop.mkBubbleDataSetsProp "borderRadius" borderRadius
    static member inline dataLabels props : IBubbleDataSetsProp =
        Interop.mkBubbleDataSetsProp "datalabels" (createObj !!props)
    static member inline dataPoints (props: IBubbleDataPointsProp seq) : IBubbleDataSetsProp = !!("data" ==> props)


[<Erase>]
type bubbleDataPoints =
    static member inline dataPoint (props: IBubbleDataPointProp seq) : IBubbleDataPointsProp = !!(createObj !!props)

[<Erase>]
type bubbleDataPoint =
    static member inline x(x: float) : IBubbleDataPointProp = Interop.mkBubbleDataPointProp "x" x
    static member inline y(y: float) : IBubbleDataPointProp = Interop.mkBubbleDataPointProp "y" y
    static member inline r(r: float) : IBubbleDataPointProp = Interop.mkBubbleDataPointProp "r" r
