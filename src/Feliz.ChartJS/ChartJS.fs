namespace Feliz.ChartJS

open Fable.Core.JsInterop
open Fable.Core
open Fable.React
open Feliz

type Event = Browser.Types.Event

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

    static member inline doughnut(props: IDoughnutChartProp seq) =
        Interop.reactApi.createElement (Interop.doughnut, createObj !!props)

    static member inline option props : IOptionsProp = !!(createObj !!props)

    static member inline children(children: ReactElement list) =
        unbox<IChartJSProp> (prop.children children)

