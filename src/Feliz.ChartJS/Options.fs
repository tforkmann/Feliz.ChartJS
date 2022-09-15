namespace Feliz.ChartJS

open Feliz
open Fable.Core.JsInterop
open Fable.Core

[<StringEnum>]
type Position =
    | Top
    | Left
    | Bottom
    | Right

[<Erase>]
type option =
    static member inline responsive(resp: bool) : IOptionsProp = Interop.mkOptionsProp "responsive" resp

    static member inline maintainAspectRatio(ratio: bool) : IOptionsProp =
        Interop.mkOptionsProp "maintainAspectRatio" ratio

    static member inline scales(props: IScalesProp seq) : IOptionsProp =
        Interop.mkOptionsProp "scales" (createObj !!props)

    static member inline plugins(props: IPluginsProp seq) : IOptionsProp =
        Interop.mkOptionsProp "plugins" (createObj !!props)

[<Erase>]
type plugin =
    static member inline title(props: ITitleProp seq) : IPluginsProp =
        Interop.mkPluginsProp "title" (createObj !!props)

    static member inline legend(props: ILegendProp seq) : IPluginsProp =
        Interop.mkPluginsProp "legend" (createObj !!props)

    static member inline datalabels(props: IDataLabelsProp seq) : IPluginsProp =
        Interop.mkPluginsProp "datalabels" (createObj !!props)

[<Erase>]
type scale =
    static member inline x(props: IAxesProp seq) : IScalesProp =
        Interop.mkScalesProp "x" (createObj !!props)

    static member inline y(props: IAxesProp seq) : IScalesProp =
        Interop.mkScalesProp "y" (createObj !!props)

[<Erase>]
type axes =
    static member inline stacked(stacked: bool) : IAxesProp = Interop.mkAxesProp "stacked" stacked

[<Erase>]
type title =
    static member inline display(display: bool) : ITitleProp = Interop.mkTitleProp "display" display
    static member inline text(text: string) : ITitleProp = Interop.mkTitleProp "text" text

[<Erase>]
type legend =
    static member inline position(position: Position) : ILegendProp =
        Interop.mkLegendProp "position" position

    static member inline display(display: bool) : ILegendProp = Interop.mkLegendProp "display" display

[<Erase>]
type datalabels =
    static member inline allign(allign: Position) : IDataLabelsProp =
        Interop.mkDataLabelsProp "allign" allign

    static member inline display(display: bool) : IDataLabelsProp =
        Interop.mkDataLabelsProp "display" display
    static member inline clamp(clamp: bool) : IDataLabelsProp =
        Interop.mkDataLabelsProp "clamp" clamp

    static member inline color(color: string) : IDataLabelsProp = Interop.mkDataLabelsProp "color" color

    static member inline backgroundColor(backgroundColor: string) : IDataLabelsProp =
        Interop.mkDataLabelsProp "backgroundColor" backgroundColor

    static member inline borderRadius(borderRadius: int) : IDataLabelsProp =
        Interop.mkDataLabelsProp "borderRadius" borderRadius

    static member inline font props : IDataLabelsProp =
        Interop.mkDataLabelsProp "font" (createObj !!props)

    static member inline labels props : IDataLabelsProp =
        Interop.mkDataLabelsProp "labels" (createObj !!props)

    static member inline formatter(context: IContextProperties -> ReactElement) : IDataLabelsProp =
        Interop.mkDataLabelsProp "formatter" context

[<Erase>]
type font =
    static member inline size(size: int) : IFontProp = Interop.mkFontProp "allign" size

[<Erase>]
type labels =
    static member inline value props : ILabelsProp =
        Interop.mkLabelsProp "value" (createObj !!props)