namespace Feliz.ChartJS

open Fable.Core.JsInterop
open Fable.Core
open Fable.React
open Feliz

type Event = Browser.Types.Event

[<Erase>]
type labelStyle =
    static member inline fill(fill: string) = Interop.mkAttr "fill" fill
    static member inline fontWeight(fontWeight: int) = Interop.mkAttr "fontWeight" fontWeight

[<StringEnum>]
type CompactType =
    | Horizontal
    | Vertical

type LineData = { lable: obj; datasets: obj }


// The !! below is used to "unsafely" expose a prop into an IChartJSProp.
[<Erase>]
type ChartJS =
    /// Creates a new ChartJS component.

    static member inline chart(props: IChartJSProp seq) =
        Interop.reactApi.createElement (Interop.chart, createObj !!props)

    static member inline line(props: ILineChartProp seq) =
        Interop.reactApi.createElement (Interop.line, createObj !!props)

    static member inline bar(props: IBarChartProp seq) =
        Interop.reactApi.createElement (Interop.bar, createObj !!props)

    static member inline option props : IOptionsProp = !!(createObj !!props)

    static member inline children(children: ReactElement list) =
        unbox<IChartJSProp> (prop.children children)

