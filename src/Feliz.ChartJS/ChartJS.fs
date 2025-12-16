namespace Feliz.ChartJS

open Fable.Core.JsInterop
open Fable.Core
open Feliz

type Event = Browser.Types.Event

// The !! below is used to "unsafely" expose a prop into an IChartJSProp.
[<Erase>]
type ChartJS =
    /// Creates a new ChartJS component.

    static member inline line(props: ILineChartProp seq) =
        ReactLegacy.createElement (Interop.line, createObj !!props)

    static member inline bar(props: IBarChartProp seq) =
        ReactLegacy.createElement (Interop.bar, createObj !!props)

    static member inline doughnut(props: IDoughnutChartProp seq) =
        ReactLegacy.createElement (Interop.doughnut, createObj !!props)

    static member inline bubble(props: IBubbleChartProp seq) =
        ReactLegacy.createElement (Interop.bubble, createObj !!props)

    static member inline pie(props: IPieChartProp seq) =
        ReactLegacy.createElement (Interop.pie, createObj !!props)

    static member inline radar(props: IRadarChartProp seq) =
        ReactLegacy.createElement (Interop.radar, createObj !!props)

    static member inline polarArea(props: IPolarAreaChartProp seq) =
        ReactLegacy.createElement (Interop.polarArea, createObj !!props)

    static member inline scatter(props: IScatterChartProp seq) =
        ReactLegacy.createElement (Interop.scatter, createObj !!props)

    static member inline option props : IOptionsProp = !!(createObj !!props)

    static member inline plugins(props: obj seq) = (!!("plugins" ==> props))

    static member inline children(children: ReactElement list) =
        unbox<IChartJSProp> (prop.children children)
