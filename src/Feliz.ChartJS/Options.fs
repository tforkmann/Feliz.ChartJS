namespace Feliz.ChartJS

open Feliz
open Fable.Core.JsInterop
open Fable.Core

[<StringEnum>]
type LegendPosition =
    | Top
    | Left
    | Bottom
    | Right

[<Erase>]
type option =
    static member inline responsive (resp: bool): IOptionsProp =
        Interop.mkOptionsProp "responsive" resp
    static member inline maintainAspectRatio (ratio: bool): IOptionsProp =
        Interop.mkOptionsProp "maintainAspectRatio" ratio
    static member inline scales (scales: obj): IOptionsProp =
        Interop.mkOptionsProp "scales" scales
    static member inline plugins(props: IPluginsProp seq) : IOptionsProp =
        Interop.mkOptionsProp "plugins" (createObj !!props)

[<Erase>]
type plugin =
    static member inline title(props: ITitleProp seq) : IPluginsProp =
        Interop.mkPluginsProp "title" (createObj !!props)
    static member inline legend(props: ILegendProp seq): IPluginsProp =
        Interop.mkPluginsProp "legend" (createObj !!props)
[<Erase>]
type title =
    static member inline display(display: bool): ITitleProp =
        Interop.mkTitleProp "display" display
    static member inline text(text: string): ITitleProp =
        Interop.mkTitleProp "text" text
[<Erase>]
type legend =
    static member inline position(position: LegendPosition): ILegendProp =
        Interop.mkLegendProp "position" position
    static member inline display(display: bool): ILegendProp =
        Interop.mkLegendProp "legend" display